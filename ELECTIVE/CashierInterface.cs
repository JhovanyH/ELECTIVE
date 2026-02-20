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

        private int currentQuantity = 1; // Track current quantity
        private Control lastFocusedControl = null;

        public CashierInterface()
        {
            InitializeComponent();
        }

        private void CashierInterface_Load(object sender, EventArgs e)
        {
            // Focus on barcode field when form opens
            txtBarcode.Focus();
            lastFocusedControl = txtBarcode; // Remember which textbox is active

            // Initialize DataGridView columns at start
            InitializeCartGrid();

            // Load discount options
            LoadDiscountOptions();

            lblQuantityDisplay.Text = "1";

            // Add these event handlers to track focus
            txtBarcode.Enter += (s, e) => lastFocusedControl = txtBarcode;
            txtCashGiven.Enter += (s, e) => lastFocusedControl = txtCashGiven;
            txtChange.Enter += (s, e) => lastFocusedControl = txtChange;
        }

        private void InitializeCartGrid()
        {
            try
            {
                dgvCart.AutoGenerateColumns = false;
                dgvCart.Columns.Clear();

                // Add columns manually
                dgvCart.Columns.Add("ProductID", "ID");
                dgvCart.Columns.Add("ProductName", "Product Name");
                dgvCart.Columns.Add("Quantity", "Quantity");
                dgvCart.Columns.Add("UnitPrice", "Unit Price");
                dgvCart.Columns.Add("TotalPrice", "Total Price");

                // Set column properties
                dgvCart.Columns["ProductID"].Visible = false;
                dgvCart.Columns["ProductName"].Width = 150;
                dgvCart.Columns["Quantity"].Width = 80;
                dgvCart.Columns["UnitPrice"].Width = 100;
                dgvCart.Columns["TotalPrice"].Width = 100;

                // Allow row selection
                dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing grid: " + ex.Message);
            }
        }

        private void LoadDiscountOptions()
        {
            try
            {
                cmbDiscount.Items.Clear();
                cmbDiscount.Items.Add("No Discount");
                cmbDiscount.Items.Add("Senior Citizen (10%)");
                cmbDiscount.Items.Add("PWD (15%)");
                cmbDiscount.Items.Add("Membership (5%)");
                cmbDiscount.SelectedIndex = 0; // Default: No Discount
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading discounts: " + ex.Message);
            }
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
                        lblProductName.Text = product.ProductName;
                        lblProductPrice.Text = product.Price.ToString("0.00");  // ✅ NO $ symbol!
                        lblAvailableQty.Text = product.Quantity.ToString();

                        // Check if already in cart
                        CartItem existingItem = cart.Find(item => item.ProductID == product.ProductID);

                        if (existingItem != null)
                        {
                            lblProductName.Text += " (Already in cart)";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found! Check the barcode.", "Not Found");
                        lblProductName.Text = "";
                        lblProductPrice.Text = "";  // ✅ Clear, not "$"
                        lblAvailableQty.Text = "";
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
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                string barcode = txtBarcode.Text.Trim();

                if (string.IsNullOrEmpty(barcode))
                {
                    MessageBox.Show("Please scan a barcode first");
                    return;
                }

                Product product = ProductDAL.GetProductByBarcode(barcode);

                if (product == null)
                {
                    MessageBox.Show("Product not found");
                    return;
                }

                int quantity = currentQuantity;

                if (quantity > product.Quantity)
                {
                    MessageBox.Show("Not enough stock! Available: " + product.Quantity);
                    return;
                }

                CartItem existingItem = cart.Find(item => item.ProductID == product.ProductID);

                if (existingItem != null)
                {
                    existingItem.Quantity += quantity;
                    existingItem.TotalPrice = existingItem.UnitPrice * existingItem.Quantity;
                }
                else
                {
                    cart.Add(new CartItem
                    {
                        ProductID = product.ProductID,
                        ProductName = product.ProductName,
                        Quantity = quantity,
                        UnitPrice = product.Price,
                        TotalPrice = product.Price * quantity
                    });
                }

                RefreshCart();

                // Clear only product info, NOT price preview
                txtBarcode.Clear();
                lblProductName.Text = "";
                lblProductPrice.Text = "";
                lblAvailableQty.Text = "";
                currentQuantity = 1;
                lblQuantityDisplay.Text = "1";
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
                // Clear existing rows
                dgvCart.Rows.Clear();

                // Add cart items to grid
                foreach (CartItem item in cart)
                {
                    dgvCart.Rows.Add(
                        item.ProductID,
                        item.ProductName,
                        item.Quantity,
                        item.UnitPrice.ToString("0.00"),
                        item.TotalPrice.ToString("0.00")
                    );
                }

                // Calculate totals with discount
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

            // Get discount percentage
            decimal discountPercent = GetDiscountPercent();
            decimal discountAmount = subtotal * discountPercent;
            decimal subtotalAfterDiscount = subtotal - discountAmount;

            decimal tax = subtotalAfterDiscount * TAX_RATE;
            decimal total = subtotalAfterDiscount + tax;

            // ✅ FIX: Use consistent format with text labels
            lblSubtotal.Text = "Subtotal: $" + subtotal.ToString("0.00");
            lblDiscount.Text = "Discount (" + (discountPercent * 100) + "%): -$" + discountAmount.ToString("0.00");
            lblTax.Text = "Tax (5%): $" + tax.ToString("0.00");
            lblTotal.Text = "TOTAL: $" + total.ToString("0.00");  // ✅ Has "TOTAL: $" prefix

            lblPricePreview.Text = "Cart Total: $" + total.ToString("0.00");
        }

        private decimal GetDiscountPercent()
        {
            string selectedDiscount = cmbDiscount.SelectedItem?.ToString() ?? "No Discount";

            switch (selectedDiscount)
            {
                case "Senior Citizen (10%)":
                    return 0.10m;
                case "PWD (15%)":
                    return 0.15m;
                case "Membership (5%)":
                    return 0.05m;
                default:
                    return 0.0m;
            }
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
                lblProductName.Text = "";
                lblProductPrice.Text = "";
                lblAvailableQty.Text = "";
                lblPricePreview.Text = "";
                txtBarcode.Clear();
                txtCashGiven.Clear();
                txtChange.Clear();
                cmbDiscount.SelectedIndex = 0;
                currentQuantity = 1;
                lblQuantityDisplay.Text = "1";
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

                if (string.IsNullOrEmpty(txtChange.Text))
                {
                    MessageBox.Show("Please calculate change first!");
                    return;
                }

                // Get total amount
                string totalText = lblTotal.Text.Replace("TOTAL: $", "").Trim();
                decimal total = decimal.Parse(totalText);

                // Confirm purchase
                DialogResult result = MessageBox.Show(
                    "Complete the sale?\n\n" +
                    lblSubtotal.Text + "\n" +
                    lblDiscount.Text + "\n" +
                    lblTax.Text + "\n" +
                    lblTotal.Text,
                    "Confirm Sale", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // ==========================================
                    // SAVE TO DATABASE
                    // ==========================================

                    // Step 1: Create a new Sale record
                    int saleID = ProductDAL.AddSale(total, "Completed");

                    if (saleID > 0)
                    {
                        bool allItemsSaved = true;

                        // Step 2: For each item in cart, save SaleDetail and update stock
                        foreach (CartItem item in cart)
                        {
                            // Save the item to SaleDetails table
                            bool detailSaved = ProductDAL.AddSaleDetail(
                                saleID,
                                item.ProductID,
                                item.Quantity,
                                item.UnitPrice,
                                item.TotalPrice
                            );

                            // Decrease the product stock
                            bool stockUpdated = ProductDAL.DecreaseProductStock(
                                item.ProductID,
                                item.Quantity
                            );

                            if (!detailSaved || !stockUpdated)
                            {
                                allItemsSaved = false;
                            }
                        }

                        if (allItemsSaved)
                        {
                            // Show receipt
                            ShowReceipt();

                            // Clear everything
                            ClearEverything();

                            MessageBox.Show("Sale completed successfully! Transaction saved.", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Sale completed but some items failed to save properly.", "Warning");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error saving sale to database!", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ShowReceipt()
        {
            string totalText = lblTotal.Text.Replace("TOTAL: $", "").Trim();
            decimal cashGiven = decimal.Parse(txtCashGiven.Text);
            decimal change = decimal.Parse(txtChange.Text);

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
            receipt += lblSubtotal.Text + "\n";
            receipt += lblDiscount.Text + "\n";
            receipt += lblTax.Text + "\n";
            receipt += lblTotal.Text + "\n";
            receipt += "------------------------------\n";
            receipt += "Cash Given: $" + cashGiven.ToString("0.00") + "\n";
            receipt += "Change: $" + change.ToString("0.00") + "\n";
            receipt += "=============================\n";
            receipt += "Thank you for your purchase!\n";

            MessageBox.Show(receipt, "Receipt");
        }

        private void searchbtton_Click(object sender, EventArgs e)
        {

            try
            {
                string barcode = txtBarcode.Text.Trim();

                if (string.IsNullOrEmpty(barcode))
                {
                    MessageBox.Show("Please enter or scan a barcode");
                    return;
                }

                // Look up product by barcode
                Product product = ProductDAL.GetProductByBarcode(barcode);

                if (product != null)
                {
                    // Display product info
                    lblProductName.Text = product.ProductName;
                    lblProductPrice.Text = product.Price.ToString("0.00");  // ✅ NO $ symbol!
                    lblAvailableQty.Text = product.Quantity.ToString();

                    // Check if already in cart
                    CartItem existingItem = cart.Find(item => item.ProductID == product.ProductID);

                    if (existingItem != null)
                    {
                        lblProductName.Text += " (Already in cart)";
                    }

                    // Reset quantity to 1
                    currentQuantity = 1;
                    lblQuantityDisplay.Text = "1";
                    UpdatePricePreview(product.Price);
                }
                else
                {
                    MessageBox.Show("Product not found! Check the barcode.", "Not Found");
                    lblProductName.Text = "";
                    lblProductPrice.Text = "";  // ✅ Clear, not "$"
                    lblAvailableQty.Text = "";
                    lblPricePreview.Text = "";  // ✅ Clear, not "$"
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {

            CalculateTotals();
        }

        private void btnCalculateChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblTotal.Text))
                {
                    MessageBox.Show("Cart is empty!");
                    return;
                }

                // Extract total amount from label
                // lblTotal.Text = "TOTAL: $100.50"
                string totalText = lblTotal.Text.Replace("TOTAL: $", "").Trim();

                if (!decimal.TryParse(totalText, out decimal total))
                {
                    MessageBox.Show("Invalid total amount");
                    return;
                }

                // Get cash given
                if (string.IsNullOrEmpty(txtCashGiven.Text))
                {
                    MessageBox.Show("Please enter cash given");
                    return;
                }

                if (!decimal.TryParse(txtCashGiven.Text, out decimal cashGiven))
                {
                    MessageBox.Show("Invalid cash amount");
                    return;
                }

                if (cashGiven < total)
                {
                    MessageBox.Show("Cash given is less than total amount!");
                    return;
                }

                // Calculate change
                decimal change = cashGiven - total;
                txtChange.Text = change.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating change: " + ex.Message);
            }
        }

        private void btnquantityplus_Click(object sender, EventArgs e)
        {
            currentQuantity++;
            lblQuantityDisplay.Text = currentQuantity.ToString();
            UpdatePricePreview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentQuantity > 1)
            {
                currentQuantity--;
                lblQuantityDisplay.Text = currentQuantity.ToString();
                UpdatePricePreview();
            }
        }
        private void UpdatePricePreview(decimal price = 0)
        {
            try
            {
                // If price is 0, get it from the product label
                if (price == 0)
                {
                    // lblProductPrice now just shows the number like "50.00"
                    // No need to remove "Price: $"
                    if (decimal.TryParse(lblProductPrice.Text, out decimal parsedPrice))
                    {
                        price = parsedPrice;
                    }
                }

                decimal totalPrice = price * currentQuantity;
                lblPricePreview.Text = "Total: $" + totalPrice.ToString("0.00");
            }
            catch
            {
                lblPricePreview.Text = "Total: $0.00";
            }
        }

        private void btnclearbarcode_Click(object sender, EventArgs e)
        {
            // Use lastFocusedControl to remember which textbox was active
            if (lastFocusedControl == txtBarcode)
            {
                if (txtBarcode.Text.Length > 0)
                {
                    txtBarcode.Text = txtBarcode.Text.Substring(0, txtBarcode.Text.Length - 1);
                }
            }
            else if (lastFocusedControl == txtCashGiven)
            {
                if (txtCashGiven.Text.Length > 0)
                {
                    txtCashGiven.Text = txtCashGiven.Text.Substring(0, txtCashGiven.Text.Length - 1);
                }
            }
            else if (lastFocusedControl == txtChange)
            {
                if (txtChange.Text.Length > 0)
                {
                    txtChange.Text = txtChange.Text.Substring(0, txtChange.Text.Length - 1);
                }
            }

            // Put focus back on the textbox after deleting
            lastFocusedControl?.Focus();
        }
        

    
        
        public void AddNumberToFocusedTextbox(string number)
        {
            if (lastFocusedControl == txtBarcode)
                txtBarcode.Text += number;
            else if (lastFocusedControl == txtCashGiven)
                txtCashGiven.Text += number;
            else if (lastFocusedControl == txtChange)
                txtChange.Text += number;
            else
                txtBarcode.Text += number; // Default

            // Keep focus on the textbox, not the button
            lastFocusedControl?.Focus();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddNumberToFocusedTextbox("0");
        }

        private void button1click_Click(object sender, EventArgs e)
        {
            AddNumberToFocusedTextbox("1");
        }

        private void button2click_Click(object sender, EventArgs e)
        {
            AddNumberToFocusedTextbox("2");
        }

        private void button3click_Click(object sender, EventArgs e)
        {
            AddNumberToFocusedTextbox("3");
        }

        private void button4click_Click(object sender, EventArgs e)
        {
            AddNumberToFocusedTextbox("4");
        }

        private void button5click_Click(object sender, EventArgs e)
        {
            AddNumberToFocusedTextbox("5");
        }

        private void button6click_Click(object sender, EventArgs e)
        {
            AddNumberToFocusedTextbox("6");
        }

        private void button7click_Click(object sender, EventArgs e)
        {
            AddNumberToFocusedTextbox("7");
        }

        private void button8click_Click(object sender, EventArgs e)
        {
            AddNumberToFocusedTextbox("8");
        }

        private void button9click_Click(object sender, EventArgs e)
        {
            AddNumberToFocusedTextbox("9");
        }

        private void buttondecimal_Click(object sender, EventArgs e)
        {
            AddNumberToFocusedTextbox(".");
        }

        // Helper method to clear everything
        private void ClearEverything()
        {
            cart.Clear();
            RefreshCart();
            lblProductName.Text = "";
            lblProductPrice.Text = "";
            lblAvailableQty.Text = "";
            lblPricePreview.Text = "";
            txtBarcode.Clear();
            txtCashGiven.Clear();
            txtChange.Clear();
            cmbDiscount.SelectedIndex = 0;
            currentQuantity = 1;
            lblQuantityDisplay.Text = "1";
            txtBarcode.Focus();
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

