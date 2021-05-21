namespace RBSv2.User_Controls
{
    partial class PlaceOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ItemInfoPanel = new System.Windows.Forms.Panel();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxPlaceOrderCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddToCartPanel = new System.Windows.Forms.Panel();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.QuantityUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomerPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCGST = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSGST = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PrintBillPanel = new System.Windows.Forms.Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnReload = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveFromCart = new Guna.UI2.WinForms.Guna2Button();
            this.CartGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PlaceOrderElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ItemInfoPanel.SuspendLayout();
            this.AddToCartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).BeginInit();
            this.CustomerPanel.SuspendLayout();
            this.PrintBillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemInfoPanel
            // 
            this.ItemInfoPanel.BackColor = System.Drawing.Color.White;
            this.ItemInfoPanel.Controls.Add(this.itemsListBox);
            this.ItemInfoPanel.Controls.Add(this.txtSearch);
            this.ItemInfoPanel.Controls.Add(this.ComboBoxPlaceOrderCategory);
            this.ItemInfoPanel.Controls.Add(this.label2);
            this.ItemInfoPanel.Controls.Add(this.label1);
            this.ItemInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.ItemInfoPanel.Name = "ItemInfoPanel";
            this.ItemInfoPanel.Size = new System.Drawing.Size(237, 530);
            this.ItemInfoPanel.TabIndex = 0;
            // 
            // itemsListBox
            // 
            this.itemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 18;
            this.itemsListBox.Location = new System.Drawing.Point(21, 176);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(186, 346);
            this.itemsListBox.TabIndex = 17;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(22, 132);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(186, 36);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ComboBoxPlaceOrderCategory
            // 
            this.ComboBoxPlaceOrderCategory.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxPlaceOrderCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxPlaceOrderCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPlaceOrderCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxPlaceOrderCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxPlaceOrderCategory.FocusedState.Parent = this.ComboBoxPlaceOrderCategory;
            this.ComboBoxPlaceOrderCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBoxPlaceOrderCategory.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxPlaceOrderCategory.HoverState.Parent = this.ComboBoxPlaceOrderCategory;
            this.ComboBoxPlaceOrderCategory.ItemHeight = 30;
            this.ComboBoxPlaceOrderCategory.Items.AddRange(new object[] {
            "Chinese",
            "South Indian",
            "Thali",
            "Hot Drinks",
            "Cold Drinks",
            "Biryani",
            "Snacks",
            "Punjabi",
            "Starters",
            "Juice"});
            this.ComboBoxPlaceOrderCategory.ItemsAppearance.Parent = this.ComboBoxPlaceOrderCategory;
            this.ComboBoxPlaceOrderCategory.Location = new System.Drawing.Point(22, 84);
            this.ComboBoxPlaceOrderCategory.Name = "ComboBoxPlaceOrderCategory";
            this.ComboBoxPlaceOrderCategory.ShadowDecoration.Parent = this.ComboBoxPlaceOrderCategory;
            this.ComboBoxPlaceOrderCategory.Size = new System.Drawing.Size(186, 36);
            this.ComboBoxPlaceOrderCategory.TabIndex = 15;
            this.ComboBoxPlaceOrderCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ComboBoxPlaceOrderCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPlaceOrderCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(56, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(38, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Place Order";
            // 
            // AddToCartPanel
            // 
            this.AddToCartPanel.BackColor = System.Drawing.Color.White;
            this.AddToCartPanel.Controls.Add(this.btnAddToCart);
            this.AddToCartPanel.Controls.Add(this.QuantityUpDown);
            this.AddToCartPanel.Controls.Add(this.txtTotal);
            this.AddToCartPanel.Controls.Add(this.txtItemName);
            this.AddToCartPanel.Controls.Add(this.txtPrice);
            this.AddToCartPanel.Controls.Add(this.label6);
            this.AddToCartPanel.Controls.Add(this.label5);
            this.AddToCartPanel.Controls.Add(this.label4);
            this.AddToCartPanel.Controls.Add(this.label3);
            this.AddToCartPanel.Location = new System.Drawing.Point(243, 3);
            this.AddToCartPanel.Name = "AddToCartPanel";
            this.AddToCartPanel.Size = new System.Drawing.Size(328, 304);
            this.AddToCartPanel.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BorderRadius = 15;
            this.btnAddToCart.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddToCart.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddToCart.CheckedState.Parent = this.btnAddToCart;
            this.btnAddToCart.CustomImages.Parent = this.btnAddToCart;
            this.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddToCart.HoverState.Parent = this.btnAddToCart;
            this.btnAddToCart.Location = new System.Drawing.Point(80, 237);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.ShadowDecoration.Parent = this.btnAddToCart;
            this.btnAddToCart.Size = new System.Drawing.Size(148, 36);
            this.btnAddToCart.TabIndex = 28;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // QuantityUpDown
            // 
            this.QuantityUpDown.BackColor = System.Drawing.Color.Transparent;
            this.QuantityUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityUpDown.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityUpDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityUpDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityUpDown.DisabledState.Parent = this.QuantityUpDown;
            this.QuantityUpDown.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.QuantityUpDown.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.QuantityUpDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityUpDown.FocusedState.Parent = this.QuantityUpDown;
            this.QuantityUpDown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityUpDown.ForeColor = System.Drawing.Color.Black;
            this.QuantityUpDown.Location = new System.Drawing.Point(143, 72);
            this.QuantityUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuantityUpDown.Name = "QuantityUpDown";
            this.QuantityUpDown.ShadowDecoration.Parent = this.QuantityUpDown;
            this.QuantityUpDown.Size = new System.Drawing.Size(182, 24);
            this.QuantityUpDown.TabIndex = 27;
            this.QuantityUpDown.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.QuantityUpDown.ValueChanged += new System.EventHandler(this.QuantityUpDown_ValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(143, 174);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.SelectedText = "";
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(182, 24);
            this.txtTotal.TabIndex = 26;
            // 
            // txtItemName
            // 
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.DefaultText = "";
            this.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.DisabledState.Parent = this.txtItemName;
            this.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemName.FocusedState.Parent = this.txtItemName;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.Color.Black;
            this.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemName.HoverState.Parent = this.txtItemName;
            this.txtItemName.Location = new System.Drawing.Point(143, 25);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.PlaceholderText = "";
            this.txtItemName.SelectedText = "";
            this.txtItemName.ShadowDecoration.Parent = this.txtItemName;
            this.txtItemName.Size = new System.Drawing.Size(182, 24);
            this.txtItemName.TabIndex = 25;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(143, 124);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(182, 24);
            this.txtPrice.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(18, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(23, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Item Name";
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 15;
            this.btnClear.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnClear.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.White;
            this.btnClear.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(569, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CustomerPanel
            // 
            this.CustomerPanel.BackColor = System.Drawing.Color.White;
            this.CustomerPanel.Controls.Add(this.label15);
            this.CustomerPanel.Controls.Add(this.label14);
            this.CustomerPanel.Controls.Add(this.label13);
            this.CustomerPanel.Controls.Add(this.txtCustomerAddress);
            this.CustomerPanel.Controls.Add(this.txtCustomerPhoneNumber);
            this.CustomerPanel.Controls.Add(this.txtCGST);
            this.CustomerPanel.Controls.Add(this.label11);
            this.CustomerPanel.Controls.Add(this.txtSGST);
            this.CustomerPanel.Controls.Add(this.label10);
            this.CustomerPanel.Controls.Add(this.txtDiscount);
            this.CustomerPanel.Controls.Add(this.label9);
            this.CustomerPanel.Controls.Add(this.txtCustomerName);
            this.CustomerPanel.Controls.Add(this.label8);
            this.CustomerPanel.Location = new System.Drawing.Point(572, 3);
            this.CustomerPanel.Name = "CustomerPanel";
            this.CustomerPanel.Size = new System.Drawing.Size(334, 304);
            this.CustomerPanel.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(239, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 25);
            this.label15.TabIndex = 44;
            this.label15.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(239, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 25);
            this.label14.TabIndex = 43;
            this.label14.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(239, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 25);
            this.label13.TabIndex = 42;
            this.label13.Text = "%";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerAddress.DefaultText = "";
            this.txtCustomerAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerAddress.DisabledState.Parent = this.txtCustomerAddress;
            this.txtCustomerAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerAddress.FocusedState.Parent = this.txtCustomerAddress;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCustomerAddress.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerAddress.HoverState.Parent = this.txtCustomerAddress;
            this.txtCustomerAddress.Location = new System.Drawing.Point(6, 84);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.PasswordChar = '\0';
            this.txtCustomerAddress.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCustomerAddress.PlaceholderText = "   Customer Address";
            this.txtCustomerAddress.SelectedText = "";
            this.txtCustomerAddress.ShadowDecoration.Parent = this.txtCustomerAddress;
            this.txtCustomerAddress.Size = new System.Drawing.Size(324, 36);
            this.txtCustomerAddress.TabIndex = 41;
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerPhoneNumber.DefaultText = "";
            this.txtCustomerPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerPhoneNumber.DisabledState.Parent = this.txtCustomerPhoneNumber;
            this.txtCustomerPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerPhoneNumber.FocusedState.Parent = this.txtCustomerPhoneNumber;
            this.txtCustomerPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCustomerPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerPhoneNumber.HoverState.Parent = this.txtCustomerPhoneNumber;
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(173, 47);
            this.txtCustomerPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.PasswordChar = '\0';
            this.txtCustomerPhoneNumber.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCustomerPhoneNumber.PlaceholderText = "Phone Number";
            this.txtCustomerPhoneNumber.SelectedText = "";
            this.txtCustomerPhoneNumber.ShadowDecoration.Parent = this.txtCustomerPhoneNumber;
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(157, 24);
            this.txtCustomerPhoneNumber.TabIndex = 40;
            // 
            // txtCGST
            // 
            this.txtCGST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCGST.DefaultText = "2.5";
            this.txtCGST.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCGST.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCGST.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCGST.DisabledState.Parent = this.txtCGST;
            this.txtCGST.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCGST.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCGST.FocusedState.Parent = this.txtCGST;
            this.txtCGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCGST.ForeColor = System.Drawing.Color.Black;
            this.txtCGST.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCGST.HoverState.Parent = this.txtCGST;
            this.txtCGST.Location = new System.Drawing.Point(141, 251);
            this.txtCGST.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.PasswordChar = '\0';
            this.txtCGST.PlaceholderText = "";
            this.txtCGST.SelectedText = "";
            this.txtCGST.SelectionStart = 3;
            this.txtCGST.ShadowDecoration.Parent = this.txtCGST;
            this.txtCGST.Size = new System.Drawing.Size(91, 24);
            this.txtCGST.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(21, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 28);
            this.label11.TabIndex = 38;
            this.label11.Text = "CGST";
            // 
            // txtSGST
            // 
            this.txtSGST.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSGST.DefaultText = "2.5";
            this.txtSGST.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSGST.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSGST.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSGST.DisabledState.Parent = this.txtSGST;
            this.txtSGST.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSGST.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSGST.FocusedState.Parent = this.txtSGST;
            this.txtSGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtSGST.ForeColor = System.Drawing.Color.Black;
            this.txtSGST.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSGST.HoverState.Parent = this.txtSGST;
            this.txtSGST.Location = new System.Drawing.Point(141, 204);
            this.txtSGST.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.PasswordChar = '\0';
            this.txtSGST.PlaceholderText = "";
            this.txtSGST.SelectedText = "";
            this.txtSGST.SelectionStart = 3;
            this.txtSGST.ShadowDecoration.Parent = this.txtSGST;
            this.txtSGST.Size = new System.Drawing.Size(91, 24);
            this.txtSGST.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(21, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 28);
            this.label10.TabIndex = 36;
            this.label10.Text = "SGST";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "0.0";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.Parent = this.txtDiscount;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.FocusedState.Parent = this.txtDiscount;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.HoverState.Parent = this.txtDiscount;
            this.txtDiscount.Location = new System.Drawing.Point(141, 154);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionStart = 3;
            this.txtDiscount.ShadowDecoration.Parent = this.txtDiscount;
            this.txtDiscount.Size = new System.Drawing.Size(91, 24);
            this.txtDiscount.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(21, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 34;
            this.label9.Text = "Discount";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.DefaultText = "";
            this.txtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.DisabledState.Parent = this.txtCustomerName;
            this.txtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.FocusedState.Parent = this.txtCustomerName;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.HoverState.Parent = this.txtCustomerName;
            this.txtCustomerName.Location = new System.Drawing.Point(4, 47);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.PlaceholderText = "Customer Name";
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.ShadowDecoration.Parent = this.txtCustomerName;
            this.txtCustomerName.Size = new System.Drawing.Size(157, 24);
            this.txtCustomerName.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(74, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "Customer Details";
            // 
            // PrintBillPanel
            // 
            this.PrintBillPanel.BackColor = System.Drawing.Color.White;
            this.PrintBillPanel.Controls.Add(this.btnSave);
            this.PrintBillPanel.Controls.Add(this.btnReload);
            this.PrintBillPanel.Controls.Add(this.btnClear);
            this.PrintBillPanel.Controls.Add(this.btnPrint);
            this.PrintBillPanel.Controls.Add(this.btnRemoveFromCart);
            this.PrintBillPanel.Controls.Add(this.CartGridView);
            this.PrintBillPanel.Controls.Add(this.labelGrandTotal);
            this.PrintBillPanel.Controls.Add(this.label7);
            this.PrintBillPanel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBillPanel.Location = new System.Drawing.Point(243, 310);
            this.PrintBillPanel.Name = "PrintBillPanel";
            this.PrintBillPanel.Size = new System.Drawing.Size(663, 223);
            this.PrintBillPanel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 15;
            this.btnSave.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSave.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(569, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.CheckedState.Parent = this.btnReload;
            this.btnReload.CustomImages.Parent = this.btnReload;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.HoverState.Parent = this.btnReload;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageSize = new System.Drawing.Size(50, 39);
            this.btnReload.Location = new System.Drawing.Point(335, 185);
            this.btnReload.Name = "btnReload";
            this.btnReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReload.ShadowDecoration.Parent = this.btnReload;
            this.btnReload.Size = new System.Drawing.Size(42, 30);
            this.btnReload.TabIndex = 33;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 15;
            this.btnPrint.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPrint.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrint.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(435, 185);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(90, 30);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BorderRadius = 15;
            this.btnRemoveFromCart.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRemoveFromCart.CheckedState.Parent = this.btnRemoveFromCart;
            this.btnRemoveFromCart.CustomImages.Parent = this.btnRemoveFromCart;
            this.btnRemoveFromCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCart.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveFromCart.HoverState.Parent = this.btnRemoveFromCart;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(569, 71);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.ShadowDecoration.Parent = this.btnRemoveFromCart;
            this.btnRemoveFromCart.Size = new System.Drawing.Size(90, 30);
            this.btnRemoveFromCart.TabIndex = 30;
            this.btnRemoveFromCart.Text = "Remove";
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // CartGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CartGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartGridView.BackgroundColor = System.Drawing.Color.White;
            this.CartGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CartGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CartGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CartGridView.ColumnHeadersHeight = 21;
            this.CartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CartGridView.EnableHeadersVisualStyles = false;
            this.CartGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CartGridView.Location = new System.Drawing.Point(22, 18);
            this.CartGridView.Name = "CartGridView";
            this.CartGridView.RowHeadersVisible = false;
            this.CartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartGridView.Size = new System.Drawing.Size(539, 150);
            this.CartGridView.TabIndex = 19;
            this.CartGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CartGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CartGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CartGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CartGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CartGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CartGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CartGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CartGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CartGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CartGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CartGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CartGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.CartGridView.ThemeStyle.ReadOnly = false;
            this.CartGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CartGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CartGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CartGridView.ThemeStyle.RowsStyle.Height = 22;
            this.CartGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CartGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CartGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelGrandTotal.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.ForeColor = System.Drawing.Color.White;
            this.labelGrandTotal.Location = new System.Drawing.Point(137, 185);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(188, 30);
            this.labelGrandTotal.TabIndex = 23;
            this.labelGrandTotal.Text = "RS. 00";
            this.labelGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(3, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "Grand Total";
            // 
            // PlaceOrderElipse
            // 
            this.PlaceOrderElipse.TargetControl = this;
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.PrintBillPanel);
            this.Controls.Add(this.CustomerPanel);
            this.Controls.Add(this.AddToCartPanel);
            this.Controls.Add(this.ItemInfoPanel);
            this.Name = "PlaceOrder";
            this.Size = new System.Drawing.Size(909, 536);
            this.ItemInfoPanel.ResumeLayout(false);
            this.ItemInfoPanel.PerformLayout();
            this.AddToCartPanel.ResumeLayout(false);
            this.AddToCartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUpDown)).EndInit();
            this.CustomerPanel.ResumeLayout(false);
            this.CustomerPanel.PerformLayout();
            this.PrintBillPanel.ResumeLayout(false);
            this.PrintBillPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ItemInfoPanel;
        private System.Windows.Forms.Panel AddToCartPanel;
        private System.Windows.Forms.Panel CustomerPanel;
        private System.Windows.Forms.Panel PrintBillPanel;
        private Guna.UI2.WinForms.Guna2Elipse PlaceOrderElipse;
        private System.Windows.Forms.ListBox itemsListBox;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxPlaceOrderCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private Guna.UI2.WinForms.Guna2NumericUpDown QuantityUpDown;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtCGST;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtSGST;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerName;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerAddress;
        private Guna.UI2.WinForms.Guna2DataGridView CartGridView;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnRemoveFromCart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2CircleButton btnReload;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
