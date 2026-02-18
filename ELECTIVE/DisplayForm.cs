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
    public partial class DisplayForm : Form
    {
        private List<Product> allProducts;
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
            LoadCategories();

        }
        private void LoadAllProducts()
        {
            try
            {
                allProducts = ProductDAL.GetAllProducts();
                DisplayProducts(allProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }
        private void DisplayProducts(List<Product> products)
        {
            try
            {
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = products;

                // Hide unnecessary columns
                if (dgvProducts.Columns.Contains("ProductID"))
                    dgvProducts.Columns["ProductID"].Visible = false;
                if (dgvProducts.Columns.Contains("ImagePath"))
                    dgvProducts.Columns["ImagePath"].Visible = false;
                if (dgvProducts.Columns.Contains("BarcodeImagePath"))
                    dgvProducts.Columns["BarcodeImagePath"].Visible = false;
                if (dgvProducts.Columns.Contains("QRCodeImagePath"))
                    dgvProducts.Columns["QRCodeImagePath"].Visible = false;
                if (dgvProducts.Columns.Contains("CreatedDate"))
                    dgvProducts.Columns["CreatedDate"].Visible = false;
                if (dgvProducts.Columns.Contains("UpdatedDate"))
                    dgvProducts.Columns["UpdatedDate"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying products: " + ex.Message);
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];

                if (row.Cells["ProductID"].Value != null)
                {
                    int productID = (int)row.Cells["ProductID"].Value;
                    Product product = ProductDAL.GetProductByID(productID);

                    if (product != null)
                    {
                        // Display product details
                        lblBarcode.Text = product.Barcode;
                        lblName.Text = product.ProductName;
                        lblCategory.Text =  product.Category;
                        lblPrice.Text = product.Price.ToString("0.00");
                        lblSupplier.Text = (string.IsNullOrEmpty(product.Supplier) ? "N/A" : product.Supplier);
                        lblUnit.Text =  product.Unit;
                        lblStock.Text = "Stock: " + product.Quantity;
                        txtDescription.Text = product.Description;
                        lblExpDate.Text = (product.ExpirationDate.HasValue ? product.ExpirationDate.Value.ToShortDateString() : "N/A");
                        lblMfgDate.Text = (product.ManufacturingDate.HasValue ? product.ManufacturingDate.Value.ToShortDateString() : "N/A");

                        // Load product image
                        if (!string.IsNullOrEmpty(product.ImagePath) && System.IO.File.Exists(product.ImagePath))
                        {
                            try
                            {
                                productimage.Image = Image.FromFile(product.ImagePath);
                                productimage.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                            catch
                            {
                                productimage.Image = null;
                            }
                        }
                        else
                        {
                            productimage.Image = null;
                        }

                        // Load barcode image
                        if (!string.IsNullOrEmpty(product.BarcodeImagePath) && System.IO.File.Exists(product.BarcodeImagePath))
                        {
                            try
                            {
                                barcodeimage.Image = Image.FromFile(product.BarcodeImagePath);
                                barcodeimage.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                            catch
                            {
                                barcodeimage.Image = null;
                            }
                        }
                        else
                        {
                            barcodeimage.Image = null;
                        }

                        // Load QR code image
                        if (!string.IsNullOrEmpty(product.QRCodeImagePath) && System.IO.File.Exists(product.QRCodeImagePath))
                        {
                            try
                            {
                                qrcodeimage.Image = Image.FromFile(product.QRCodeImagePath);
                                qrcodeimage.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                            catch
                            {
                                qrcodeimage.Image = null;
                            }
                        }
                        else
                        {
                            qrcodeimage.Image = null;
                        }
                    }
                }
            }
        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = searchtxtbox.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    DisplayProducts(allProducts);
                }
                else
                {
                    // Search by barcode first
                    Product productByBarcode = ProductDAL.GetProductByBarcode(searchText);

                    if (productByBarcode != null)
                    {
                        List<Product> results = new List<Product> { productByBarcode };
                        DisplayProducts(results);
                    }
                    else
                    {
                        // Search by name
                        List<Product> results = ProductDAL.SearchProductsByName(searchText);
                        DisplayProducts(results);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message);
            }
        }

        private void categorycombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedCategory = categorycombobox.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedCategory) || selectedCategory == "All")
                {
                    DisplayProducts(allProducts);
                }
                else
                {
                    List<Product> filtered = ProductDAL.SearchProductsByCategory(selectedCategory);
                    DisplayProducts(filtered);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering: " + ex.Message);
            }
        }
        private void LoadCategories()
        {
            try
            {
                // Get unique categories
                List<string> categories = new List<string> { "All" };

                if (allProducts != null)
                {
                    var uniqueCategories = allProducts
                        .Where(p => !string.IsNullOrEmpty(p.Category))
                        .Select(p => p.Category)
                        .Distinct()
                        .OrderBy(c => c)
                        .ToList();

                    categories.AddRange(uniqueCategories);
                }

                categorycombobox.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }
    }
}
