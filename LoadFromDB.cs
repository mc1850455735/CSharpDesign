using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesign
{
    internal static class LoadFromDB
    {
        static string connString = Properties.Resources.connString;
        
        public static List<User> loadData()
        {
            List<User> userList = new List<User>();
            string sql;

            MySqlConnection conn;
            MySqlCommand command;
            MySqlDataReader reader;

            conn = new MySqlConnection(connString);
            command = new MySqlCommand();
            command.Connection = conn;

            conn.Open();
            sql = "select * from usertable;";
            command.CommandText = sql;
            reader = command.ExecuteReader();
            string username;
            string password;
            bool isAdmin;
            while (reader.Read())
            {
                username = reader["username"].ToString();
                password = reader["password"].ToString();
                isAdmin = bool.Parse(reader["isAdmin"].ToString());
                User temp = new User(username, password, isAdmin);
                userList.Add(temp);
            }
            conn.Close();

            return userList;
        }
    }
}
