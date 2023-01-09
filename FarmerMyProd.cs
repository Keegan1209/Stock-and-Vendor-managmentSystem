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

namespace PROG_POE_FARM_CENTRAL
{
    public partial class FarmerMyProd : UserControl
    {
        public FarmerMyProd()
        {
            InitializeComponent();
        }




        /// --------------------------------------------- Display Logged in farmers produts ------------------------------------
        private void FarmerMyProd_Load(object sender, EventArgs e)
        {
            
            SqlConnection sqlCon = new SqlConnection(@"Data Source=KEEGANSPC\SQLEXPRESS02;Initial Catalog=DBA_FARMCENTRAL;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");


            SqlCommand cmd = new SqlCommand("SELECT FARMERID, PRODUCTID, PR_NAME, PR_DESCRIPTION, PR_PRICE, DATE_ADDED, PR_IMAGE FROM PRODUCT WHERE FARMERID = '" + FarmDetails.fID + "'", sqlCon);

            SqlDataAdapter sd = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
