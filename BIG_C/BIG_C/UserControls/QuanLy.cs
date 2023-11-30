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
    public partial class QuanLy : UserControl
    {
        public QuanLy()
        {
            InitializeComponent();
        }
      
        private void lvNhanVien_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvNhanVien_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.Bounds); 
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.Black);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            lvNhanVien.OwnerDraw = true;
            CompanyDB db = new CompanyDB();
            List<NhanVien> nhanViens = db.GetNhanViens();
            lvNhanVien.Items.Clear();
            foreach(var item in nhanViens)
            {
                ListViewItem item1 = new ListViewItem(item.MaNhanVien);
                item1.SubItems.Add(item.TenNhanVien);
                item1.SubItems.Add(item.NgaySinh.ToString());
                item1.SubItems.Add(item.DiaChi);
                item1.SubItems.Add(item.SDT);
                item1.SubItems.Add(item.CCCD);
                item1.SubItems.Add(item.NgayVaoLam.ToString());
                item1.SubItems.Add(item.SoNgayLam.ToString());
                item1.SubItems.Add(db.GetNameChiNhanh(item.MaChiNhanh));
                lvNhanVien.Items.Add(item1);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
