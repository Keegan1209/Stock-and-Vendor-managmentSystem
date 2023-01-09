
namespace PROG_POE_FARM_CENTRAL
{
    partial class FarmerMyProd
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
            this.EmployeeDashlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PR_IMAGE});
            this.dataGridView1.Location = new System.Drawing.Point(19, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 140;
            this.dataGridView1.Size = new System.Drawing.Size(738, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // PR_IMAGE
            // 
            this.PR_IMAGE.DataPropertyName = "PR_IMAGE";
            this.PR_IMAGE.HeaderText = "IMAGE";
            this.PR_IMAGE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.PR_IMAGE.Name = "PR_IMAGE";
            // 
            // EmployeeDashlbl
            // 
            this.EmployeeDashlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeDashlbl.AutoSize = true;
            this.EmployeeDashlbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDashlbl.Location = new System.Drawing.Point(28, 40);
            this.EmployeeDashlbl.Name = "EmployeeDashlbl";
            this.EmployeeDashlbl.Size = new System.Drawing.Size(273, 23);
            this.EmployeeDashlbl.TabIndex = 5;
            this.EmployeeDashlbl.Text = "FARM CENTRAL PRODUCTS";
            this.EmployeeDashlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FarmerMyProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.EmployeeDashlbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FarmerMyProd";
            this.Size = new System.Drawing.Size(777, 513);
            this.Load += new System.EventHandler(this.FarmerMyProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn PR_IMAGE;
        private System.Windows.Forms.Label EmployeeDashlbl;
    }
}
