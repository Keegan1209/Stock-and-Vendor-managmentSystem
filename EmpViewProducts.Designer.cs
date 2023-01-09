
namespace PROG_POE_FARM_CENTRAL
{
    partial class EmpViewProducts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PR_IMAGE = new System.Windows.Forms.DataGridViewImageColumn();
            this.DateTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterDateBTN = new System.Windows.Forms.Button();
            this.EmployeeDashlbl = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FarmerFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FarmerTXT = new System.Windows.Forms.TextBox();
            this.productFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProdTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PR_IMAGE});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 140;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(809, 461);
            this.dataGridView1.TabIndex = 0;
            // 
            // PR_IMAGE
            // 
            this.PR_IMAGE.DataPropertyName = "PR_IMAGE";
            this.PR_IMAGE.HeaderText = "IMAGE";
            this.PR_IMAGE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.PR_IMAGE.Name = "PR_IMAGE";
            // 
            // DateTXT
            // 
            this.DateTXT.Location = new System.Drawing.Point(136, 94);
            this.DateTXT.Name = "DateTXT";
            this.DateTXT.Size = new System.Drawing.Size(100, 20);
            this.DateTXT.TabIndex = 1;
            this.DateTXT.Text = "DD/MM/YYYY";
            this.DateTXT.Click += new System.EventHandler(this.DateTXT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter by Date";
            // 
            // FilterDateBTN
            // 
            this.FilterDateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.FilterDateBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FilterDateBTN.Location = new System.Drawing.Point(136, 120);
            this.FilterDateBTN.Name = "FilterDateBTN";
            this.FilterDateBTN.Size = new System.Drawing.Size(75, 23);
            this.FilterDateBTN.TabIndex = 3;
            this.FilterDateBTN.Text = "Search";
            this.FilterDateBTN.UseVisualStyleBackColor = false;
            this.FilterDateBTN.Click += new System.EventHandler(this.FilterDateBTN_Click);
            // 
            // EmployeeDashlbl
            // 
            this.EmployeeDashlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeDashlbl.AutoSize = true;
            this.EmployeeDashlbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDashlbl.Location = new System.Drawing.Point(51, 34);
            this.EmployeeDashlbl.Name = "EmployeeDashlbl";
            this.EmployeeDashlbl.Size = new System.Drawing.Size(273, 23);
            this.EmployeeDashlbl.TabIndex = 4;
            this.EmployeeDashlbl.Text = "FARM CENTRAL PRODUCTS";
            this.EmployeeDashlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Yellow;
            this.Reset.Location = new System.Drawing.Point(724, 34);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reload";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reload Records";
            // 
            // FarmerFilter
            // 
            this.FarmerFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.FarmerFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FarmerFilter.Location = new System.Drawing.Point(353, 121);
            this.FarmerFilter.Name = "FarmerFilter";
            this.FarmerFilter.Size = new System.Drawing.Size(75, 23);
            this.FarmerFilter.TabIndex = 9;
            this.FarmerFilter.Text = "Search";
            this.FarmerFilter.UseVisualStyleBackColor = false;
            this.FarmerFilter.Click += new System.EventHandler(this.FarmerFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filter by Farmer";
            // 
            // FarmerTXT
            // 
            this.FarmerTXT.Location = new System.Drawing.Point(353, 95);
            this.FarmerTXT.Name = "FarmerTXT";
            this.FarmerTXT.Size = new System.Drawing.Size(100, 20);
            this.FarmerTXT.TabIndex = 7;
            this.FarmerTXT.Text = "ID";
            this.FarmerTXT.Click += new System.EventHandler(this.FarmerTXT_Click);
            // 
            // productFilter
            // 
            this.productFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.productFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productFilter.Location = new System.Drawing.Point(566, 121);
            this.productFilter.Name = "productFilter";
            this.productFilter.Size = new System.Drawing.Size(75, 23);
            this.productFilter.TabIndex = 12;
            this.productFilter.Text = "Search";
            this.productFilter.UseVisualStyleBackColor = false;
            this.productFilter.Click += new System.EventHandler(this.productFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filter by Product";
            // 
            // ProdTXT
            // 
            this.ProdTXT.Location = new System.Drawing.Point(566, 95);
            this.ProdTXT.Name = "ProdTXT";
            this.ProdTXT.Size = new System.Drawing.Size(100, 20);
            this.ProdTXT.TabIndex = 10;
            this.ProdTXT.Text = "ID/NAME";
            this.ProdTXT.Click += new System.EventHandler(this.ProdTXT_Click);
            // 
            // EmpViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.productFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProdTXT);
            this.Controls.Add(this.FarmerFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FarmerTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.EmployeeDashlbl);
            this.Controls.Add(this.FilterDateBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTXT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmpViewProducts";
            this.Size = new System.Drawing.Size(819, 732);
            this.Load += new System.EventHandler(this.EmpViewProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn PR_IMAGE;
        private System.Windows.Forms.TextBox DateTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FilterDateBTN;
        private System.Windows.Forms.Label EmployeeDashlbl;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FarmerFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FarmerTXT;
        private System.Windows.Forms.Button productFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProdTXT;
    }
}
