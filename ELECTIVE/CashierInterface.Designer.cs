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
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            label9 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label6 = new Label();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            pbProductImage = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 22);
            label1.Name = "label1";
            label1.Size = new Size(124, 27);
            label1.TabIndex = 0;
            label1.Text = "BARCODE:";
            // 
            // txtBarcode
            // 
            txtBarcode.BackColor = SystemColors.Info;
            txtBarcode.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBarcode.Location = new Point(149, 15);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(355, 41);
            txtBarcode.TabIndex = 1;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(txtBarcode);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 71);
            panel1.TabIndex = 2;
            // 
            // lblProductPrice
            // 
            lblProductPrice.BackColor = SystemColors.ControlLightLight;
            lblProductPrice.BorderStyle = BorderStyle.None;
            lblProductPrice.Font = new Font("Courier New", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblProductPrice.Location = new Point(397, 10);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.ReadOnly = true;
            lblProductPrice.Size = new Size(203, 21);
            lblProductPrice.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 10);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 4;
            label2.Text = "NAME:";
            // 
            // lblProductName
            // 
            lblProductName.BackColor = Color.White;
            lblProductName.BorderStyle = BorderStyle.None;
            lblProductName.Font = new Font("Courier New", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(19, 10);
            lblProductName.Name = "lblProductName";
            lblProductName.ReadOnly = true;
            lblProductName.Size = new Size(284, 21);
            lblProductName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(397, 12);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 6;
            label3.Text = "PRICE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 60);
            label4.Name = "label4";
            label4.Size = new Size(179, 17);
            label4.TabIndex = 7;
            label4.Text = "AVAILABLE QUANTITY:";
            // 
            // lblAvailableQty
            // 
            lblAvailableQty.BackColor = SystemColors.ControlLightLight;
            lblAvailableQty.BorderStyle = BorderStyle.None;
            lblAvailableQty.Font = new Font("Courier New", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblAvailableQty.Location = new Point(208, 53);
            lblAvailableQty.Name = "lblAvailableQty";
            lblAvailableQty.ReadOnly = true;
            lblAvailableQty.Size = new Size(90, 21);
            lblAvailableQty.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 551);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 9;
            // 
            // lblSubtotal
            // 
            lblSubtotal.BackColor = SystemColors.ControlLightLight;
            lblSubtotal.BorderStyle = BorderStyle.None;
            lblSubtotal.Font = new Font("Courier New", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(18, 199);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.ReadOnly = true;
            lblSubtotal.Size = new Size(247, 17);
            lblSubtotal.TabIndex = 10;
            // 
            // lblTax
            // 
            lblTax.BackColor = SystemColors.ControlLightLight;
            lblTax.BorderStyle = BorderStyle.None;
            lblTax.Font = new Font("Courier New", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTax.Location = new Point(397, 199);
            lblTax.Name = "lblTax";
            lblTax.ReadOnly = true;
            lblTax.Size = new Size(183, 17);
            lblTax.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 246);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 13;
            label7.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = SystemColors.ControlLightLight;
            lblTotal.BorderStyle = BorderStyle.None;
            lblTotal.Font = new Font("Courier New", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(87, 239);
            lblTotal.Name = "lblTotal";
            lblTotal.ReadOnly = true;
            lblTotal.Size = new Size(149, 17);
            lblTotal.TabIndex = 14;
            // 
            // lblQuantityDisplay
            // 
            lblQuantityDisplay.AutoSize = true;
            lblQuantityDisplay.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblQuantityDisplay.Location = new Point(173, 17);
            lblQuantityDisplay.Name = "lblQuantityDisplay";
            lblQuantityDisplay.Size = new Size(37, 37);
            lblQuantityDisplay.TabIndex = 16;
            lblQuantityDisplay.Text = "1";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.DeepSkyBlue;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnAddToCart.Location = new Point(1304, 103);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(163, 116);
            btnAddToCart.TabIndex = 17;
            btnAddToCart.Text = "ADD TO CART";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.Maroon;
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnRemoveItem.Location = new Point(1304, 529);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.RightToLeft = RightToLeft.No;
            btnRemoveItem.Size = new Size(163, 116);
            btnRemoveItem.TabIndex = 18;
            btnRemoveItem.Text = "REMOVE ITEM";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.DarkOrange;
            btnClearCart.FlatStyle = FlatStyle.Flat;
            btnClearCart.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnClearCart.Location = new Point(1304, 387);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.RightToLeft = RightToLeft.No;
            btnClearCart.Size = new Size(163, 116);
            btnClearCart.TabIndex = 20;
            btnClearCart.Text = "CLEAR CART";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.Violet;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnCheckOut.Location = new Point(1304, 671);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.RightToLeft = RightToLeft.No;
            btnCheckOut.Size = new Size(163, 116);
            btnCheckOut.TabIndex = 21;
            btnCheckOut.Text = "CHECK OUT";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(648, 105);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(639, 249);
            dgvCart.TabIndex = 22;
            // 
            // searchbtton
            // 
            searchbtton.BackColor = SystemColors.InactiveCaptionText;
            searchbtton.BackgroundImage = Properties.Resources.magnifyingGlass1;
            searchbtton.BackgroundImageLayout = ImageLayout.Zoom;
            searchbtton.ForeColor = SystemColors.ControlText;
            searchbtton.Location = new Point(536, 20);
            searchbtton.Name = "searchbtton";
            searchbtton.Size = new Size(95, 76);
            searchbtton.TabIndex = 23;
            searchbtton.UseVisualStyleBackColor = false;
            searchbtton.Click += searchbtton_Click;
            // 
            // cmbDiscount
            // 
            cmbDiscount.BackColor = SystemColors.Info;
            cmbDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiscount.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDiscount.FormattingEnabled = true;
            cmbDiscount.Location = new Point(103, 8);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.Size = new Size(235, 42);
            cmbDiscount.TabIndex = 24;
            cmbDiscount.SelectedIndexChanged += cmbDiscount_SelectedIndexChanged;
            // 
            // lblDiscount
            // 
            lblDiscount.BackColor = SystemColors.Info;
            lblDiscount.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(18, 72);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.ReadOnly = true;
            lblDiscount.Size = new Size(542, 41);
            lblDiscount.TabIndex = 25;
            // 
            // txtCashGiven
            // 
            txtCashGiven.BackColor = SystemColors.Info;
            txtCashGiven.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCashGiven.Location = new Point(18, 171);
            txtCashGiven.Name = "txtCashGiven";
            txtCashGiven.Size = new Size(541, 41);
            txtCashGiven.TabIndex = 26;
            // 
            // txtChange
            // 
            txtChange.BackColor = SystemColors.Info;
            txtChange.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChange.Location = new Point(18, 263);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(541, 41);
            txtChange.TabIndex = 27;
            // 
            // btnCalculateChange
            // 
            btnCalculateChange.BackColor = Color.MediumSeaGreen;
            btnCalculateChange.FlatStyle = FlatStyle.Flat;
            btnCalculateChange.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnCalculateChange.Location = new Point(1304, 245);
            btnCalculateChange.Name = "btnCalculateChange";
            btnCalculateChange.Size = new Size(163, 116);
            btnCalculateChange.TabIndex = 28;
            btnCalculateChange.Text = "CALCULATE";
            btnCalculateChange.UseVisualStyleBackColor = false;
            btnCalculateChange.Click += btnCalculateChange_Click;
            // 
            // btnquantityplus
            // 
            btnquantityplus.BackColor = Color.FromArgb(255, 255, 192);
            btnquantityplus.FlatStyle = FlatStyle.Flat;
            btnquantityplus.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnquantityplus.Location = new Point(114, 7);
            btnquantityplus.Name = "btnquantityplus";
            btnquantityplus.Size = new Size(53, 54);
            btnquantityplus.TabIndex = 29;
            btnquantityplus.Text = "+\r\n+\r\n";
            btnquantityplus.TextAlign = ContentAlignment.TopCenter;
            btnquantityplus.UseVisualStyleBackColor = false;
            btnquantityplus.Click += btnquantityplus_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(212, 7);
            button1.Name = "button1";
            button1.Size = new Size(53, 54);
            button1.TabIndex = 30;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button7click
            // 
            button7click.BackColor = Color.FromArgb(255, 192, 192);
            button7click.FlatStyle = FlatStyle.Popup;
            button7click.Font = new Font("Courier New", 18F, FontStyle.Bold);
            button7click.Location = new Point(648, 495);
            button7click.Name = "button7click";
            button7click.Size = new Size(96, 68);
            button7click.TabIndex = 31;
            button7click.Text = "7";
            button7click.UseVisualStyleBackColor = false;
            button7click.Click += button7click_Click;
            // 
            // button8click
            // 
            button8click.BackColor = Color.FromArgb(255, 192, 192);
            button8click.FlatStyle = FlatStyle.Popup;
            button8click.Font = new Font("Courier New", 18F, FontStyle.Bold);
            button8click.Location = new Point(753, 495);
            button8click.Name = "button8click";
            button8click.Size = new Size(96, 68);
            button8click.TabIndex = 32;
            button8click.Text = "8";
            button8click.UseVisualStyleBackColor = false;
            button8click.Click += button8click_Click;
            // 
            // button9click
            // 
            button9click.BackColor = Color.FromArgb(255, 192, 192);
            button9click.FlatStyle = FlatStyle.Popup;
            button9click.Font = new Font("Courier New", 18F, FontStyle.Bold);
            button9click.Location = new Point(855, 495);
            button9click.Name = "button9click";
            button9click.Size = new Size(96, 68);
            button9click.TabIndex = 33;
            button9click.Text = "9";
            button9click.UseVisualStyleBackColor = false;
            button9click.Click += button9click_Click;
            // 
            // button4click
            // 
            button4click.BackColor = Color.FromArgb(255, 192, 192);
            button4click.FlatStyle = FlatStyle.Popup;
            button4click.Font = new Font("Courier New", 18F, FontStyle.Bold);
            button4click.Location = new Point(648, 569);
            button4click.Name = "button4click";
            button4click.Size = new Size(96, 68);
            button4click.TabIndex = 34;
            button4click.Text = "4";
            button4click.UseVisualStyleBackColor = false;
            button4click.Click += button4click_Click;
            // 
            // button5click
            // 
            button5click.BackColor = Color.FromArgb(255, 192, 192);
            button5click.FlatStyle = FlatStyle.Popup;
            button5click.Font = new Font("Courier New", 18F, FontStyle.Bold);
            button5click.Location = new Point(753, 569);
            button5click.Name = "button5click";
            button5click.Size = new Size(96, 68);
            button5click.TabIndex = 35;
            button5click.Text = "5";
            button5click.UseVisualStyleBackColor = false;
            button5click.Click += button5click_Click;
            // 
            // button6click
            // 
            button6click.BackColor = Color.FromArgb(255, 192, 192);
            button6click.FlatStyle = FlatStyle.Popup;
            button6click.Font = new Font("Courier New", 18F, FontStyle.Bold);
            button6click.Location = new Point(855, 564);
            button6click.Name = "button6click";
            button6click.Size = new Size(96, 68);
            button6click.TabIndex = 36;
            button6click.Text = "6";
            button6click.UseVisualStyleBackColor = false;
            button6click.Click += button6click_Click;
            // 
            // button1click
            // 
            button1click.BackColor = Color.FromArgb(255, 192, 192);
            button1click.FlatStyle = FlatStyle.Popup;
            button1click.Font = new Font("Courier New", 18F, FontStyle.Bold);
            button1click.Location = new Point(648, 643);
            button1click.Name = "button1click";
            button1click.Size = new Size(96, 68);
            button1click.TabIndex = 37;
            button1click.Text = "1";
            button1click.UseVisualStyleBackColor = false;
            button1click.Click += button1click_Click;
            // 
            // button2click
            // 
            button2click.BackColor = Color.FromArgb(255, 192, 192);
            button2click.FlatStyle = FlatStyle.Popup;
            button2click.Font = new Font("Courier New", 18F, FontStyle.Bold);
            button2click.Location = new Point(753, 643);
            button2click.Name = "button2click";
            button2click.Size = new Size(96, 68);
            button2click.TabIndex = 38;
            button2click.Text = "2";
            button2click.UseVisualStyleBackColor = false;
            button2click.Click += button2click_Click;
            // 
            // button3click
            // 
            button3click.BackColor = Color.FromArgb(255, 192, 192);
            button3click.FlatStyle = FlatStyle.Popup;
            button3click.Font = new Font("Courier New", 18F, FontStyle.Bold);
            button3click.Location = new Point(855, 638);
            button3click.Name = "button3click";
            button3click.Size = new Size(96, 68);
            button3click.TabIndex = 39;
            button3click.Text = "3";
            button3click.UseVisualStyleBackColor = false;
            button3click.Click += button3click_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.FromArgb(255, 192, 192);
            button0.FlatStyle = FlatStyle.Popup;
            button0.Font = new Font("Courier New", 18F, FontStyle.Bold);
            button0.Location = new Point(648, 717);
            button0.Name = "button0";
            button0.Size = new Size(96, 68);
            button0.TabIndex = 40;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // btnclearbarcode
            // 
            btnclearbarcode.FlatStyle = FlatStyle.Flat;
            btnclearbarcode.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            btnclearbarcode.Location = new Point(855, 719);
            btnclearbarcode.Name = "btnclearbarcode";
            btnclearbarcode.Size = new Size(96, 68);
            btnclearbarcode.TabIndex = 41;
            btnclearbarcode.Text = "CLEAR";
            btnclearbarcode.UseVisualStyleBackColor = true;
            btnclearbarcode.Click += btnclearbarcode_Click;
            // 
            // lblPricePreview
            // 
            lblPricePreview.AutoSize = true;
            lblPricePreview.BackColor = Color.WhiteSmoke;
            lblPricePreview.Font = new Font("Courier New", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPricePreview.Location = new Point(3, 31);
            lblPricePreview.Name = "lblPricePreview";
            lblPricePreview.Size = new Size(51, 53);
            lblPricePreview.TabIndex = 42;
            lblPricePreview.Text = "0";
            // 
            // buttondecimal
            // 
            buttondecimal.BackColor = Color.FromArgb(255, 192, 192);
            buttondecimal.FlatStyle = FlatStyle.Popup;
            buttondecimal.Font = new Font("Courier New", 18F, FontStyle.Bold);
            buttondecimal.Location = new Point(753, 719);
            buttondecimal.Name = "buttondecimal";
            buttondecimal.Size = new Size(96, 68);
            buttondecimal.TabIndex = 43;
            buttondecimal.Text = ".";
            buttondecimal.UseVisualStyleBackColor = false;
            buttondecimal.Click += buttondecimal_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(620, 32);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblAvailableQty);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lblProductName);
            panel3.Controls.Add(lblProductPrice);
            panel3.Controls.Add(lblSubtotal);
            panel3.Controls.Add(lblTax);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lblTotal);
            panel3.Location = new Point(12, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(619, 296);
            panel3.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Red;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(1, 158);
            panel5.Name = "panel5";
            panel5.Size = new Size(619, 32);
            panel5.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(18, 8);
            label9.Name = "label9";
            label9.Size = new Size(89, 17);
            label9.TabIndex = 4;
            label9.Text = "SUBTOTAL:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.WhiteSmoke;
            label10.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(396, 8);
            label10.Name = "label10";
            label10.Size = new Size(44, 17);
            label10.TabIndex = 6;
            label10.Text = "TAX:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 192);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(btnquantityplus);
            panel4.Controls.Add(lblQuantityDisplay);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(0, 91);
            panel4.Name = "panel4";
            panel4.Size = new Size(619, 68);
            panel4.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 24);
            label8.Name = "label8";
            label8.Size = new Size(89, 17);
            label8.TabIndex = 9;
            label8.Text = "QUANTITY:";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.AppWorkspace;
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(12, 438);
            panel6.Name = "panel6";
            panel6.Size = new Size(618, 347);
            panel6.TabIndex = 44;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlLightLight;
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(cmbDiscount);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(lblDiscount);
            panel7.Controls.Add(txtCashGiven);
            panel7.Controls.Add(txtChange);
            panel7.Location = new Point(20, 17);
            panel7.Name = "panel7";
            panel7.Size = new Size(582, 312);
            panel7.TabIndex = 45;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(18, 214);
            label12.Name = "label12";
            label12.Size = new Size(141, 34);
            label12.TabIndex = 28;
            label12.Text = "CHANGE:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(18, 123);
            label11.Name = "label11";
            label11.Size = new Size(213, 34);
            label11.TabIndex = 27;
            label11.Text = "CASH GIVEN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(8, 24);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 7;
            label6.Text = "DISCOUNT:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(744, 45);
            label13.Name = "label13";
            label13.Size = new Size(105, 34);
            label13.TabIndex = 29;
            label13.Text = "CART:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.shopping_cart;
            pictureBox1.Location = new Point(648, 23);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Controls.Add(lblPricePreview);
            panel8.Location = new Point(648, 351);
            panel8.Name = "panel8";
            panel8.Size = new Size(639, 123);
            panel8.TabIndex = 46;
            // 
            // pbProductImage
            // 
            pbProductImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbProductImage.BorderStyle = BorderStyle.Fixed3D;
            pbProductImage.Location = new Point(975, 495);
            pbProductImage.Name = "pbProductImage";
            pbProductImage.Size = new Size(312, 290);
            pbProductImage.TabIndex = 47;
            pbProductImage.TabStop = false;
            // 
            // CashierInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1724, 799);
            Controls.Add(pbProductImage);
            Controls.Add(panel8);
            Controls.Add(pictureBox1);
            Controls.Add(label13);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(buttondecimal);
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
            Controls.Add(btnCalculateChange);
            Controls.Add(searchbtton);
            Controls.Add(dgvCart);
            Controls.Add(btnCheckOut);
            Controls.Add(btnClearCart);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnAddToCart);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "CashierInterface";
            Text = "CashierInterface";
            Load += CashierInterface_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProductImage).EndInit();
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
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label8;
        private Panel panel5;
        private Label label9;
        private Label label10;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
        private Label label12;
        private Label label11;
        private Label label13;
        private PictureBox pictureBox1;
        private Panel panel8;
        private PictureBox pbProductImage;
    }
}