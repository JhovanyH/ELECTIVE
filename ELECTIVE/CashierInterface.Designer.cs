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
            lblQuantityDisplay = new Label();
            btnAddToCart = new Button();
            btnRemoveItem = new Button();
            btnClearCart = new Button();
            btnCheckOut = new Button();
            dgvCart = new DataGridView();
            searchbtton = new Button();
            cmbDiscount = new ComboBox();
            lblDiscount = new TextBox();
            txtCashGiven = new TextBox();
            txtChange = new TextBox();
            btnCalculateChange = new Button();
            btnquantityplus = new Button();
            button1 = new Button();
            button7click = new Button();
            button8click = new Button();
            button9click = new Button();
            button4click = new Button();
            button5click = new Button();
            button6click = new Button();
            button1click = new Button();
            button2click = new Button();
            button3click = new Button();
            button0 = new Button();
            btnclearbarcode = new Button();
            lblPricePreview = new Label();
            buttondecimal = new Button();
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
            panel1.Location = new Point(1148, 382);
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
            // lblQuantityDisplay
            // 
            lblQuantityDisplay.AutoSize = true;
            lblQuantityDisplay.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantityDisplay.Location = new Point(1124, 44);
            lblQuantityDisplay.Name = "lblQuantityDisplay";
            lblQuantityDisplay.Size = new Size(89, 17);
            lblQuantityDisplay.TabIndex = 16;
            lblQuantityDisplay.Text = "QUANTITY:";
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
            dgvCart.Location = new Point(733, 114);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(641, 249);
            dgvCart.TabIndex = 22;
            // 
            // searchbtton
            // 
            searchbtton.Location = new Point(746, 27);
            searchbtton.Name = "searchbtton";
            searchbtton.Size = new Size(136, 53);
            searchbtton.TabIndex = 23;
            searchbtton.Text = "SEARCH";
            searchbtton.UseVisualStyleBackColor = true;
            searchbtton.Click += searchbtton_Click;
            // 
            // cmbDiscount
            // 
            cmbDiscount.BackColor = SystemColors.Info;
            cmbDiscount.FormattingEnabled = true;
            cmbDiscount.Location = new Point(209, 513);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.Size = new Size(151, 28);
            cmbDiscount.TabIndex = 24;
            cmbDiscount.SelectedIndexChanged += cmbDiscount_SelectedIndexChanged;
            // 
            // lblDiscount
            // 
            lblDiscount.BackColor = SystemColors.Info;
            lblDiscount.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(161, 571);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(183, 24);
            lblDiscount.TabIndex = 25;
            // 
            // txtCashGiven
            // 
            txtCashGiven.BackColor = SystemColors.Info;
            txtCashGiven.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCashGiven.Location = new Point(73, 643);
            txtCashGiven.Name = "txtCashGiven";
            txtCashGiven.Size = new Size(183, 24);
            txtCashGiven.TabIndex = 26;
            // 
            // txtChange
            // 
            txtChange.BackColor = SystemColors.Info;
            txtChange.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChange.Location = new Point(522, 689);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(183, 24);
            txtChange.TabIndex = 27;
            // 
            // btnCalculateChange
            // 
            btnCalculateChange.Location = new Point(415, 488);
            btnCalculateChange.Name = "btnCalculateChange";
            btnCalculateChange.Size = new Size(136, 53);
            btnCalculateChange.TabIndex = 28;
            btnCalculateChange.Text = "CALCULATE";
            btnCalculateChange.UseVisualStyleBackColor = true;
            btnCalculateChange.Click += btnCalculateChange_Click;
            // 
            // btnquantityplus
            // 
            btnquantityplus.FlatStyle = FlatStyle.Flat;
            btnquantityplus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnquantityplus.Location = new Point(1070, 20);
            btnquantityplus.Name = "btnquantityplus";
            btnquantityplus.Size = new Size(48, 47);
            btnquantityplus.TabIndex = 29;
            btnquantityplus.Text = "+";
            btnquantityplus.TextAlign = ContentAlignment.MiddleRight;
            btnquantityplus.UseVisualStyleBackColor = true;
            btnquantityplus.Click += btnquantityplus_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1220, 23);
            button1.Name = "button1";
            button1.Size = new Size(48, 47);
            button1.TabIndex = 30;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button7click
            // 
            button7click.Font = new Font("Courier New", 10.2F, FontStyle.Bold);
            button7click.Location = new Point(746, 454);
            button7click.Name = "button7click";
            button7click.Size = new Size(64, 53);
            button7click.TabIndex = 31;
            button7click.Text = "7";
            button7click.UseVisualStyleBackColor = true;
            button7click.Click += button7click_Click;
            // 
            // button8click
            // 
            button8click.Font = new Font("Courier New", 10.2F, FontStyle.Bold);
            button8click.Location = new Point(816, 454);
            button8click.Name = "button8click";
            button8click.Size = new Size(64, 53);
            button8click.TabIndex = 32;
            button8click.Text = "8";
            button8click.UseVisualStyleBackColor = true;
            button8click.Click += button8click_Click;
            // 
            // button9click
            // 
            button9click.Font = new Font("Courier New", 10.2F, FontStyle.Bold);
            button9click.Location = new Point(886, 454);
            button9click.Name = "button9click";
            button9click.Size = new Size(64, 53);
            button9click.TabIndex = 33;
            button9click.Text = "9";
            button9click.UseVisualStyleBackColor = true;
            button9click.Click += button9click_Click;
            // 
            // button4click
            // 
            button4click.Font = new Font("Courier New", 10.2F, FontStyle.Bold);
            button4click.Location = new Point(746, 513);
            button4click.Name = "button4click";
            button4click.Size = new Size(64, 53);
            button4click.TabIndex = 34;
            button4click.Text = "4";
            button4click.UseVisualStyleBackColor = true;
            button4click.Click += button4click_Click;
            // 
            // button5click
            // 
            button5click.Font = new Font("Courier New", 10.2F, FontStyle.Bold);
            button5click.Location = new Point(816, 513);
            button5click.Name = "button5click";
            button5click.Size = new Size(64, 53);
            button5click.TabIndex = 35;
            button5click.Text = "5";
            button5click.UseVisualStyleBackColor = true;
            button5click.Click += button5click_Click;
            // 
            // button6click
            // 
            button6click.Font = new Font("Courier New", 10.2F, FontStyle.Bold);
            button6click.Location = new Point(886, 513);
            button6click.Name = "button6click";
            button6click.Size = new Size(64, 53);
            button6click.TabIndex = 36;
            button6click.Text = "6";
            button6click.UseVisualStyleBackColor = true;
            button6click.Click += button6click_Click;
            // 
            // button1click
            // 
            button1click.Font = new Font("Courier New", 10.2F, FontStyle.Bold);
            button1click.Location = new Point(746, 572);
            button1click.Name = "button1click";
            button1click.Size = new Size(64, 53);
            button1click.TabIndex = 37;
            button1click.Text = "1";
            button1click.UseVisualStyleBackColor = true;
            button1click.Click += button1click_Click;
            // 
            // button2click
            // 
            button2click.Font = new Font("Courier New", 10.2F, FontStyle.Bold);
            button2click.Location = new Point(816, 571);
            button2click.Name = "button2click";
            button2click.Size = new Size(64, 53);
            button2click.TabIndex = 38;
            button2click.Text = "2";
            button2click.UseVisualStyleBackColor = true;
            button2click.Click += button2click_Click;
            // 
            // button3click
            // 
            button3click.Font = new Font("Courier New", 10.2F, FontStyle.Bold);
            button3click.Location = new Point(886, 572);
            button3click.Name = "button3click";
            button3click.Size = new Size(64, 53);
            button3click.TabIndex = 39;
            button3click.Text = "3";
            button3click.UseVisualStyleBackColor = true;
            button3click.Click += button3click_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Courier New", 10.2F, FontStyle.Bold);
            button0.Location = new Point(746, 631);
            button0.Name = "button0";
            button0.Size = new Size(64, 53);
            button0.TabIndex = 40;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // btnclearbarcode
            // 
            btnclearbarcode.Font = new Font("Courier New", 10.2F, FontStyle.Bold);
            btnclearbarcode.Location = new Point(984, 631);
            btnclearbarcode.Name = "btnclearbarcode";
            btnclearbarcode.Size = new Size(134, 53);
            btnclearbarcode.TabIndex = 41;
            btnclearbarcode.Text = "CLEAR";
            btnclearbarcode.UseVisualStyleBackColor = true;
            btnclearbarcode.Click += btnclearbarcode_Click;
            // 
            // lblPricePreview
            // 
            lblPricePreview.AutoSize = true;
            lblPricePreview.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPricePreview.Location = new Point(668, 391);
            lblPricePreview.Name = "lblPricePreview";
            lblPricePreview.Size = new Size(17, 17);
            lblPricePreview.TabIndex = 42;
            lblPricePreview.Text = "0";
            // 
            // buttondecimal
            // 
            buttondecimal.Font = new Font("Courier New", 10.2F, FontStyle.Bold);
            buttondecimal.Location = new Point(818, 631);
            buttondecimal.Name = "buttondecimal";
            buttondecimal.Size = new Size(64, 53);
            buttondecimal.TabIndex = 43;
            buttondecimal.Text = ".";
            buttondecimal.UseVisualStyleBackColor = true;
            buttondecimal.Click += buttondecimal_Click;
            // 
            // CashierInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 799);
            Controls.Add(buttondecimal);
            Controls.Add(lblPricePreview);
            Controls.Add(btnclearbarcode);
            Controls.Add(button0);
            Controls.Add(button3click);
            Controls.Add(button2click);
            Controls.Add(button1click);
            Controls.Add(button6click);
            Controls.Add(button5click);
            Controls.Add(button4click);
            Controls.Add(button9click);
            Controls.Add(button8click);
            Controls.Add(button7click);
            Controls.Add(button1);
            Controls.Add(btnquantityplus);
            Controls.Add(btnCalculateChange);
            Controls.Add(txtChange);
            Controls.Add(txtCashGiven);
            Controls.Add(lblDiscount);
            Controls.Add(cmbDiscount);
            Controls.Add(searchbtton);
            Controls.Add(dgvCart);
            Controls.Add(btnCheckOut);
            Controls.Add(btnClearCart);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnAddToCart);
            Controls.Add(lblQuantityDisplay);
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
        private Label lblQuantityDisplay;
        private Button btnAddToCart;
        private Button btnRemoveItem;
        private Button btnClearCart;
        private Button btnCheckOut;
        private DataGridView dgvCart;
        private Button searchbtton;
        private ComboBox cmbDiscount;
        private TextBox lblDiscount;
        private TextBox txtCashGiven;
        private TextBox txtChange;
        private Button btnCalculateChange;
        private Button btnquantityplus;
        private Button button1;
        private Button button7click;
        private Button button8click;
        private Button button9click;
        private Button button4click;
        private Button button5click;
        private Button button6click;
        private Button button1click;
        private Button button2click;
        private Button button3click;
        private Button button0;
        private Button btnclearbarcode;
        private Label lblPricePreview;
        private Button buttondecimal;
    }
}