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
using Big_C.Model;

namespace Big_C
{
    public partial class ChamLuong : Form
    {
        public ChamLuong()
        {
            InitializeComponent();
        }

        List<NhanVien> lnv = new List<NhanVien>();
        string strcon = "SERVER = THANHHAI; DATABASE = QL_BigC; Integrated Security = TRUE";
        SqlConnection connection = null;
        private void ChamLuong_Load(object sender, EventArgs e)
        {
            if(connection == null)
            {
                connection = new SqlConnection(strcon);
            }    
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from NhanVien";
            command.Connection = connection; 
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhanVien nv = new NhanVien();
                nv.maNV = reader.GetString(0);
                nv.tenNV = reader.GetString(1);
                nv.NgaySinh = reader.GetDateTime(2);
                nv.diaChi = reader.GetString(3);
                nv.SDT = reader.GetString(4);
                nv.CCCD = reader.GetString(5);
                nv.ngayVaoLam = reader.GetDateTime(6);
                nv.soNgayLam = reader.GetInt32(7);
                nv.maQuanLy = reader.GetString(8);
                lnv.Add(nv);
            }
            reader.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắc muốn thanh toán lương?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No)
            {
                MessageBox.Show("Bạn đã từ chối!");
            }
            else
            {
                MessageBox.Show("Bạn đã thanh toán lương!");
                txtMa.Text = "";
                txtMa.Focus();
                txtCCCD.Text = "";
                txtName.Text = "";
                txtSoGioLam.Text = "";
                txtPhone.Text = "";
                txtTongLuong.Text = "";
            }
            
        }

        private void txtSoGioLam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from NhanVien where MaNhanVien = @ma";
            command.Connection = connection;

            command.Parameters.Add("@ma",SqlDbType.Char).Value = txtMa.Text;

            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                txtName.Text = reader.GetString(1);
                txtCCCD.Text = reader.GetString(5);
                txtPhone.Text = reader.GetString(4);
                txtSoGioLam.Text = reader.GetInt32(7) + "";
                 txtTongLuong.Text = (int.Parse(txtSoGioLam.Text) * 24000) + "";
            }
            else
            {
                MessageBox.Show("Không có nhân viên này , vào xem tất cả nhân viên đê!");
                txtMa.Text = "";
                txtMa.Focus();
                txtCCCD.Text = "";
                txtName.Text = "";
                txtSoGioLam.Text = "";
                txtPhone.Text = "";
                txtTongLuong.Text = "";
            }
            reader.Close();
             
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            ChiTietNhanVien frmchitiet = new ChiTietNhanVien();
            frmchitiet.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
