namespace SuperShop
{
    partial class EmployeePanel
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
            this.lblJoinDate = new MetroFramework.Controls.MetroLabel();
            this.lblContact = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblAdminName = new MetroFramework.Controls.MetroLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbout = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.tempPanel = new System.Windows.Forms.Panel();
            this.btnSalesReport = new MetroFramework.Controls.MetroButton();
            this.btnInventory = new MetroFramework.Controls.MetroButton();
            this.btnManageCustomer = new MetroFramework.Controls.MetroButton();
            this.btnSellProduct = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJoinDate.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblJoinDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblJoinDate.Location = new System.Drawing.Point(3, 84);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(232, 24);
            this.lblJoinDate.TabIndex = 3;
            this.lblJoinDate.Text = "Joined on:";
            this.lblJoinDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContact
            // 
            this.lblContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContact.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblContact.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblContact.Location = new System.Drawing.Point(3, 64);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(232, 24);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact:";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.BackColor = System.Drawing.Color.Gray;
            this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(3, 45);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(232, 24);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdminName
            // 
            this.lblAdminName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminName.BackColor = System.Drawing.Color.Gray;
            this.lblAdminName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAdminName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAdminName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdminName.Location = new System.Drawing.Point(6, 22);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(229, 27);
            this.lblAdminName.TabIndex = 3;
            this.lblAdminName.Text = "Employee Name";
            this.lblAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButton5
            // 
            this.metroButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton5.Location = new System.Drawing.Point(15, 632);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 50);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton5.TabIndex = 19;
            this.metroButton5.Text = "Profile";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblJoinDate);
            this.groupBox1.Controls.Add(this.lblContact);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblAdminName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 115);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information";
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.Location = new System.Drawing.Point(97, 632);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 50);
            this.btnAbout.Style = MetroFramework.MetroColorStyle.Black;
            this.btnAbout.TabIndex = 21;
            this.btnAbout.Text = "About";
            this.btnAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Location = new System.Drawing.Point(180, 631);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 50);
            this.btnLogout.Style = MetroFramework.MetroColorStyle.Black;
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tempPanel
            // 
            this.tempPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tempPanel.BackColor = System.Drawing.Color.White;
            this.tempPanel.Location = new System.Drawing.Point(270, 35);
            this.tempPanel.Name = "tempPanel";
            this.tempPanel.Size = new System.Drawing.Size(695, 646);
            this.tempPanel.TabIndex = 20;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalesReport.Location = new System.Drawing.Point(15, 425);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(240, 50);
            this.btnSalesReport.Style = MetroFramework.MetroColorStyle.Black;
            this.btnSalesReport.TabIndex = 13;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInventory.Location = new System.Drawing.Point(15, 370);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(240, 50);
            this.btnInventory.Style = MetroFramework.MetroColorStyle.Black;
            this.btnInventory.TabIndex = 14;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnManageCustomer.Location = new System.Drawing.Point(15, 315);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(240, 50);
            this.btnManageCustomer.Style = MetroFramework.MetroColorStyle.Black;
            this.btnManageCustomer.TabIndex = 17;
            this.btnManageCustomer.Text = "Manage Customer";
            this.btnManageCustomer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // btnSellProduct
            // 
            this.btnSellProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSellProduct.Location = new System.Drawing.Point(15, 260);
            this.btnSellProduct.Name = "btnSellProduct";
            this.btnSellProduct.Size = new System.Drawing.Size(240, 50);
            this.btnSellProduct.Style = MetroFramework.MetroColorStyle.Black;
            this.btnSellProduct.TabIndex = 11;
            this.btnSellProduct.Text = "Sell Product";
            this.btnSellProduct.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSellProduct.Click += new System.EventHandler(this.btnSellProduct_Click);
            // 
            // EmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 695);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tempPanel);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnManageCustomer);
            this.Controls.Add(this.btnSellProduct);
            this.MinimumSize = new System.Drawing.Size(980, 695);
            this.Name = "EmployeePanel";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblJoinDate;
        private MetroFramework.Controls.MetroLabel lblContact;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblAdminName;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnAbout;
        private MetroFramework.Controls.MetroButton btnLogout;
        private System.Windows.Forms.Panel tempPanel;
        private MetroFramework.Controls.MetroButton btnSalesReport;
        private MetroFramework.Controls.MetroButton btnInventory;
        private MetroFramework.Controls.MetroButton btnManageCustomer;
        private MetroFramework.Controls.MetroButton btnSellProduct;
    }
}