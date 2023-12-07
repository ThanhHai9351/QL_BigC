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

namespace BIG_C.UserControls
{
    public partial class LuongUser : UserControl
    {
        public string manv = null;
        CompanyDB db = new CompanyDB();
        public LuongUser()
        {
            InitializeComponent();
        }

        public LuongUser(string id)
        {
            manv = id;
            InitializeComponent();
        }

        private void lvPhieuLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPhieuLuong.SelectedItems.Count > 0)
            {
                txtMa.Text = lvPhieuLuong.SelectedItems[0].SubItems[0].Text;
                cboNhanVien.Text = lvPhieuLuong.SelectedItems[0].SubItems[1].Text;
                txtLuongCB.Text = lvPhieuLuong.SelectedItems[0].SubItems[2].Text;
                txtSoGioLam.Text = lvPhieuLuong.SelectedItems[0].SubItems[3].Text;
                txtSoGioTangCa.Text = lvPhieuLuong.SelectedItems[0].SubItems[4].Text;
                txtPhuCap.Text = lvPhieuLuong.SelectedItems[0].SubItems[5].Text;
                txtTroCap.Text = lvPhieuLuong.SelectedItems[0].SubItems[6].Text;
                dtDateLuong.Value = DateTime.Parse(lvPhieuLuong.SelectedItems[0].SubItems[8].Text);
                txtTongLuong.Text = lvPhieuLuong.SelectedItems[0].SubItems[7].Text;
                cbo_TrangThai.Text = lvPhieuLuong.SelectedItems[0].SubItems[9].Text;
            }
        }

        private void dtThangLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LuongUser_Load(object sender, EventArgs e)
        {
            List<PhieuLuong> pl = db.GetPhieuLuongs().Where(row => row.MaNhanVien.TrimEnd() == manv.TrimEnd()).ToList();
            lvPhieuLuong.Items.Clear();
            foreach (var item in pl)
            {
                ListViewItem item1 = new ListViewItem(item.MaPhieu);
                item1.SubItems.Add(db.GetNameNhanVien(item.MaNhanVien));
                item1.SubItems.Add(item.LuongHienTai.ToString());
                item1.SubItems.Add(item.SoGioLam.ToString());
                item1.SubItems.Add(item.SoGioTangCa.ToString());
                item1.SubItems.Add(item.PhuCap.ToString());
                item1.SubItems.Add(item.TroCap.ToString());
                item1.SubItems.Add(item.TongLuong.ToString());
                item1.SubItems.Add(item.ThangLuong.ToString());
                item1.SubItems.Add(item.TrangThai.ToString());
                lvPhieuLuong.Items.Add(item1);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            List<PhieuLuong> pl = db.GetPhieuLuongs().Where(row => row.MaNhanVien.TrimEnd() == manv.TrimEnd()).ToList();
            lvPhieuLuong.Items.Clear();
            foreach (var item in pl)
            {
                ListViewItem item1 = new ListViewItem(item.MaPhieu);
                item1.SubItems.Add(db.GetNameNhanVien(item.MaNhanVien));
                item1.SubItems.Add(item.LuongHienTai.ToString());
                item1.SubItems.Add(item.SoGioLam.ToString());
                item1.SubItems.Add(item.SoGioTangCa.ToString());
                item1.SubItems.Add(item.PhuCap.ToString());
                item1.SubItems.Add(item.TroCap.ToString());
                item1.SubItems.Add(item.TongLuong.ToString());
                item1.SubItems.Add(item.ThangLuong.ToString());
                item1.SubItems.Add(item.TrangThai.ToString());
                lvPhieuLuong.Items.Add(item1);
            }
        }
    }
}
