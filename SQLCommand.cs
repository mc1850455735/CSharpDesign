using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace CSharpDesign
{
    internal static class SQLCommand
    {
        public static bool ExecuteCommand(string sql)
        {
            string connString = Properties.Resources.connString;

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command;
            command = new MySqlCommand(sql, conn);

            conn.Open();

            command.CommandText = sql;
            try
            {
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
    }
}
