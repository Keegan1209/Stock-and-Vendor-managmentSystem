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
using System.IO; 


namespace PROG_POE_FARM_CENTRAL
{
    public partial class AddProduct : UserControl
    {

        String con = @"Data Source=KEEGANSPC\SQLEXPRESS02;Initial Catalog=DBA_FARMCENTRAL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        private bool validateInfo;
        String imgLocation = ""; 
       

        public AddProduct()
        {
            InitializeComponent();
            this.DateTimeLbl.Text = DateTime.Today.ToString("dd/MM/yyyy"); 
        }









        private void AddNewBTN_Click(object sender, EventArgs e)
        {

            if (validateInfo == false)
            {

                ValidateProductInfo();
            }
            else
            {


                byte[] images = null;
                FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                images = brs.ReadBytes((int)Stream.Length);




                FarmDetails.proName = ProNameTXT.Text;
                FarmDetails.proDescription = DescriptionTXT.Text;
                FarmDetails.proDate = DateTime.Now.ToString("dd/MM/yyyy");
                FarmDetails.proPrice = double.Parse(PriceTXT.Text);
                FarmDetails.proID = PrIDTXT.Text;

                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(con))
                    {
                        sqlCon.Open();
                        SqlCommand sqlComm = new SqlCommand("ADD_PRODUCTS", sqlCon);

                        sqlComm.CommandType = CommandType.StoredProcedure;
                        sqlComm.Parameters.AddWithValue("@PRODUCTID", FarmDetails.proID);
                        sqlComm.Parameters.AddWithValue("@PR_NAME", FarmDetails.proName);
                        sqlComm.Parameters.AddWithValue("@PR_DESCRIPTION", FarmDetails.proDescription);
                        sqlComm.Parameters.AddWithValue("@PR_PRICE", FarmDetails.proPrice);
                        sqlComm.Parameters.AddWithValue("@PR_IMAGE", images);
                        sqlComm.Parameters.AddWithValue("@DATE_ADDED", FarmDetails.proDate);
                        sqlComm.Parameters.AddWithValue("@FARMERID", FarmDetails.fID);

                        sqlComm.ExecuteNonQuery();
                        sqlCon.Close();

                        MessageBox.Show("ADDED successfully");


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



            }


            }





/// ---------------------------------------------- interaction methods -------------------------------------------
        private void UploadImgBTN_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                proImageDP.ImageLocation = imgLocation;
            }
        }


        private void GenerateIDBTN_Click(object sender, EventArgs e)
        {
            char[] Letters = "FARMCENTRLPDS1234567890".ToCharArray();
            Random rand = new Random();
            FarmDetails.proID = "";
            for (int i = 0; i <4; i++)
            {
                FarmDetails.proID += Letters[rand.Next(0, 23)].ToString();
            }
            this.PrIDTXT.Text = FarmDetails.proID; 
        }



     



        /// --------------------------------------------------- TEXT BOX ERROR CHECKING ----------------------------------------
        private void ProNameTXT_TextChanged(object sender, EventArgs e)
        {
            ProNameTXT.ForeColor = Color.Black;
            ProNameTXT.Focus();
            ReqNamePnl.Visible = false;
        }

        private void DescriptionTXT_TextChanged(object sender, EventArgs e)
        {
            DescriptionTXT.ForeColor = Color.Black;
            DescriptionTXT.Focus();
            ReqDescPNL.Visible = false;
        }

        private void PriceTXT_TextChanged(object sender, EventArgs e)
        {
            PriceTXT.ForeColor = Color.Black;
            PriceTXT.Focus();
            ReqPricePNL.Visible = false;
        }

        private void PrIDTXT_TextChanged(object sender, EventArgs e)
        {
            PrIDTXT.ForeColor = Color.Black;
            PrIDTXT.Focus();
            ReqIDpnl.Visible = false;
        }

        private void ValidateProductInfo()
        {


            if (validateInfo == false)
            {
                if (ProNameTXT.Text == "Enter Name" || ProNameTXT.Text == "")
                {
                    ReqNamePnl.Visible = true;
                    ProNameTXT.Focus();
                    return;
                }
                if (DescriptionTXT.Text == "Description" || DescriptionTXT.Text == "")
                {
                    ReqDescPNL.Visible = true;
                    DescriptionTXT.Focus();
                    return;
                }
                if (PriceTXT.Text == "000" || PriceTXT.Text == "")
                {
                    ReqPricePNL.Visible = true;
                    PriceTXT.Focus();
                    return;
                }
                if (PrIDTXT.Text == "ID" || PrIDTXT.Text == "")
                {
                    ReqIDlbl.Visible = true;
                    PrIDTXT.Focus();
                    return;
                }
                else
                {
                    validateInfo = true;
                }
            }
        }

        private void ProNameTXT_Click(object sender, EventArgs e)
        {
            ProNameTXT.SelectAll();
        }

        private void DescriptionTXT_Click(object sender, EventArgs e)
        {
            DescriptionTXT.SelectAll();
        }

        private void PriceTXT_Click(object sender, EventArgs e)
        {
            PriceTXT.SelectAll();
        }

        private void PrIDTXT_Click(object sender, EventArgs e)
        {
            PrIDTXT.SelectAll();
        }

        private void PriceTXT_KeyPress(object sender, KeyPressEventArgs e)
        {


            
            char ch = e.KeyChar;

            if (ch == 46 && PriceTXT.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

            
        }

        /// --------------------------------------------------- END TEXT BOX ERROR CHECKING ----------------------------------------
    }
}
