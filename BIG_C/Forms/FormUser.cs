using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIG_C.UserControls;
using BIG_C.Forms;

namespace BIG_C.Forms
{
    public partial class FormUser : Form
    {
        string manv = null;
        public FormUser()
        {
            InitializeComponent();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public FormUser(string id)
        {
            manv = id;
            InitializeComponent();
        }

        private void FormUser1_Load(object sender, EventArgs e)
        {
            HomePageNhanVien frm = new HomePageNhanVien(manv);
            addUserControl(frm);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePageNhanVien frm = new HomePageNhanVien(manv);
            addUserControl(frm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            LuongUser frm = new LuongUser(manv);
            addUserControl(frm);
        }

        private void btnLichLam_Click(object sender, EventArgs e)
        {
            LichLamUser frm = new LichLamUser(manv);
            addUserControl(frm);
        }

        private void btnLichSuBan_Click(object sender, EventArgs e)
        {
            PhieuBanUser frm = new PhieuBanUser(manv);
            addUserControl(frm);
        }
    }
}
