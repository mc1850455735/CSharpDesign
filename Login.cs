using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CSharpDesign
{
    public partial class Login : Form
    {
        string sql;
        string connString = Properties.Resources.connString;

        MySqlConnection conn;
        MySqlCommand command;
        MySqlDataReader reader;
        public Login()
        {
            InitializeComponent();
        }

        private void preForm_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connString);
            command = new MySqlCommand();
            command.Connection = conn;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            bool isAdmin;

            conn.Open();
            sql = string.Format("select * from usertable where username = '{0}' and password = '{1}';",
                username, password);
            command.CommandText = sql;
            try
            {
                reader = command.ExecuteReader();
                reader.Read();
                isAdmin = bool.Parse(reader["isAdmin"].ToString());
                if (isAdmin)
                    new AdminForm().Show();
                else
                    new UserForm().Show();
                this.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("未找到用户");
            }
            finally
            { conn.Close(); }
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm().ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
