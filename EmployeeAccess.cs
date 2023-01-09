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
    public partial class EmployeeAccess : Form
    {
        String con = @"Data Source=KEEGANSPC\SQLEXPRESS02;Initial Catalog=DBA_FARMCENTRAL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";

        bool validateInfo = false;
        Point lastPoint;
        public EmployeeAccess()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }









 // -------------------------------------------- START REGISTER INTERFACE --------------------------------------------------------  


        // register new user button
        private void RegisterBTN_Click(object sender, EventArgs e)
        {
           
           
               

             
                if (validateInfo == false)
                {
                   
                    ValidateRegisterInfo();
                }
                else
                {

                    
                    FarmDetails.empName = nameTXT.Text;
                    FarmDetails.empSurname = SurnameTXT.Text;
                    FarmDetails.empUsername = RegUsernameTXT.Text;
                    FarmDetails.empPassword = RegPasswordTXT.Text;
                    FarmDetails.empID = 0;


                    using (SqlConnection SqlCon1 = new SqlConnection(con))
                    {

                        String checkUsername = "SELECT * FROM EMPLOYEE WHERE USERNAME = @USERNAME";
                        SqlCon1.Open();
                        SqlCommand sqlCmd1 = new SqlCommand(checkUsername, SqlCon1);
                        sqlCmd1.Parameters.AddWithValue("@USERNAME", FarmDetails.empUsername);

                        sqlCmd1.ExecuteNonQuery();
                        int Count = Convert.ToInt32(sqlCmd1.ExecuteScalar());


                        

                        if (Count > 0)
                        {
                            MessageBox.Show("Username is taken Please Create a new one.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            RegUsernameTXT.Clear(); 
                            RegUsernameTXT.Focus();
                        }
                        else
                        {
                            
                            using (SqlConnection sqlCon = new SqlConnection(con))
                            {
                                sqlCon.Open();
                                SqlCommand sqlComm = new SqlCommand("EMP", sqlCon);
                                sqlComm.CommandType = CommandType.StoredProcedure;
                                sqlComm.Parameters.AddWithValue("@EMPID", FarmDetails.empID);
                                sqlComm.Parameters.AddWithValue("@FIRST_NAME", FarmDetails.empName);
                                sqlComm.Parameters.AddWithValue("@SURNAME", FarmDetails.empSurname);
                                sqlComm.Parameters.AddWithValue("@USERNAME", FarmDetails.empUsername);
                                sqlComm.Parameters.AddWithValue("@PASSWORD", FarmDetails.hashPassword(RegPasswordTXT.Text));

                                sqlComm.ExecuteNonQuery();
                                sqlCon.Close();

                                MessageBox.Show("registration is successful");


                            }
                        }


                    }





                   
                }


            
        }



        // ----------------------------------------------- END REGISTER USER METHOD ---------------------------------------------------------------------


        // ------------------------------------------------ START LOGIN WINDOW ---------------------------------------------------------------------
        // existing employee login button 
        private void empLoginBTN_Click(object sender, EventArgs e)
        {
            ValidateUserInput();

            FarmDetails.empUsername = empUsernameTXT.Text;
            FarmDetails.empPassword = empPasswordTXT.Text;


           

            using (SqlConnection SqlCon = new SqlConnection(con)) { 

            String sqlQuery = "SELECT * FROM EMPLOYEE WHERE USERNAME = @USERNAME AND PASSWORD = @PASSWORD";

            SqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, SqlCon);

            sqlCmd.Parameters.AddWithValue("@USERNAME", FarmDetails.empUsername);
            sqlCmd.Parameters.AddWithValue("@PASSWORD", FarmDetails.hashPassword(RegPasswordTXT.Text));

            
            sqlCmd.ExecuteNonQuery();
            int Count = Convert.ToInt32(sqlCmd.ExecuteScalar());


            SqlCon.Close();
           
            if (Count > 0)
            {

                EmpDashboard ed = new EmpDashboard();
                ed.Show();
            }
            else
            {

                    MessageBox.Show("Username or password not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ValidateUserInput();
            }
        }
            
    }


// -------------------------------------------------END LOGIN WINDOW METHOD ------------------------------------------------------------

/// --------------------------------------------- START REGISTRATION INTERFACE HOUSE KEEPING ---------------------------------------------------


        // validate register user input
        private void ValidateRegisterInfo()
        {
           

            if (validateInfo == false)
            {
                if (nameTXT.Text == "Enter Name" || nameTXT.Text == "")
                {
                    pnlName.Visible = true;
                    nameTXT.Focus();
                    return;
                }
                if (SurnameTXT.Text == "Enter Surname" || SurnameTXT.Text == "")
                {
                    pnlSurname.Visible = true;
                    SurnameTXT.Focus();
                    return;
                }
                if (RegUsernameTXT.Text == "Enter Username"|| RegUsernameTXT.Text == "")
                {
                    pnlUsername.Visible = true;
                    RegUsernameTXT.Focus();
                    return;
                }
                if (RegPasswordTXT.Text == "Enter Password"|| RegPasswordTXT.Text == "")
                {
                    pnlPassword.Visible = true;
                    RegPasswordTXT.Focus();
                    return;
                }
                else
                {
                    validateInfo = true; 
                }
            }
        }



        private void nameTXT_TextChanged(object sender, EventArgs e)
        {
            
                nameTXT.ForeColor = Color.Black;
                nameTXT.Focus(); 
                pnlName.Visible = false;

          
        }

        private void SurnameTXT_TextChanged(object sender, EventArgs e)
        {
           
                SurnameTXT.ForeColor = Color.Black;
                SurnameTXT.Focus(); 
                pnlSurname.Visible = false;

            
        }

        private void RegUsernameTXT_TextChanged(object sender, EventArgs e)
        {
            
            
             RegUsernameTXT.ForeColor = Color.Black;
             RegUsernameTXT.Focus(); 
             pnlUsername.Visible = false;

            
            
        }

        private void RegPasswordTXT_TextChanged(object sender, EventArgs e)
        {
            
            
             RegPasswordTXT.ForeColor = Color.Black;
             RegPasswordTXT.Focus(); 
             RegPasswordTXT.PasswordChar = '*';
             pnlPassword.Visible = false;
            
            
        }

        private void nameTXT_Click(object sender, EventArgs e)
        {
            nameTXT.SelectAll(); 
        }

        private void SurnameTXT_Click(object sender, EventArgs e)
        {
           SurnameTXT.SelectAll();
        }

        private void RegUsernameTXT_Click(object sender, EventArgs e)
        {
            RegUsernameTXT.SelectAll(); 
        }

        private void RegPasswordTXT_Click(object sender, EventArgs e)
        {
            RegPasswordTXT.SelectAll();
        }

// -------------------------------------------- END REGISTER INTERFACE --------------------------------------------------------

// -------------------------------------------- START LOGIN INTERFACE HOUSE KEEPING --------------------------------------------------------  
        // LOGIN window validate user input 
        private void empUsernameTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                empUsernameTXT.ForeColor = Color.Black;
                empUsernameTXT.Focus(); 
                panel7.Visible = false;

            }
            catch { }
        }

        private void empPasswordTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                empPasswordTXT.ForeColor = Color.Black;
                empPasswordTXT.Focus(); 
                empPasswordTXT.PasswordChar = '*';
                panel9.Visible = false;
            }
            catch { }
        }

        private void empUsernameTXT_Click(object sender, EventArgs e)
        {
            empUsernameTXT.SelectAll();
        }

        private void empPasswordTXT_Click(object sender, EventArgs e)
        {
            empPasswordTXT.SelectAll();
        }






        private void ValidateUserInput()
        {
            if (empUsernameTXT.Text == "Enter Username")
            {
                panel7.Visible = true;
                empUsernameTXT.Focus();
                return;
            }

            if (empPasswordTXT.Text == "Enter Password")
            {
                panel9.Visible = true;
                empPasswordTXT.Focus();
                return;
            }

        }// end login window input


// -------------------------------------------- END LOGIN INTERFACE --------------------------------------------------------       

 // -------------------------------------------- START Window set up --------------------------------------------------------  

        // DRAGABLE window. 
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

        // View register widnow
        private void RegisterEmpBTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPanel.Visible = true;
            LoginPanel.Visible = false;
            RegisterPanel.Dock = DockStyle.Fill;


        }

        /// view login window
        private void LoginLinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPanel.Dock = DockStyle.Fill;
            //RegisterPanel.Visible = false;
            LoginPanel.Visible = true;
        } /// End register login switch 



        /// end program button 
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // minimize window
        private void MinWinBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // maximize window
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

        /// return to previous window
        private void homeBTN_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }


// -------------------------------------------- END Window set up --------------------------------------------------------  

    }// END FUNCTION
}
