using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELECTIVE
{
    public partial class AdminForm : Form
    {
        private Product currentProduct = null;
        private string selectedImagePath = null;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
        }

        private void LoadAllProducts()
        {
            try
            {
                List<Product> products = ProductDAL.GetAllProducts();
                dgvProducts.DataSource = products;
                dgvProducts.Columns["ProductID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }
        //==========================================
        // GRID SELECTION
        // ==========================================
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];

                if (row.Cells["ProductID"].Value != null)
                {
                    int productID = (int)row.Cells["ProductID"].Value;
                    currentProduct = ProductDAL.GetProductByID(productID);

                    if (currentProduct != null)
                    {
                        // Fill form fields
                        txtBarcode.Text = currentProduct.Barcode;
                        txtProductName.Text = currentProduct.ProductName;
                        txtCategory.Text = currentProduct.Category;
                        txtQuantity.Text = currentProduct.Quantity.ToString();
                        txtPrice.Text = currentProduct.Price.ToString();
                        txtUnit.Text = currentProduct.Unit;
                        txtDescription.Text = currentProduct.Description;
                        txtSupplier.Text = currentProduct.Supplier;

                        if (currentProduct.ManufacturingDate.HasValue)
                            dtpMfgDate.Value = currentProduct.ManufacturingDate.Value;

                        if (currentProduct.ExpirationDate.HasValue)
                            dtpExpDate.Value = currentProduct.ExpirationDate.Value;

                        // Load image if exists
                        if (!string.IsNullOrEmpty(currentProduct.ImagePath) && File.Exists(currentProduct.ImagePath))
                        {
                            try
                            {
                                pbProductImage.Image = Image.FromFile(currentProduct.ImagePath);
                                selectedImagePath = currentProduct.ImagePath;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error loading image: " + ex.Message);
                            }
                        }
                        else
                        {
                            pbProductImage.Image = null;
                            selectedImagePath = null;
                        }
                    }
                }
            }
        }


        private void ClearForm()
        {
            txtBarcode.Clear();
            txtProductName.Clear();
            // ComboBox - use .SelectedIndex
            if (txtCategory != null)
                txtCategory.SelectedIndex = -1;  // Deselect

            // NumericUpDown - use .Value
            if (txtQuantity != null)
                txtQuantity.Value = 0;

            // Decimal/Price NumericUpDown
            if (txtPrice != null)
                txtPrice.Value = 0;

            if (txtUnit != null)
                txtUnit.SelectedIndex = -1;
            txtDescription.Clear();
            txtSupplier.Clear();
            dtpMfgDate.Value = DateTime.Now;
            dtpExpDate.Value = DateTime.Now;
            pbProductImage.Image = null;
            selectedImagePath = null;
            txtBarcode.Focus();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate
                if (string.IsNullOrEmpty(txtBarcode.Text))
                {
                    MessageBox.Show("Please enter a barcode", "Validation Error");
                    return;
                }

                if (string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("Please enter a product name", "Validation Error");
                    return;
                }

                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Please enter a price", "Validation Error");
                    return;
                }

                // Check if barcode already exists
                if (ProductDAL.BarcodeExists(txtBarcode.Text))
                {
                    MessageBox.Show("Barcode already exists! Use a different one.", "Duplicate Barcode");
                    return;
                }

                // Create new product
                Product newProduct = new Product();
                newProduct.Barcode = txtBarcode.Text;
                newProduct.ProductName = txtProductName.Text;
                newProduct.Category = txtCategory.Text;
                newProduct.Quantity = string.IsNullOrEmpty(txtQuantity.Text) ? 0 : int.Parse(txtQuantity.Text);
                newProduct.Price = decimal.Parse(txtPrice.Text);
                newProduct.Unit = txtUnit.Text;
                newProduct.Description = txtDescription.Text;
                newProduct.Supplier = txtSupplier.Text;
                newProduct.ManufacturingDate = dtpMfgDate.Value;
                newProduct.ExpirationDate = dtpExpDate.Value;
                newProduct.ImagePath = selectedImagePath; // Include image path

                // Save
                if (ProductDAL.AddProduct(newProduct))
                {
                    MessageBox.Show("Product saved successfully!", "Success");
                    ClearForm();
                    LoadAllProducts();
                }
                else
                {
                    MessageBox.Show("Error saving product", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            ClearForm();
            currentProduct = null;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show("Please select a product to edit");
                return;
            }

            try
            {
                currentProduct.Barcode = txtBarcode.Text;
                currentProduct.ProductName = txtProductName.Text;
                currentProduct.Category = txtCategory.Text;
                currentProduct.Quantity = int.Parse(txtQuantity.Text);
                currentProduct.Price = decimal.Parse(txtPrice.Text);
                currentProduct.Unit = txtUnit.Text;
                currentProduct.Description = txtDescription.Text;
                currentProduct.Supplier = txtSupplier.Text;
                currentProduct.ManufacturingDate = dtpMfgDate.Value;
                currentProduct.ExpirationDate = dtpExpDate.Value;
                currentProduct.ImagePath = selectedImagePath;

                if (ProductDAL.UpdateProduct(currentProduct))
                {
                    MessageBox.Show("Product updated successfully!", "Success");
                    LoadAllProducts();
                }
                else
                {
                    MessageBox.Show("Error updating product", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show("Please select a product to delete");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (ProductDAL.DeleteProduct(currentProduct.ProductID))
                {
                    MessageBox.Show("Product deleted successfully!", "Success");
                    ClearForm();
                    LoadAllProducts();
                }
                else
                {
                    MessageBox.Show("Error deleting product", "Error");
                }
            }
        }



        private void button_browse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select a product image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;

                    // Display image in PictureBox
                    Image image = Image.FromFile(selectedImagePath);
                    pbProductImage.Image = image;
                    pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;

                    MessageBox.Show("Image selected successfully!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting image: " + ex.Message);
            }
        }

        private void Searchbttn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Please enter a search term");
                    LoadAllProducts();
                    return;
                }

                // Try barcode search first
                Product productByBarcode = ProductDAL.GetProductByBarcode(searchText);

                if (productByBarcode != null)
                {
                    // Found by barcode!
                    List<Product> results = new List<Product> { productByBarcode };
                    dgvProducts.DataSource = results;
                    if (dgvProducts.Columns.Count > 0)
                        dgvProducts.Columns["ProductID"].Visible = false;
                }
                else
                {
                    // Search by name instead
                    List<Product> results = ProductDAL.SearchProductsByName(searchText);
                    dgvProducts.DataSource = results;
                    if (dgvProducts.Columns.Count > 0)
                        dgvProducts.Columns["ProductID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
        }

        private void dgvProducts_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];

                if (row.Cells["ProductID"].Value != null)
                {
                    int productID = (int)row.Cells["ProductID"].Value;
                    currentProduct = ProductDAL.GetProductByID(productID);

                    if (currentProduct != null)
                    {
                        // Fill form fields
                        txtBarcode.Text = currentProduct.Barcode;
                        txtProductName.Text = currentProduct.ProductName;
                        txtCategory.Text = currentProduct.Category;
                        txtQuantity.Text = currentProduct.Quantity.ToString();
                        txtPrice.Text = currentProduct.Price.ToString();
                        txtUnit.Text = currentProduct.Unit;
                        txtDescription.Text = currentProduct.Description;
                        txtSupplier.Text = currentProduct.Supplier;

                        if (currentProduct.ManufacturingDate.HasValue)
                            dtpMfgDate.Value = currentProduct.ManufacturingDate.Value;

                        if (currentProduct.ExpirationDate.HasValue)
                            dtpExpDate.Value = currentProduct.ExpirationDate.Value;

                        if (!string.IsNullOrEmpty(currentProduct.ImagePath) && File.Exists(currentProduct.ImagePath))
                        {
                            try
                            {
                                pbProductImage.Image = Image.FromFile(currentProduct.ImagePath);
                                pbProductImage.SizeMode = PictureBoxSizeMode.Zoom;  // ✅ ADD THIS LINE!
                                selectedImagePath = currentProduct.ImagePath;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error loading image: " + ex.Message);
                            }
                        }
                        else
                        {
                            pbProductImage.Image = null;
                            selectedImagePath = null;
                        }
                    }
                }
            }
        }
    }
}
