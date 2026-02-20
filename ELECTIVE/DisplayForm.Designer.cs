namespace ELECTIVE
{
    partial class DisplayForm
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
            label1 = new Label();
            searchtxtbox = new TextBox();
            categorycombobox = new ComboBox();
            dgvProducts = new DataGridView();
            productimage = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            qrcodeimage = new PictureBox();
            barcodeimage = new PictureBox();
            panel3 = new Panel();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            lblMfgDate = new TextBox();
            lblExpDate = new TextBox();
            lblUnit = new TextBox();
            lblStock = new TextBox();
            txtDescription = new TextBox();
            lblSupplier = new TextBox();
            lblPrice = new TextBox();
            lblCategory = new TextBox();
            lblName = new TextBox();
            lblBarcode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productimage).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qrcodeimage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barcodeimage).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "SEARCH:";
            // 
            // searchtxtbox
            // 
            searchtxtbox.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            searchtxtbox.Location = new Point(120, 15);
            searchtxtbox.Name = "searchtxtbox";
            searchtxtbox.Size = new Size(350, 28);
            searchtxtbox.TabIndex = 1;
            searchtxtbox.TextChanged += searchtxtbox_TextChanged;
            // 
            // categorycombobox
            // 
            categorycombobox.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            categorycombobox.FormattingEnabled = true;
            categorycombobox.Location = new Point(655, 12);
            categorycombobox.Name = "categorycombobox";
            categorycombobox.Size = new Size(291, 29);
            categorycombobox.TabIndex = 2;
            categorycombobox.SelectedIndexChanged += categorycombobox_SelectedIndexChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 85);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(962, 341);
            dgvProducts.TabIndex = 3;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // productimage
            // 
            productimage.BackColor = Color.MistyRose;
            productimage.BackgroundImageLayout = ImageLayout.Zoom;
            productimage.BorderStyle = BorderStyle.Fixed3D;
            productimage.Location = new Point(17, 33);
            productimage.Name = "productimage";
            productimage.Size = new Size(235, 152);
            productimage.TabIndex = 4;
            productimage.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            label2.Location = new Point(540, 18);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 5;
            label2.Text = "CATEGORY:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(searchtxtbox);
            panel1.Controls.Add(categorycombobox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 57);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(qrcodeimage);
            panel2.Controls.Add(barcodeimage);
            panel2.Controls.Add(productimage);
            panel2.Location = new Point(12, 444);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 225);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(741, 188);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 8;
            label5.Text = "QR Code Image";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(394, 188);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 7;
            label4.Text = "Barcode Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 188);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 6;
            label3.Text = "Product Image";
            // 
            // qrcodeimage
            // 
            qrcodeimage.BackColor = Color.MistyRose;
            qrcodeimage.BackgroundImageLayout = ImageLayout.Zoom;
            qrcodeimage.BorderStyle = BorderStyle.Fixed3D;
            qrcodeimage.Location = new Point(683, 33);
            qrcodeimage.Name = "qrcodeimage";
            qrcodeimage.Size = new Size(251, 152);
            qrcodeimage.TabIndex = 6;
            qrcodeimage.TabStop = false;
            // 
            // barcodeimage
            // 
            barcodeimage.BackColor = Color.MistyRose;
            barcodeimage.BackgroundImageLayout = ImageLayout.Zoom;
            barcodeimage.BorderStyle = BorderStyle.Fixed3D;
            barcodeimage.Location = new Point(307, 72);
            barcodeimage.Name = "barcodeimage";
            barcodeimage.Size = new Size(335, 113);
            barcodeimage.TabIndex = 5;
            barcodeimage.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lblMfgDate);
            panel3.Controls.Add(lblExpDate);
            panel3.Controls.Add(lblUnit);
            panel3.Controls.Add(lblStock);
            panel3.Controls.Add(txtDescription);
            panel3.Controls.Add(lblSupplier);
            panel3.Controls.Add(lblPrice);
            panel3.Controls.Add(lblCategory);
            panel3.Controls.Add(lblName);
            panel3.Controls.Add(lblBarcode);
            panel3.Location = new Point(980, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(494, 657);
            panel3.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 589);
            label15.Name = "label15";
            label15.Size = new Size(159, 16);
            label15.TabIndex = 35;
            label15.Text = "Manufacturing Date:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(3, 528);
            label14.Name = "label14";
            label14.Size = new Size(135, 16);
            label14.TabIndex = 34;
            label14.Text = "Expiration Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 467);
            label13.Name = "label13";
            label13.Size = new Size(39, 16);
            label13.TabIndex = 33;
            label13.Text = "Unit";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 406);
            label12.Name = "label12";
            label12.Size = new Size(55, 16);
            label12.TabIndex = 32;
            label12.Text = "Stock:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 345);
            label11.Name = "label11";
            label11.Size = new Size(103, 16);
            label11.TabIndex = 31;
            label11.Text = "Description:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 284);
            label10.Name = "label10";
            label10.Size = new Size(79, 16);
            label10.TabIndex = 30;
            label10.Text = "Supplier:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 223);
            label9.Name = "label9";
            label9.Size = new Size(55, 16);
            label9.TabIndex = 29;
            label9.Text = "Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 162);
            label8.Name = "label8";
            label8.Size = new Size(79, 16);
            label8.TabIndex = 28;
            label8.Text = "Category:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 101);
            label7.Name = "label7";
            label7.Size = new Size(71, 16);
            label7.TabIndex = 27;
            label7.Text = "Product:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 40);
            label6.Name = "label6";
            label6.Size = new Size(71, 16);
            label6.TabIndex = 6;
            label6.Text = "Barcode:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Location = new Point(0, 643);
            panel5.Name = "panel5";
            panel5.Size = new Size(494, 14);
            panel5.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(0, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(494, 14);
            panel4.TabIndex = 25;
            // 
            // lblMfgDate
            // 
            lblMfgDate.BorderStyle = BorderStyle.None;
            lblMfgDate.Font = new Font("Courier New", 10.2F, FontStyle.Bold | FontStyle.Underline);
            lblMfgDate.Location = new Point(177, 577);
            lblMfgDate.Name = "lblMfgDate";
            lblMfgDate.Size = new Size(296, 20);
            lblMfgDate.TabIndex = 24;
            lblMfgDate.TextAlign = HorizontalAlignment.Right;
            // 
            // lblExpDate
            // 
            lblExpDate.BorderStyle = BorderStyle.None;
            lblExpDate.Font = new Font("Courier New", 10.2F, FontStyle.Bold | FontStyle.Underline);
            lblExpDate.Location = new Point(177, 516);
            lblExpDate.Name = "lblExpDate";
            lblExpDate.Size = new Size(296, 20);
            lblExpDate.TabIndex = 23;
            lblExpDate.TextAlign = HorizontalAlignment.Right;
            // 
            // lblUnit
            // 
            lblUnit.BorderStyle = BorderStyle.None;
            lblUnit.Font = new Font("Courier New", 10.2F, FontStyle.Bold | FontStyle.Underline);
            lblUnit.Location = new Point(139, 455);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(334, 20);
            lblUnit.TabIndex = 22;
            lblUnit.TextAlign = HorizontalAlignment.Right;
            // 
            // lblStock
            // 
            lblStock.BorderStyle = BorderStyle.None;
            lblStock.Font = new Font("Courier New", 10.2F, FontStyle.Bold | FontStyle.Underline);
            lblStock.Location = new Point(139, 394);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(334, 20);
            lblStock.TabIndex = 21;
            lblStock.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Courier New", 10.2F, FontStyle.Bold | FontStyle.Underline);
            txtDescription.Location = new Point(139, 333);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(334, 20);
            txtDescription.TabIndex = 20;
            txtDescription.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSupplier
            // 
            lblSupplier.BorderStyle = BorderStyle.None;
            lblSupplier.Font = new Font("Courier New", 10.2F, FontStyle.Bold | FontStyle.Underline);
            lblSupplier.Location = new Point(139, 272);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(334, 20);
            lblSupplier.TabIndex = 19;
            lblSupplier.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            lblPrice.BorderStyle = BorderStyle.None;
            lblPrice.Font = new Font("Courier New", 10.2F, FontStyle.Bold | FontStyle.Underline);
            lblPrice.Location = new Point(139, 211);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(334, 20);
            lblPrice.TabIndex = 18;
            lblPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCategory
            // 
            lblCategory.BorderStyle = BorderStyle.None;
            lblCategory.Font = new Font("Courier New", 10.2F, FontStyle.Bold | FontStyle.Underline);
            lblCategory.Location = new Point(139, 150);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(334, 20);
            lblCategory.TabIndex = 17;
            lblCategory.TextAlign = HorizontalAlignment.Right;
            // 
            // lblName
            // 
            lblName.BorderStyle = BorderStyle.None;
            lblName.Font = new Font("Courier New", 10.2F, FontStyle.Bold | FontStyle.Underline);
            lblName.Location = new Point(139, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(334, 20);
            lblName.TabIndex = 16;
            lblName.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBarcode
            // 
            lblBarcode.BorderStyle = BorderStyle.None;
            lblBarcode.Font = new Font("Courier New", 10.2F, FontStyle.Bold | FontStyle.Underline);
            lblBarcode.Location = new Point(139, 28);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(334, 20);
            lblBarcode.TabIndex = 6;
            lblBarcode.TextAlign = HorizontalAlignment.Right;
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 700);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvProducts);
            Name = "DisplayForm";
            Text = "DisplayForm";
            Load += DisplayForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productimage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)qrcodeimage).EndInit();
            ((System.ComponentModel.ISupportInitialize)barcodeimage).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox searchtxtbox;
        private ComboBox categorycombobox;
        private DataGridView dgvProducts;
        private PictureBox productimage;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox qrcodeimage;
        private PictureBox barcodeimage;
        private Panel panel3;
        private TextBox lblBarcode;
        private TextBox lblExpDate;
        private TextBox lblUnit;
        private TextBox lblStock;
        private TextBox txtDescription;
        private TextBox lblSupplier;
        private TextBox lblPrice;
        private TextBox lblCategory;
        private TextBox lblName;
        private TextBox lblMfgDate;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel5;
        private Panel panel4;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
    }
}