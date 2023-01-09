
namespace PROG_POE_FARM_CENTRAL
{
    partial class AddNewFarmerUC
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
            this.panel21 = new System.Windows.Forms.Panel();
            this.pnlSurname = new System.Windows.Forms.Panel();
            this.Rlblsurname = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.SurnameTXT = new System.Windows.Forms.TextBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.pnlName = new System.Windows.Forms.Panel();
            this.RlblName = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.RlblPassword = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.RegPasswordTXT = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.RlblUsername = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.RegUsernameTXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel21.SuspendLayout();
            this.pnlSurname.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel25.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel13.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel17.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.pnlSurname);
            this.panel21.Controls.Add(this.panel23);
            this.panel21.Location = new System.Drawing.Point(152, 138);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(282, 68);
            this.panel21.TabIndex = 33;
            // 
            // pnlSurname
            // 
            this.pnlSurname.Controls.Add(this.Rlblsurname);
            this.pnlSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSurname.Location = new System.Drawing.Point(0, 37);
            this.pnlSurname.Name = "pnlSurname";
            this.pnlSurname.Size = new System.Drawing.Size(282, 27);
            this.pnlSurname.TabIndex = 5;
            this.pnlSurname.Visible = false;
            // 
            // Rlblsurname
            // 
            this.Rlblsurname.AutoSize = true;
            this.Rlblsurname.Dock = System.Windows.Forms.DockStyle.Left;
            this.Rlblsurname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rlblsurname.ForeColor = System.Drawing.Color.Red;
            this.Rlblsurname.Location = new System.Drawing.Point(0, 0);
            this.Rlblsurname.Name = "Rlblsurname";
            this.Rlblsurname.Size = new System.Drawing.Size(65, 13);
            this.Rlblsurname.TabIndex = 3;
            this.Rlblsurname.Text = "*REQUIRED";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Controls.Add(this.SurnameTXT);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(282, 37);
            this.panel23.TabIndex = 4;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel24.Location = new System.Drawing.Point(3, 28);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(270, 1);
            this.panel24.TabIndex = 5;
            // 
            // SurnameTXT
            // 
            this.SurnameTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.SurnameTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SurnameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameTXT.ForeColor = System.Drawing.SystemColors.Info;
            this.SurnameTXT.Location = new System.Drawing.Point(3, 3);
            this.SurnameTXT.Name = "SurnameTXT";
            this.SurnameTXT.Size = new System.Drawing.Size(270, 17);
            this.SurnameTXT.TabIndex = 3;
            this.SurnameTXT.Text = "Enter Surname";
            this.SurnameTXT.Click += new System.EventHandler(this.SurnameTXT_Click);
            this.SurnameTXT.TextChanged += new System.EventHandler(this.SurnameTXT_TextChanged);
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.pnlName);
            this.panel25.Controls.Add(this.panel27);
            this.panel25.Location = new System.Drawing.Point(152, 63);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(282, 68);
            this.panel25.TabIndex = 31;
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.RlblName);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlName.Location = new System.Drawing.Point(0, 37);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(282, 27);
            this.pnlName.TabIndex = 5;
            this.pnlName.Visible = false;
            // 
            // RlblName
            // 
            this.RlblName.AutoSize = true;
            this.RlblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.RlblName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RlblName.ForeColor = System.Drawing.Color.Red;
            this.RlblName.Location = new System.Drawing.Point(0, 0);
            this.RlblName.Name = "RlblName";
            this.RlblName.Size = new System.Drawing.Size(65, 13);
            this.RlblName.TabIndex = 3;
            this.RlblName.Text = "*REQUIRED";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.panel28);
            this.panel27.Controls.Add(this.nameTXT);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel27.Location = new System.Drawing.Point(0, 0);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(282, 37);
            this.panel27.TabIndex = 4;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel28.Location = new System.Drawing.Point(3, 30);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(270, 1);
            this.panel28.TabIndex = 5;
            // 
            // nameTXT
            // 
            this.nameTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.nameTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTXT.ForeColor = System.Drawing.SystemColors.Info;
            this.nameTXT.Location = new System.Drawing.Point(3, 5);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(270, 17);
            this.nameTXT.TabIndex = 3;
            this.nameTXT.Text = "Enter Name";
            this.nameTXT.Click += new System.EventHandler(this.nameTXT_Click);
            this.nameTXT.TextChanged += new System.EventHandler(this.nameTXT_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(82, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "SURNAME";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(82, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "FIRST NAME";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(198, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "ADD NEW FARMER";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(188)))), ((int)(((byte)(96)))));
            this.RegisterBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.RegisterBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RegisterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBTN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBTN.Location = new System.Drawing.Point(232, 367);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(140, 44);
            this.RegisterBTN.TabIndex = 28;
            this.RegisterBTN.Text = "ADD NEW";
            this.RegisterBTN.UseVisualStyleBackColor = false;
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.pnlPassword);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Location = new System.Drawing.Point(152, 293);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(282, 68);
            this.panel13.TabIndex = 27;
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.RlblPassword);
            this.pnlPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPassword.Location = new System.Drawing.Point(0, 37);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(282, 27);
            this.pnlPassword.TabIndex = 5;
            this.pnlPassword.Visible = false;
            // 
            // RlblPassword
            // 
            this.RlblPassword.AutoSize = true;
            this.RlblPassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.RlblPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RlblPassword.ForeColor = System.Drawing.Color.Red;
            this.RlblPassword.Location = new System.Drawing.Point(0, 0);
            this.RlblPassword.Name = "RlblPassword";
            this.RlblPassword.Size = new System.Drawing.Size(65, 13);
            this.RlblPassword.TabIndex = 3;
            this.RlblPassword.Text = "*REQUIRED";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.RegPasswordTXT);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(282, 37);
            this.panel15.TabIndex = 4;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel16.Location = new System.Drawing.Point(3, 28);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(270, 1);
            this.panel16.TabIndex = 5;
            // 
            // RegPasswordTXT
            // 
            this.RegPasswordTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.RegPasswordTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegPasswordTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPasswordTXT.ForeColor = System.Drawing.SystemColors.Info;
            this.RegPasswordTXT.Location = new System.Drawing.Point(3, 3);
            this.RegPasswordTXT.Name = "RegPasswordTXT";
            this.RegPasswordTXT.Size = new System.Drawing.Size(270, 17);
            this.RegPasswordTXT.TabIndex = 3;
            this.RegPasswordTXT.Text = "Enter Password";
            this.RegPasswordTXT.Click += new System.EventHandler(this.RegPasswordTXT_Click);
            this.RegPasswordTXT.TextChanged += new System.EventHandler(this.RegPasswordTXT_TextChanged);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.pnlUsername);
            this.panel17.Controls.Add(this.panel19);
            this.panel17.Location = new System.Drawing.Point(152, 218);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(282, 68);
            this.panel17.TabIndex = 25;
            // 
            // pnlUsername
            // 
            this.pnlUsername.Controls.Add(this.RlblUsername);
            this.pnlUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsername.Location = new System.Drawing.Point(0, 37);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(282, 27);
            this.pnlUsername.TabIndex = 5;
            this.pnlUsername.Visible = false;
            // 
            // RlblUsername
            // 
            this.RlblUsername.AutoSize = true;
            this.RlblUsername.Dock = System.Windows.Forms.DockStyle.Left;
            this.RlblUsername.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RlblUsername.ForeColor = System.Drawing.Color.Red;
            this.RlblUsername.Location = new System.Drawing.Point(0, 0);
            this.RlblUsername.Name = "RlblUsername";
            this.RlblUsername.Size = new System.Drawing.Size(65, 13);
            this.RlblUsername.TabIndex = 3;
            this.RlblUsername.Text = "*REQUIRED";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.panel20);
            this.panel19.Controls.Add(this.RegUsernameTXT);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(282, 37);
            this.panel19.TabIndex = 4;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel20.Location = new System.Drawing.Point(3, 30);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(270, 1);
            this.panel20.TabIndex = 5;
            // 
            // RegUsernameTXT
            // 
            this.RegUsernameTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.RegUsernameTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegUsernameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegUsernameTXT.ForeColor = System.Drawing.SystemColors.Info;
            this.RegUsernameTXT.Location = new System.Drawing.Point(3, 5);
            this.RegUsernameTXT.Name = "RegUsernameTXT";
            this.RegUsernameTXT.Size = new System.Drawing.Size(270, 17);
            this.RegUsernameTXT.TabIndex = 3;
            this.RegUsernameTXT.Text = "Enter Username";
            this.RegUsernameTXT.Click += new System.EventHandler(this.RegUsernameTXT_Click);
            this.RegUsernameTXT.TextChanged += new System.EventHandler(this.RegUsernameTXT_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "PASSWORD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(82, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "USERNAME";
            // 
            // AddNewFarmerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "AddNewFarmerUC";
            this.Size = new System.Drawing.Size(563, 461);
            this.panel21.ResumeLayout(false);
            this.pnlSurname.ResumeLayout(false);
            this.pnlSurname.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel pnlSurname;
        private System.Windows.Forms.Label Rlblsurname;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox SurnameTXT;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Label RlblName;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button RegisterBTN;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Label RlblPassword;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox RegPasswordTXT;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Label RlblUsername;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox RegUsernameTXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
