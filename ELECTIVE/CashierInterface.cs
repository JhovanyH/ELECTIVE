using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace ELECTIVE
{
    public partial class CashierInterface : Form
    {
        private List<CartItem> cart = new List<CartItem>();
        private decimal TAX_RATE = 0.05m; // 5% tax
        public CashierInterface()
        {
            InitializeComponent();
        }

        private void CashierInterface_Load(object sender, EventArgs e)
        {
            // Focus on barcode field when form opens
            txtBarcode.Focus();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            // When user presses Enter after scanning/typing barcode
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    string barcode = txtBarcode.Text.Trim();

                    if (string.IsNullOrEmpty(barcode))
                    {
                        MessageBox.Show("Please scan or enter a barcode");
                        return;
                    }

                    // Look up product by barcode
                    Product product = ProductDAL.GetProductByBarcode(barcode);

                    if (product != null)
                    {
                        // Display product info
                        lblProductName.Text = "Product: " + product.ProductName;
                        lblProductPrice.Text = "Price: $" + product.Price.ToString("0.00");
                        lblAvailableQty.Text = "Available: " + product.Quantity;

                        // Check if already in cart
                        CartItem existingItem = cart.Find(item => item.ProductID == product.ProductID);

                        if (existingItem != null)
                        {
                            lblProductName.Text += " (Already in cart)";
                        }

                        // Set quantity to 1 by default
                        numQuantity.Value = 1;
                        numQuantity.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Product not found! Check the barcode.", "Not Found");
                        lblProductName.Text = "Product: Not Found";
                        lblProductPrice.Text = "Price: $0.00";
                        lblAvailableQty.Text = "Available: 0";
                    }

                    e.Handled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                // Clear barcode field and refocus for next scan
                txtBarcode.Clear();
                txtBarcode.Focus();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBarcode.Text) && lblProductName.Text == "Product: ")
                {
                    MessageBox.Show("Please scan a barcode first");
                    return;
                }

                // Get the last scanned barcode from label or textbox
                string barcode = txtBarcode.Text.Trim();
                if (string.IsNullOrEmpty(barcode))
                {
                    MessageBox.Show("Please scan a barcode");
                    return;
                }

                Product product = ProductDAL.GetProductByBarcode(barcode);

                if (product == null)
                {
                    MessageBox.Show("Product not found");
                    return;
                }

                int quantity = (int)numQuantity.Value;

                if (quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity");
                    return;
                }

                if (quantity > product.Quantity)
                {
                    MessageBox.Show("Not enough stock! Available: " + product.Quantity);
                    return;
                }

                // Add to cart
                CartItem existingItem = cart.Find(item => item.ProductID == product.ProductID);

                if (existingItem != null)
                {
                    // Item already in cart - increase quantity
                    existingItem.Quantity += quantity;
                    existingItem.TotalPrice = existingItem.UnitPrice * existingItem.Quantity;
                }
                else
                {
                    // New item - add to cart
                    CartItem newItem = new CartItem
                    {
                        ProductID = product.ProductID,
                        ProductName = product.ProductName,
                        Quantity = quantity,
                        UnitPrice = product.Price,
                        TotalPrice = product.Price * quantity
                    };
                    cart.Add(newItem);
                }

                // Refresh cart display
                RefreshCart();

                // Clear form
                txtBarcode.Clear();
                lblProductName.Text = "Product: ";
                lblProductPrice.Text = "Price: $0.00";
                lblAvailableQty.Text = "Available: 0";
                numQuantity.Value = 1;
                txtBarcode.Focus();

                MessageBox.Show(product.ProductName + " added to cart!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void RefreshCart()
        {
            try
            {
                // Clear grid
                dgvCart.DataSource = null;

                // Display cart items
                dgvCart.DataSource = new List<CartItem>(cart);

                // Adjust columns
                if (dgvCart.Columns.Count > 0)
                {
                    dgvCart.Columns["ProductID"].Visible = false;
                }

                // Calculate totals
                CalculateTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing cart: " + ex.Message);
            }
        }
        private void CalculateTotals()
        {
            decimal subtotal = 0;

            foreach (CartItem item in cart)
            {
                subtotal += item.TotalPrice;
            }

            decimal tax = subtotal * TAX_RATE;
            decimal total = subtotal + tax;

            lblSubtotal.Text = "Subtotal: $" + subtotal.ToString("0.00");
            lblTax.Text = "Tax (5%): $" + tax.ToString("0.00");
            lblTotal.Text = "TOTAL: $" + total.ToString("0.00");
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCart.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvCart.SelectedRows[0].Index;
                    if (rowIndex >= 0 && rowIndex < cart.Count)
                    {
                        cart.RemoveAt(rowIndex);
                        RefreshCart();
                        MessageBox.Show("Item removed from cart");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to remove");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Clear the entire cart?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                cart.Clear();
                RefreshCart();
                lblProductName.Text = "Product: ";
                lblProductPrice.Text = "Price: $0.00";
                lblAvailableQty.Text = "Available: 0";
                txtBarcode.Clear();
                txtBarcode.Focus();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (cart.Count == 0)
                {
                    MessageBox.Show("Cart is empty!");
                    return;
                }

                // Calculate total
                decimal subtotal = 0;
                foreach (CartItem item in cart)
                {
                    subtotal += item.TotalPrice;
                }

                decimal tax = subtotal * TAX_RATE;
                decimal total = subtotal + tax;

                // Confirm purchase
                DialogResult result = MessageBox.Show(
                    "Complete the sale?\n\n" +
                    "Subtotal: $" + subtotal.ToString("0.00") + "\n" +
                    "Tax: $" + tax.ToString("0.00") + "\n" +
                    "TOTAL: $" + total.ToString("0.00"),
                    "Confirm Sale", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Show receipt
                    ShowReceipt(subtotal, tax, total);

                    // Clear cart and reset
                    cart.Clear();
                    RefreshCart();
                    lblProductName.Text = "Product: ";
                    lblProductPrice.Text = "Price: $0.00";
                    lblAvailableQty.Text = "Available: 0";
                    txtBarcode.Clear();
                    numQuantity.Value = 1;
                    txtBarcode.Focus();

                    MessageBox.Show("Sale completed successfully!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ShowReceipt(decimal subtotal, decimal tax, decimal total)
        {
            string receipt = "========== RECEIPT ==========\n";
            receipt += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n\n";

            receipt += "Item Details:\n";
            receipt += "------------------------------\n";

            int itemNo = 1;
            foreach (CartItem item in cart)
            {
                receipt += itemNo + ". " + item.ProductName + "\n";
                receipt += "   Qty: " + item.Quantity + " x $" + item.UnitPrice.ToString("0.00") + "\n";
                receipt += "   Total: $" + item.TotalPrice.ToString("0.00") + "\n\n";
                itemNo++;
            }

            receipt += "------------------------------\n";
            receipt += "Subtotal: $" + subtotal.ToString("0.00") + "\n";
            receipt += "Tax (5%): $" + tax.ToString("0.00") + "\n";
            receipt += "TOTAL: $" + total.ToString("0.00") + "\n";
            receipt += "=============================\n";
            receipt += "Thank you for your purchase!\n";

            // Show receipt in message
            MessageBox.Show(receipt, "Receipt");
        }
    }
    public class CartItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

