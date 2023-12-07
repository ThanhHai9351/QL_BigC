using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using BIG_C.Models;

namespace BIG_C.UserControls
{
    public partial class HomePageNhanVien : UserControl
    {
        public string manv = null;
        CompanyDB db = new CompanyDB();
        public HomePageNhanVien()
        {
            InitializeComponent();
        }

        public HomePageNhanVien(string id)
        {
            manv = id;
            InitializeComponent();
        }

        private void HomePageNhanVien_Load(object sender, EventArgs e)
        {
            lbName.Text = db.GetNameNhanVien(manv.TrimEnd());
            NhanVien nv = db.GetNhanViens().Where(row => row.MaNhanVien.TrimEnd() == manv.TrimEnd()).FirstOrDefault();
            txtMa.Text = nv.MaNhanVien;
            txtTen.Text = nv.TenNhanVien;
            dtNgaySinh.Value = nv.NgaySinh;
            txtDiaChi.Text = nv.DiaChi;
            txtSDT.Text = nv.SDT;
            txtCCCD.Text = nv.CCCD ;
            dtNgayVaoLam.Value = dtNgayVaoLam.Value;
            txtSoNgayLam.Text = nv.SoNgayLam + "";
            txtChiNhanh.Text=db.GetNameChiNhanh(nv.MaChiNhanh.TrimEnd());

        }


        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
