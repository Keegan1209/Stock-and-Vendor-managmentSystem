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
using System.IO;
using System.Text.RegularExpressions;

namespace PROG_POE_FARM_CENTRAL
{
    public partial class EmpViewProducts : UserControl
    {


        //String con = @"Data Source=KEEGANSPC\SQLEXPRESS02;Initial Catalog=DBA_FARMCENTRAL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        String FilterDate;
        String farmer;
        String Product; 
        public EmpViewProducts()
        {
            InitializeComponent();
            
        }



// ------------------------------------------ START LOAD PRODUCTS METHOD ---------------------------------------------------------------------------------
        private void EmpViewProducts_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=KEEGANSPC\SQLEXPRESS02;Initial Catalog=DBA_FARMCENTRAL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
     

            SqlCommand cmd = new SqlCommand("SELECT FARMERID, PRODUCTID, PR_NAME, PR_DESCRIPTION, PR_PRICE, DATE_ADDED, PR_IMAGE FROM PRODUCT", sqlCon);
            //FARMERID, PRODUCTID, PR_NAME, PR_DESCRIPTION, PR_PRICE, DATE_ADDED, PR_IMAGE

            SqlDataAdapter sd = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sd.Fill(dt);
            //dt.Columns.Add("PR_IMAGES", Type.GetType("System.Byte[]")); 
            //foreach(DataRow drow in dt.Rows)
            //{
            //    drow["PR_IMAGES"] = File.ReadAllBytes(drow["PR_IMAGES"].ToString()); 
            //}
            dataGridView1.DataSource = dt; 

}

// ------------------------------------------------------ END LOAD PRODUCTS ---------------------------------------------------------------------------------

// ------------------------------------------------------- START FILTER ALL PRODUCTS BY DATE ---------------------------------------------------------------
        private void FilterDateBTN_Click(object sender, EventArgs e)
        {
            // VALIDATE USER INPUT DATE FORMAT
            Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})$");
            Match m = reg.Match(DateTXT.Text);
            if (m.Success)
            {

                FilterDate = DateTXT.Text;
                SqlConnection sqlCon = new SqlConnection(@"Data Source=KEEGANSPC\SQLEXPRESS02;Initial Catalog=DBA_FARMCENTRAL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");


                SqlCommand cmd = new SqlCommand("SELECT FARMERID, PRODUCTID, PR_NAME, PR_DESCRIPTION, PR_PRICE, DATE_ADDED, PR_IMAGE FROM PRODUCT WHERE DATE_ADDED = '" + FilterDate + "'", sqlCon);

                SqlDataAdapter sd = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            else if (DateTXT.Text == "")
            {
                MessageBox.Show("Invalid input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // --------------------------------------------------------END FILTER BY DATE -------------------------------------------------------------------------

// ----------------------------------------------------------- START FILTER BY FARMER --------------------------------------------------
        private void FarmerFilter_Click(object sender, EventArgs e)
        {


            if (FarmerTXT.Text == "")
            {
                MessageBox.Show("Invalid input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                farmer = FarmerTXT.Text;
                SqlConnection sqlCon = new SqlConnection(@"Data Source=KEEGANSPC\SQLEXPRESS02;Initial Catalog=DBA_FARMCENTRAL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");


                SqlCommand cmd = new SqlCommand("SELECT FARMERID, PRODUCTID, PR_NAME, PR_DESCRIPTION, PR_PRICE, DATE_ADDED, PR_IMAGE FROM PRODUCT WHERE FARMERID = '" + farmer + "'", sqlCon);

                SqlDataAdapter sd = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        // ----------------------------------------------------------- END FILTER BY FARMER --------------------------------------------------

        // ----------------------------------------------------------- START FILTER BY PRODUCT --------------------------------------------------



        private void productFilter_Click(object sender, EventArgs e)
        {
            if (ProdTXT.Text == "")
            {
                MessageBox.Show("Invalid input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                

                Product = ProdTXT.Text;
                SqlConnection sqlCon = new SqlConnection(@"Data Source=KEEGANSPC\SQLEXPRESS02;Initial Catalog=DBA_FARMCENTRAL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");


                SqlCommand cmd = new SqlCommand("SELECT FARMERID, PRODUCTID, PR_NAME, PR_DESCRIPTION, PR_PRICE, DATE_ADDED, PR_IMAGE FROM PRODUCT WHERE PRODUCTID = '" + Product + "'", sqlCon);
                SqlCommand cmd2 = new SqlCommand("SELECT FARMERID, PRODUCTID, PR_NAME, PR_DESCRIPTION, PR_PRICE, DATE_ADDED, PR_IMAGE FROM PRODUCT WHERE PR_NAME = '" + Product + "'", sqlCon);

                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                SqlDataAdapter sd2 = new SqlDataAdapter(cmd2);

                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }




        // ----------------------------------------------------------- END FILTER BY PRODUCT --------------------------------------------------







        // ---------------------------------------------------------- CLEAR FILTER ---------------------------------------------------------------------------
        private void Reset_Click(object sender, EventArgs e)
        {
             DateTXT.Clear();
            FarmerTXT.Clear();
            ProdTXT.Clear(); 

            SqlConnection sqlCon = new SqlConnection(@"Data Source=KEEGANSPC\SQLEXPRESS02;Initial Catalog=DBA_FARMCENTRAL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");


            SqlCommand cmd = new SqlCommand("SELECT FARMERID, PRODUCTID, PR_NAME, PR_DESCRIPTION, PR_PRICE, DATE_ADDED, PR_IMAGE FROM PRODUCT", sqlCon);
            
            SqlDataAdapter sd = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sd.Fill(dt);
            
            dataGridView1.DataSource = dt;
        }// -------------------------------------------------------------END FILTER METHOD ----------------------------------------------------------------------

        private void DateTXT_Click(object sender, EventArgs e)
        {
            DateTXT.SelectAll(); 
        }

        private void FarmerTXT_Click(object sender, EventArgs e)
        {
            FarmerTXT.SelectAll();
        }

        private void ProdTXT_Click(object sender, EventArgs e)
        {
            ProdTXT.SelectAll();
        }
    }/// ----------------------------------------------------------------- END OF FILE ------------------------------------------------------------------------
}
