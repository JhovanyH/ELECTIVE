namespace ELECTIVE
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SEARCH = new Label();
            txtSearch = new Button();
            groupBox4 = new GroupBox();
            txtDescription = new TextBox();
            label11 = new Label();
            txtUnit = new ComboBox();
            dtpMfgDate = new DateTimePicker();
            txtSupplier = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            delete_button = new Button();
            update_button = new Button();
            cancel_button = new Button();
            save_button = new Button();
            groupBox3 = new GroupBox();
            button_browse = new Button();
            pbProductImage = new PictureBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            dtpExpDate = new DateTimePicker();
            label10 = new Label();
            txtQuantity = new NumericUpDown();
            label5 = new Label();
            txtPrice = new NumericUpDown();
            label4 = new Label();
            txtCategory = new ComboBox();
            label3 = new Label();
            dgvProducts = new DataGridView();
            groupBox2 = new GroupBox();
            txtProductName = new TextBox();
            label1 = new Label();
            txtBarcode = new TextBox();
            label2 = new Label();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // SEARCH
            // 
            SEARCH.AutoSize = true;
            SEARCH.BackColor = SystemColors.ButtonHighlight;
            SEARCH.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SEARCH.Location = new Point(1505, 84);
            SEARCH.Name = "SEARCH";
            SEARCH.Size = new Size(76, 21);
            SEARCH.TabIndex = 32;
            SEARCH.Text = "SEARCH";
            // 
            // txtSearch
            // 
            txtSearch.BackgroundImage = Properties.Resources.magnifyingGlass;
            txtSearch.BackgroundImageLayout = ImageLayout.Zoom;
            txtSearch.FlatAppearance.BorderSize = 0;
            txtSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            txtSearch.FlatAppearance.MouseOverBackColor = Color.Gray;
            txtSearch.FlatStyle = FlatStyle.Flat;
            txtSearch.Location = new Point(1431, 61);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(65, 67);
            txtSearch.TabIndex = 31;
            txtSearch.UseVisualStyleBackColor = true;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Snow;
            groupBox4.Controls.Add(txtDescription);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txtUnit);
            groupBox4.Controls.Add(dtpMfgDate);
            groupBox4.Controls.Add(txtSupplier);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(583, 23);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(488, 417);
            groupBox4.TabIndex = 30;
            groupBox4.TabStop = false;
            groupBox4.Text = "Product Details";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.Info;
            txtDescription.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(46, 328);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(401, 24);
            txtDescription.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(46, 288);
            label11.Name = "label11";
            label11.Size = new Size(142, 21);
            label11.TabIndex = 21;
            label11.Text = "DESCRIPTION:";
            // 
            // txtUnit
            // 
            txtUnit.BackColor = SystemColors.Info;
            txtUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUnit.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnit.FormattingEnabled = true;
            txtUnit.Items.AddRange(new object[] { "Piece", "Kilo", "Box", "Pack" });
            txtUnit.Location = new Point(43, 245);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(266, 25);
            txtUnit.TabIndex = 20;
            // 
            // dtpMfgDate
            // 
            dtpMfgDate.CalendarMonthBackground = SystemColors.Info;
            dtpMfgDate.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpMfgDate.Location = new Point(43, 154);
            dtpMfgDate.Name = "dtpMfgDate";
            dtpMfgDate.Size = new Size(239, 24);
            dtpMfgDate.TabIndex = 20;
            // 
            // txtSupplier
            // 
            txtSupplier.BackColor = SystemColors.Info;
            txtSupplier.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplier.Location = new Point(46, 64);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(401, 24);
            txtSupplier.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(43, 128);
            label7.Name = "label7";
            label7.Size = new Size(219, 21);
            label7.TabIndex = 16;
            label7.Text = "MANUFACTURING DATE:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(43, 220);
            label8.Name = "label8";
            label8.Size = new Size(65, 21);
            label8.TabIndex = 14;
            label8.Text = "UNIT:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(43, 38);
            label9.Name = "label9";
            label9.Size = new Size(109, 21);
            label9.TabIndex = 12;
            label9.Text = "SUPPLIER:";
            // 
            // delete_button
            // 
            delete_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            delete_button.BackColor = Color.Crimson;
            delete_button.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_button.Location = new Point(1428, 367);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(164, 56);
            delete_button.TabIndex = 29;
            delete_button.Text = "DELETE";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;
            // 
            // update_button
            // 
            update_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            update_button.BackColor = Color.DeepSkyBlue;
            update_button.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_button.Location = new Point(1428, 295);
            update_button.Name = "update_button";
            update_button.Size = new Size(164, 56);
            update_button.TabIndex = 28;
            update_button.Text = "UPDATE";
            update_button.UseVisualStyleBackColor = false;
            update_button.Click += update_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancel_button.BackColor = Color.Gold;
            cancel_button.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_button.Location = new Point(1428, 226);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(164, 56);
            cancel_button.TabIndex = 26;
            cancel_button.Text = "CANCEL";
            cancel_button.UseVisualStyleBackColor = false;
            cancel_button.Click += cancel_button_Click;
            // 
            // save_button
            // 
            save_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save_button.BackColor = Color.LimeGreen;
            save_button.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save_button.Location = new Point(1428, 151);
            save_button.Name = "save_button";
            save_button.Size = new Size(164, 60);
            save_button.TabIndex = 25;
            save_button.Text = "SAVE";
            save_button.UseVisualStyleBackColor = false;
            save_button.Click += save_button_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Snow;
            groupBox3.Controls.Add(button_browse);
            groupBox3.Controls.Add(pbProductImage);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(1077, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(331, 417);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "More Details:";
            // 
            // button_browse
            // 
            button_browse.BackColor = SystemColors.Info;
            button_browse.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_browse.Location = new Point(106, 351);
            button_browse.Name = "button_browse";
            button_browse.Size = new Size(124, 42);
            button_browse.TabIndex = 20;
            button_browse.Text = "BROWSE";
            button_browse.UseVisualStyleBackColor = false;
            button_browse.Click += button_browse_Click;
            // 
            // pbProductImage
            // 
            pbProductImage.BackColor = Color.MistyRose;
            pbProductImage.BackgroundImageLayout = ImageLayout.Stretch;
            pbProductImage.BorderStyle = BorderStyle.Fixed3D;
            pbProductImage.Location = new Point(27, 55);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(285, 273);
            pbProductImage.TabIndex = 19;
            pbProductImage.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 32);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 18;
            label6.Text = "PRODUCT IMAGE:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.Controls.Add(dtpExpDate);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCategory);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(23, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 227);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // dtpExpDate
            // 
            dtpExpDate.CalendarMonthBackground = SystemColors.Info;
            dtpExpDate.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpExpDate.Location = new Point(301, 142);
            dtpExpDate.Name = "dtpExpDate";
            dtpExpDate.Size = new Size(239, 24);
            dtpExpDate.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(354, 117);
            label10.Name = "label10";
            label10.Size = new Size(186, 21);
            label10.TabIndex = 18;
            label10.Text = "EXPIRATION DATE:";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.Info;
            txtQuantity.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(368, 73);
            txtQuantity.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(172, 22);
            txtQuantity.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(368, 48);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 16;
            label5.Text = "STOCK:";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Info;
            txtPrice.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(46, 142);
            txtPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(172, 22);
            txtPrice.TabIndex = 15;
            txtPrice.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 117);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 14;
            label4.Text = "PRICE(PHP):";
            // 
            // txtCategory
            // 
            txtCategory.BackColor = SystemColors.Info;
            txtCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCategory.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategory.FormattingEnabled = true;
            txtCategory.Items.AddRange(new object[] { "Beverages", "", "Snacks", "", "Canned Goods", "", "Dairy", "", "Frozen Food", "", "Meat & Poultry", "", "ruits & Vegetables", "", "Personal Care", "", "Cleaning Supplies", "", "Electronics", "", "Appliances", "", "Furniture", "", "Stationery", "", "Clothing", "", "Hardware", "", "Toys", "", "Medicine", "", "Others" });
            txtCategory.Location = new Point(43, 73);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(266, 25);
            txtCategory.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 48);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 12;
            label3.Text = "CATEGORY:";
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = Color.MistyRose;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(23, 446);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(1574, 308);
            dgvProducts.TabIndex = 27;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Snow;
            groupBox2.Controls.Add(txtProductName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtBarcode);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(23, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(554, 184);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product Identification";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.Info;
            txtProductName.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(43, 128);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(513, 24);
            txtProductName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 105);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 4;
            label1.Text = "PRODUCT NAME:";
            // 
            // txtBarcode
            // 
            txtBarcode.BackColor = SystemColors.Info;
            txtBarcode.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBarcode.Location = new Point(43, 61);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(401, 24);
            txtBarcode.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 39);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 2;
            label2.Text = "BARCODE:";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1715, 781);
            Controls.Add(SEARCH);
            Controls.Add(txtSearch);
            Controls.Add(groupBox4);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(cancel_button);
            Controls.Add(save_button);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dgvProducts);
            Controls.Add(groupBox2);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SEARCH;
        private Button txtSearch;
        public GroupBox groupBox4;
        private TextBox txtDescription;
        private Label label11;
        public ComboBox txtUnit;
        private DateTimePicker dtpMfgDate;
        private TextBox txtSupplier;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button delete_button;
        private Button update_button;
        private Button cancel_button;
        private Button save_button;
        public GroupBox groupBox3;
        private Button button_browse;
        private PictureBox pbProductImage;
        private Label label6;
        public GroupBox groupBox1;
        private DateTimePicker dtpExpDate;
        private Label label10;
        private NumericUpDown txtQuantity;
        private Label label5;
        private NumericUpDown txtPrice;
        private Label label4;
        public ComboBox txtCategory;
        private Label label3;
        private DataGridView dgvProducts;
        public GroupBox groupBox2;
        private TextBox txtProductName;
        private Label label1;
        private TextBox txtBarcode;
        private Label label2;
    }
}