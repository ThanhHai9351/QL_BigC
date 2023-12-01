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

namespace BIG_C.Forms
{
    public partial class OrderKho : Form
    {
        public SqlConnection connection = null;
        public OrderKho()
        {
            InitializeComponent();
        }

        private void lvKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            if (lvKho.SelectedItems.Count > 0)
            {
                txtMa.Text = lvKho.SelectedItems[0].SubItems[0].Text;
                cboChiNhanh.Text = lvKho.SelectedItems[0].SubItems[1].Text;
                cboHangHoa.Text = lvKho.SelectedItems[0].SubItems[2].Text;
                dtNgayDat.Value = DateTime.Parse(lvKho.SelectedItems[0].SubItems[3].Text);
                dtNgayGiao.Value = DateTime.Parse(lvKho.SelectedItems[0].SubItems[4].Text);
                txtSoLuong.Text = lvKho.SelectedItems[0].SubItems[5].Text;
                txtTongTien.Text = lvKho.SelectedItems[0].SubItems[6].Text;
                txtMoTa.Text = lvKho.SelectedItems[0].SubItems[7].Text;
            }
        }

        private void cbo_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
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
            command.CommandText = "Select * from PhieuMuaHang where MaChiNhanh = @ma";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = db.GetIDChiNhanh(cbo_ChiNhanh.Text.TrimEnd());
            lvKho.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item1 = new ListViewItem(reader.GetString(0));
                item1.SubItems.Add(db.GetNameChiNhanh(reader.GetString(1)));
                item1.SubItems.Add(db.GetNameHangHoa(reader.GetString(2)));
                item1.SubItems.Add(reader.GetDateTime(3).ToString());
                item1.SubItems.Add(reader.GetDateTime(4).ToString());
                item1.SubItems.Add(reader.GetInt32(5).ToString());
                item1.SubItems.Add(reader.GetInt32(6).ToString());
                item1.SubItems.Add(reader.GetString(7).ToString());
                lvKho.Items.Add(item1);
            }
            reader.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<HangHoa> hangHoas = db.GetHangHoas();
            List<ChiNhanh> chiNhanhs = db.GetChiNhanhs();
            List<PhieuMuaHang> phieuMuaHangs = db.GetPhieuMuaHangs();
            cboChiNhanh.Items.Clear();
            cbo_ChiNhanh.Items.Clear();
            foreach (var item in chiNhanhs)
            {
                cbo_ChiNhanh.Items.Add(item.TenChiNhanh);
                cboChiNhanh.Items.Add(item.TenChiNhanh);
            }
            cboHangHoa.Items.Clear();
            foreach (var item in hangHoas)
            {
                cboHangHoa.Items.Add(item.TenHangHoa);
            }
            lvKho.Items.Clear();
            foreach (var item in phieuMuaHangs)
            {
                ListViewItem item1 = new ListViewItem(item.MaPhieu);
                item1.SubItems.Add(db.GetNameChiNhanh(item.MaChiNhanh));
                item1.SubItems.Add(db.GetNameHangHoa(item.MaHangHoa));
                item1.SubItems.Add(item.NgayDat.ToString());
                item1.SubItems.Add(item.NgayGiao.ToString());
                item1.SubItems.Add(item.SoLuong.ToString());
                item1.SubItems.Add(item.TongTien.ToString());
                item1.SubItems.Add(item.MoTa);
                lvKho.Items.Add(item1);
            }
            txtMa.Text = "";
            cboChiNhanh.Text = "";
            cboHangHoa.Text = "";
            txtSoLuong.Text = "";
            txtTongTien.Text = "";
            txtMoTa.Text = "";
        }

        private void OrderKho_Load(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<HangHoa> hangHoas = db.GetHangHoas();
            List<ChiNhanh> chiNhanhs = db.GetChiNhanhs();
            List<PhieuMuaHang> phieuMuaHangs = db.GetPhieuMuaHangs();
            cboChiNhanh.Items.Clear();
            cbo_ChiNhanh.Items.Clear();
            foreach(var item in chiNhanhs)
            {
                cbo_ChiNhanh.Items.Add(item.TenChiNhanh);
                cboChiNhanh.Items.Add(item.TenChiNhanh);
            }
            cboHangHoa.Items.Clear();
            foreach(var item in hangHoas)
            {
                cboHangHoa.Items.Add(item.TenHangHoa);
            }
            lvKho.Items.Clear();
            foreach(var item in phieuMuaHangs)
            {
                ListViewItem item1 = new ListViewItem(item.MaPhieu);
                item1.SubItems.Add(db.GetNameChiNhanh(item.MaChiNhanh));
                item1.SubItems.Add(db.GetNameHangHoa(item.MaHangHoa));
                item1.SubItems.Add(item.NgayDat.ToString());
                item1.SubItems.Add(item.NgayGiao.ToString());
                item1.SubItems.Add(item.SoLuong.ToString());
                item1.SubItems.Add(item.TongTien.ToString());
                item1.SubItems.Add(item.MoTa);
                lvKho.Items.Add(item1);
            }
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
            command.CommandText = "insert into PhieuMuaHang values (@ma,@macn,@mahh,@nd,@ng,@sl,@tt,@mt)";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();
            command.Parameters.Add("@macn", SqlDbType.Char).Value = db.GetIDChiNhanh(cboChiNhanh.Text.TrimEnd());
            command.Parameters.Add("@mahh", SqlDbType.Char).Value = db.GetIDHangHoa(cboHangHoa.Text.TrimEnd());
            command.Parameters.Add("@nd", SqlDbType.DateTime).Value = dtNgayDat.Value;
            command.Parameters.Add("@ng", SqlDbType.DateTime).Value = dtNgayGiao.Value;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = int.Parse(txtSoLuong.Text.TrimEnd());
            command.Parameters.Add("@tt", SqlDbType.Int).Value = int.Parse(txtTongTien.Text);
            command.Parameters.Add("@mt", SqlDbType.NVarChar).Value = txtMoTa.Text.TrimEnd();

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Thêm thành công!");
                txtMa.Text = "";
                cboChiNhanh.Text = "";
                cboHangHoa.Text = "";
                txtSoLuong.Text = "";
                txtTongTien.Text = "";
                txtMoTa.Text = "";
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            command.CommandText = "delete PhieuMuaHang where MaPhieu = @ma";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();
            

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Xóa thành công!");
                txtMa.Text = "";
                cboChiNhanh.Text = "";
                cboHangHoa.Text = "";
                txtSoLuong.Text = "";
                txtTongTien.Text = "";
                txtMoTa.Text = "";
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            txtTongTien.Text = int.Parse(txtSoLuong.Text) * db.GetPriceHangHoa(db.GetIDHangHoa(cboHangHoa.Text.TrimEnd())) + ""; 
        }
    }
}
