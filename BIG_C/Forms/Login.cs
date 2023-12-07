using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIG_C.Models;

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
            if(txtUser.Text == ""||txtPass.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập đủ các trường!");
            }
            else if(cboIsNhanVien.Checked)
            {
                CompanyDB db = new CompanyDB();
                if(db.checkIsvalidAccount(txtUser.Text.TrimEnd(),txtPass.Text.TrimEnd()))
                {
                    FormUser frm = new FormUser(txtUser.Text.TrimEnd());
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ!");
                }
            }else if(!cboIsNhanVien.Checked)
            {
                if(txtUser.Text.TrimEnd()=="admin"&&txtPass.Text.TrimEnd()=="admin123")
                {
                    FormAdmin frm = new FormAdmin();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ!");
                }
            }
        }
       

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cboIsAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
