using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesign
{
    internal class User
    {
        private string username;
        private string password;
        private bool isAdmin;          // 0为用户,1为管理员

        public string Username => username;
        public string Password => password;
        public bool IsAdmin => isAdmin;

        public User(string username, string password, bool isAdmin)
        {
            this.username = username;
            this.password = password;
            this.isAdmin = isAdmin;
        }
    }
}
