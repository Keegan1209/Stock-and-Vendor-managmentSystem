
namespace PROG_POE_FARM_CENTRAL
{
    partial class EmpDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpDashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EmployeeDashlbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MinWinBTN = new System.Windows.Forms.Button();
            this.MaxWinBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dashboard = new System.Windows.Forms.Button();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.ViewProductBTN = new System.Windows.Forms.Button();
            this.AddFarmerBTN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DashPanel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddFarmerPNL = new System.Windows.Forms.Panel();
            this.ViewProPNL = new System.Windows.Forms.Panel();
            this.addNewFarmerUC = new PROG_POE_FARM_CENTRAL.AddNewFarmerUC();
            this.empViewProducts1 = new PROG_POE_FARM_CENTRAL.EmpViewProducts();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DashPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.AddFarmerPNL.SuspendLayout();
            this.ViewProPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(155, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 78);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.EmployeeDashlbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(937, 53);
            this.panel4.TabIndex = 0;
            // 
            // EmployeeDashlbl
            // 
            this.EmployeeDashlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmployeeDashlbl.AutoSize = true;
            this.EmployeeDashlbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDashlbl.Location = new System.Drawing.Point(347, 9);
            this.EmployeeDashlbl.Name = "EmployeeDashlbl";
            this.EmployeeDashlbl.Size = new System.Drawing.Size(243, 23);
            this.EmployeeDashlbl.TabIndex = 0;
            this.EmployeeDashlbl.Text = "EMPLOYEE DASHBOARD";
            this.EmployeeDashlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.panel5.Controls.Add(this.MinWinBTN);
            this.panel5.Controls.Add(this.MaxWinBTN);
            this.panel5.Controls.Add(this.ExitBTN);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(937, 25);
            this.panel5.TabIndex = 13;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            // 
            // MinWinBTN
            // 
            this.MinWinBTN.BackgroundImage = global::PROG_POE_FARM_CENTRAL.Properties.Resources.icons8_subtract_50;
            this.MinWinBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinWinBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinWinBTN.FlatAppearance.BorderSize = 0;
            this.MinWinBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MinWinBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinWinBTN.Location = new System.Drawing.Point(853, 0);
            this.MinWinBTN.Name = "MinWinBTN";
            this.MinWinBTN.Size = new System.Drawing.Size(28, 25);
            this.MinWinBTN.TabIndex = 3;
            this.MinWinBTN.UseVisualStyleBackColor = true;
            this.MinWinBTN.Click += new System.EventHandler(this.MinWinBTN_Click);
            // 
            // MaxWinBTN
            // 
            this.MaxWinBTN.BackgroundImage = global::PROG_POE_FARM_CENTRAL.Properties.Resources.icons8_expand_50;
            this.MaxWinBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaxWinBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxWinBTN.FlatAppearance.BorderSize = 0;
            this.MaxWinBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MaxWinBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxWinBTN.Location = new System.Drawing.Point(881, 0);
            this.MaxWinBTN.Name = "MaxWinBTN";
            this.MaxWinBTN.Size = new System.Drawing.Size(28, 25);
            this.MaxWinBTN.TabIndex = 2;
            this.MaxWinBTN.UseVisualStyleBackColor = true;
            this.MaxWinBTN.Click += new System.EventHandler(this.MaxWinBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackgroundImage = global::PROG_POE_FARM_CENTRAL.Properties.Resources.icons8_close_50;
            this.ExitBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBTN.FlatAppearance.BorderSize = 0;
            this.ExitBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBTN.Location = new System.Drawing.Point(909, 0);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(28, 25);
            this.ExitBTN.TabIndex = 1;
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(195, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome Back";
            // 
            // welcomeUsername
            // 
            this.welcomeUsername.AutoSize = true;
            this.welcomeUsername.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomeUsername.Location = new System.Drawing.Point(204, 68);
            this.welcomeUsername.Name = "welcomeUsername";
            this.welcomeUsername.Size = new System.Drawing.Size(0, 33);
            this.welcomeUsername.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.Dashboard);
            this.panel1.Controls.Add(this.HomeBTN);
            this.panel1.Controls.Add(this.ViewProductBTN);
            this.panel1.Controls.Add(this.AddFarmerBTN);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 732);
            this.panel1.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(188)))), ((int)(((byte)(96)))));
            this.Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Location = new System.Drawing.Point(0, 328);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(150, 94);
            this.Dashboard.TabIndex = 4;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // HomeBTN
            // 
            this.HomeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(188)))), ((int)(((byte)(96)))));
            this.HomeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HomeBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HomeBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.HomeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HomeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBTN.Location = new System.Drawing.Point(0, 674);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(150, 58);
            this.HomeBTN.TabIndex = 3;
            this.HomeBTN.Text = "LOG OUT";
            this.HomeBTN.UseVisualStyleBackColor = false;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // ViewProductBTN
            // 
            this.ViewProductBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(188)))), ((int)(((byte)(96)))));
            this.ViewProductBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewProductBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewProductBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ViewProductBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.ViewProductBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ViewProductBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewProductBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProductBTN.Location = new System.Drawing.Point(0, 234);
            this.ViewProductBTN.Name = "ViewProductBTN";
            this.ViewProductBTN.Size = new System.Drawing.Size(150, 94);
            this.ViewProductBTN.TabIndex = 2;
            this.ViewProductBTN.Text = "View Products";
            this.ViewProductBTN.UseVisualStyleBackColor = false;
            this.ViewProductBTN.Click += new System.EventHandler(this.ViewProductBTN_Click);
            // 
            // AddFarmerBTN
            // 
            this.AddFarmerBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(188)))), ((int)(((byte)(96)))));
            this.AddFarmerBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFarmerBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddFarmerBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddFarmerBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.AddFarmerBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddFarmerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFarmerBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFarmerBTN.Location = new System.Drawing.Point(0, 140);
            this.AddFarmerBTN.Name = "AddFarmerBTN";
            this.AddFarmerBTN.Size = new System.Drawing.Size(150, 94);
            this.AddFarmerBTN.TabIndex = 1;
            this.AddFarmerBTN.Text = "Add Farmer";
            this.AddFarmerBTN.UseVisualStyleBackColor = false;
            this.AddFarmerBTN.Click += new System.EventHandler(this.AddFarmerBTN_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 140);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // DashPanel
            // 
            this.DashPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.DashPanel.Controls.Add(this.panel8);
            this.DashPanel.Controls.Add(this.panel7);
            this.DashPanel.Controls.Add(this.panel6);
            this.DashPanel.Controls.Add(this.label1);
            this.DashPanel.Controls.Add(this.welcomeUsername);
            this.DashPanel.Controls.Add(this.pictureBox2);
            this.DashPanel.Location = new System.Drawing.Point(246, 112);
            this.DashPanel.Name = "DashPanel";
            this.DashPanel.Padding = new System.Windows.Forms.Padding(5);
            this.DashPanel.Size = new System.Drawing.Size(818, 599);
            this.DashPanel.TabIndex = 4;
            this.DashPanel.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Location = new System.Drawing.Point(392, 337);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(354, 95);
            this.panel8.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(97, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "VIEW AND TRACK ALL PRODUCTS SITE-WIDE\r\n FROM THE \"VIEW PRODUCTS\" TAB\r\n\r\n";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PROG_POE_FARM_CENTRAL.Properties.Resources.file;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 83);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(67)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Location = new System.Drawing.Point(51, 334);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(303, 95);
            this.panel7.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(95, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "YOU CAN ADD A NEW FARMER \r\nFROM THE \"ADD FARMER\" WINDOW. ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PROG_POE_FARM_CENTRAL.Properties.Resources.add_contact;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(51, 169);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(405, 75);
            this.panel6.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "WELCOME TO FARM CENTRAL EMPLOYEE. TO UTILIZE THE APP\r\nNAVIGATE TO THE MENU BUTTON" +
    "S ON THE LEFT, AND SELECT \r\nAN ACTION YOU WISH TO PERFORM, YOU WILL THEN BE REDI" +
    "RECTED\r\nTO THE CORRESPONDING WINDOW.  ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PROG_POE_FARM_CENTRAL.Properties.Resources.graphic_designer;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(51, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // AddFarmerPNL
            // 
            this.AddFarmerPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.AddFarmerPNL.Controls.Add(this.addNewFarmerUC);
            this.AddFarmerPNL.Location = new System.Drawing.Point(158, 352);
            this.AddFarmerPNL.Name = "AddFarmerPNL";
            this.AddFarmerPNL.Size = new System.Drawing.Size(947, 664);
            this.AddFarmerPNL.TabIndex = 3;
            this.AddFarmerPNL.Visible = false;
            // 
            // ViewProPNL
            // 
            this.ViewProPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.ViewProPNL.Controls.Add(this.empViewProducts1);
            this.ViewProPNL.Location = new System.Drawing.Point(192, 145);
            this.ViewProPNL.Name = "ViewProPNL";
            this.ViewProPNL.Size = new System.Drawing.Size(947, 664);
            this.ViewProPNL.TabIndex = 6;
            this.ViewProPNL.Visible = false;
            // 
            // addNewFarmerUC
            // 
            this.addNewFarmerUC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewFarmerUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.addNewFarmerUC.Location = new System.Drawing.Point(0, 0);
            this.addNewFarmerUC.Name = "addNewFarmerUC";
            this.addNewFarmerUC.Size = new System.Drawing.Size(563, 664);
            this.addNewFarmerUC.TabIndex = 0;
            // 
            // empViewProducts1
            // 
            this.empViewProducts1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empViewProducts1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.empViewProducts1.Location = new System.Drawing.Point(0, 0);
            this.empViewProducts1.Name = "empViewProducts1";
            this.empViewProducts1.Size = new System.Drawing.Size(860, 664);
            this.empViewProducts1.TabIndex = 4;
            // 
            // EmpDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(209)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1097, 742);
            this.Controls.Add(this.AddFarmerPNL);
            this.Controls.Add(this.DashPanel);
            this.Controls.Add(this.ViewProPNL);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpDashboard";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "EmpDashboard";
            this.Load += new System.EventHandler(this.EmpDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DashPanel.ResumeLayout(false);
            this.DashPanel.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.AddFarmerPNL.ResumeLayout(false);
            this.ViewProPNL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HomeBTN;
        private System.Windows.Forms.Button ViewProductBTN;
        private System.Windows.Forms.Button AddFarmerBTN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label EmployeeDashlbl;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label welcomeUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button MinWinBTN;
        private System.Windows.Forms.Button MaxWinBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Panel DashPanel;
        private System.Windows.Forms.Panel AddFarmerPNL;
        private System.Windows.Forms.PictureBox pictureBox2;
        private AddNewFarmerUC addNewFarmerUC;
        private EmpViewProducts empViewProducts1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ViewProPNL;
        private System.Windows.Forms.Button Dashboard;
    }
}