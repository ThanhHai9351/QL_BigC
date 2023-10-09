using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Big_C.Model;
using Big_C.Forms;

namespace Big_C.UserControls
{
    public partial class QLNhanSu : UserControl
    {
        public QLNhanSu()
        {
            InitializeComponent();
        }

        List<NhanVien> lnv = new List<NhanVien>();
        string strcon = "SERVER = ADUMOIMOIMOI; DATABASE = QL_BigC; Integrated Security = TRUE";
        SqlConnection connection = null;
        private void QLNhanSu_Load(object sender, EventArgs e)
        {
            
        }

        private void dtGrView_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
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

        private void btnCreateNV_Click(object sender, EventArgs e)
        {
            CreateNV cr = new CreateNV();
            cr.Show();
        }

        private void btnEditDeleteNV_Click(object sender, EventArgs e)
        {
            EditRemoveNhanVien form = new EditRemoveNhanVien();
            form.Show();
        }

        private void QLNhanSu_Load_1(object sender, EventArgs e)
        {

        }
    }

}
