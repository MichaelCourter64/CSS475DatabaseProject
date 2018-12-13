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
        public static Queue<string> GetAllGames()
        {
            MySqlConnection sqlConnection = OpenConnection();

            string sql = "SELECT GName, RDate FROM GAME;";
            MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);

            Queue<string> gameNames = DoubleAttributeToSingleStringQueue(cmd);

            CloseConnection(sqlConnection);

            return gameNames;
        }

        public static Queue<string> GetPlayerGames(string userName)
        {
            MySqlConnection sqlConnection = OpenConnection();

            string sql = "SELECT g.GName, g.RDate FROM GAME g " +
                "INNER JOIN GAME_OWNERSHIP go ON g.GName = go.G_Name AND g.RDate = go.R_Date " +
                "INNER JOIN USER u ON go.U_Name = u.UName " + 
                "WHERE u.UName = '" + userName + "' " + 
                "ORDER BY g.GName;";

            MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);

            Queue<string> gameNames = DoubleAttributeToSingleStringQueue(cmd);
            
            CloseConnection(sqlConnection);

            return gameNames;
        }

        public static void AddGameToOwnership(string username, string gameToAdd)
        {
            const int GNAME = 0;
            const int RDATE = 1;
            string[] gameKeys = gameToAdd.Split(',');

            gameKeys[RDATE] = Convert.ToDateTime(gameKeys[RDATE]).ToString("yyyy-MM-dd");

            MySqlConnection sqlConnection = OpenConnection();

            string sql = "INSERT INTO GAME_OWNERSHIP(G_Name, R_Date, U_Name) VALUES ('" + gameKeys[GNAME] + "', '" + gameKeys[RDATE] + "', '" + username + "');";

            MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
            cmd.BeginExecuteNonQuery();

            CloseConnection(sqlConnection);
        }

        public static void RemoveGameFromOwnership(string username, string gameToRemove)
        {
            const int GNAME = 0;
            const int RDATE = 1;
            string[] gameKeys = gameToRemove.Split(',');

            gameKeys[RDATE] = Convert.ToDateTime(gameKeys[RDATE]).ToString("yyyy-MM-dd");

            MySqlConnection sqlConnection = OpenConnection();

            string sql = "DELETE FROM GAME_OWNERSHIP " +
                "WHERE U_Name = '" + username + "' AND " +
                "G_Name = '" + gameKeys[GNAME] + "' AND " +
                "R_Date = '" + gameKeys[RDATE] + "';";

            MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
            cmd.BeginExecuteNonQuery();

            CloseConnection(sqlConnection);
        }

        public static Queue<string> GetFriends(string userName)
        {
            MySqlConnection sqlConnection = OpenConnection();

            string sql = "SELECT u.UName FROM USER u " +
                "WHERE u.UName IN " +
                "(SELECT fl.F_Name FROM USER u " +
                "INNER JOIN FRIENDS_LIST fl ON u.UName = fl.U_Name " +
                "WHERE u.UName = '" + userName + "') " +
                "OR " +
                "u.UName IN " +
                "(SELECT u.UName FROM USER u " +
                "INNER JOIN FRIENDS_LIST fl ON u.UName = fl.U_Name " +
                "WHERE fl.F_Name = '" + userName + "') " +
                "ORDER BY u.UName;";

            MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);

            Queue<string> friendNames = SingleStringAttributeToQueue(cmd);

            CloseConnection(sqlConnection);

            return friendNames;
        }

        static MySqlConnection OpenConnection()
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

            return sqlConnection;
        }

        static void CloseConnection(MySqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static Queue<string> SingleStringAttributeToQueue(MySqlCommand command)
        {
            MySqlDataReader rdr = command.ExecuteReader();

            Queue<string> items = new Queue<string>();

            while (rdr.Read())
            {
                items.Enqueue(rdr[0].ToString());
            }

            return items;
        }

        static Queue<string> DoubleAttributeToSingleStringQueue(MySqlCommand command)
        {
            MySqlDataReader rdr = command.ExecuteReader();

            Queue<string> items = new Queue<string>();

            while (rdr.Read())
            {
                items.Enqueue(rdr[0].ToString() + "," + rdr[1].ToString());
            }

            return items;
        }
    }
}
