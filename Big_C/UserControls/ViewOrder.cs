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
using Big_C.UserControls;

namespace Big_C.UserControls
{
    public partial class ViewOrder : UserControl
    {
        public ViewOrder()
        {
            InitializeComponent();
        }

        string strcon = "SERVER = THANHHAI; DATABASE = QL_BigC; Integrated Security = TRUE";
        SqlConnection connection = null;

        private void ViewOrder_Load(object sender, EventArgs e)
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
            command.CommandText = "select MaPhieu,MaNhaCungCap from PhieuMuaHang Group by MaPhieu,MaNhaCungCap";
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            int widthY = 0;
            while(reader.Read())
            {
                Button btnMaPhieu = new Button();
                btnMaPhieu.Name = reader.GetString(0);
                btnMaPhieu.Text = reader.GetString(0);
                btnMaPhieu.Location = new Point(100,widthY);
                btnMaPhieu.Size = new Size(500,30);
                btnMaPhieu.Click += new EventHandler(btnMaPhieu_Click);
                this.Controls.Add(btnMaPhieu);
                widthY += 35;
            }
            reader.Close();
        }

        private void btnMaPhieu_Click(object sender, EventArgs e)
        {
            Button clickButton = sender as Button;
            string ma = clickButton.Name.TrimEnd();
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
            command.CommandText = "select * from PhieuMuaHang where MaPhieu = @maphieu";
            command.Connection = connection;

            command.Parameters.Add("@maphieu", SqlDbType.Char).Value = ma;
            string str = "\tMa Phiếu: " + clickButton.Name.TrimEnd();
            int money = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                str += "\n------------------------";
                str += "\nMã Hàng Hóa: " + reader.GetString(1);
                str += "\nMã Nhà Cung Cấp: " + reader.GetString(2);
                str += "\nNgày đặt: " + reader.GetDateTime(3).ToString();
                str += "\nNgày giao: " + reader.GetDateTime(4).ToString();
                str += "\nSố Lượng: " + reader.GetInt32(5);
                str += "\nTổng Tiền: " + reader.GetInt32(6);
                str += "\nMô tả: " + reader.GetString(7);
                money += reader.GetInt32(6);
            }
            reader.Close();
            str += "\n----------------------------------" + "\n\tTổng hóa đơn: " +money ;
            MessageBox.Show(str);
        }
    }
}
