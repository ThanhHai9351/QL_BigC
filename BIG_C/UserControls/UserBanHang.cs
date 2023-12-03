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

namespace BIG_C.UserControls
{
    public partial class UserBanHang : UserControl
    {
        public SqlConnection connection = null;
        public UserBanHang()
        {
            InitializeComponent();
        }

        private void UserBanHang_Load(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<HangHoa> hangHoas = db.GetHangHoas();
            List<NhanVien> nhanViens = db.GetNhanViens();
            List<PhieuBanHang> phieuBanHangs = db.GetPhieuBanHangs();
            cboHangHoa.Items.Clear();
            foreach (var item in hangHoas)
            {
                cboHangHoa.Items.Add(item.TenHangHoa);
            }
            cboNhanVien.Items.Clear();
            foreach(var item in nhanViens)
            {
                cboNhanVien.Items.Add(item.TenNhanVien);
            }    
            lvPhieuBan.Items.Clear();
            foreach (var item in phieuBanHangs)
            {
                ListViewItem item1 = new ListViewItem(item.MaPhieu);
                item1.SubItems.Add(db.GetNameHangHoa(item.MaHangHoa));
                item1.SubItems.Add(db.GetNameNhanVien(item.MaNhanVien));
                item1.SubItems.Add(item.NgayBan.ToString());
                item1.SubItems.Add(item.SoLuong.ToString());
                item1.SubItems.Add(item.TongTien.ToString());
                lvPhieuBan.Items.Add(item1);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu!");
            }
            else
            {
                List<PhieuBanHang> phieuBanHangs = new List<PhieuBanHang>();
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
                command.CommandText = "Select * from PhieuBanHang where MaPhieu LIKE N'%" + txtSearch.Text.TrimEnd() + "%'";
                command.Connection = connection;

                lvPhieuBan.Items.Clear();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(db.GetNameHangHoa(reader.GetString(1)));
                    item.SubItems.Add(db.GetNameNhanVien(reader.GetString(2)));
                    item.SubItems.Add(reader.GetDateTime(3).ToString());
                    item.SubItems.Add(reader.GetInt32(4).ToString());
                    item.SubItems.Add(reader.GetInt32(5).ToString());
                    lvPhieuBan.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<HangHoa> hangHoas = db.GetHangHoas();
            List<ChiNhanh> chiNhanhs = db.GetChiNhanhs();
            List<PhieuBanHang> phieuBanHangs = db.GetPhieuBanHangs();
            cboHangHoa.Items.Clear();
            foreach (var item in hangHoas)
            {
                cboHangHoa.Items.Add(item.TenHangHoa);
            }
            lvPhieuBan.Items.Clear();
            foreach (var item in phieuBanHangs)
            {
                ListViewItem item1 = new ListViewItem(item.MaPhieu);
                item1.SubItems.Add(db.GetNameHangHoa(item.MaHangHoa));
                item1.SubItems.Add(db.GetNameNhanVien(item.MaNhanVien));
                item1.SubItems.Add(item.NgayBan.ToString());
                item1.SubItems.Add(item.SoLuong.ToString());
                item1.SubItems.Add(item.TongTien.ToString());
                lvPhieuBan.Items.Add(item1);
            }
            txtSearch.Text = "";
            txtMa.Text = "";
            cboHangHoa.Text = "";
            cboNhanVien.Text = "";
            txtSoLuong.Text = "";
            txtTongTien.Text = "";
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            txtTongTien.Text = (int.Parse(txtSoLuong.Text) * db.GetPriceHangHoa(db.GetIDHangHoa(cboHangHoa.Text.TrimEnd())))*1.15 + "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
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
            command.CommandText = "insert into PhieuBanHang values (@ma,@mahh,@manv,@nb,@sl,@tt)";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();
            command.Parameters.Add("@mahh", SqlDbType.Char).Value = db.GetIDHangHoa(cboHangHoa.Text.TrimEnd());
            command.Parameters.Add("@manv", SqlDbType.Char).Value = db.GetIDNhanVien(cboNhanVien.Text.TrimEnd());
            command.Parameters.Add("@nb", SqlDbType.DateTime).Value = dtNgayBan.Value;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = int.Parse(txtSoLuong.Text.TrimEnd());
            command.Parameters.Add("@tt", SqlDbType.Int).Value = int.Parse(txtTongTien.Text);

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Thêm thành công!");
                txtMa.Text = "";
                cboHangHoa.Text = "";
                cboNhanVien.Text = "";
                txtSoLuong.Text = "";
                txtTongTien.Text = "";
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
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
            command.CommandText = "delete PhieuBanHang where MaPhieu = @ma";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();


            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Xóa thành công!");
                txtMa.Text = "";
                cboHangHoa.Text = "";
                cboNhanVien.Text = "";
                txtSoLuong.Text = "";
                txtTongTien.Text = "";
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void lvPhieuBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvPhieuBan.SelectedItems.Count > 0)
            {
                txtMa.Text = lvPhieuBan.SelectedItems[0].SubItems[0].Text.TrimEnd();
                cboHangHoa.Text = lvPhieuBan.SelectedItems[0].SubItems[1].Text.TrimEnd();
                cboNhanVien.Text = lvPhieuBan.SelectedItems[0].SubItems[2].Text.TrimEnd();
                dtNgayBan.Value = DateTime.Parse(lvPhieuBan.SelectedItems[0].SubItems[3].Text.TrimEnd());
                txtSoLuong.Text = lvPhieuBan.SelectedItems[0].SubItems[4].Text.TrimEnd();
                txtTongTien.Text = lvPhieuBan.SelectedItems[0].SubItems[5].Text.TrimEnd();
            }
        }
    }
}
