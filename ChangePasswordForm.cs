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
        List<User> list = new List<User>();
        public ChangePasswordForm()
        {
            InitializeComponent();
            list = LoadFromDB.loadData();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtOld.Text;
            
        }
    }
}
