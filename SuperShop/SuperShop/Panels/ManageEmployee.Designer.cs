namespace SuperShop.Panels
{
    partial class ManageEmployee
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
            this.lblMenuName = new System.Windows.Forms.Label();
            this.tabControlManageEmployee = new System.Windows.Forms.TabControl();
            this.tabPageNewEmployee = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.joinDate = new System.Windows.Forms.DateTimePicker();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tabPageExistingEmployee = new System.Windows.Forms.TabPage();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchText = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblSearchBy = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.groupBoxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.lblEmployeeAddress = new MetroFramework.Controls.MetroLabel();
            this.lblEmployeeContactNumber = new MetroFramework.Controls.MetroLabel();
            this.lblEmployeeName = new MetroFramework.Controls.MetroLabel();
            this.lblEmployeeUserName = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tabControlManageEmployee.SuspendLayout();
            this.tabPageNewEmployee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageExistingEmployee.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.groupBoxCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenuName
            // 
            this.lblMenuName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMenuName.Location = new System.Drawing.Point(193, -5);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(339, 37);
            this.lblMenuName.TabIndex = 15;
            this.lblMenuName.Text = "Manage Employees";
            this.lblMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlManageEmployee
            // 
            this.tabControlManageEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlManageEmployee.Controls.Add(this.tabPageNewEmployee);
            this.tabControlManageEmployee.Controls.Add(this.tabPageExistingEmployee);
            this.tabControlManageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlManageEmployee.Location = new System.Drawing.Point(8, 32);
            this.tabControlManageEmployee.Name = "tabControlManageEmployee";
            this.tabControlManageEmployee.SelectedIndex = 0;
            this.tabControlManageEmployee.Size = new System.Drawing.Size(711, 584);
            this.tabControlManageEmployee.TabIndex = 16;
            // 
            // tabPageNewEmployee
            // 
            this.tabPageNewEmployee.Controls.Add(this.groupBox1);
            this.tabPageNewEmployee.Location = new System.Drawing.Point(4, 27);
            this.tabPageNewEmployee.Name = "tabPageNewEmployee";
            this.tabPageNewEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewEmployee.Size = new System.Drawing.Size(703, 553);
            this.tabPageNewEmployee.TabIndex = 0;
            this.tabPageNewEmployee.Text = "New employee";
            this.tabPageNewEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.joinDate);
            this.groupBox1.Controls.Add(this.txtContactNo);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 473);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new employee form";
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroButton1.Location = new System.Drawing.Point(344, 372);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 35);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton1.TabIndex = 25;
            this.metroButton1.Text = "Reset";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Location = new System.Drawing.Point(450, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 35);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Black;
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(106, 327);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(92, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Joining Date";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(106, 285);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Contact No";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(106, 238);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Address";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(106, 194);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Email";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(106, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(106, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "User name";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(106, 108);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Password";
            // 
            // joinDate
            // 
            this.joinDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.joinDate.Location = new System.Drawing.Point(205, 327);
            this.joinDate.Name = "joinDate";
            this.joinDate.Size = new System.Drawing.Size(333, 24);
            this.joinDate.TabIndex = 7;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactNo.Location = new System.Drawing.Point(205, 284);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(333, 24);
            this.txtContactNo.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(205, 239);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(333, 24);
            this.txtAddress.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(205, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(333, 24);
            this.txtEmail.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(205, 148);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(333, 24);
            this.txtName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(205, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(333, 24);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(205, 66);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(333, 24);
            this.txtUsername.TabIndex = 1;
            // 
            // tabPageExistingEmployee
            // 
            this.tabPageExistingEmployee.Controls.Add(this.groupBoxSearch);
            this.tabPageExistingEmployee.Controls.Add(this.btnDelete);
            this.tabPageExistingEmployee.Controls.Add(this.btnRefresh);
            this.tabPageExistingEmployee.Controls.Add(this.dataGridViewEmployees);
            this.tabPageExistingEmployee.Controls.Add(this.groupBoxCustomerInfo);
            this.tabPageExistingEmployee.Controls.Add(this.btnSave);
            this.tabPageExistingEmployee.Location = new System.Drawing.Point(4, 27);
            this.tabPageExistingEmployee.Name = "tabPageExistingEmployee";
            this.tabPageExistingEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExistingEmployee.Size = new System.Drawing.Size(703, 553);
            this.tabPageExistingEmployee.TabIndex = 1;
            this.tabPageExistingEmployee.Text = "Existing employees";
            this.tabPageExistingEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.txtSearchText);
            this.groupBoxSearch.Controls.Add(this.comboBoxSearchBy);
            this.groupBoxSearch.Controls.Add(this.metroLabel8);
            this.groupBoxSearch.Controls.Add(this.lblSearchBy);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(315, 13);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(362, 151);
            this.groupBoxSearch.TabIndex = 17;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search Employee";
            // 
            // txtSearchText
            // 
            this.txtSearchText.BackColor = System.Drawing.Color.Violet;
            this.txtSearchText.Location = new System.Drawing.Point(83, 68);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(175, 28);
            this.txtSearchText.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtSearchText.TabIndex = 12;
            this.txtSearchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchText.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.AllowDrop = true;
            this.comboBoxSearchBy.DisplayMember = "name";
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Username",
            "Name",
            "Contact Number"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(83, 30);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(175, 26);
            this.comboBoxSearchBy.TabIndex = 11;
            this.comboBoxSearchBy.ValueMember = "name";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(2, 72);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(37, 19);
            this.metroLabel8.TabIndex = 1;
            this.metroLabel8.Text = "Text";
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSearchBy.Location = new System.Drawing.Point(2, 33);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(75, 19);
            this.lblSearchBy.TabIndex = 1;
            this.lblSearchBy.Text = "Search by";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Location = new System.Drawing.Point(589, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 35);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Black;
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.Location = new System.Drawing.Point(589, 214);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 35);
            this.btnRefresh.Style = MetroFramework.MetroColorStyle.Black;
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(24, 177);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(560, 356);
            this.dataGridViewEmployees.TabIndex = 19;
            this.dataGridViewEmployees.SelectionChanged += new System.EventHandler(this.dataGridViewEmployees_SelectionChanged);
            // 
            // groupBoxCustomerInfo
            // 
            this.groupBoxCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCustomerInfo.Controls.Add(this.metroLabel9);
            this.groupBoxCustomerInfo.Controls.Add(this.metroLabel10);
            this.groupBoxCustomerInfo.Controls.Add(this.metroLabel11);
            this.groupBoxCustomerInfo.Controls.Add(this.metroLabel12);
            this.groupBoxCustomerInfo.Controls.Add(this.lblEmployeeAddress);
            this.groupBoxCustomerInfo.Controls.Add(this.lblEmployeeContactNumber);
            this.groupBoxCustomerInfo.Controls.Add(this.lblEmployeeName);
            this.groupBoxCustomerInfo.Controls.Add(this.lblEmployeeUserName);
            this.groupBoxCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomerInfo.Location = new System.Drawing.Point(24, 13);
            this.groupBoxCustomerInfo.Name = "groupBoxCustomerInfo";
            this.groupBoxCustomerInfo.Size = new System.Drawing.Size(285, 152);
            this.groupBoxCustomerInfo.TabIndex = 18;
            this.groupBoxCustomerInfo.TabStop = false;
            this.groupBoxCustomerInfo.Text = "Employee Information";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(6, 114);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(85, 25);
            this.metroLabel9.TabIndex = 1;
            this.metroLabel9.Text = "Address:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(6, 87);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(83, 25);
            this.metroLabel10.TabIndex = 1;
            this.metroLabel10.Text = "Contact:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(6, 58);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(67, 25);
            this.metroLabel11.TabIndex = 1;
            this.metroLabel11.Text = "Name:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(6, 30);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(102, 25);
            this.metroLabel12.TabIndex = 1;
            this.metroLabel12.Text = "Username:";
            // 
            // lblEmployeeAddress
            // 
            this.lblEmployeeAddress.AutoSize = true;
            this.lblEmployeeAddress.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmployeeAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEmployeeAddress.Location = new System.Drawing.Point(113, 114);
            this.lblEmployeeAddress.Name = "lblEmployeeAddress";
            this.lblEmployeeAddress.Size = new System.Drawing.Size(120, 25);
            this.lblEmployeeAddress.TabIndex = 1;
            this.lblEmployeeAddress.Text = "Customer List";
            // 
            // lblEmployeeContactNumber
            // 
            this.lblEmployeeContactNumber.AutoSize = true;
            this.lblEmployeeContactNumber.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmployeeContactNumber.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEmployeeContactNumber.Location = new System.Drawing.Point(113, 87);
            this.lblEmployeeContactNumber.Name = "lblEmployeeContactNumber";
            this.lblEmployeeContactNumber.Size = new System.Drawing.Size(120, 25);
            this.lblEmployeeContactNumber.TabIndex = 1;
            this.lblEmployeeContactNumber.Text = "Customer List";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmployeeName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEmployeeName.Location = new System.Drawing.Point(113, 58);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(120, 25);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Customer List";
            // 
            // lblEmployeeUserName
            // 
            this.lblEmployeeUserName.AutoSize = true;
            this.lblEmployeeUserName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmployeeUserName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEmployeeUserName.Location = new System.Drawing.Point(113, 30);
            this.lblEmployeeUserName.Name = "lblEmployeeUserName";
            this.lblEmployeeUserName.Size = new System.Drawing.Size(120, 25);
            this.lblEmployeeUserName.TabIndex = 1;
            this.lblEmployeeUserName.Text = "Customer List";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(589, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 35);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Black;
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlManageEmployee);
            this.Controls.Add(this.lblMenuName);
            this.Name = "ManageEmployee";
            this.Size = new System.Drawing.Size(726, 614);
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            this.tabControlManageEmployee.ResumeLayout(false);
            this.tabPageNewEmployee.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageExistingEmployee.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.groupBoxCustomerInfo.ResumeLayout(false);
            this.groupBoxCustomerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.TabControl tabControlManageEmployee;
        private System.Windows.Forms.TabPage tabPageNewEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker joinDate;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TabPage tabPageExistingEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private MetroFramework.Controls.MetroTextBox txtSearchText;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblSearchBy;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.GroupBox groupBoxCustomerInfo;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel lblEmployeeAddress;
        private MetroFramework.Controls.MetroLabel lblEmployeeContactNumber;
        private MetroFramework.Controls.MetroLabel lblEmployeeName;
        private MetroFramework.Controls.MetroLabel lblEmployeeUserName;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}
