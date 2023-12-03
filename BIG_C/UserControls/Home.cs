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
using System.Windows.Forms.DataVisualization.Charting;

namespace BIG_C.UserControls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            TaiKhoan tk = db.GetTaiKhoan();
            lbGiaTien.Text = tk.SoDu + "";
            Chart chart = new Chart();
            chart.Size = new System.Drawing.Size(400, 300);

            // Thêm biểu đồ vào Form
            this.Controls.Add(chart);

            // Tạo một chuỗi giá trị
            string[] categories = new string[] { "Tuổi 18", "Tuổi 20", "Tuổi 25", "Tuổi 26", "Tuổi 30" };
            int[] values = new int[] { 35, 20, 30, 25, 40 };

            // Tạo loại biểu đồ cột
            Series series = new Series("Số Nhân Viên");
            series.ChartType = SeriesChartType.Column;

            // Thêm các giá trị vào chuỗi biểu đồ
            for (int i = 0; i < categories.Length; i++)
            {
                series.Points.AddXY(categories[i], values[i]);
            }

            // Thêm chuỗi biểu đồ vào biểu đồ
            chart1.Series.Add(series);
            lbSoTonKho.Text = db.GetSoSPTrongKho().ToString();
            lbTienMua.Text = db.GetSoTienDaDat().ToString();
            lbSoSPBan.Text = db.GetSoSPDaBan().ToString();
            lbTienBan.Text = db.GetSoTienDaBan().ToString();
            lbLuong.Text = db.GetAllLuongNhanVien().ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void lbGiaTien_Click(object sender, EventArgs e)
        {

        }
    }
}
