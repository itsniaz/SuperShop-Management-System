namespace SuperShop.Panels
{
    partial class ManageCustomer
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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchText = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblSearchBy = new MetroFramework.Controls.MetroLabel();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.groupBoxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblCustomerAddress = new MetroFramework.Controls.MetroLabel();
            this.lblCustomerContact = new MetroFramework.Controls.MetroLabel();
            this.lblCustomerName = new MetroFramework.Controls.MetroLabel();
            this.lblCustomerId = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.customerDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDatasetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.txtSearchText);
            this.groupBoxSearch.Controls.Add(this.comboBoxSearchBy);
            this.groupBoxSearch.Controls.Add(this.metroLabel2);
            this.groupBoxSearch.Controls.Add(this.lblSearchBy);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(322, 59);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(376, 151);
            this.groupBoxSearch.TabIndex = 13;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search Customer";
            // 
            // txtSearchText
            // 
            this.txtSearchText.BackColor = System.Drawing.Color.Violet;
            this.txtSearchText.Location = new System.Drawing.Point(83, 68);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(244, 28);
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
            "ID",
            "Name",
            "Contact Number"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(83, 30);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(244, 26);
            this.comboBoxSearchBy.TabIndex = 11;
            this.comboBoxSearchBy.ValueMember = "name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(2, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Text";
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
            // lblMenuName
            // 
            this.lblMenuName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMenuName.Location = new System.Drawing.Point(196, 0);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(339, 37);
            this.lblMenuName.TabIndex = 14;
            this.lblMenuName.Text = "Manage Customers";
            this.lblMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxCustomerInfo
            // 
            this.groupBoxCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCustomerInfo.Controls.Add(this.metroLabel5);
            this.groupBoxCustomerInfo.Controls.Add(this.metroLabel4);
            this.groupBoxCustomerInfo.Controls.Add(this.metroLabel3);
            this.groupBoxCustomerInfo.Controls.Add(this.metroLabel6);
            this.groupBoxCustomerInfo.Controls.Add(this.lblCustomerAddress);
            this.groupBoxCustomerInfo.Controls.Add(this.lblCustomerContact);
            this.groupBoxCustomerInfo.Controls.Add(this.lblCustomerName);
            this.groupBoxCustomerInfo.Controls.Add(this.lblCustomerId);
            this.groupBoxCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomerInfo.Location = new System.Drawing.Point(27, 58);
            this.groupBoxCustomerInfo.Name = "groupBoxCustomerInfo";
            this.groupBoxCustomerInfo.Size = new System.Drawing.Size(272, 152);
            this.groupBoxCustomerInfo.TabIndex = 13;
            this.groupBoxCustomerInfo.TabStop = false;
            this.groupBoxCustomerInfo.Text = "Customer Information";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(6, 114);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 25);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Address:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(6, 87);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 25);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Contact:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(6, 58);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 25);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Name:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(6, 30);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 25);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "ID:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCustomerAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCustomerAddress.Location = new System.Drawing.Point(91, 118);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(120, 25);
            this.lblCustomerAddress.TabIndex = 1;
            this.lblCustomerAddress.Text = "Customer List";
            // 
            // lblCustomerContact
            // 
            this.lblCustomerContact.AutoSize = true;
            this.lblCustomerContact.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCustomerContact.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCustomerContact.Location = new System.Drawing.Point(91, 91);
            this.lblCustomerContact.Name = "lblCustomerContact";
            this.lblCustomerContact.Size = new System.Drawing.Size(120, 25);
            this.lblCustomerContact.TabIndex = 1;
            this.lblCustomerContact.Text = "Customer List";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCustomerName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCustomerName.Location = new System.Drawing.Point(91, 62);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(120, 25);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer List";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCustomerId.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCustomerId.Location = new System.Drawing.Point(91, 34);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(120, 25);
            this.lblCustomerId.TabIndex = 1;
            this.lblCustomerId.Text = "Customer List";
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(27, 235);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(577, 350);
            this.dataGridViewCustomers.TabIndex = 15;
            this.dataGridViewCustomers.SelectionChanged += new System.EventHandler(this.dataGridViewCustomers_SelectionChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(610, 266);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 35);
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Black;
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(610, 307);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 35);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Black;
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(610, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 35);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Black;
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.lblMenuName);
            this.Controls.Add(this.groupBoxCustomerInfo);
            this.Controls.Add(this.groupBoxSearch);
            this.Name = "ManageCustomer";
            this.Size = new System.Drawing.Size(726, 614);
            this.Load += new System.EventHandler(this.ManageCustomer_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxCustomerInfo.ResumeLayout(false);
            this.groupBoxCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDatasetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private MetroFramework.Controls.MetroLabel lblSearchBy;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.GroupBox groupBoxCustomerInfo;
        private MetroFramework.Controls.MetroLabel lblCustomerId;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtSearchText;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblCustomerAddress;
        private MetroFramework.Controls.MetroLabel lblCustomerContact;
        private MetroFramework.Controls.MetroLabel lblCustomerName;
        private System.Windows.Forms.BindingSource customerDatasetBindingSource;
    }
}
