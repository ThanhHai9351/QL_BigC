﻿using System;
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
    public partial class CreateNV : Form
    {
        public CreateNV()
        {
            InitializeComponent();
        }

        List<NhanVien> lnv = new List<NhanVien>();
        string strcon = "SERVER = THANHHAI; DATABASE = QL_BigC; Integrated Security = TRUE";
        SqlConnection connection = null;

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

        private void CreateNV_Load(object sender, EventArgs e)
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

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Nhập mã nhân viên cần thêm đi má ơi!");
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
                    command.CommandText = "insert into NhanVien values (@ma,@ten,@ngaysinh,@diachi,@sdt,@cccd,@ngayvaolam,@songaylam,@maquanly)";
                    command.Connection = connection;

                    command.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();
                    command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtName.Text.TrimEnd();
                    command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = dt_NgaySinh.Value;
                    command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txtDiaChi.Text.TrimEnd();
                    command.Parameters.Add("@sdt", SqlDbType.Char).Value = txtPhone.Text.TrimEnd();
                    command.Parameters.Add("@cccd", SqlDbType.Char).Value = txtCCCD.Text.TrimEnd();
                    command.Parameters.Add("@ngayvaolam", SqlDbType.DateTime).Value = dt_NgayVaoLam.Value;
                    command.Parameters.Add("@songaylam", SqlDbType.Int).Value = int.Parse(txtSoGioLam.Text.TrimEnd());
                    command.Parameters.Add("@maquanly", SqlDbType.Char).Value = txtMaQuanLy.Text.TrimEnd();

                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        listView1.Items.Clear();
                        hienThiNhanVien();
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
        }
    }
}
