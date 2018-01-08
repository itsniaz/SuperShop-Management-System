namespace SuperShop.Panels
{
    partial class Inventory
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
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchText = new MetroFramework.Controls.MetroTextBox();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblSearchBy = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(611, 279);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 35);
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Black;
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(28, 244);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.Size = new System.Drawing.Size(577, 356);
            this.dataGridViewProducts.TabIndex = 20;
            // 
            // lblMenuName
            // 
            this.lblMenuName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMenuName.Location = new System.Drawing.Point(197, 15);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(339, 37);
            this.lblMenuName.TabIndex = 19;
            this.lblMenuName.Text = "Inventory";
            this.lblMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.txtSearchText);
            this.groupBoxSearch.Controls.Add(this.comboBoxSearchBy);
            this.groupBoxSearch.Controls.Add(this.metroLabel2);
            this.groupBoxSearch.Controls.Add(this.lblSearchBy);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(54, 73);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(373, 151);
            this.groupBoxSearch.TabIndex = 18;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search product";
            // 
            // txtSearchText
            // 
            this.txtSearchText.BackColor = System.Drawing.Color.Violet;
            this.txtSearchText.Location = new System.Drawing.Point(83, 68);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(258, 28);
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
            "Name"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(83, 30);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(258, 26);
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
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.lblMenuName);
            this.Controls.Add(this.groupBoxSearch);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(726, 614);
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLoad;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private MetroFramework.Controls.MetroTextBox txtSearchText;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblSearchBy;

    }
}
