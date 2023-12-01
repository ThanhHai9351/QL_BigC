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
using BIG_C.Forms;

namespace BIG_C.UserControls
{
    public partial class LichLams : UserControl
    {

        SqlConnection connection = null;
        public LichLams()
        {
            InitializeComponent();
        }

        private void lvNhanVien_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;

        }


        private void lvLichLam_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.Bounds);
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.Black);
        }

        private void lvLichLam_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;

        }

        private void lvNhanVien_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.Bounds);
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.Black);
        }

        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LichLam_Load(object sender, EventArgs e)
        {
            lvNhanVien.OwnerDraw = true;
            CompanyDB db = new CompanyDB();
            List<NhanVien> nhanViens = db.GetNhanViens();
            List<ChiNhanh> chiNhanhs = db.GetChiNhanhs();
            lvNhanVien.Items.Clear();
            foreach (var item in nhanViens)
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
            cbo_ChiNhanh.Items.Clear();
            foreach (var item in chiNhanhs)
            {
                cbo_ChiNhanh.Items.Add(item.TenChiNhanh);
            }
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            if (lvNhanVien.SelectedItems.Count  > 0)
            {
                string ma = "";
                ma = lvNhanVien.SelectedItems[0].SubItems[0].Text.TrimEnd();
                List<LichLam> lichLams = db.GetLichLams();
                lichLams = lichLams.Where(row => row.MaNhanVien.TrimEnd() == ma).ToList();
                lvLichLam.Items.Clear();
                foreach (var item in lichLams)
                {
                    ListViewItem item1 = new ListViewItem(item.NgayLam.ToString());
                    if (item.CaLam == 1)
                    {
                        item1.SubItems.Add("X");
                        item1.SubItems.Add("");
                        item1.SubItems.Add("");
                        item1.SubItems.Add("");
                    }
                    if (item.CaLam == 2)
                    {
                        item1.SubItems.Add("");
                        item1.SubItems.Add("X");
                        item1.SubItems.Add("");
                        item1.SubItems.Add("");
                    }
                    if (item.CaLam == 3)
                    {
                        item1.SubItems.Add("");
                        item1.SubItems.Add("");
                        item1.SubItems.Add("X");
                        item1.SubItems.Add("");
                    }
                    if (item.CaLam == 4)
                    {
                        item1.SubItems.Add("");
                        item1.SubItems.Add("");
                        item1.SubItems.Add("");
                        item1.SubItems.Add("X");
                    }
                    lvLichLam.Items.Add(item1);
                }
                if (MessageBox.Show("Mở lịch cho nhân viên " + db.GetNameNhanVien(lvNhanVien.SelectedItems[0].SubItems[0].Text), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<NhanVien> nhanViens = db.GetNhanViens();
                    NhanVien nv = nhanViens.Where(row => row.MaNhanVien.TrimEnd() == lvNhanVien.SelectedItems[0].SubItems[0].Text.TrimEnd()).FirstOrDefault();
                    TaoLich frm = new TaoLich(nv);
                    frm.ShowDialog();
                }
            }   
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<NhanVien> nhanViens = db.GetNhanViens();
            List<ChiNhanh> chiNhanhs = db.GetChiNhanhs();
            lvNhanVien.Items.Clear();
            foreach (var item in nhanViens)
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
            cbo_ChiNhanh.Items.Clear();
            foreach (var item in chiNhanhs)
            {
                cbo_ChiNhanh.Items.Add(item.TenChiNhanh);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!");
            }
            else
            {
                List<NhanVien> nhanViens = new List<NhanVien>();
                if (connection == null)
                {
                    connection = new SqlConnection(db.strcon);
                }
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from NhanVien where TenNhanVien LIKE N'%" + txtSearch.Text.TrimEnd() + "%'";
                command.Connection = connection;

                lvNhanVien.Items.Clear();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetDateTime(2).ToString());
                    item.SubItems.Add(reader.GetString(3));
                    item.SubItems.Add(reader.GetString(4));
                    item.SubItems.Add(reader.GetString(5));
                    item.SubItems.Add(reader.GetDateTime(6).ToString());
                    item.SubItems.Add(reader.GetInt32(7).ToString());
                    item.SubItems.Add(reader.GetString(8));
                    lvNhanVien.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void cbo_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<NhanVien> nhanViens = new List<NhanVien>();
            if (connection == null)
            {
                connection = new SqlConnection(db.strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from NhanVien where MaChiNhanh = @ma";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = db.GetIDChiNhanh(cbo_ChiNhanh.Text);
            lvNhanVien.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetDateTime(2).ToString());
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetString(4));
                item.SubItems.Add(reader.GetString(5));
                item.SubItems.Add(reader.GetDateTime(6).ToString());
                item.SubItems.Add(reader.GetInt32(7).ToString());
                item.SubItems.Add(db.GetNameChiNhanh(reader.GetString(8)));
                lvNhanVien.Items.Add(item);
            }
            reader.Close();
        }
    }
}
