using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

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
                
            MySqlConnection sqlConnection = new MySqlConnection("Server=css475mariadbbasedgamelibrary.cuk3vrnaztl4.us-west-2.rds.amazonaws.com;" +
                " Database=Vapor; user=mAsterAcc; Password=fescdwax;");

            try
            {
                sqlConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            string sql = "SELECT UName FROM USER";
            MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr[0]);
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
