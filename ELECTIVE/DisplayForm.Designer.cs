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
            panel3.BackColor = Color.WhiteSmoke;
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
            panel3.Size = new Size(371, 657);
            panel3.TabIndex = 8;
            // 
            // lblMfgDate
            // 
            lblMfgDate.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            lblMfgDate.Location = new Point(16, 598);
            lblMfgDate.Name = "lblMfgDate";
            lblMfgDate.Size = new Size(334, 28);
            lblMfgDate.TabIndex = 24;
            // 
            // lblExpDate
            // 
            lblExpDate.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            lblExpDate.Location = new Point(16, 532);
            lblExpDate.Name = "lblExpDate";
            lblExpDate.Size = new Size(334, 28);
            lblExpDate.TabIndex = 23;
            // 
            // lblUnit
            // 
            lblUnit.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            lblUnit.Location = new Point(30, 451);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(318, 28);
            lblUnit.TabIndex = 22;
            // 
            // lblStock
            // 
            lblStock.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            lblStock.Location = new Point(30, 393);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(318, 28);
            lblStock.TabIndex = 21;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            txtDescription.Location = new Point(14, 325);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(354, 28);
            txtDescription.TabIndex = 20;
            // 
            // lblSupplier
            // 
            lblSupplier.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            lblSupplier.Location = new Point(30, 257);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(318, 28);
            lblSupplier.TabIndex = 19;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            lblPrice.Location = new Point(30, 185);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(318, 28);
            lblPrice.TabIndex = 18;
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            lblCategory.Location = new Point(30, 122);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(320, 28);
            lblCategory.TabIndex = 17;
            // 
            // lblName
            // 
            lblName.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            lblName.Location = new Point(30, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(318, 28);
            lblName.TabIndex = 16;
            // 
            // lblBarcode
            // 
            lblBarcode.Font = new Font("Courier New", 10.8F, FontStyle.Bold);
            lblBarcode.Location = new Point(30, 18);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(318, 28);
            lblBarcode.TabIndex = 6;
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 700);
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
    }
}