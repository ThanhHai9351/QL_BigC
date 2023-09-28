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

namespace Big_C.Forms
{
    public partial class EditRemoveNhanVien : Form
    {
        public EditRemoveNhanVien()
        {
            InitializeComponent();
        }

        List<NhanVien> lnv = new List<NhanVien>();
        string strcon = "SERVER = THANHHAI; DATABASE = QL_BigC; Integrated Security = TRUE";
        SqlConnection connection = null;

        private void EditRemoveNhanVien_Load(object sender, EventArgs e)
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

            foreach(NhanVien nv in lnv)
            {
                ListViewItem item = new ListViewItem(nv.maNV);
                item.SubItems.Add(nv.tenNV);
                item.SubItems.Add(nv.NgaySinh.ToString());
                item.SubItems.Add(nv.diaChi);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(nv.CCCD);
                item.SubItems.Add(nv.ngayVaoLam.ToString());
                item.SubItems.Add(nv.soNgayLam.ToString());
                item.SubItems.Add(nv.maQuanLy);
                listView1.Items.Add(item);
            }
            reader.Close();

        }

        public void hienThiNhanVien()
        {
            lnv = new List<NhanVien>();
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

            foreach (NhanVien nv in lnv)
            {
                ListViewItem item = new ListViewItem(nv.maNV);
                item.SubItems.Add(nv.tenNV);
                item.SubItems.Add(nv.NgaySinh.ToString());
                item.SubItems.Add(nv.diaChi);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(nv.CCCD);
                item.SubItems.Add(nv.ngayVaoLam.ToString());
                item.SubItems.Add(nv.soNgayLam.ToString());
                item.SubItems.Add(nv.maQuanLy);
                listView1.Items.Add(item);
            }
            reader.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string manv = listView1.SelectedItems[0].SubItems[0].Text;
                foreach(NhanVien nv in lnv)
                {
                    if(nv.maNV == manv)
                    {
                        txtMa.Text = nv.maNV;
                        txtName.Text = nv.tenNV;
                        txtDiaChi.Text = nv.diaChi;
                        txtPhone.Text = nv.SDT;
                        txtCCCD.Text = nv.CCCD;
                        txtSoGioLam.Text = nv.soNgayLam + "";
                    }    
                }    
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Nhập mã nhân viên cần xóa đi má ơi!");
                return;
            }
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {
                string id = txtMa.Text.TrimEnd();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Delete from NhanVien where MaNhanVien = @ma";
                command.Connection = connection;

                command.Parameters.Add("@ma", SqlDbType.Char).Value = id;

                
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    listView1.Items.Clear();
                    hienThiNhanVien();
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Nhập mã nhân viên cần sửa đi má ơi!");
                return;
            }
            else
            {
                if (connection == null)
                {
                    connection = new SqlConnection(strcon);
                }
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                else
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "Update NhanVien set TenNhanVien = @ten, DiaChi = @diachi, SDT = @sdt, CCCD = @cccd, SoNgayLam = @songaylam where MaNhanVien = @ma";
                    command.Connection = connection;

                    command.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();
                    command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtName.Text.TrimEnd();
                    command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txtDiaChi.Text.TrimEnd();
                    command.Parameters.Add("@sdt", SqlDbType.Char).Value = txtPhone.Text.TrimEnd();
                    command.Parameters.Add("@cccd", SqlDbType.Char).Value = txtCCCD.Text.TrimEnd();
                    command.Parameters.Add("@songaylam", SqlDbType.Int).Value = int.Parse(txtSoGioLam.Text.TrimEnd());



                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        listView1.Items.Clear();
                        hienThiNhanVien();
                        MessageBox.Show("Sửa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }

            }
        }
    }
}
