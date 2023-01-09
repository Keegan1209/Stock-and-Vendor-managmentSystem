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
    public partial class AddNewFarmerUC : UserControl
    {

        String con = @"Data Source=KEEGANSPC\SQLEXPRESS02;Initial Catalog=DBA_FARMCENTRAL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        private bool validateInfo;

        public AddNewFarmerUC()
        {
            InitializeComponent();
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {




            if (validateInfo == false)
            {

                ValidateRegisterInfo();
            }
            else
            {


                FarmDetails.fName = nameTXT.Text;
                FarmDetails.fSurname = SurnameTXT.Text;
                FarmDetails.fUsername = RegUsernameTXT.Text;
                FarmDetails.fPassword = RegPasswordTXT.Text;
                FarmDetails.fID = 0;


                using (SqlConnection SqlCon1 = new SqlConnection(con))
                {

                    String checkUsername = "SELECT * FROM FARMERS WHERE USERNAME = @USERNAME";
                    SqlCon1.Open();
                    SqlCommand sqlCmd1 = new SqlCommand(checkUsername, SqlCon1);
                    sqlCmd1.Parameters.AddWithValue("@USERNAME", FarmDetails.fUsername);

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
                            SqlCommand sqlComm = new SqlCommand("ADD_FARMER", sqlCon);
                            sqlComm.CommandType = CommandType.StoredProcedure;
                            sqlComm.Parameters.AddWithValue("@FARMERID", FarmDetails.fID);
                            sqlComm.Parameters.AddWithValue("@F_NAME", FarmDetails.fName);
                            sqlComm.Parameters.AddWithValue("@F_SURNAME", FarmDetails.fSurname);
                            sqlComm.Parameters.AddWithValue("@USERNAME", FarmDetails.fUsername);
                            sqlComm.Parameters.AddWithValue("@PASSWORD", FarmDetails.hashPassword2(RegPasswordTXT.Text));

                            sqlComm.ExecuteNonQuery();
                            sqlCon.Close();

                            MessageBox.Show("registration is successful");


                        }
                    }


                }

            }




        }





 /// --------------------------------------------- START ADD FARMER INTERFACE HOUSE KEEPING ---------------------------------------------------

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
                if (RegUsernameTXT.Text == "Enter Username" || RegUsernameTXT.Text == "")
                {
                    pnlUsername.Visible = true;
                    RegUsernameTXT.Focus();
                    return;
                }
                if (RegPasswordTXT.Text == "Enter Password" || RegPasswordTXT.Text == "")
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

/// --------------------------------------------- END ADD FARMER INTERFACE HOUSE KEEPING ---------------------------------------------------


    }
}
