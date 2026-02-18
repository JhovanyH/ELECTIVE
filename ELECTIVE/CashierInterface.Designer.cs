namespace ELECTIVE
{
    partial class CashierInterface
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
            txtBarcode = new TextBox();
            panel1 = new Panel();
            lblProductPrice = new TextBox();
            label2 = new Label();
            lblProductName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblAvailableQty = new TextBox();
            label5 = new Label();
            lblSubtotal = new TextBox();
            label6 = new Label();
            lblTax = new TextBox();
            label7 = new Label();
            lblTotal = new TextBox();
            numQuantity = new NumericUpDown();
            label8 = new Label();
            btnAddToCart = new Button();
            btnRemoveItem = new Button();
            btnClearCart = new Button();
            btnCheckOut = new Button();
            dgvCart = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 44);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 0;
            label1.Text = "BARCODE:";
            // 
            // txtBarcode
            // 
            txtBarcode.BackColor = SystemColors.Info;
            txtBarcode.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBarcode.Location = new Point(195, 37);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(180, 24);
            txtBarcode.TabIndex = 1;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // panel1
            // 
            panel1.Location = new Point(1124, 626);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 2;
            // 
            // lblProductPrice
            // 
            lblProductPrice.BackColor = SystemColors.Info;
            lblProductPrice.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductPrice.Location = new Point(195, 151);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(174, 24);
            lblProductPrice.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 105);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 4;
            label2.Text = "NAME:";
            // 
            // lblProductName
            // 
            lblProductName.BackColor = SystemColors.Info;
            lblProductName.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(195, 102);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(192, 24);
            lblProductName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(109, 158);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 6;
            label3.Text = "PRICE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 205);
            label4.Name = "label4";
            label4.Size = new Size(179, 17);
            label4.TabIndex = 7;
            label4.Text = "AVAILABLE QUANTITY:";
            // 
            // lblAvailableQty
            // 
            lblAvailableQty.BackColor = SystemColors.Info;
            lblAvailableQty.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableQty.Location = new Point(195, 205);
            lblAvailableQty.Name = "lblAvailableQty";
            lblAvailableQty.Size = new Size(165, 24);
            lblAvailableQty.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(82, 256);
            label5.Name = "label5";
            label5.Size = new Size(89, 17);
            label5.TabIndex = 9;
            label5.Text = "SUBTOTAL:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.BackColor = SystemColors.Info;
            lblSubtotal.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(195, 249);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(149, 24);
            lblSubtotal.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(118, 297);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 11;
            label6.Text = "TAX:";
            // 
            // lblTax
            // 
            lblTax.BackColor = SystemColors.Info;
            lblTax.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTax.Location = new Point(192, 290);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(183, 24);
            lblTax.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(109, 346);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 13;
            label7.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = SystemColors.Info;
            lblTotal.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(195, 339);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(149, 24);
            lblTotal.TabIndex = 14;
            // 
            // numQuantity
            // 
            numQuantity.BackColor = SystemColors.Info;
            numQuantity.Location = new Point(192, 409);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(150, 27);
            numQuantity.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(73, 419);
            label8.Name = "label8";
            label8.Size = new Size(89, 17);
            label8.TabIndex = 16;
            label8.Text = "QUANTITY:";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(552, 41);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(136, 53);
            btnAddToCart.TabIndex = 17;
            btnAddToCart.Text = "ADD TO CART";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(552, 105);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.RightToLeft = RightToLeft.No;
            btnRemoveItem.Size = new Size(136, 53);
            btnRemoveItem.TabIndex = 18;
            btnRemoveItem.Text = "REMOVE ITEM";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.Location = new Point(552, 169);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.RightToLeft = RightToLeft.No;
            btnClearCart.Size = new Size(136, 53);
            btnClearCart.TabIndex = 20;
            btnClearCart.Text = "CLEAR CART";
            btnClearCart.UseVisualStyleBackColor = true;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(552, 249);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.RightToLeft = RightToLeft.No;
            btnCheckOut.Size = new Size(136, 53);
            btnCheckOut.TabIndex = 21;
            btnCheckOut.Text = "CHECK OUT";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(709, 105);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(641, 249);
            dgvCart.TabIndex = 22;
            // 
            // CashierInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 799);
            Controls.Add(dgvCart);
            Controls.Add(btnCheckOut);
            Controls.Add(btnClearCart);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnAddToCart);
            Controls.Add(label8);
            Controls.Add(numQuantity);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(lblTax);
            Controls.Add(label6);
            Controls.Add(lblSubtotal);
            Controls.Add(label5);
            Controls.Add(lblAvailableQty);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblProductName);
            Controls.Add(label2);
            Controls.Add(lblProductPrice);
            Controls.Add(panel1);
            Controls.Add(txtBarcode);
            Controls.Add(label1);
            Name = "CashierInterface";
            Text = "CashierInterface";
            Load += CashierInterface_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBarcode;
        private Panel panel1;
        private TextBox lblProductPrice;
        private Label label2;
        private TextBox lblProductName;
        private Label label3;
        private Label label4;
        private TextBox lblAvailableQty;
        private Label label5;
        private TextBox lblSubtotal;
        private Label label6;
        private TextBox lblTax;
        private Label label7;
        private TextBox lblTotal;
        private NumericUpDown numQuantity;
        private Label label8;
        private Button btnAddToCart;
        private Button btnRemoveItem;
        private Button btnClearCart;
        private Button btnCheckOut;
        private DataGridView dgvCart;
    }
}