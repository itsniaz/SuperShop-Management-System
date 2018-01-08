namespace SuperShop.Panels
{
    partial class SellProducts
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
            this.lblMenuName = new System.Windows.Forms.Label();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.comboBoxCustomerList = new System.Windows.Forms.ComboBox();
            this.customerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataSet = new SuperShop.CustomerDataSet();
            this.btnRefreshCustomerList = new MetroFramework.Controls.MetroButton();
            this.lblCustomerList = new MetroFramework.Controls.MetroLabel();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxAddCustomer = new System.Windows.Forms.GroupBox();
            this.btnResetCustomerForm = new MetroFramework.Controls.MetroButton();
            this.txtCustomerContact = new MetroFramework.Controls.MetroTextBox();
            this.btnAddCustomer = new MetroFramework.Controls.MetroButton();
            this.txtCustomerAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.lblCustomerContact = new MetroFramework.Controls.MetroLabel();
            this.lblCustomerName = new MetroFramework.Controls.MetroLabel();
            this.lblCustomerAddress = new MetroFramework.Controls.MetroLabel();
            this.groupBoxAddProduct = new System.Windows.Forms.GroupBox();
            this.comboBoxProductList = new System.Windows.Forms.ComboBox();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet = new SuperShop.ProductDataSet();
            this.btnRemoveItem = new MetroFramework.Controls.MetroButton();
            this.btnAddItem = new MetroFramework.Controls.MetroButton();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.lblQuantity = new MetroFramework.Controls.MetroLabel();
            this.btnRefreshProductList = new MetroFramework.Controls.MetroButton();
            this.lblProductName = new MetroFramework.Controls.MetroLabel();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewReceipt = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxGrandTotal = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblGrandTotal = new MetroFramework.Controls.MetroLabel();
            this.btnPrintAndSave = new MetroFramework.Controls.MetroButton();
            this.productsTableAdapter = new SuperShop.ProductDataSetTableAdapters.ProductsTableAdapter();
            this.customerTableAdapter = new SuperShop.CustomerDataSetTableAdapters.CustomerTableAdapter();
            this.lblChangedAmount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtCashReceived = new MetroFramework.Controls.MetroTextBox();
            this.groupBoxCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.groupBoxAddCustomer.SuspendLayout();
            this.groupBoxAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).BeginInit();
            this.groupBoxGrandTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenuName
            // 
            this.lblMenuName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMenuName.Location = new System.Drawing.Point(253, 0);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(214, 37);
            this.lblMenuName.TabIndex = 11;
            this.lblMenuName.Text = "Sell Products";
            this.lblMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCustomer.Controls.Add(this.comboBoxCustomerList);
            this.groupBoxCustomer.Controls.Add(this.btnRefreshCustomerList);
            this.groupBoxCustomer.Controls.Add(this.lblCustomerList);
            this.groupBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomer.Location = new System.Drawing.Point(11, 40);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(280, 120);
            this.groupBoxCustomer.TabIndex = 12;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer";
            // 
            // comboBoxCustomerList
            // 
            this.comboBoxCustomerList.AllowDrop = true;
            this.comboBoxCustomerList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCustomerList.DataSource = this.customerBindingSource3;
            this.comboBoxCustomerList.DisplayMember = "name";
            this.comboBoxCustomerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomerList.FormattingEnabled = true;
            this.comboBoxCustomerList.Location = new System.Drawing.Point(125, 30);
            this.comboBoxCustomerList.Name = "comboBoxCustomerList";
            this.comboBoxCustomerList.Size = new System.Drawing.Size(140, 26);
            this.comboBoxCustomerList.TabIndex = 11;
            this.comboBoxCustomerList.ValueMember = "name";
            // 
            // customerBindingSource3
            // 
            this.customerBindingSource3.DataMember = "Customer";
            this.customerBindingSource3.DataSource = this.customerDataSet;
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "CustomerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefreshCustomerList
            // 
            this.btnRefreshCustomerList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefreshCustomerList.Location = new System.Drawing.Point(177, 62);
            this.btnRefreshCustomerList.Name = "btnRefreshCustomerList";
            this.btnRefreshCustomerList.Size = new System.Drawing.Size(88, 35);
            this.btnRefreshCustomerList.Style = MetroFramework.MetroColorStyle.Black;
            this.btnRefreshCustomerList.TabIndex = 10;
            this.btnRefreshCustomerList.Text = "Refresh";
            this.btnRefreshCustomerList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRefreshCustomerList.Click += new System.EventHandler(this.btnRefreshCustomerList_Click);
            // 
            // lblCustomerList
            // 
            this.lblCustomerList.AutoSize = true;
            this.lblCustomerList.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCustomerList.Location = new System.Drawing.Point(6, 32);
            this.lblCustomerList.Name = "lblCustomerList";
            this.lblCustomerList.Size = new System.Drawing.Size(99, 19);
            this.lblCustomerList.TabIndex = 1;
            this.lblCustomerList.Text = "Customer List";
            // 
            // groupBoxAddCustomer
            // 
            this.groupBoxAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddCustomer.Controls.Add(this.btnResetCustomerForm);
            this.groupBoxAddCustomer.Controls.Add(this.txtCustomerContact);
            this.groupBoxAddCustomer.Controls.Add(this.btnAddCustomer);
            this.groupBoxAddCustomer.Controls.Add(this.txtCustomerAddress);
            this.groupBoxAddCustomer.Controls.Add(this.txtCustomerName);
            this.groupBoxAddCustomer.Controls.Add(this.lblCustomerContact);
            this.groupBoxAddCustomer.Controls.Add(this.lblCustomerName);
            this.groupBoxAddCustomer.Controls.Add(this.lblCustomerAddress);
            this.groupBoxAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddCustomer.Location = new System.Drawing.Point(297, 40);
            this.groupBoxAddCustomer.Name = "groupBoxAddCustomer";
            this.groupBoxAddCustomer.Size = new System.Drawing.Size(418, 120);
            this.groupBoxAddCustomer.TabIndex = 13;
            this.groupBoxAddCustomer.TabStop = false;
            this.groupBoxAddCustomer.Text = "Add new customer";
            // 
            // btnResetCustomerForm
            // 
            this.btnResetCustomerForm.Location = new System.Drawing.Point(316, 71);
            this.btnResetCustomerForm.Name = "btnResetCustomerForm";
            this.btnResetCustomerForm.Size = new System.Drawing.Size(88, 35);
            this.btnResetCustomerForm.Style = MetroFramework.MetroColorStyle.Black;
            this.btnResetCustomerForm.TabIndex = 10;
            this.btnResetCustomerForm.Text = "Reset";
            this.btnResetCustomerForm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnResetCustomerForm.Click += new System.EventHandler(this.btnResetCustomerForm_Click);
            // 
            // txtCustomerContact
            // 
            this.txtCustomerContact.Location = new System.Drawing.Point(105, 87);
            this.txtCustomerContact.Name = "txtCustomerContact";
            this.txtCustomerContact.Size = new System.Drawing.Size(204, 28);
            this.txtCustomerContact.TabIndex = 7;
            this.txtCustomerContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(316, 30);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(88, 35);
            this.btnAddCustomer.Style = MetroFramework.MetroColorStyle.Black;
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            this.btnAddCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAddCustomer_KeyPress);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(105, 55);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(204, 28);
            this.txtCustomerAddress.TabIndex = 6;
            this.txtCustomerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.Violet;
            this.txtCustomerName.Location = new System.Drawing.Point(105, 21);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(204, 28);
            this.txtCustomerName.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtCustomerName.TabIndex = 5;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerName.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblCustomerContact
            // 
            this.lblCustomerContact.AutoSize = true;
            this.lblCustomerContact.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCustomerContact.Location = new System.Drawing.Point(20, 88);
            this.lblCustomerContact.Name = "lblCustomerContact";
            this.lblCustomerContact.Size = new System.Drawing.Size(60, 19);
            this.lblCustomerContact.TabIndex = 3;
            this.lblCustomerContact.Text = "Contact";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCustomerName.Location = new System.Drawing.Point(20, 27);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(49, 19);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Name";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCustomerAddress.Location = new System.Drawing.Point(20, 58);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(63, 19);
            this.lblCustomerAddress.TabIndex = 0;
            this.lblCustomerAddress.Text = "Address";
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddProduct.Controls.Add(this.comboBoxProductList);
            this.groupBoxAddProduct.Controls.Add(this.btnRemoveItem);
            this.groupBoxAddProduct.Controls.Add(this.btnAddItem);
            this.groupBoxAddProduct.Controls.Add(this.txtQuantity);
            this.groupBoxAddProduct.Controls.Add(this.lblQuantity);
            this.groupBoxAddProduct.Controls.Add(this.btnRefreshProductList);
            this.groupBoxAddProduct.Controls.Add(this.lblProductName);
            this.groupBoxAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddProduct.Location = new System.Drawing.Point(11, 159);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Size = new System.Drawing.Size(704, 106);
            this.groupBoxAddProduct.TabIndex = 12;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "Add Products";
            // 
            // comboBoxProductList
            // 
            this.comboBoxProductList.AllowDrop = true;
            this.comboBoxProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProductList.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxProductList.DataSource = this.productsBindingSource1;
            this.comboBoxProductList.DisplayMember = "name";
            this.comboBoxProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductList.FormattingEnabled = true;
            this.comboBoxProductList.Location = new System.Drawing.Point(125, 22);
            this.comboBoxProductList.Name = "comboBoxProductList";
            this.comboBoxProductList.Size = new System.Drawing.Size(140, 26);
            this.comboBoxProductList.TabIndex = 14;
            this.comboBoxProductList.ValueMember = "name";
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.productDataSet;
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "ProductDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemoveItem.Location = new System.Drawing.Point(602, 60);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(88, 35);
            this.btnRemoveItem.Style = MetroFramework.MetroColorStyle.Black;
            this.btnRemoveItem.TabIndex = 13;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddItem.Location = new System.Drawing.Point(602, 19);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(88, 35);
            this.btnAddItem.Style = MetroFramework.MetroColorStyle.Black;
            this.btnAddItem.TabIndex = 13;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtQuantity.BackColor = System.Drawing.Color.Violet;
            this.txtQuantity.Location = new System.Drawing.Point(391, 19);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(204, 28);
            this.txtQuantity.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblQuantity.Location = new System.Drawing.Point(306, 22);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(66, 19);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnRefreshProductList
            // 
            this.btnRefreshProductList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefreshProductList.Location = new System.Drawing.Point(177, 60);
            this.btnRefreshProductList.Name = "btnRefreshProductList";
            this.btnRefreshProductList.Size = new System.Drawing.Size(88, 35);
            this.btnRefreshProductList.Style = MetroFramework.MetroColorStyle.Black;
            this.btnRefreshProductList.TabIndex = 10;
            this.btnRefreshProductList.Text = "Refresh";
            this.btnRefreshProductList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRefreshProductList.Click += new System.EventHandler(this.btnRefreshProductList_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblProductName.Location = new System.Drawing.Point(13, 28);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(88, 19);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product List";
            // 
            // dataGridViewReceipt
            // 
            this.dataGridViewReceipt.AllowUserToAddRows = false;
            this.dataGridViewReceipt.AllowUserToDeleteRows = false;
            this.dataGridViewReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceipt.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.quantity,
            this.perUnitPrice,
            this.totalPrice});
            this.dataGridViewReceipt.Location = new System.Drawing.Point(11, 273);
            this.dataGridViewReceipt.Name = "dataGridViewReceipt";
            this.dataGridViewReceipt.Size = new System.Drawing.Size(513, 329);
            this.dataGridViewReceipt.TabIndex = 14;
            this.dataGridViewReceipt.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReceipt_CellEndEdit);
            // 
            // productName
            // 
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // perUnitPrice
            // 
            this.perUnitPrice.HeaderText = "Per Unit Price";
            this.perUnitPrice.Name = "perUnitPrice";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.Name = "totalPrice";
            // 
            // groupBoxGrandTotal
            // 
            this.groupBoxGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGrandTotal.Controls.Add(this.lblChangedAmount);
            this.groupBoxGrandTotal.Controls.Add(this.metroLabel2);
            this.groupBoxGrandTotal.Controls.Add(this.txtCashReceived);
            this.groupBoxGrandTotal.Controls.Add(this.metroLabel4);
            this.groupBoxGrandTotal.Controls.Add(this.metroLabel3);
            this.groupBoxGrandTotal.Controls.Add(this.lblGrandTotal);
            this.groupBoxGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGrandTotal.Location = new System.Drawing.Point(530, 273);
            this.groupBoxGrandTotal.Name = "groupBoxGrandTotal";
            this.groupBoxGrandTotal.Size = new System.Drawing.Size(185, 273);
            this.groupBoxGrandTotal.TabIndex = 15;
            this.groupBoxGrandTotal.TabStop = false;
            this.groupBoxGrandTotal.Text = "Bill Information";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(51, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Grand Total";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(35, 201);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Changed Amount";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblGrandTotal.Location = new System.Drawing.Point(84, 77);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(17, 19);
            this.lblGrandTotal.TabIndex = 1;
            this.lblGrandTotal.Text = "0";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrintAndSave
            // 
            this.btnPrintAndSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintAndSave.Location = new System.Drawing.Point(530, 552);
            this.btnPrintAndSave.Name = "btnPrintAndSave";
            this.btnPrintAndSave.Size = new System.Drawing.Size(185, 50);
            this.btnPrintAndSave.Style = MetroFramework.MetroColorStyle.Black;
            this.btnPrintAndSave.TabIndex = 10;
            this.btnPrintAndSave.Text = "Save and Print";
            this.btnPrintAndSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPrintAndSave.Click += new System.EventHandler(this.btnPrintAndSave_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // lblChangedAmount
            // 
            this.lblChangedAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChangedAmount.AutoSize = true;
            this.lblChangedAmount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblChangedAmount.Location = new System.Drawing.Point(85, 227);
            this.lblChangedAmount.Name = "lblChangedAmount";
            this.lblChangedAmount.Size = new System.Drawing.Size(17, 19);
            this.lblChangedAmount.TabIndex = 1;
            this.lblChangedAmount.Text = "0";
            this.lblChangedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(42, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(105, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Cash Received";
            // 
            // txtCashReceived
            // 
            this.txtCashReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCashReceived.BackColor = System.Drawing.Color.Violet;
            this.txtCashReceived.Location = new System.Drawing.Point(31, 146);
            this.txtCashReceived.Name = "txtCashReceived";
            this.txtCashReceived.Size = new System.Drawing.Size(133, 28);
            this.txtCashReceived.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtCashReceived.TabIndex = 13;
            this.txtCashReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCashReceived.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCashReceived.TextChanged += new System.EventHandler(this.txtCashReceived_TextChanged);
            this.txtCashReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashReceived_KeyPress);
            // 
            // SellProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxGrandTotal);
            this.Controls.Add(this.dataGridViewReceipt);
            this.Controls.Add(this.btnPrintAndSave);
            this.Controls.Add(this.groupBoxAddCustomer);
            this.Controls.Add(this.groupBoxAddProduct);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.lblMenuName);
            this.Name = "SellProducts";
            this.Size = new System.Drawing.Size(726, 614);
            this.Load += new System.EventHandler(this.SellProducts_Load);
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.groupBoxAddCustomer.ResumeLayout(false);
            this.groupBoxAddCustomer.PerformLayout();
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
            this.groupBoxGrandTotal.ResumeLayout(false);
            this.groupBoxGrandTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private MetroFramework.Controls.MetroButton btnRefreshCustomerList;
        private MetroFramework.Controls.MetroLabel lblCustomerList;
        private System.Windows.Forms.GroupBox groupBoxAddCustomer;
        private MetroFramework.Controls.MetroButton btnResetCustomerForm;
        private MetroFramework.Controls.MetroTextBox txtCustomerContact;
        private MetroFramework.Controls.MetroButton btnAddCustomer;
        private MetroFramework.Controls.MetroTextBox txtCustomerAddress;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroLabel lblCustomerContact;
        private MetroFramework.Controls.MetroLabel lblCustomerName;
        private MetroFramework.Controls.MetroLabel lblCustomerAddress;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private MetroFramework.Controls.MetroButton btnRemoveItem;
        private MetroFramework.Controls.MetroButton btnAddItem;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel lblQuantity;
        private MetroFramework.Controls.MetroButton btnRefreshProductList;
        private MetroFramework.Controls.MetroLabel lblProductName;
        private System.Windows.Forms.ComboBox comboBoxCustomerList;
        private System.Windows.Forms.ComboBox comboBoxProductList;
        private System.Windows.Forms.DataGridView dataGridViewReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn perUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.GroupBox groupBoxGrandTotal;
        private MetroFramework.Controls.MetroLabel lblGrandTotal;
        private MetroFramework.Controls.MetroButton btnPrintAndSave;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private ProductDataSet productDataSet;
        private ProductDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource3;
        private CustomerDataSet customerDataSet;
        private CustomerDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblChangedAmount;
        private MetroFramework.Controls.MetroTextBox txtCashReceived;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        
    }
}
