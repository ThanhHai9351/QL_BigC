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

namespace Big_C.UserControls
{
    public partial class EnterOrder : UserControl
    {
        public EnterOrder()
        {
            InitializeComponent();
        }

        List<NhaCungCap> lncc = new List<NhaCungCap>();
        List<HangHoa> lhh = new List<HangHoa>();
        string strcon = "SERVER = THANHHAI; DATABASE = QL_BigC; Integrated Security = TRUE";
        SqlConnection connection = null;
       
        private void EnterOrder_Load(object sender, EventArgs e)
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
            command.CommandText = "Select * from NhaCungCap";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNhaCungCap = reader.GetString(0);
                ncc.TenNhaCungCap = reader.GetString(1);
                ncc.DiaChi = reader.GetString(2);
                cbo_NhaCC.Items.Add(reader.GetString(1));
                lncc.Add(ncc);
            }
            reader.Close();
        }

        private void cbo_NhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_TenHH.Enabled = true;
            string mancc = "";
            foreach(NhaCungCap ncc in lncc)
            {
                if(ncc.TenNhaCungCap == cbo_NhaCC.SelectedItem.ToString())
                {
                    mancc = ncc.MaNhaCungCap;
                }
            }
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
            command.CommandText = "Select * from HangHoa where MaNhaCungCap = @mancc";
            command.Connection = connection;
            command.Parameters.Add("@mancc", SqlDbType.Char).Value = mancc.TrimEnd();
            SqlDataReader reader = command.ExecuteReader();
            cbo_TenHH.Items.Clear();
            while (reader.Read())
            {
                HangHoa hh = new HangHoa();
                hh.MaHangHoa = reader.GetString(0);
                hh.TenHangHoa = reader.GetString(1);
                hh.DonGia = reader.GetInt32(2);
                hh.MaNhaCungCap = reader.GetString(3);
                cbo_TenHH.Items.Add(reader.GetString(1));
                lhh.Add(hh);
            }
            reader.Close();
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if(cbo_TenHH.SelectedItem == null)
            {
                return;
            }
            else
            {
                string mahh = "";
                foreach (HangHoa hh in lhh)
                {
                    if (hh.TenHangHoa == cbo_TenHH.SelectedItem.ToString())
                    {
                        mahh = hh.MaHangHoa;
                    }
                }
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
                command.CommandText = "Select * from HangHoa where MaHangHoa = @mahh";
                command.Connection = connection;
                command.Parameters.Add("@mahh", SqlDbType.Char).Value = mahh.TrimEnd();


                SqlDataReader reader = command.ExecuteReader();
                int giatien = 1;
                int soluong = int.Parse(txtSoLuong.Text);
                if (reader.Read())
                {
                    giatien = reader.GetInt32(2);
                }
                txtTongTien.Text = (giatien * soluong) + "";
                reader.Close();
            }
        }
    }
}
