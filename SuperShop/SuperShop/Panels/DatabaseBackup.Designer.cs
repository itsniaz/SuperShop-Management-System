namespace SuperShop.Panels
{
    partial class DatabaseBackup
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
            this.groupBoxBackup = new System.Windows.Forms.GroupBox();
            this.btnBackup = new MetroFramework.Controls.MetroButton();
            this.btnBrowseBackup = new MetroFramework.Controls.MetroButton();
            this.txtLocationBackup = new MetroFramework.Controls.MetroTextBox();
            this.lblLocation = new MetroFramework.Controls.MetroLabel();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.groupBoxRestore = new System.Windows.Forms.GroupBox();
            this.btnRestore = new MetroFramework.Controls.MetroButton();
            this.btnBrowseRestore = new MetroFramework.Controls.MetroButton();
            this.txtLocationRestore = new MetroFramework.Controls.MetroTextBox();
            this.lblLocationRestore = new MetroFramework.Controls.MetroLabel();
            this.groupBoxBackup.SuspendLayout();
            this.groupBoxRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBackup
            // 
            this.groupBoxBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBackup.Controls.Add(this.btnBackup);
            this.groupBoxBackup.Controls.Add(this.btnBrowseBackup);
            this.groupBoxBackup.Controls.Add(this.txtLocationBackup);
            this.groupBoxBackup.Controls.Add(this.lblLocation);
            this.groupBoxBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBackup.Location = new System.Drawing.Point(24, 80);
            this.groupBoxBackup.Name = "groupBoxBackup";
            this.groupBoxBackup.Size = new System.Drawing.Size(678, 164);
            this.groupBoxBackup.TabIndex = 14;
            this.groupBoxBackup.TabStop = false;
            this.groupBoxBackup.Text = "Back Up";
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBackup.Location = new System.Drawing.Point(570, 72);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(88, 35);
            this.btnBackup.Style = MetroFramework.MetroColorStyle.Black;
            this.btnBackup.TabIndex = 10;
            this.btnBackup.Text = "Back Up";
            this.btnBackup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBrowseBackup.Location = new System.Drawing.Point(570, 27);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.Size = new System.Drawing.Size(88, 35);
            this.btnBrowseBackup.Style = MetroFramework.MetroColorStyle.Black;
            this.btnBrowseBackup.TabIndex = 8;
            this.btnBrowseBackup.Text = "Browse";
            this.btnBrowseBackup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrowseBackup.Click += new System.EventHandler(this.btnBrowseBackup_Click);
            // 
            // txtLocationBackup
            // 
            this.txtLocationBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocationBackup.BackColor = System.Drawing.Color.Violet;
            this.txtLocationBackup.Location = new System.Drawing.Point(96, 52);
            this.txtLocationBackup.Name = "txtLocationBackup";
            this.txtLocationBackup.Size = new System.Drawing.Size(452, 28);
            this.txtLocationBackup.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtLocationBackup.TabIndex = 5;
            this.txtLocationBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLocationBackup.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLocation.AutoSize = true;
            this.lblLocation.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLocation.Location = new System.Drawing.Point(24, 56);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 19);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // lblMenuName
            // 
            this.lblMenuName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMenuName.Location = new System.Drawing.Point(220, 2);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(285, 37);
            this.lblMenuName.TabIndex = 15;
            this.lblMenuName.Text = "Database Backup";
            this.lblMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxRestore
            // 
            this.groupBoxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRestore.Controls.Add(this.btnRestore);
            this.groupBoxRestore.Controls.Add(this.btnBrowseRestore);
            this.groupBoxRestore.Controls.Add(this.txtLocationRestore);
            this.groupBoxRestore.Controls.Add(this.lblLocationRestore);
            this.groupBoxRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRestore.Location = new System.Drawing.Point(24, 269);
            this.groupBoxRestore.Name = "groupBoxRestore";
            this.groupBoxRestore.Size = new System.Drawing.Size(678, 159);
            this.groupBoxRestore.TabIndex = 14;
            this.groupBoxRestore.TabStop = false;
            this.groupBoxRestore.Text = "Restore Back Up";
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRestore.Location = new System.Drawing.Point(570, 72);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(88, 35);
            this.btnRestore.Style = MetroFramework.MetroColorStyle.Black;
            this.btnRestore.TabIndex = 10;
            this.btnRestore.Text = "Restore";
            this.btnRestore.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowseRestore
            // 
            this.btnBrowseRestore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBrowseRestore.Location = new System.Drawing.Point(570, 27);
            this.btnBrowseRestore.Name = "btnBrowseRestore";
            this.btnBrowseRestore.Size = new System.Drawing.Size(88, 35);
            this.btnBrowseRestore.Style = MetroFramework.MetroColorStyle.Black;
            this.btnBrowseRestore.TabIndex = 8;
            this.btnBrowseRestore.Text = "Browse";
            this.btnBrowseRestore.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrowseRestore.Click += new System.EventHandler(this.btnBrowseRestore_Click);
            // 
            // txtLocationRestore
            // 
            this.txtLocationRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocationRestore.BackColor = System.Drawing.Color.Violet;
            this.txtLocationRestore.Location = new System.Drawing.Point(96, 47);
            this.txtLocationRestore.Name = "txtLocationRestore";
            this.txtLocationRestore.Size = new System.Drawing.Size(452, 28);
            this.txtLocationRestore.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtLocationRestore.TabIndex = 5;
            this.txtLocationRestore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLocationRestore.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblLocationRestore
            // 
            this.lblLocationRestore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLocationRestore.AutoSize = true;
            this.lblLocationRestore.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLocationRestore.Location = new System.Drawing.Point(24, 56);
            this.lblLocationRestore.Name = "lblLocationRestore";
            this.lblLocationRestore.Size = new System.Drawing.Size(66, 19);
            this.lblLocationRestore.TabIndex = 1;
            this.lblLocationRestore.Text = "Location";
            // 
            // DatabaseBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblMenuName);
            this.Controls.Add(this.groupBoxRestore);
            this.Controls.Add(this.groupBoxBackup);
            this.Name = "DatabaseBackup";
            this.Size = new System.Drawing.Size(726, 614);
            this.groupBoxBackup.ResumeLayout(false);
            this.groupBoxBackup.PerformLayout();
            this.groupBoxRestore.ResumeLayout(false);
            this.groupBoxRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBackup;
        private MetroFramework.Controls.MetroButton btnBackup;
        private MetroFramework.Controls.MetroButton btnBrowseBackup;
        private MetroFramework.Controls.MetroTextBox txtLocationBackup;
        private MetroFramework.Controls.MetroLabel lblLocation;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.GroupBox groupBoxRestore;
        private MetroFramework.Controls.MetroButton btnRestore;
        private MetroFramework.Controls.MetroButton btnBrowseRestore;
        private MetroFramework.Controls.MetroTextBox txtLocationRestore;
        private MetroFramework.Controls.MetroLabel lblLocationRestore;
    }
}
