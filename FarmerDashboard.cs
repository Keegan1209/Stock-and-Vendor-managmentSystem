using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_POE_FARM_CENTRAL
{
    public partial class FarmerDashboard : Form
    {

        Point lastPoint; 
        public FarmerDashboard()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            welcomeUsername.Text = FarmDetails.fUsername;
            this.Text = FarmDetails.fUsername;
            FarmerDashPNL.Visible = true;
            FarmerDashPNL.Dock = DockStyle.Fill;
        }





// ------------------------------------------- Window navigation set up ------------------------------------------------------
        private void AddProductsBTN_Click(object sender, EventArgs e)
        {
            AddProPnl.Visible = true;
            FarmerDashPNL.Visible = false;
            MyProdPNL.Visible = false;
            AddProPnl.Dock = DockStyle.Fill;
        }

        private void ViewProductBTN_Click(object sender, EventArgs e)
        {
            MyProdPNL.Visible = true;
            FarmerDashPNL.Visible = false;
            AddProPnl.Visible = false;
            MyProdPNL.Dock = DockStyle.Fill;
        }

        private void dashboardBTN_Click(object sender, EventArgs e)
        {
            FarmerDashPNL.Visible = true;
            MyProdPNL.Visible = false;
            AddProPnl.Visible = false;
            FarmerDashPNL.Dock = DockStyle.Fill;
        }




        private void HomeBTN_Click(object sender, EventArgs e)
        {
            FarmerDashboard fd = new FarmerDashboard();
            FarmerLogin FL = new FarmerLogin();
                FL.Show();
                fd.Close();

            
            
        }



        // ------------------------------------------- end Window navigation set up ------------------------------------------------------







        // -------------------------------------------- START Window set up --------------------------------------------------------  

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaxWinBTN_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

            }
        }

        private void MinWinBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }






        // -------------------------------------------- END Window set up --------------------------------------------------------  

    }
}
