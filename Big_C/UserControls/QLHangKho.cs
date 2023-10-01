using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_C.UserControls
{
    public partial class QLHangKho : UserControl
    {
        public QLHangKho()
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

        private void QLHangKho_Load(object sender, EventArgs e)
        {
            ViewOrder frm = new ViewOrder();
            addUserControl(frm);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            EnterOrder frm = new EnterOrder();
            addUserControl(frm);
        }

        private void btnSeeOrder_Click(object sender, EventArgs e)
        {
            ViewOrder frm = new ViewOrder();
            addUserControl(frm);
        }

        private void btnCreateNV_Click(object sender, EventArgs e)
        {
            TonKho frm = new TonKho();
            addUserControl(frm);
        }


    }
}
