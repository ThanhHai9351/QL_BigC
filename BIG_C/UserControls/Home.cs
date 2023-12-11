using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BIG_C.Models;
using System.Windows.Forms.DataVisualization.Charting;

namespace BIG_C.UserControls
{
    public partial class Home : UserControl
    {
        CompanyDB db = new CompanyDB();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lvLuong.Items.Clear();
            lvHangHoa.Items.Clear();
            lvDanhThu.Items.Clear();
            List<CanDoi> candoiHangHoa = db.GetCanDoiHangHoa();
            List<CanDoi> candoiDanhThu = db.GetCanDoiDanhThu();
            List<CanDoi> candoiLuong = db.GetCanDoiLuong();
            List<TaiKhoan> tks = db.GetTaiKhoan();
            TaiKhoan taiKhoanHH = db.GetTaiKhoan().Where(row => row.MaTaiKhoan.TrimEnd() == "156").FirstOrDefault();
            TaiKhoan taiKhoanDT = db.GetTaiKhoan().Where(row => row.MaTaiKhoan.TrimEnd() == "511").FirstOrDefault();
            TaiKhoan taiKhoanLuong = db.GetTaiKhoan().Where(row => row.MaTaiKhoan.TrimEnd() == "334").FirstOrDefault();
            lbCanDoiHH.Text = taiKhoanHH.SoDu.ToString();
            lbCanDoiDT.Text = taiKhoanDT.SoDu.ToString();
            lbCanDoiLuong.Text = taiKhoanLuong.SoDu.ToString();
            foreach (var item in candoiHangHoa)
            {
                ListViewItem item1 = new ListViewItem(db.GetNameHangHoa(item.ID.TrimEnd()));
                item1.SubItems.Add(item.Money.ToString());
                item1.SubItems.Add(item.Money.ToString());
                lvHangHoa.Items.Add(item1);
            }
            foreach (var item in candoiDanhThu)
            {
                ListViewItem item1 = new ListViewItem(db.GetNameHangHoa(item.ID.TrimEnd()));
                item1.SubItems.Add(item.Money.ToString());
                item1.SubItems.Add(item.Money.ToString());
                lvDanhThu.Items.Add(item1);
            }
            foreach (var item in candoiLuong)
            {
                ListViewItem item1 = new ListViewItem(db.GetNameNhanVien(item.ID.TrimEnd()));
                item1.SubItems.Add(item.Money.ToString());
                item1.SubItems.Add(item.Money.ToString());
                lvLuong.Items.Add(item1);
            }
            lbSoTonKho.Text = db.GetSoSPTrongKho().ToString();
            lbTienMua.Text = db.GetSoTienDaDat().ToString();
            lbSoSPBan.Text = db.GetSoSPDaBan().ToString();
            lbTienBan.Text = db.GetSoTienDaBan().ToString();
            lbLuong.Text = db.GetAllLuongNhanVien().ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void lbGiaTien_Click(object sender, EventArgs e)
        {

        }

        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
