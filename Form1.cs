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
    public partial class Form1 : Form
    {
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
            
        }



        // open employee login 
        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeAccess empAc = new EmployeeAccess();
            empAc.Show();

            Form1 f1 = new Form1();
            f1.Close(); 
        }


        // open farmer login 
        private void FarmerAccessBTN_Click(object sender, EventArgs e)
        {
            FarmerLogin farmL = new FarmerLogin();
            farmL.Show();

            Form1 f1 = new Form1();
            f1.Close();
        }

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
