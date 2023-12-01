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

namespace BIG_C.UserControls
{
    public partial class QuanLy : UserControl
    {
        SqlConnection connection = null;

        public QuanLy()
        {
            InitializeComponent();
        }
      
        private void lvNhanVien_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvNhanVien_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DeepSkyBlue, e.Bounds); 
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.Black);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            if(txtSearch.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!");
            }
            else
            {
                List<NhanVien> nhanViens = new List<NhanVien>();
                if (connection == null)
                {
                    connection = new SqlConnection(db.strcon);
                }
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from NhanVien where TenNhanVien LIKE N'%"+ txtSearch.Text.TrimEnd() + "%'";
                command.Connection = connection;

                lvNhanVien.Items.Clear();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));
                    item.SubItems.Add(reader.GetString(1));
                    item.SubItems.Add(reader.GetDateTime(2).ToString());
                    item.SubItems.Add(reader.GetString(3));
                    item.SubItems.Add(reader.GetString(4));
                    item.SubItems.Add(reader.GetString(5));
                    item.SubItems.Add(reader.GetDateTime(6).ToString());
                    item.SubItems.Add(reader.GetInt32(7).ToString());
                    item.SubItems.Add(reader.GetString(8));
                    lvNhanVien.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            lvNhanVien.OwnerDraw = true;
            CompanyDB db = new CompanyDB();
            List<NhanVien> nhanViens = db.GetNhanViens();
            List<ChiNhanh> chiNhanhs = db.GetChiNhanhs();
            lvNhanVien.Items.Clear();
            foreach(var item in nhanViens)
            {
                ListViewItem item1 = new ListViewItem(item.MaNhanVien);
                item1.SubItems.Add(item.TenNhanVien);
                item1.SubItems.Add(item.NgaySinh.ToString());
                item1.SubItems.Add(item.DiaChi);
                item1.SubItems.Add(item.SDT);
                item1.SubItems.Add(item.CCCD);
                item1.SubItems.Add(item.NgayVaoLam.ToString());
                item1.SubItems.Add(item.SoNgayLam.ToString());
                item1.SubItems.Add(db.GetNameChiNhanh(item.MaChiNhanh));
                lvNhanVien.Items.Add(item1);
            }
            cbo_ChiNhanh.Items.Clear();
            cboChiNhanh.Items.Clear();
            foreach(var item in chiNhanhs)
            {
                cbo_ChiNhanh.Items.Add(item.TenChiNhanh);
                cboChiNhanh.Items.Add(item.TenChiNhanh);
            }
            txtSoNgayLam.Enabled = false;
            txtSDT.Enabled = false;
            txtCCCD.Enabled = false;
            cboChiNhanh.Enabled = false;
            dtNgayVaoLam.Enabled = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
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
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into NhanVien values (@ma,@ten,@ns,@dc,@sdt,@cccd,@ngaylam,@songaylam,@macn)";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTen.Text.TrimEnd();
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = dtNgaySinh.Value;
            command.Parameters.Add("@dc", SqlDbType.NVarChar).Value = txtDiaChi.Text.TrimEnd();
            command.Parameters.Add("@sdt", SqlDbType.Char).Value = txtSDT.Text.TrimEnd();
            command.Parameters.Add("@cccd", SqlDbType.Char).Value = txtCCCD.Text.TrimEnd();
            command.Parameters.Add("@ngaylam", SqlDbType.DateTime).Value = dtNgayVaoLam.Value;
            command.Parameters.Add("@songaylam", SqlDbType.Int).Value = int.Parse(txtSoNgayLam.Text.TrimEnd());
            command.Parameters.Add("@macn", SqlDbType.Char).Value = db.GetIDChiNhanh(cboChiNhanh.Text.TrimEnd());

            int ret = command.ExecuteNonQuery();
           if(ret>0)
            {
                MessageBox.Show("Thêm thành công!");
                txtSearch.Text = "";
                cbo_ChiNhanh.Text = "";
                txtSoNgayLam.Enabled = false;
                txtSDT.Enabled = false;
                txtCCCD.Enabled = false;
                cboChiNhanh.Enabled = false;
                dtNgayVaoLam.Enabled = false;
                txtMa.Enabled = true;
                txtMa.Text = "";
                txtTen.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtCCCD.Text = "";
                txtSoNgayLam.Text = "";
                cboChiNhanh.Text = "";
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void cbo_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<NhanVien> nhanViens = new List<NhanVien>();
            if (connection == null)
            {
                connection = new SqlConnection(db.strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from NhanVien where MaChiNhanh = @ma";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = db.GetIDChiNhanh(cbo_ChiNhanh.Text);
            lvNhanVien.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetDateTime(2).ToString());
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetString(4));
                item.SubItems.Add(reader.GetString(5));
                item.SubItems.Add(reader.GetDateTime(6).ToString());
                item.SubItems.Add(reader.GetInt32(7).ToString());
                item.SubItems.Add(db.GetNameChiNhanh(reader.GetString(8)));
                lvNhanVien.Items.Add(item);
            }
            reader.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<NhanVien> nhanViens = db.GetNhanViens();
            List<ChiNhanh> chiNhanhs = db.GetChiNhanhs();
            lvNhanVien.Items.Clear();
            foreach (var item in nhanViens)
            {
                ListViewItem item1 = new ListViewItem(item.MaNhanVien);
                item1.SubItems.Add(item.TenNhanVien);
                item1.SubItems.Add(item.NgaySinh.ToString());
                item1.SubItems.Add(item.DiaChi);
                item1.SubItems.Add(item.SDT);
                item1.SubItems.Add(item.CCCD);
                item1.SubItems.Add(item.NgayVaoLam.ToString());
                item1.SubItems.Add(item.SoNgayLam.ToString());
                item1.SubItems.Add(db.GetNameChiNhanh(item.MaChiNhanh));
                lvNhanVien.Items.Add(item1);
            }
            cbo_ChiNhanh.Items.Clear();
            foreach (var item in chiNhanhs)
            {
                cbo_ChiNhanh.Items.Add(item.TenChiNhanh);
            }
            txtSearch.Text = "";
            cbo_ChiNhanh.Text = "";
            txtSoNgayLam.Enabled = false;
            txtSDT.Enabled = false;
            txtCCCD.Enabled = false;
            cboChiNhanh.Enabled = false;
            dtNgayVaoLam.Enabled = false;
            txtMa.Enabled = true;
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            txtSoNgayLam.Text = "";
            cboChiNhanh.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public bool checkTrungID (string id)
        {
            CompanyDB db = new CompanyDB();
            List<NhanVien> nhanViens = db.GetNhanViens();
            foreach(var item in nhanViens)
            {
                if(item.MaNhanVien.TrimEnd() == id.TrimEnd())
                {
                    return false;
                }    
            }
            return true;
        }

        private void txtMa_Leave(object sender, EventArgs e)
        {
            if(!checkTrungID(txtMa.Text.TrimEnd()))
            {
                MessageBox.Show("Trùng mã rồi!");
            }
            else
            {
                txtSoNgayLam.Enabled = true;
                txtSDT.Enabled = true;
                txtCCCD.Enabled = true;
                cboChiNhanh.Enabled = true;
                dtNgayVaoLam.Enabled = true;
            }
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                txtMa.Text = lvNhanVien.SelectedItems[0].SubItems[0].Text;
                txtMa.Enabled = false;
                txtTen.Text = lvNhanVien.SelectedItems[0].SubItems[1].Text;
                dtNgaySinh.Value = DateTime.Parse(lvNhanVien.SelectedItems[0].SubItems[2].Text);
                txtDiaChi.Text = lvNhanVien.SelectedItems[0].SubItems[3].Text;
                txtSDT.Text = lvNhanVien.SelectedItems[0].SubItems[4].Text;
                txtCCCD.Text = lvNhanVien.SelectedItems[0].SubItems[5].Text;
                dtNgayVaoLam.Value = DateTime.Parse(lvNhanVien.SelectedItems[0].SubItems[6].Text);
                txtSoNgayLam.Text = lvNhanVien.SelectedItems[0].SubItems[7].Text;
                cboChiNhanh.Text = lvNhanVien.SelectedItems[0].SubItems[8].Text;
                txtSoNgayLam.Enabled = true;
                txtSDT.Enabled = true;
                txtCCCD.Enabled = true;
                cboChiNhanh.Enabled = true;
                dtNgayVaoLam.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update NhanVien set TenNhanVien = @ten,NgaySinh = @ns,DiaChi = @dc,SDT = @sdt,CCCD = @cccd,NgayVaoLam = @ngaylam,SoNgayLam = @songaylam,MaChiNhanh = @macn where MaNhanVien = @ma";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtTen.Text.TrimEnd();
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = dtNgaySinh.Value;
            command.Parameters.Add("@dc", SqlDbType.NVarChar).Value = txtDiaChi.Text.TrimEnd();
            command.Parameters.Add("@sdt", SqlDbType.Char).Value = txtSDT.Text.TrimEnd();
            command.Parameters.Add("@cccd", SqlDbType.Char).Value = txtCCCD.Text.TrimEnd();
            command.Parameters.Add("@ngaylam", SqlDbType.DateTime).Value = dtNgayVaoLam.Value;
            command.Parameters.Add("@songaylam", SqlDbType.Int).Value = int.Parse(txtSoNgayLam.Text.TrimEnd());
            command.Parameters.Add("@macn", SqlDbType.Char).Value = db.GetIDChiNhanh(cboChiNhanh.Text.TrimEnd());

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Sửa thành công!");
                txtSearch.Text = "";
                cbo_ChiNhanh.Text = "";
                txtSoNgayLam.Enabled = false;
                txtSDT.Enabled = false;
                txtCCCD.Enabled = false;
                cboChiNhanh.Enabled = false;
                dtNgayVaoLam.Enabled = false;
                txtMa.Enabled = true;
                txtMa.Text = "";
                txtTen.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtCCCD.Text = "";
                txtSoNgayLam.Text = "";
                cboChiNhanh.Text = "";
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
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
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Delete NhanVien where MaNhanVien = @ma";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Xóa thành công!");
                txtSearch.Text = "";
                cbo_ChiNhanh.Text = "";
                txtSoNgayLam.Enabled = false;
                txtSDT.Enabled = false;
                txtCCCD.Enabled = false;
                cboChiNhanh.Enabled = false;
                dtNgayVaoLam.Enabled = false;
                txtMa.Enabled = true;
                txtMa.Text = "";
                txtTen.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtCCCD.Text = "";
                txtSoNgayLam.Text = "";
                cboChiNhanh.Text = "";
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "I1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã Nhân Viên";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tên Nhân Viên";

            cl2.ColumnWidth = 40.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Địa chỉ";
            cl3.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Ngày Sinh";

            cl4.ColumnWidth = 30.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "SDT";

            cl5.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "CCCD";

            cl6.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Ngày Vào Làm";

            cl7.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Số Ngày Làm";

            cl8.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Chi Nhánh";

            cl9.ColumnWidth = 18.5;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "I3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();

            DataColumn c1 = new DataColumn("MaNhanVien");
            DataColumn c2 = new DataColumn("TenNhanVien");
            DataColumn c3 = new DataColumn("NgaySinh");
            DataColumn c4 = new DataColumn("DiaChi");
            DataColumn c5 = new DataColumn("SDT");
            DataColumn c6 = new DataColumn("CCCD");
            DataColumn c7 = new DataColumn("NgayVaoLam");
            DataColumn c8 = new DataColumn("SoNgayLam");
            DataColumn c9 = new DataColumn("ChiNhanh");


            datatable.Columns.Add(c1);
            datatable.Columns.Add(c2);
            datatable.Columns.Add(c3);
            datatable.Columns.Add(c4);
            datatable.Columns.Add(c5);
            datatable.Columns.Add(c6);
            datatable.Columns.Add(c7);
            datatable.Columns.Add(c8);
            datatable.Columns.Add(c9);


            for (int i = 0; i < lvNhanVien.Items.Count; i++)
            {
                DataRow dtorw = datatable.NewRow();
                for (int j = 0; j < 9; j++)
                {
                    dtorw[j] = lvNhanVien.Items[i].SubItems[j].Text;
                }
                datatable.Rows.Add(dtorw);
            }

            ExportFile(datatable, "Danh sach", "DANH SÁCH NHÂN VIÊN");
        }
    }
}
