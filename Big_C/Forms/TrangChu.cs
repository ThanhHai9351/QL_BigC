using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Big_C.UserControls;
using Big_C.Model;
using System.Data.SqlClient;

namespace Big_C
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            Home hm = new Home();
            addUserControl(hm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (btnChamCong.BackColor == Color.Tan)
            {
                btnHome.BackColor = Color.Tan;
                btnChamCong.BackColor = Color.PaleTurquoise;
                btnQLHangKho.BackColor = Color.Tan;
                btnQuanLyLichLam.BackColor = Color.Tan;
                btnQLNhanSu.BackColor = Color.Tan;
                btnSupport.BackColor = Color.Tan;
            }
            ChamCong cc = new ChamCong();
            addUserControl(cc);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(btnHome.BackColor == Color.Tan)
            {
                btnHome.BackColor = Color.PaleTurquoise;
                btnChamCong.BackColor = Color.Tan;
                btnQLHangKho.BackColor = Color.Tan;
                btnQuanLyLichLam.BackColor = Color.Tan;
                btnQLNhanSu.BackColor = Color.Tan;
                btnSupport.BackColor = Color.Tan;
            }
            Home hm = new Home();
            addUserControl(hm);
        }

        private void btnQLHangKho_Click(object sender, EventArgs e)
        {
            if (btnQLHangKho.BackColor == Color.Tan)
            {
                btnHome.BackColor = Color.Tan;
                btnChamCong.BackColor = Color.Tan;
                btnQLHangKho.BackColor = Color.PaleTurquoise;
                btnQuanLyLichLam.BackColor = Color.Tan;
                btnQLNhanSu.BackColor = Color.Tan;
                btnSupport.BackColor = Color.Tan;
            }
            QLHangKho qlhk = new QLHangKho();
            addUserControl(qlhk);

        }

        private void btnQuanLyLichLam_Click(object sender, EventArgs e)
        {
            if (btnQuanLyLichLam.BackColor == Color.Tan)
            {
                btnHome.BackColor = Color.Tan;
                btnChamCong.BackColor = Color.Tan;
                btnQLHangKho.BackColor = Color.Tan;
                btnQuanLyLichLam.BackColor = Color.PaleTurquoise;
                btnQLNhanSu.BackColor = Color.Tan;
                btnSupport.BackColor = Color.Tan;
            }
            LichLam lm = new LichLam();
            addUserControl(lm);
        }

        private void btnQLNhanSu_Click(object sender, EventArgs e)
        {
            if (btnQLNhanSu.BackColor == Color.Tan)
            {
                btnHome.BackColor = Color.Tan;
                btnChamCong.BackColor = Color.Tan;
                btnQLHangKho.BackColor = Color.Tan;
                btnQuanLyLichLam.BackColor = Color.Tan;
                btnQLNhanSu.BackColor = Color.PaleTurquoise;
                btnSupport.BackColor = Color.Tan;
            }
            QLNhanSu qlns = new QLNhanSu();
            addUserControl(qlns);
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            if (btnSupport.BackColor == Color.Tan)
            {
                btnHome.BackColor = Color.Tan;
                btnChamCong.BackColor = Color.Tan;
                btnQLHangKho.BackColor = Color.Tan;
                btnQuanLyLichLam.BackColor = Color.Tan;
                btnQLNhanSu.BackColor = Color.Tan;
                btnSupport.BackColor = Color.PaleTurquoise;
            }
            Suppport sp = new Suppport();
            addUserControl(sp);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }


        List<NhanVien> lnv = new List<NhanVien>();
        string strcon = "SERVER = THANHHAI; DATABASE = QL_BigC; Integrated Security = TRUE";
        SqlConnection connection = null;
        private void QLNhanSu_Load(object sender, EventArgs e)
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

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
