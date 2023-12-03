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
    public partial class ChamCong : UserControl
    {
        public SqlConnection connection = null;
        public ChamCong()
        {
            InitializeComponent();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<PhieuLuong> phieuLuongs = db.GetPhieuLuongs();
            lvPhieuLuong.Items.Clear();
            foreach (var item in phieuLuongs)
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
            cboTrangThai.Text = "";
            txtMa.Text = "";
            cboChiNhanh.Text = "";
            cboNhanVien.Text = "";
            txtLuongCB.Text = "";
            txtSoGioLam.Text = "";
            txtSoGioTangCa.Text = "";
            txtPhuCap.Text = "";
            txtTroCap.Text = "";
            txtTongLuong.Text = "";
            cbo_TrangThai.Text = "";
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<PhieuLuong> phieuLuongs = db.GetPhieuLuongs();
            List<NhanVien> nhanViens = db.GetNhanViens();
            List<ChiNhanh> chiNhanhs = db.GetChiNhanhs();
            cbo_TrangThai.Items.Add("Yes");
            cbo_TrangThai.Items.Add("No");
            cboTrangThai.Items.Add("Yes");
            cboTrangThai.Items.Add("No");
            lvPhieuLuong.Items.Clear();
            foreach(var item in phieuLuongs)
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
            foreach(var item in nhanViens)
            {
                cboNhanVien.Items.Add(item.TenNhanVien);
            }
            foreach(var item in chiNhanhs)
            {
                cboChiNhanh.Items.Add(item.TenChiNhanh);
            }
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<PhieuLuong> phieuLuongs = db.GetPhieuLuongs();
            phieuLuongs = phieuLuongs.Where(row => row.TrangThai.TrimEnd() == cboTrangThai.Text.TrimEnd()).ToList();
            lvPhieuLuong.Items.Clear();
            foreach (var item in phieuLuongs)
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

        private void lvPhieuLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvPhieuLuong.SelectedItems.Count > 0)
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            if(cbo_TrangThai.Text.TrimEnd()=="Yes")
            {
                MessageBox.Show("Trạng thái lương dã được thanh toán");
            }
            else
            {
                if(connection == null)
                {
                    connection = new SqlConnection(db.strcon);
                }    
                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update PhieuLuong set TrangThai = 'Yes' where MaPhieu = @ma";
                cmd.Connection = connection;

                cmd.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();

                int ret = cmd.ExecuteNonQuery();
                if(ret > 0)
                {
                    MessageBox.Show("Thanh toán lương thành công cho nhân viên " + cboNhanVien.Text);
                    cboTrangThai.Text = "";
                    txtMa.Text = "";
                    cboChiNhanh.Text = "";
                    cboNhanVien.Text = "";
                    txtLuongCB.Text = "";
                    txtSoGioLam.Text = "";
                    txtSoGioTangCa.Text = "";
                    txtPhuCap.Text = "";
                    txtTroCap.Text = "";
                    txtTongLuong.Text = "";
                    cbo_TrangThai.Text = "";
                }
                else
                {
                    MessageBox.Show("Thanh toán lương thất bại!");
                }
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
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into PhieuLuong values (@ma,@manv,@luong,@shl,@sltc,@pc,@tc,@tl,@date,@tt)";
            cmd.Connection = connection;

            cmd.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();
            cmd.Parameters.Add("@manv", SqlDbType.Char).Value = db.GetIDNhanVien(cboNhanVien.Text.TrimEnd());
            cmd.Parameters.Add("@luong", SqlDbType.Int).Value = int.Parse(txtLuongCB.Text.TrimEnd());
            cmd.Parameters.Add("@shl", SqlDbType.Int).Value = int.Parse(txtSoGioLam.Text.TrimEnd());
            cmd.Parameters.Add("@sltc", SqlDbType.Int).Value = int.Parse(txtSoGioTangCa.Text.TrimEnd());
            cmd.Parameters.Add("@pc", SqlDbType.Int).Value = int.Parse(txtPhuCap.Text.TrimEnd());
            cmd.Parameters.Add("@tc", SqlDbType.Int).Value = int.Parse(txtTroCap.Text.TrimEnd());
            cmd.Parameters.Add("@tl", SqlDbType.Int).Value = int.Parse(txtTongLuong.Text.TrimEnd());
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dtDateLuong.Value;
            cmd.Parameters.Add("@tt", SqlDbType.Char).Value = cbo_TrangThai.Text.TrimEnd();


            int ret = cmd.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Tạo phiếu lương thành công!");
                cboTrangThai.Text = "";
                txtMa.Text = "";
                cboChiNhanh.Text = "";
                cboNhanVien.Text = "";
                txtLuongCB.Text = "";
                txtSoGioLam.Text = "";
                txtSoGioTangCa.Text = "";
                txtPhuCap.Text = "";
                txtTroCap.Text = "";
                txtTongLuong.Text = "";
                cbo_TrangThai.Text = "";
            }
            else
            {
                MessageBox.Show("Tạo phiếu lương thất bại!");
            }
        }

        private void txtTroCap_Leave(object sender, EventArgs e)
        {
            txtTongLuong.Text = (int.Parse(txtSoGioLam.Text) * int.Parse(txtLuongCB.Text)) + (int.Parse(txtSoGioTangCa.Text) * int.Parse(txtLuongCB.Text))+ int.Parse(txtPhuCap.Text) + int.Parse(txtTroCap.Text) + "";
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
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete PhieuLuong where MaPhieu = @ma";
            cmd.Connection = connection;

            cmd.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();

            int ret = cmd.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Xóa phiếu lương thành công!");
                cboTrangThai.Text = "";
                txtMa.Text = "";
                cboChiNhanh.Text = "";
                cboNhanVien.Text = "";
                txtLuongCB.Text = "";
                txtSoGioLam.Text = "";
                txtSoGioTangCa.Text = "";
                txtPhuCap.Text = "";
                txtTroCap.Text = "";
                txtTongLuong.Text = "";
                cbo_TrangThai.Text = "";
            }
            else
            {
                MessageBox.Show("Xóa phiếu lương thất bại!");
            }
        }
    }
}
