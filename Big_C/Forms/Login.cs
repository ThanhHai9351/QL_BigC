﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_C
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Bạn có chắc muốn thoát!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin!");
            }
            else if (txtUser.Text != "admin" || txtPass.Text != "123")
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản!");
            }
            if (txtUser.Text == "admin" && txtPass.Text == "123")
            {
                TrangChu frm = new TrangChu();
                frm.Show();
                this.Hide();
            }

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (txtUser.Text == "")
            {
                this.errorProvider1.SetError(ctr, "Bạn không được để trống trường này!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (txtPass.Text == "")
            {
                this.errorProvider1.SetError(ctr, "Bạn không được để trống trường này!");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

      
    }
}
