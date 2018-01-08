namespace SuperShop.Panels
{
    partial class SalesReport
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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchText = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblSearchBy = new MetroFramework.Controls.MetroLabel();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.dataGridViewSalesReport = new System.Windows.Forms.DataGridView();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.txtSearchText);
            this.groupBoxSearch.Controls.Add(this.comboBoxSearchBy);
            this.groupBoxSearch.Controls.Add(this.metroLabel2);
            this.groupBoxSearch.Controls.Add(this.lblSearchBy);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(24, 73);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(679, 151);
            this.groupBoxSearch.TabIndex = 19;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search report";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchText.BackColor = System.Drawing.Color.Violet;
            this.txtSearchText.Location = new System.Drawing.Point(192, 78);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(363, 28);
            this.txtSearchText.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtSearchText.TabIndex = 12;
            this.txtSearchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchText.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.AllowDrop = true;
            this.comboBoxSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchBy.DisplayMember = "name";
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Invoice Number",
            "Customer Name",
            "Employee Name",
            "Product Name"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(192, 40);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(363, 26);
            this.comboBoxSearchBy.TabIndex = 11;
            this.comboBoxSearchBy.ValueMember = "name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(111, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Text";
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSearchBy.Location = new System.Drawing.Point(111, 43);
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
            this.lblMenuName.Location = new System.Drawing.Point(179, 10);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(339, 37);
            this.lblMenuName.TabIndex = 20;
            this.lblMenuName.Text = "Sales Report";
            this.lblMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewSalesReport
            // 
            this.dataGridViewSalesReport.AllowUserToAddRows = false;
            this.dataGridViewSalesReport.AllowUserToDeleteRows = false;
            this.dataGridViewSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSalesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalesReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesReport.Location = new System.Drawing.Point(24, 234);
            this.dataGridViewSalesReport.Name = "dataGridViewSalesReport";
            this.dataGridViewSalesReport.ReadOnly = true;
            this.dataGridViewSalesReport.Size = new System.Drawing.Size(577, 356);
            this.dataGridViewSalesReport.TabIndex = 21;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(615, 268);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 35);
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Black;
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(615, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 35);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Black;
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridViewSalesReport);
            this.Controls.Add(this.lblMenuName);
            this.Controls.Add(this.groupBoxSearch);
            this.Name = "SalesReport";
            this.Size = new System.Drawing.Size(726, 614);
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private MetroFramework.Controls.MetroTextBox txtSearchText;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblSearchBy;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.DataGridView dataGridViewSalesReport;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroButton btnDelete;
    }
}
