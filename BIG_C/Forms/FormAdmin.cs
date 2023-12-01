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

namespace BIG_C.Forms
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
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

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Home frm = new Home();
            addUserControl(frm);
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            QuanLy frm = new QuanLy();
            addUserControl(frm);
        }

        private void btnLichLam_Click(object sender, EventArgs e)
        {
            LichLams frm = new LichLams();
            addUserControl(frm);
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            Store frm = new Store();
            addUserControl(frm);
        }
    }
}
