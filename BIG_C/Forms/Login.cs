using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIG_C.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(cboIsAdmin.Checked)
            {
                if(txtUser.Text.TrimEnd()=="admin"&&txtPass.Text.TrimEnd()=="123")
                {
                    FormAdmin frm = new FormAdmin();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu");
                }
            }
            else
            {
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu!");
            }    
        }
    }
}
