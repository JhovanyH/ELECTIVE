using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELECTIVE
{
    internal class ProductDAL
    {
        // ==========================================
        // CREATE - Add a new product to database
        // ==========================================
        /// <summary>
        /// Adds a new product to the database
        /// </summary>
        public static bool AddProduct(Product product)
        {
            try
            {
                // Get a connection from our DatabaseConnection class
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    // SQL INSERT statement
                    // The ? are placeholders for our actual values (to prevent SQL injection)
                    string query = @"INSERT INTO Products 
                                    (Barcode, ProductName, Category, Quantity, Price, 
                                     ExpirationDate, ManufacturingDate, Unit, Description, Supplier, ImagePath, BarcodeImagePath, QRCodeImagePath) 
                                    VALUES 
                                    (@Barcode, @ProductName, @Category, @Quantity, @Price, 
                                     @ExpirationDate, @ManufacturingDate, @Unit, @Description, @Supplier, @ImagePath, @BarcodeImagePath, @QRCodeImagePath)";

                    // Create a SQL command with the query and connection
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters - these are the actual values that go into the database
                        // @ParameterName is the placeholder, .Value is what we're inserting
                        cmd.Parameters.AddWithValue("@Barcode", product.Barcode ?? "");
                        cmd.Parameters.AddWithValue("@ProductName", product.ProductName ?? "");
                        cmd.Parameters.AddWithValue("@Category", product.Category ?? "");
                        cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                        cmd.Parameters.AddWithValue("@Price", product.Price);
                        cmd.Parameters.AddWithValue("@Supplier", product.Supplier ?? "");

                        // For nullable dates, check if they have a value before adding
                        cmd.Parameters.AddWithValue("@ExpirationDate", product.ExpirationDate.HasValue ? (object)product.ExpirationDate.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@ManufacturingDate", product.ManufacturingDate.HasValue ? (object)product.ManufacturingDate.Value : DBNull.Value);

                        cmd.Parameters.AddWithValue("@Unit", product.Unit ?? "");
                        cmd.Parameters.AddWithValue("@Description", product.Description ?? "");
                        cmd.Parameters.AddWithValue("@ImagePath", product.ImagePath ?? "");
                        cmd.Parameters.AddWithValue("@BarcodeImagePath", product.BarcodeImagePath ?? "");
                        cmd.Parameters.AddWithValue("@QRCodeImagePath", product.QRCodeImagePath ?? "");

                        // Execute the INSERT command
                        // ExecuteNonQuery returns the number of rows affected (should be 1 if successful)
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // If 1 row was inserted, return true (success)
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // If something goes wrong, show the error
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ==========================================
        // READ - Get products from database
        // ==========================================
        /// <summary>
        /// Gets all products from the database
        /// </summary>
        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    // SQL SELECT statement to get all products
                    string query = "SELECT * FROM Products";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // ExecuteReader returns a reader object that we can loop through
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Loop through each row in the result
                            while (reader.Read())
                            {
                                // Create a new Product object for each row
                                Product product = new Product
                                {
                                    // reader["ColumnName"] gets the value from that column
                                    ProductID = (int)reader["ProductID"],
                                    Barcode = reader["Barcode"].ToString(),
                                    ProductName = reader["ProductName"].ToString(),
                                    Category = reader["Category"].ToString(),
                                    Quantity = (int)reader["Quantity"],
                                    Price = (decimal)reader["Price"],
                                    Supplier = reader["Supplier"].ToString(),
                                    Unit = reader["Unit"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    ImagePath = reader["ImagePath"].ToString(),
                                    BarcodeImagePath = reader["BarcodeImagePath"].ToString(),
                                    QRCodeImagePath = reader["QRCodeImagePath"].ToString(),
                                    CreatedDate = (DateTime)reader["CreatedDate"],
                                    UpdatedDate = (DateTime)reader["UpdatedDate"]
                                };

                                // Handle nullable dates
                                if (reader["ExpirationDate"] != DBNull.Value)
                                    product.ExpirationDate = (DateTime)reader["ExpirationDate"];

                                if (reader["ManufacturingDate"] != DBNull.Value)
                                    product.ManufacturingDate = (DateTime)reader["ManufacturingDate"];

                                // Add this product to our list
                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return products;
        }

        /// <summary>
        /// Gets a specific product by its ID
        /// </summary>
        public static Product GetProductByID(int productID)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    // SELECT only the product with matching ProductID
                    string query = "SELECT * FROM Products WHERE ProductID = @ProductID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // If we found a product with this ID
                            if (reader.Read())
                            {
                                Product product = new Product
                                {
                                    ProductID = (int)reader["ProductID"],
                                    Barcode = reader["Barcode"].ToString(),
                                    ProductName = reader["ProductName"].ToString(),
                                    Category = reader["Category"].ToString(),
                                    Quantity = (int)reader["Quantity"],
                                    Supplier = reader["Supplier"].ToString(),
                                    Price = (decimal)reader["Price"],
                                    Unit = reader["Unit"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    ImagePath = reader["ImagePath"].ToString(),
                                    BarcodeImagePath = reader["BarcodeImagePath"].ToString(),
                                    QRCodeImagePath = reader["QRCodeImagePath"].ToString(),
                                    CreatedDate = (DateTime)reader["CreatedDate"],
                                    UpdatedDate = (DateTime)reader["UpdatedDate"]
                                };

                                if (reader["ExpirationDate"] != DBNull.Value)
                                    product.ExpirationDate = (DateTime)reader["ExpirationDate"];

                                if (reader["ManufacturingDate"] != DBNull.Value)
                                    product.ManufacturingDate = (DateTime)reader["ManufacturingDate"];

                                return product;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        /// <summary>
        /// Searches products by barcode
        /// </summary>
        public static Product GetProductByBarcode(string barcode)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    // SELECT product where Barcode matches
                    string query = "SELECT * FROM Products WHERE Barcode = @Barcode";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Barcode", barcode ?? "");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Product product = new Product
                                {
                                    ProductID = (int)reader["ProductID"],
                                    Barcode = reader["Barcode"].ToString(),
                                    ProductName = reader["ProductName"].ToString(),
                                    Category = reader["Category"].ToString(),
                                    Quantity = (int)reader["Quantity"],
                                    Supplier = reader["Supplier"].ToString(),
                                    Price = (decimal)reader["Price"],
                                    Unit = reader["Unit"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    ImagePath = reader["ImagePath"].ToString(),
                                    BarcodeImagePath = reader["BarcodeImagePath"].ToString(),
                                    QRCodeImagePath = reader["QRCodeImagePath"].ToString(),
                                    CreatedDate = (DateTime)reader["CreatedDate"],
                                    UpdatedDate = (DateTime)reader["UpdatedDate"]
                                };

                                if (reader["ExpirationDate"] != DBNull.Value)
                                    product.ExpirationDate = (DateTime)reader["ExpirationDate"];

                                if (reader["ManufacturingDate"] != DBNull.Value)
                                    product.ManufacturingDate = (DateTime)reader["ManufacturingDate"];

                                return product;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        /// <summary>
        /// Search products by product name (LIKE search)
        /// LIKE is a SQL keyword that does partial matching
        /// Example: search for "apple" finds "Apple Juice", "Apple Pie", etc.
        /// </summary>
        public static List<Product> SearchProductsByName(string productName)
        {
            List<Product> products = new List<Product>();

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    // LIKE with % means "contains this text"
                    // % means "any characters before/after"
                    string query = "SELECT * FROM Products WHERE ProductName LIKE @ProductName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add % signs so it searches for products containing the text
                        cmd.Parameters.AddWithValue("@ProductName", "%" + (productName ?? "") + "%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product
                                {
                                    ProductID = (int)reader["ProductID"],
                                    Barcode = reader["Barcode"].ToString(),
                                    ProductName = reader["ProductName"].ToString(),
                                    Category = reader["Category"].ToString(),
                                    Quantity = (int)reader["Quantity"],
                                    Supplier = reader["Supplier"].ToString(),
                                    Price = (decimal)reader["Price"],
                                    Unit = reader["Unit"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    ImagePath = reader["ImagePath"].ToString(),
                                    BarcodeImagePath = reader["BarcodeImagePath"].ToString(),
                                    QRCodeImagePath = reader["QRCodeImagePath"].ToString(),
                                    CreatedDate = (DateTime)reader["CreatedDate"],
                                    UpdatedDate = (DateTime)reader["UpdatedDate"]
                                };

                                if (reader["ExpirationDate"] != DBNull.Value)
                                    product.ExpirationDate = (DateTime)reader["ExpirationDate"];

                                if (reader["ManufacturingDate"] != DBNull.Value)
                                    product.ManufacturingDate = (DateTime)reader["ManufacturingDate"];

                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return products;
        }

        // ==========================================
        // UPDATE - Modify an existing product
        // ==========================================
        /// <summary>
        /// Updates an existing product in the database
        /// </summary>
        public static bool UpdateProduct(Product product)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    // SQL UPDATE statement
                    // SET specifies which columns to update
                    // WHERE specifies which row to update (by ProductID)
                    string query = @"UPDATE Products SET 
                                    Barcode = @Barcode,
                                    ProductName = @ProductName,
                                    Category = @Category,
                                    Quantity = @Quantity,
                                    Supplier = @Supplier,
                                    Price = @Price,
                                    ExpirationDate = @ExpirationDate,
                                    ManufacturingDate = @ManufacturingDate,
                                    Unit = @Unit,
                                    Description = @Description,
                                    ImagePath = @ImagePath, 
                                    BarcodeImagePath = @BarcodeImagePath,      // ← ADD THIS
                                    QRCodeImagePath = @QRCodeImagePath,  
                                    UpdatedDate = GETDATE()
                                    WHERE ProductID = @ProductID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add all the parameters
                        cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
                        cmd.Parameters.AddWithValue("@Barcode", product.Barcode ?? "");
                        cmd.Parameters.AddWithValue("@ProductName", product.ProductName ?? "");
                        cmd.Parameters.AddWithValue("@Category", product.Category ?? "");
                        cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                        cmd.Parameters.AddWithValue("@Supplier", product.Supplier ?? "");
                        cmd.Parameters.AddWithValue("@Price", product.Price);
                        cmd.Parameters.AddWithValue("@ExpirationDate", product.ExpirationDate.HasValue ? (object)product.ExpirationDate.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@ManufacturingDate", product.ManufacturingDate.HasValue ? (object)product.ManufacturingDate.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Unit", product.Unit ?? "");
                        cmd.Parameters.AddWithValue("@Description", product.Description ?? "");
                        cmd.Parameters.AddWithValue("@ImagePath", product.ImagePath ?? "");
                        cmd.Parameters.AddWithValue("@BarcodeImagePath", product.BarcodeImagePath ?? "");
                        cmd.Parameters.AddWithValue("@QRCodeImagePath", product.QRCodeImagePath ?? "");

                        // Execute the UPDATE command
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ==========================================
        // DELETE - Remove a product from database
        // ==========================================
        /// <summary>
        /// Deletes a product from the database
        /// </summary>
        public static bool DeleteProduct(int productID)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    // SQL DELETE statement
                    // WHERE specifies which row to delete
                    string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);

                        // Execute the DELETE command
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ==========================================
        // SEARCH METHODS
        // ==========================================
        /// <summary>
        /// Search products by category
        /// </summary>
        public static List<Product> SearchProductsByCategory(string category)
        {
            List<Product> products = new List<Product>();

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Products WHERE Category = @Category";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Category", category ?? "");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product
                                {
                                    ProductID = (int)reader["ProductID"],
                                    Barcode = reader["Barcode"].ToString(),
                                    ProductName = reader["ProductName"].ToString(),
                                    Category = reader["Category"].ToString(),
                                    Supplier = reader["Supplier"].ToString(),
                                    Quantity = (int)reader["Quantity"],
                                    Price = (decimal)reader["Price"],
                                    Unit = reader["Unit"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    ImagePath = reader["ImagePath"].ToString(),
                                    BarcodeImagePath = reader["BarcodeImagePath"].ToString(),
                                    QRCodeImagePath = reader["QRCodeImagePath"].ToString(),
                                    CreatedDate = (DateTime)reader["CreatedDate"],
                                    UpdatedDate = (DateTime)reader["UpdatedDate"]
                                };

                                if (reader["ExpirationDate"] != DBNull.Value)
                                    product.ExpirationDate = (DateTime)reader["ExpirationDate"];

                                if (reader["ManufacturingDate"] != DBNull.Value)
                                    product.ManufacturingDate = (DateTime)reader["ManufacturingDate"];

                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return products;
        }

        /// <summary>
        /// Check if barcode already exists in database
        /// Useful before adding a new product
        /// </summary>
        public static bool BarcodeExists(string barcode)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM Products WHERE Barcode = @Barcode";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Barcode", barcode ?? "");
                        // ExecuteScalar returns the first column of the first row
                        // In this case, it returns the COUNT result
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking barcode: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool DecreaseProductStock(int productID, int quantitySold)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"UPDATE Products 
                            SET Quantity = Quantity - @QuantitySold,
                                UpdatedDate = GETDATE()
                            WHERE ProductID = @ProductID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.Parameters.AddWithValue("@QuantitySold", quantitySold);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error decreasing stock: " + ex.Message);
                return false;
            }
        }

       // ==========================================
// SAVE SALE TO DATABASE
// ==========================================
public static int AddSale(decimal totalAmount, string status = "Completed")
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"INSERT INTO Sales (SaleDate, TotalAmount, Status)
                            VALUES (GETDATE(), @TotalAmount, @Status);
                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmd.Parameters.AddWithValue("@Status", status);

                        // ExecuteScalar returns the SaleID
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int saleID))
                        {
                            return saleID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving sale: " + ex.Message);
            }

            return 0;
        }


        // ==========================================
        // SAVE SALE DETAIL (Individual item in sale)
        // ==========================================
        public static bool AddSaleDetail(int saleID, int productID, int quantity,
            decimal unitPrice, decimal totalPrice)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"INSERT INTO SaleDetails 
                            (SaleID, ProductID, Quantity, UnitPrice, TotalPrice)
                            VALUES 
                            (@SaleID, @ProductID, @Quantity, @UnitPrice, @TotalPrice)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SaleID", saleID);
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving sale detail: " + ex.Message);
                return false;
            }
        }


    }
}
