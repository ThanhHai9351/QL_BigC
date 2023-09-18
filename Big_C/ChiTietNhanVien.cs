using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Big_C.Model;
using System.Data.SqlClient;
namespace Big_C
{
    public partial class ChiTietNhanVien : Form
    {
        public ChiTietNhanVien()
        {
            InitializeComponent();
        }

        private void dtGrView_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        List<NhanVien> lnv = new List<NhanVien>();
        string strcon = "SERVER = THANHHAI; DATABASE = QL_BigC; Integrated Security = TRUE";
        SqlConnection connection = null;
        private void ChiTietNhanVien_Load(object sender, EventArgs e)
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
            reader.Close();

            dtGrView_NhanVien.DataSource = lnv;
        }
    }
}
