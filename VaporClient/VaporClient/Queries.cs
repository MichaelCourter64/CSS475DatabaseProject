using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VaporClient
{
    class Queries
    {
        public static Queue<string> GetPlayerGames(string userName)
        {
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

            string sql = "SELECT g.GName FROM GAME g " +
                "INNER JOIN GAME_OWNERSHIP go ON g.GName = go.G_Name AND g.RDate = go.R_Date " +
                "INNER JOIN USER u ON go.U_Name = u.UName " + 
                "WHERE u.UName = '" + userName + "' " + 
                "ORDER BY g.GName;";

            MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            Queue<string> gameNames = new Queue<string>();

            while (rdr.Read())
            {
                gameNames.Enqueue(rdr[0].ToString());
            }

            try
            {
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return gameNames;
        }

        public static Queue<string> GetFriends(string userName)
        {
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

            string sql = "SELECT fl.F_Name FROM USER u " +
                "INNER JOIN FRIENDS_LIST fl ON u.UName = fl.U_Name " +
                "WHERE u.UName = '" + userName + "' " +
                "ORDER BY fl.U_Name;";

            MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            Queue<string> friendNames = new Queue<string>();

            while (rdr.Read())
            {
                friendNames.Enqueue(rdr[0].ToString());
            }

            try
            {
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return friendNames;
        }
    }
}
