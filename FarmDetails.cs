using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE_FARM_CENTRAL
{
    class FarmDetails
    {
        // regsiter employee
        private int EmpID;
        private String EmpName;
        private String EmpSurname;

        // login + regsiter variables
        private String EmpUsername;
        private String EmpPassword;


        // regsiter farmer
        private int FID; 
        private String FName;
        private String FSurname; 



        // LOGIN REGSITER FARMER
        private String Fusername;
        private String Fpassword;


        public static int fID { get; set;  }
        public static String fName { get; set; }
        public static String fSurname { get; set; }
        public static String fUsername { get; set; }
        public static String fPassword { get; set; }
        public static int empID { get; set; }
        public static String empName  { get; set; }
        public static String empSurname { get; set; }

        public static String empUsername { get; set; }

        public static String empPassword { get; set; }



        // ----------------------------- ADD PRODUCT FIELDS -------------------------------------------

        private string ProID;
        private string ProName;
        private string ProDescription;
        private double ProPrice;
        private String ProDate;
       


       
        public static String proID { get; set; }
        public static String proName { get; set; }
        public static String proDescription { get; set; }
        public static double proPrice { get; set; }
        public static String proDate { get; set; }

        public FarmDetails(int empID, string empName, string empSurname, string empUsername, string empPassword, 
            int fID, String fName, String fSurname, string fUsername, String fPassword)
        {
            this.EmpID = empID;
            this.EmpName = empName;
            this.EmpSurname = empSurname;
            this.EmpUsername = empUsername;
            this.EmpPassword = empPassword;

            this.FID = fID;
            this.FName = fName;
            this.FSurname = fSurname; 
            this.Fusername = fUsername;
            this.Fpassword = fPassword; 
        }

        public FarmDetails( string proID, string proName, string proDescription, double proPrice, String proDate)
        {
           
           this.ProID = proID;
           this.ProName = proName;
           this.ProDescription = proDescription;
           this.ProPrice = proPrice;
           this.ProDate = proDate;
        }

        internal static object hashPassword(string text)
        {
            SHA1CryptoServiceProvider HASHPWORD = new SHA1CryptoServiceProvider();

            byte[] Password_bytes = Encoding.ASCII.GetBytes(empPassword);
            byte[] encrypted_bytes = HASHPWORD.ComputeHash(Password_bytes);
            return Convert.ToBase64String(encrypted_bytes);

        }

        internal static object hashPassword2(string text)
        {
            SHA1CryptoServiceProvider HASHPWORD = new SHA1CryptoServiceProvider();

            byte[] Password_bytes = Encoding.ASCII.GetBytes(fPassword);
            byte[] encrypted_bytes = HASHPWORD.ComputeHash(Password_bytes);
            return Convert.ToBase64String(encrypted_bytes);

        }
    }
}
