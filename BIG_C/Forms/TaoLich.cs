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
using System.Data.SqlClient;

namespace BIG_C.Forms
{
    public partial class TaoLich : Form
    {
        SqlConnection connection = null;
        public NhanVien nhanvien = null;
        
        public TaoLich()
        {
            InitializeComponent();
        }

        public TaoLich(NhanVien nv)
        {
            nhanvien = nv;
            InitializeComponent();
        }

        private void TaoLich_Load(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            this.Text = nhanvien.TenNhanVien;
            txtMa.Text = nhanvien.MaNhanVien; ;
            txtTen.Text = nhanvien.TenNhanVien;
            dtNgaySinh.Value = nhanvien.NgaySinh;
            txtDiaChi.Text = nhanvien.DiaChi;
            txtSDT.Text = nhanvien.SDT;
            txtCCCD.Text = nhanvien.CCCD;
            dtNgayVaoLam.Value = nhanvien.NgayVaoLam;
            txtSoNgayLam.Text = nhanvien.SoNgayLam.ToString();
            cboChiNhanh.Text = db.GetNameChiNhanh(nhanvien.MaChiNhanh);
            List<LichLam> lichLams = db.GetLichLams();
            lichLams = lichLams.Where(row => row.MaNhanVien == nhanvien.MaNhanVien).ToList();

            cboLichAll.Items.Clear();
            foreach (var item in lichLams)
            {
                cboLichAll.Items.Add(item.NgayLam);
            }
            cboCaLam.Items.Add("1");
            cboCaLam.Items.Add("2");
            cboCaLam.Items.Add("3");
            cboCaLam.Items.Add("4");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            if(connection==null)
            {
                connection = new SqlConnection(db.strcon);
            }    
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Lichlam values (@ma,@ngay,@ca)";
            cmd.Connection = connection;

            cmd.Parameters.Add("@ma", SqlDbType.Char).Value = nhanvien.MaNhanVien.TrimEnd();
            cmd.Parameters.Add("@ngay", SqlDbType.DateTime).Value = dtNgayLam.Value;
            cmd.Parameters.Add("@ca", SqlDbType.Int).Value = cboCaLam.Text.TrimEnd();

            int ret = cmd.ExecuteNonQuery();
            if(ret>0)
            {
                MessageBox.Show("Thêm thành cong!");
                cboCaLam.Text = "";
                List<LichLam> lichLams = db.GetLichLams();
                lichLams = lichLams.Where(row => row.MaNhanVien == nhanvien.MaNhanVien).ToList();

                cboLichAll.Items.Clear();
                foreach (var item in lichLams)
                {
                    cboLichAll.Items.Add(item.NgayLam);
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        public bool isTrungLichLam(DateTime dt)
        {
            CompanyDB db = new CompanyDB();
            List<LichLam> lichLams = db.GetLichLams();
            foreach(var item  in lichLams)
            {
                if(item.NgayLam.Day==dt.Day&&item.NgayLam.Month == dt.Month &&item.NgayLam.Year == dt.Year)
                {
                    return false;
                }    
            }
            return true;
        }

        private void dtNgayLam_ValueChanged(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            if (!isTrungLichLam(dtNgayLam.Value))
            {
                MessageBox.Show("Trùng lịch rồi!");
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
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete LichLam where NgayLam = @ngay";
            cmd.Connection = connection;

            cmd.Parameters.Add("@ngay", SqlDbType.DateTime).Value = dtNgayLam.Value;

            int ret = cmd.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Xóa thành cong!");
                cboCaLam.Text = "";
                cboLichAll.Text = "";
                dtNgayLam.Value = DateTime.Now;
                List<LichLam> lichLams = db.GetLichLams();
                lichLams = lichLams.Where(row => row.MaNhanVien == nhanvien.MaNhanVien).ToList();

                cboLichAll.Items.Clear();
                foreach (var item in lichLams)
                {
                    cboLichAll.Items.Add(item.NgayLam);
                }
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void cboLichAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            dtNgayLam.Value = DateTime.Parse(cboLichAll.SelectedItem.ToString());
            List<LichLam> lichLams = db.GetLichLams();
            LichLam lichLam = lichLams.Where(row => row.NgayLam == DateTime.Parse(cboLichAll.SelectedItem.ToString())).FirstOrDefault();
            cboCaLam.Text = lichLam.CaLam.ToString();
        }
    }
}
