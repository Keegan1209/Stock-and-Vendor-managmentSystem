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


    public partial class FarmerLogin : Form
    {

        String con = @"Data Source=KEEGANSPC\SQLEXPRESS02;Initial Catalog=DBA_FARMCENTRAL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";


        Point lastPoint;

        public FarmerLogin()
        {
            
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }





        // -------------------------------------------- START FARMER LOGIN WINDOW --------------------------------------------------------   



        private void farmerLoginBTN_Click_1(object sender, EventArgs e)
        {

            ValidateUserInput();






            FarmDetails.fUsername = faUsernameTXT.Text;
            FarmDetails.fPassword = faPasswordTXT.Text;


            using (SqlConnection SqlCon = new SqlConnection(con))
            {

                String sqlQuery = "SELECT * FROM FARMERS WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD";

                SqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlQuery, SqlCon);

                sqlCmd.Parameters.AddWithValue("@USERNAME", FarmDetails.fUsername);
                sqlCmd.Parameters.AddWithValue("@PASSWORD", FarmDetails.hashPassword2(faPasswordTXT.Text));


                sqlCmd.ExecuteNonQuery();
                int Count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                SqlCon.Close();



                AssignID();

                // USER EXISTS CONTINUE
                if (Count > 0)
                {


                    MessageBox.Show( "welcome back! " + FarmDetails.fUsername );






                    FarmerDashboard fd = new FarmerDashboard();
                    fd.Show();

                }
                // USER DOES NOT EXIST
                else
                {

                    MessageBox.Show("Username or password not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ValidateUserInput();
                }
            }



        }



        // -------------------------------------------- END FARMER LOGIN WINDOW --------------------------------------------------------   


        // ----------------------------------------- ASSIGN DBA FARMER ID TO FARMER METHOD -------------------------------------------------------
        public void AssignID()
        {


            using (SqlConnection SqlCon = new SqlConnection(con))
            {
                SqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT FARMERID FROM FARMERS WHERE USERNAME ='" + FarmDetails.fUsername + "'", SqlCon);

                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    FarmerIDTXT.Text = da.GetValue(0).ToString();
                    FarmDetails.fID = int.Parse(FarmerIDTXT.Text);

                }
                SqlCon.Close();



            }
        }
        // -------------------------------------------------------- END FARMER ASSIGN ID METHOD ---------------------------------------------------















        // -------------------------------------------- VALIDATE INPUT --------------------------------------------------------  

        private void ValidateUserInput()
        {
            if (faUsernameTXT.Text == "Enter Username" || faUsernameTXT.Text == "")
            {
                panel7.Visible = true;
                faUsernameTXT.Focus();
                return;
            }

            if (faPasswordTXT.Text == "Enter Password" || faPasswordTXT.Text == "")
            {
                panel9.Visible = true;
                faPasswordTXT.Focus();
                return;
            }

        }







        private void faUsernameTXT_TextChanged(object sender, EventArgs e)
        {
            faUsernameTXT.ForeColor = Color.Black;
            faUsernameTXT.Focus();
            panel7.Visible = false;
        }

        private void faPasswordTXT_TextChanged(object sender, EventArgs e)
        {
            faPasswordTXT.ForeColor = Color.Black;
            faPasswordTXT.Focus();
            faPasswordTXT.PasswordChar = '*';
            panel9.Visible = false;

        }











        // -------------------------------------------- START Window set up --------------------------------------------------------   



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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

        private void homeBTN_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void faUsernameTXT_Click(object sender, EventArgs e)
        {
            faUsernameTXT.SelectAll(); 
        }

        private void faPasswordTXT_Click(object sender, EventArgs e)
        {
            faPasswordTXT.SelectAll(); 
        }
    }//-------------------------------------------------------- END OF FILE ----------------------------------------------------------------
}
