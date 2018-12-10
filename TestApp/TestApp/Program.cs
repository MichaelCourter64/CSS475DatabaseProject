using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //SqlConnection sqlConnection = new SqlConnection("User ID=mAsterAcc;Password=fescdwax;Data Source=css475mariadbbasedgamelibrary.cuk3vrnaztl4.us-west-2.rds.amazonaws.com;" +
                //"Integrated Security=false;Initial Catalog=Vapor;connection timeout=10");

            SqlConnection sqlConnection = new SqlConnection("Server = css475mariadbbasedgamelibrary.cuk3vrnaztl4.us-west-2.rds.amazonaws.com; Database = Vapor; Uid = mAsterAcc; Pwd = fescdwax;");

            try
            {
                sqlConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }
    }
}
