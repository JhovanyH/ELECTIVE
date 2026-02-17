namespace ELECTIVE
{
    partial class AddProducts
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
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            productName_txtbox = new TextBox();
            label1 = new Label();
            barcode_textbox = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            expiration_date_picker = new DateTimePicker();
            label10 = new Label();
            stock_numericupdown = new NumericUpDown();
            label5 = new Label();
            Price_numericUpdown = new NumericUpDown();
            label4 = new Label();
            categoy_comboBox = new ComboBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            button_browse = new Button();
            image_Box = new PictureBox();
            label6 = new Label();
            save_button = new Button();
            cancel_button = new Button();
            update_button = new Button();
            delete_button = new Button();
            groupBox4 = new GroupBox();
            Desc_txtbox = new TextBox();
            label11 = new Label();
            unit_comboBox = new ComboBox();
            manufacturing_date_picker = new DateTimePicker();
            supplier_txtbox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SEARCH = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stock_numericupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Price_numericUpdown).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image_Box).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 445);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1574, 308);
            dataGridView1.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Snow;
            groupBox2.Controls.Add(productName_txtbox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(barcode_textbox);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(21, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(554, 184);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product Identification";
            // 
            // productName_txtbox
            // 
            productName_txtbox.BackColor = SystemColors.Info;
            productName_txtbox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productName_txtbox.Location = new Point(19, 128);
            productName_txtbox.Name = "productName_txtbox";
            productName_txtbox.Size = new Size(513, 24);
            productName_txtbox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 105);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 4;
            label1.Text = "PRODUCT NAME:";
            // 
            // barcode_textbox
            // 
            barcode_textbox.BackColor = SystemColors.Info;
            barcode_textbox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barcode_textbox.Location = new Point(19, 61);
            barcode_textbox.Name = "barcode_textbox";
            barcode_textbox.Size = new Size(401, 24);
            barcode_textbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 39);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 2;
            label2.Text = "BARCODE:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.Controls.Add(expiration_date_picker);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(stock_numericupdown);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Price_numericUpdown);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(categoy_comboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(21, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 227);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // expiration_date_picker
            // 
            expiration_date_picker.CalendarMonthBackground = SystemColors.Info;
            expiration_date_picker.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expiration_date_picker.Location = new Point(277, 142);
            expiration_date_picker.Name = "expiration_date_picker";
            expiration_date_picker.Size = new Size(239, 24);
            expiration_date_picker.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(330, 117);
            label10.Name = "label10";
            label10.Size = new Size(186, 21);
            label10.TabIndex = 18;
            label10.Text = "EXPIRATION DATE:";
            // 
            // stock_numericupdown
            // 
            stock_numericupdown.BackColor = SystemColors.Info;
            stock_numericupdown.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stock_numericupdown.Location = new Point(344, 73);
            stock_numericupdown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            stock_numericupdown.Name = "stock_numericupdown";
            stock_numericupdown.Size = new Size(172, 22);
            stock_numericupdown.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(344, 48);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 16;
            label5.Text = "STOCK:";
            // 
            // Price_numericUpdown
            // 
            Price_numericUpdown.BackColor = SystemColors.Info;
            Price_numericUpdown.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price_numericUpdown.Location = new Point(22, 142);
            Price_numericUpdown.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            Price_numericUpdown.Name = "Price_numericUpdown";
            Price_numericUpdown.Size = new Size(172, 22);
            Price_numericUpdown.TabIndex = 15;
            Price_numericUpdown.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 117);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 14;
            label4.Text = "PRICE(PHP):";
            // 
            // categoy_comboBox
            // 
            categoy_comboBox.BackColor = SystemColors.Info;
            categoy_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoy_comboBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoy_comboBox.FormattingEnabled = true;
            categoy_comboBox.Items.AddRange(new object[] { "Beverages", "", "Snacks", "", "Canned Goods", "", "Dairy", "", "Frozen Food", "", "Meat & Poultry", "", "ruits & Vegetables", "", "Personal Care", "", "Cleaning Supplies", "", "Electronics", "", "Appliances", "", "Furniture", "", "Stationery", "", "Clothing", "", "Hardware", "", "Toys", "", "Medicine", "", "Others" });
            categoy_comboBox.Location = new Point(19, 73);
            categoy_comboBox.Name = "categoy_comboBox";
            categoy_comboBox.Size = new Size(266, 25);
            categoy_comboBox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 48);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 12;
            label3.Text = "CATEGORY:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Snow;
            groupBox3.Controls.Add(button_browse);
            groupBox3.Controls.Add(image_Box);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(1075, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(331, 417);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "More Details:";
            // 
            // button_browse
            // 
            button_browse.BackColor = SystemColors.Info;
            button_browse.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_browse.Location = new Point(101, 351);
            button_browse.Name = "button_browse";
            button_browse.Size = new Size(124, 42);
            button_browse.TabIndex = 20;
            button_browse.Text = "BROWSE";
            button_browse.UseVisualStyleBackColor = false;
            button_browse.Click += button_browse_Click;
            // 
            // image_Box
            // 
            image_Box.BackColor = Color.MistyRose;
            image_Box.BackgroundImageLayout = ImageLayout.Stretch;
            image_Box.BorderStyle = BorderStyle.Fixed3D;
            image_Box.Location = new Point(20, 55);
            image_Box.Name = "image_Box";
            image_Box.Size = new Size(285, 273);
            image_Box.TabIndex = 19;
            image_Box.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 32);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 18;
            label6.Text = "PRODUCT IMAGE:";
            // 
            // save_button
            // 
            save_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save_button.BackColor = Color.LimeGreen;
            save_button.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save_button.Location = new Point(1426, 150);
            save_button.Name = "save_button";
            save_button.Size = new Size(164, 60);
            save_button.TabIndex = 3;
            save_button.Text = "SAVE";
            save_button.UseVisualStyleBackColor = false;
            save_button.Click += save_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancel_button.BackColor = Color.Gold;
            cancel_button.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_button.Location = new Point(1426, 225);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(164, 56);
            cancel_button.TabIndex = 4;
            cancel_button.Text = "CANCEL";
            cancel_button.UseVisualStyleBackColor = false;
            cancel_button.Click += cancel_button_Click;
            // 
            // update_button
            // 
            update_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            update_button.BackColor = Color.DeepSkyBlue;
            update_button.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update_button.Location = new Point(1426, 294);
            update_button.Name = "update_button";
            update_button.Size = new Size(164, 56);
            update_button.TabIndex = 6;
            update_button.Text = "UPDATE";
            update_button.UseVisualStyleBackColor = false;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            delete_button.BackColor = Color.Crimson;
            delete_button.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_button.Location = new Point(1426, 366);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(164, 56);
            delete_button.TabIndex = 7;
            delete_button.Text = "DELETE";
            delete_button.UseVisualStyleBackColor = false;
            delete_button.Click += delete_button_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Snow;
            groupBox4.Controls.Add(Desc_txtbox);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(unit_comboBox);
            groupBox4.Controls.Add(manufacturing_date_picker);
            groupBox4.Controls.Add(supplier_txtbox);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(581, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(488, 417);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Product Details";
            // 
            // Desc_txtbox
            // 
            Desc_txtbox.BackColor = SystemColors.Info;
            Desc_txtbox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Desc_txtbox.Location = new Point(22, 328);
            Desc_txtbox.Name = "Desc_txtbox";
            Desc_txtbox.Size = new Size(401, 24);
            Desc_txtbox.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(22, 288);
            label11.Name = "label11";
            label11.Size = new Size(142, 21);
            label11.TabIndex = 21;
            label11.Text = "DESCRIPTION:";
            // 
            // unit_comboBox
            // 
            unit_comboBox.BackColor = SystemColors.Info;
            unit_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unit_comboBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unit_comboBox.FormattingEnabled = true;
            unit_comboBox.Items.AddRange(new object[] { "Piece", "Kilo", "Box", "Pack" });
            unit_comboBox.Location = new Point(19, 245);
            unit_comboBox.Name = "unit_comboBox";
            unit_comboBox.Size = new Size(266, 25);
            unit_comboBox.TabIndex = 20;
            // 
            // manufacturing_date_picker
            // 
            manufacturing_date_picker.CalendarMonthBackground = SystemColors.Info;
            manufacturing_date_picker.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manufacturing_date_picker.Location = new Point(19, 154);
            manufacturing_date_picker.Name = "manufacturing_date_picker";
            manufacturing_date_picker.Size = new Size(239, 24);
            manufacturing_date_picker.TabIndex = 20;
            // 
            // supplier_txtbox
            // 
            supplier_txtbox.BackColor = SystemColors.Info;
            supplier_txtbox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplier_txtbox.Location = new Point(22, 64);
            supplier_txtbox.Name = "supplier_txtbox";
            supplier_txtbox.Size = new Size(401, 24);
            supplier_txtbox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 128);
            label7.Name = "label7";
            label7.Size = new Size(219, 21);
            label7.TabIndex = 16;
            label7.Text = "MANUFACTURING DATE:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 220);
            label8.Name = "label8";
            label8.Size = new Size(65, 21);
            label8.TabIndex = 14;
            label8.Text = "UNIT:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 38);
            label9.Name = "label9";
            label9.Size = new Size(109, 21);
            label9.TabIndex = 12;
            label9.Text = "SUPPLIER:";
            // 
            // SEARCH
            // 
            SEARCH.AutoSize = true;
            SEARCH.BackColor = SystemColors.ButtonHighlight;
            SEARCH.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SEARCH.Location = new Point(1503, 83);
            SEARCH.Name = "SEARCH";
            SEARCH.Size = new Size(76, 21);
            SEARCH.TabIndex = 21;
            SEARCH.Text = "SEARCH";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.magnifyingGlass;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1429, 60);
            button1.Name = "button1";
            button1.Size = new Size(65, 67);
            button1.TabIndex = 20;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Indigo;
            ClientSize = new Size(1607, 773);
            Controls.Add(SEARCH);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(cancel_button);
            Controls.Add(save_button);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Name = "AddProducts";
            Text = "AddProducts";
            WindowState = FormWindowState.Maximized;
            Load += AddProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stock_numericupdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Price_numericUpdown).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image_Box).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        public GroupBox groupBox2;
        private TextBox barcode_textbox;
        private Label label2;
        private TextBox productName_txtbox;
        private Label label1;
        public GroupBox groupBox1;
        private NumericUpDown stock_numericupdown;
        private Label label5;
        private NumericUpDown Price_numericUpdown;
        private Label label4;
        private Label label3;
        public GroupBox groupBox3;
        private Button button_browse;
        private PictureBox image_Box;
        private Label label6;
        private Button save_button;
        private Button cancel_button;
        private Button update_button;
        private Button delete_button;
        public ComboBox categoy_comboBox;
        public GroupBox groupBox4;
        private Label label7;
        private Label label8;
        public ComboBox comboBox1;
        private Label label9;
        private Label label10;
        private DateTimePicker expiration_date_picker;
        private TextBox supplier_txtbox;
        public ComboBox unit_comboBox;
        private DateTimePicker manufacturing_date_picker;
        private TextBox Desc_txtbox;
        private Label label11;
        private Label SEARCH;
        private Button button1;
    }
}