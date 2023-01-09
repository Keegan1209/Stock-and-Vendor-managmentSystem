using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PROG_POE_FARM_CENTRAL
{
    public partial class EmpDashboard : Form
    {
        Point lastPoint;
        public EmpDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            DashPanel.Visible = true;
            DashPanel.Dock = DockStyle.Fill; 
        }

        private void EmpDashboard_Load(object sender, EventArgs e)
        {
            welcomeUsername.Text = FarmDetails.empUsername; 
            this.Text = FarmDetails.empUsername;
        }




// -------------------------------------------- OPEN ADD FARMER WINDOW --------------------------------------------------
        private void AddFarmerBTN_Click(object sender, EventArgs e)
        {
            AddFarmerPNL.Visible = true;
            DashPanel.Visible = false;
            ViewProPNL.Visible = false;
            AddFarmerPNL.Dock = DockStyle.Fill; 

        }
  // -------------------------------------------- END OPEN ADD FARMER WINDOW --------------------------------------------------



        private void Dashboard_Click(object sender, EventArgs e)
        {
            DashPanel.Visible = true;
            ViewProPNL.Visible = false;
            AddFarmerPNL.Visible = false;
            DashPanel.Dock = DockStyle.Fill;
        }



        private void ViewProductBTN_Click(object sender, EventArgs e)
        {
            ViewProPNL.Visible = true;
            DashPanel.Visible = false;
            AddFarmerPNL.Visible = false;
            ViewProPNL.Dock = DockStyle.Fill;
        }








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

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure you want to log out?", "LOG OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                EmpDashboard ed = new EmpDashboard();
                ed.Close();

                EmployeeAccess ea = new EmployeeAccess();
                ea.Show();

                
            }
            
            
        }

       








        // -------------------------------------------- END Window set up --------------------------------------------------------  
    }
}
