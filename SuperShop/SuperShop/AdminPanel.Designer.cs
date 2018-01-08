namespace SuperShop
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnSellProduct = new MetroFramework.Controls.MetroButton();
            this.btnManageCustomer = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.tempPanel = new System.Windows.Forms.Panel();
            this.lblSystemTime = new MetroFramework.Controls.MetroLabel();
            this.lblSystemDate = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnDatabaseBackup = new MetroFramework.Controls.MetroButton();
            this.btnInventory = new MetroFramework.Controls.MetroButton();
            this.btnManageEmployee = new MetroFramework.Controls.MetroButton();
            this.btnCompanyInfo = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdminName = new MetroFramework.Controls.MetroLabel();
            this.lblJoinDate = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblContact = new MetroFramework.Controls.MetroLabel();
            this.btnSalesReport = new MetroFramework.Controls.MetroButton();
            this.btnAbout = new MetroFramework.Controls.MetroButton();
            this.timerSystemTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tempPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton1.Location = new System.Drawing.Point(15, 130);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(240, 50);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Add Products";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnSellProduct
            // 
            this.btnSellProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSellProduct.Location = new System.Drawing.Point(15, 242);
            this.btnSellProduct.Name = "btnSellProduct";
            this.btnSellProduct.Size = new System.Drawing.Size(240, 50);
            this.btnSellProduct.Style = MetroFramework.MetroColorStyle.Black;
            this.btnSellProduct.TabIndex = 2;
            this.btnSellProduct.Text = "Sell Product";
            this.btnSellProduct.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSellProduct.Click += new System.EventHandler(this.btnSellProduct_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnManageCustomer.Location = new System.Drawing.Point(15, 297);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(240, 50);
            this.btnManageCustomer.Style = MetroFramework.MetroColorStyle.Black;
            this.btnManageCustomer.TabIndex = 4;
            this.btnManageCustomer.Text = "Manage Customer";
            this.btnManageCustomer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton4.Location = new System.Drawing.Point(15, 186);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(240, 50);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton4.TabIndex = 5;
            this.metroButton4.Text = "Manage Product";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton5.Location = new System.Drawing.Point(15, 628);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 50);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton5.TabIndex = 6;
            this.metroButton5.Text = "Profile";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // tempPanel
            // 
            this.tempPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tempPanel.BackColor = System.Drawing.Color.White;
            this.tempPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tempPanel.BackgroundImage")));
            this.tempPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tempPanel.Controls.Add(this.panel1);
            this.tempPanel.Location = new System.Drawing.Point(273, 44);
            this.tempPanel.Name = "tempPanel";
            this.tempPanel.Size = new System.Drawing.Size(695, 646);
            this.tempPanel.TabIndex = 7;
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSystemTime.BackColor = System.Drawing.Color.Gray;
            this.lblSystemTime.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblSystemTime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSystemTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSystemTime.Location = new System.Drawing.Point(273, 9);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(106, 32);
            this.lblSystemTime.TabIndex = 4;
            this.lblSystemTime.Text = "00.00.00";
            this.lblSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystemDate
            // 
            this.lblSystemDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSystemDate.BackColor = System.Drawing.Color.Gray;
            this.lblSystemDate.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblSystemDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSystemDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSystemDate.Location = new System.Drawing.Point(385, 9);
            this.lblSystemDate.Name = "lblSystemDate";
            this.lblSystemDate.Size = new System.Drawing.Size(117, 32);
            this.lblSystemDate.TabIndex = 4;
            this.lblSystemDate.Text = "01 JUL 2017";
            this.lblSystemDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Location = new System.Drawing.Point(180, 627);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 50);
            this.btnLogout.Style = MetroFramework.MetroColorStyle.Black;
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDatabaseBackup
            // 
            this.btnDatabaseBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDatabaseBackup.Location = new System.Drawing.Point(15, 516);
            this.btnDatabaseBackup.Name = "btnDatabaseBackup";
            this.btnDatabaseBackup.Size = new System.Drawing.Size(240, 50);
            this.btnDatabaseBackup.Style = MetroFramework.MetroColorStyle.Black;
            this.btnDatabaseBackup.TabIndex = 4;
            this.btnDatabaseBackup.Text = "Database BackUp";
            this.btnDatabaseBackup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDatabaseBackup.Click += new System.EventHandler(this.btnDatabaseBackup_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInventory.Location = new System.Drawing.Point(15, 406);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(240, 50);
            this.btnInventory.Style = MetroFramework.MetroColorStyle.Black;
            this.btnInventory.TabIndex = 4;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnManageEmployee.Location = new System.Drawing.Point(15, 352);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(240, 50);
            this.btnManageEmployee.Style = MetroFramework.MetroColorStyle.Black;
            this.btnManageEmployee.TabIndex = 4;
            this.btnManageEmployee.Text = "Manage Employee";
            this.btnManageEmployee.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // btnCompanyInfo
            // 
            this.btnCompanyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompanyInfo.Location = new System.Drawing.Point(15, 572);
            this.btnCompanyInfo.Name = "btnCompanyInfo";
            this.btnCompanyInfo.Size = new System.Drawing.Size(240, 50);
            this.btnCompanyInfo.Style = MetroFramework.MetroColorStyle.Black;
            this.btnCompanyInfo.TabIndex = 4;
            this.btnCompanyInfo.Text = "Company Information";
            this.btnCompanyInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCompanyInfo.Click += new System.EventHandler(this.btnCompanyInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblAdminName);
            this.groupBox1.Controls.Add(this.lblJoinDate);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblContact);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 115);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information";
            // 
            // lblAdminName
            // 
            this.lblAdminName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminName.BackColor = System.Drawing.Color.Gray;
            this.lblAdminName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAdminName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAdminName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdminName.Location = new System.Drawing.Point(0, 22);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(229, 27);
            this.lblAdminName.TabIndex = 3;
            this.lblAdminName.Text = "Admin Name";
            this.lblAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJoinDate.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblJoinDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblJoinDate.Location = new System.Drawing.Point(0, 88);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(232, 24);
            this.lblJoinDate.TabIndex = 3;
            this.lblJoinDate.Text = "  Joined on:";
            this.lblJoinDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.BackColor = System.Drawing.Color.Gray;
            this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(-3, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(232, 24);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContact
            // 
            this.lblContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContact.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblContact.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblContact.Location = new System.Drawing.Point(-3, 67);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(232, 24);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact:";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalesReport.Location = new System.Drawing.Point(15, 461);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(240, 50);
            this.btnSalesReport.Style = MetroFramework.MetroColorStyle.Black;
            this.btnSalesReport.TabIndex = 4;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.Location = new System.Drawing.Point(97, 628);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 50);
            this.btnAbout.Style = MetroFramework.MetroColorStyle.Black;
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // timerSystemTime
            // 
            this.timerSystemTime.Enabled = true;
            this.timerSystemTime.Interval = 1000;
            this.timerSystemTime.Tick += new System.EventHandler(this.timerSystemTime_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(112, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 93);
            this.panel1.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 695);
            this.Controls.Add(this.lblSystemDate);
            this.Controls.Add(this.lblSystemTime);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDatabaseBackup);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tempPanel);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnCompanyInfo);
            this.Controls.Add(this.btnManageEmployee);
            this.Controls.Add(this.btnManageCustomer);
            this.Controls.Add(this.btnSellProduct);
            this.Controls.Add(this.metroButton1);
            this.MinimumSize = new System.Drawing.Size(980, 695);
            this.Name = "AdminPanel";
            this.tempPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnSellProduct;
        private MetroFramework.Controls.MetroButton btnManageCustomer;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.Panel tempPanel;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnDatabaseBackup;
        private MetroFramework.Controls.MetroButton btnInventory;
        private MetroFramework.Controls.MetroButton btnManageEmployee;
        private MetroFramework.Controls.MetroButton btnCompanyInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lblAdminName;
        private MetroFramework.Controls.MetroLabel lblJoinDate;
        private MetroFramework.Controls.MetroLabel lblContact;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroButton btnSalesReport;
        private MetroFramework.Controls.MetroButton btnAbout;
        private MetroFramework.Controls.MetroLabel lblSystemTime;
        private MetroFramework.Controls.MetroLabel lblSystemDate;
        private System.Windows.Forms.Timer timerSystemTime;
        private System.Windows.Forms.Panel panel1;

    }
}