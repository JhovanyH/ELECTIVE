using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ELECTIVE
{

    public partial class AddProducts : Form
    {
        Size baseSize;
        string connectionString = @"Data Source= LAPTOP-8COQ8R8Q\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True";
        string selectedImagePath = "";
        DatabaseHelper db = new DatabaseHelper();
        public AddProducts()
        {
            InitializeComponent();
            baseSize = this.Size;
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            // 1. Create a File Dialog to pick a file
            OpenFileDialog open = new OpenFileDialog();

            // 2. Set filters so they only see images
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            // 3. If they pick a file and click "OK"
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Display the image in the PictureBox
                image_Box.Image = new Bitmap(open.FileName);

                // Make the image fit nicely (Stretch or Zoom)
                image_Box.SizeMode = PictureBoxSizeMode.StretchImage;

                // Save the file path to our variable so we can send it to SQL later
                selectedImagePath = open.FileName;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            // === CRASH FIX: CHECK FOR EMPTY FIELDS ===
            if (string.IsNullOrWhiteSpace(barcode_textbox.Text) ||
                string.IsNullOrWhiteSpace(productName_txtbox.Text) ||
                string.IsNullOrWhiteSpace(categoy_comboBox.Text))
            {
                MessageBox.Show("Please fill in all required fields (Barcode, Name, Category)!",
                                "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // STOP! Do not run the rest of the code.
            }


            string query = "INSERT INTO Products (Barcode, ProductName, Category, Price, StockQuantity, Supplier, ImageURL, ExpiryDate, ManufacturingDate, Unit, Description) " +
                    "VALUES (@Barcode, @Name, @Category, @Price, @Qty, @Supplier, @Img, @Expiry, @Manufac, @Unit, @Description)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Barcode", barcode_textbox.Text);
                cmd.Parameters.AddWithValue("@Name", productName_txtbox.Text);
                cmd.Parameters.AddWithValue("@Category", categoy_comboBox.Text);
                cmd.Parameters.AddWithValue("@Price", Price_numericUpdown.Value); // Note: NumericUpDown uses .Value, not .Text
                cmd.Parameters.AddWithValue("@Qty", stock_numericupdown.Value);
                cmd.Parameters.AddWithValue("@Supplier", supplier_txtbox.Text);
                cmd.Parameters.AddWithValue("@Expiry", expiration_date_picker.Value);
                cmd.Parameters.AddWithValue("@Unit", unit_comboBox.Text);
                cmd.Parameters.AddWithValue("@Description", Desc_txtbox.Text);
                cmd.Parameters.AddWithValue("@Manufac", manufacturing_date_picker.Value);

                // SAVE THE IMAGE PATH
                cmd.Parameters.AddWithValue("@Img", selectedImagePath);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved!");
                LoadData(); // Refresh the grid to show the new item
            }
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            // Use the class to get data!
            DataTable data = db.LoadData("SELECT * FROM Products");

            // Put that data into your grid
            dataGridView1.DataSource = data;

            this.WindowState = FormWindowState.Maximized;
            ScaleToScreen(); // Call the scaling function after loading data
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            barcode_textbox.Clear();
            productName_txtbox.Clear();

            // Reset dropdowns and number boxes
            categoy_comboBox.SelectedIndex = -1; // -1 means "nothing selected"
            Price_numericUpdown.Value = 0;
            stock_numericupdown.Value = 0;
            supplier_txtbox.Clear();
            expiration_date_picker.Value = DateTime.Now; // Reset to today
            manufacturing_date_picker.Value = DateTime.Now;
            unit_comboBox.SelectedIndex = -1;
            Desc_txtbox.Clear();

            // Clear the picture
            image_Box.Image = null;
            selectedImagePath = ""; // Don't forget to reset the variable too!

            barcode_textbox.Focus(); // Put the cursor back in the first box
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            // 1. Safety Check: Did they type a barcode?
            if (string.IsNullOrWhiteSpace(barcode_textbox.Text))
            {
                MessageBox.Show("Please enter the Barcode of the item you want to delete.");
                return;
            }

            // 2. Confirm: Ask "Are you sure?" so they don't delete by accident
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // 3. The Query
                string query = "DELETE FROM Products WHERE Barcode = @Barcode";

                // 4. Execute using your Helper (Clean & Fast)
                // Note: I'm assuming you are using the Helper class now. 
                // If not, use the "using(SqlConnection...)" style like your Save button.
                DatabaseHelper db = new DatabaseHelper();
                SqlParameter[] parameters = {
            new SqlParameter("@Barcode", barcode_textbox.Text)
        };

                db.ExecuteQuery(query, parameters);

                MessageBox.Show("Item Deleted!");

                // Refresh the grid to show it's gone
                LoadData();
                // (Make sure you have a LoadData() function, or copy the code from your Form_Load)
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            // 1. Safety Check
            if (string.IsNullOrWhiteSpace(barcode_textbox.Text))
            {
                MessageBox.Show("Enter a Barcode to update.");
                return;
            }

            // 2. The Query
            // We update EVERYTHING based on the Barcode
            string query = "UPDATE Products SET ProductName=@Name, Category=@Category, " +
                           "Price=@Price, StockQuantity=@Qty, Supplier=@Supplier, ImageURL=@Img, ExpiryDate=@Expiry," +
                           "ManufacturingDate=@Manufac, Unit=@Unit, Description=@Description, " +
                           "WHERE Barcode=@Barcode";

            // 3. Execute
            DatabaseHelper db = new DatabaseHelper();
            SqlParameter[] parameters = {
        new SqlParameter("@Barcode", barcode_textbox.Text),
        new SqlParameter("@Name", productName_txtbox.Text),
        new SqlParameter("@Category", categoy_comboBox.Text),
        new SqlParameter("@Price", Price_numericUpdown.Value),
        new SqlParameter("@Qty", stock_numericupdown.Value),
        new SqlParameter("@Supplier", supplier_txtbox.Text),
        new SqlParameter("@Img", selectedImagePath),
        new SqlParameter("@Expiry", expiration_date_picker.Value),
        new SqlParameter("@Manufac", manufacturing_date_picker.Value),
        new SqlParameter("@Unit", unit_comboBox.Text),
        new SqlParameter("@Description", Desc_txtbox.Text)

    };

            db.ExecuteQuery(query, parameters);

            MessageBox.Show("Item Updated!");
            LoadData(); // Refresh the grid
        }

        // Paste this inside your AddProducts class
        private void LoadData()
        {
            // This calls the helper for you
            dataGridView1.DataSource = db.LoadData("SELECT * FROM Products");

        }


        private void ScaleToScreen()
        {
            // A. Calculate the ratio (New Screen / Original Design)
            float scaleX = (float)Screen.PrimaryScreen.Bounds.Width / baseSize.Width;
            float scaleY = (float)Screen.PrimaryScreen.Bounds.Height / baseSize.Height;

            // B. Scale the Form and general positions
            // This stretches the boxes and moves them
            this.Scale(new SizeF(scaleX, scaleY));

            // C. Scale the Fonts (The recursive part)
            // We call a helper function to handle controls inside controls
            ScaleFonts(this.Controls, scaleX, scaleY);
        }

        // Helper function to dig inside GroupBoxes/Panels
        private void ScaleFonts(Control.ControlCollection controls, float scaleX, float scaleY)
        {
            foreach (Control ctrl in controls)
            {
                // Scale this control's font
                // We use Math.Min to keep the text looking normal (not too stretched width-wise)
                ctrl.Font = new Font(ctrl.Font.FontFamily, ctrl.Font.Size * Math.Min(scaleX, scaleY));

                // If this control has children (like a GroupBox has buttons), scale them too!
                if (ctrl.Controls.Count > 0)
                {
                    ScaleFonts(ctrl.Controls, scaleX, scaleY);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}