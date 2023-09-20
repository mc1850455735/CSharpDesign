using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpDesign
{
    public partial class ChangePasswordForm : Form
    {
        string sql;
        string connString = Properties.Resources.connString;

        MySqlConnection conn;
        MySqlCommand command;

        public ChangePasswordForm()
        {
            InitializeComponent();
            conn = new MySqlConnection(connString);
            command = new MySqlCommand();
            command.Connection = conn;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtOld.Text;
            string newpassword = txtNew.Text;

            sql = string.Format("update usertable set password = '{0}' where username = '{1}' and password = '{2}';",
                newpassword, username, password);

            if(SQLCommand.ExecuteCommand(sql))
            {
                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }

        private void ChangePasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
