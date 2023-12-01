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
using BIG_C.Forms;

namespace BIG_C.UserControls
{
    public partial class Store : UserControl
    {
        public SqlConnection connection = null;
        public Store()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Store_Load(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<Kho> khos = db.GetKhos();
            List<ChiNhanh> chiNhanhs = db.GetChiNhanhs();
            lvKho.Items.Clear();
            foreach(var item in khos)
            {
                ListViewItem item1 = new ListViewItem(db.GetNameChiNhanh(item.MaChiNhanh));
                item1.SubItems.Add(db.GetNameHangHoa(item.MaHangHoa.TrimEnd()));
                item1.SubItems.Add(item.SoLuong.ToString());
                lvKho.Items.Add(item1);
            }    
            cbo_ChiNhanh.Items.Clear();
            foreach(var item in chiNhanhs)
            {
                cbo_ChiNhanh.Items.Add(item.TenChiNhanh);
                cboChiNhanh.Items.Add(item.TenChiNhanh);
            }    
        }

       
        private void cbo_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
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
            List<Kho> khos = new List<Kho>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Kho where MaChiNhanh = @ma";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = db.GetIDChiNhanh(cbo_ChiNhanh.Text.TrimEnd());
            lvKho.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item1 = new ListViewItem(db.GetNameChiNhanh(reader.GetString(0).TrimEnd()));
                item1.SubItems.Add(db.GetNameHangHoa(reader.GetString(1).TrimEnd()));
                item1.SubItems.Add(reader.GetInt32(2).ToString());
                lvKho.Items.Add(item1);
            }
            reader.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            List<Kho> khos = db.GetKhos();
            List<ChiNhanh> chiNhanhs = db.GetChiNhanhs();
            lvKho.Items.Clear();
            foreach (var item in khos)
            {
                ListViewItem item1 = new ListViewItem(db.GetNameChiNhanh(item.MaChiNhanh));
                item1.SubItems.Add(db.GetNameHangHoa(item.MaHangHoa.TrimEnd()));
                item1.SubItems.Add(item.SoLuong.ToString());
                lvKho.Items.Add(item1);
            }
            cbo_ChiNhanh.Items.Clear();
            foreach (var item in chiNhanhs)
            {
                cbo_ChiNhanh.Items.Add(item.TenChiNhanh);
            }
            txtTen.Text = "";
            txtSoLuong.Text = "";
            cboChiNhanh.Text = "";
        }

        

        private void txtMa_Leave(object sender, EventArgs e)
        {

        }

        private void lvKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompanyDB db = new CompanyDB();
            if(lvKho.SelectedItems.Count > 0)
            {
                txtTen.Text = lvKho.SelectedItems[0].SubItems[1].Text;
                txtSoLuong.Text = lvKho.SelectedItems[0].SubItems[2].Text;
                cboChiNhanh.Text = lvKho.SelectedItems[0].SubItems[0].Text.TrimEnd();
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
            command.CommandText = "Update Kho set MaChiNhanh=@macn,SoLuong = @sl where MaHangHoa = @ma";
            command.Connection = connection;

            command.Parameters.Add("@macn", SqlDbType.Char).Value = db.GetIDChiNhanh(cboChiNhanh.Text.TrimEnd());
            command.Parameters.Add("@ma", SqlDbType.Char).Value = db.GetIDHangHoa(txtTen.Text.TrimEnd());
            command.Parameters.Add("@sl", SqlDbType.Int).Value = int.Parse(txtSoLuong.Text.TrimEnd());

            int ret = command.ExecuteNonQuery();
            if(ret>0)
            {
                MessageBox.Show("Sửa thành công!");
                txtTen.Text = "";
                cboChiNhanh.Text = "";
                txtSoLuong.Text = "";
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
            command.CommandText = "Delete Kho where MaHangHoa = @ma";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = db.GetIDHangHoa(txtTen.Text.TrimEnd());

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Xóa thành công!");
                txtTen.Text = "";
                cboChiNhanh.Text = "";
                txtSoLuong.Text = "";
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            OrderKho frm = new OrderKho();
            frm.ShowDialog();
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Chi Nhánh";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Hàng Hóa";

            cl2.ColumnWidth = 40.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Số Lượng";
            cl3.ColumnWidth = 20.0;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "C3");

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

            DataColumn c1 = new DataColumn("MaChiNhanh");
            DataColumn c2 = new DataColumn("MaHangHoa");
            DataColumn c3 = new DataColumn("SoLuong");



            datatable.Columns.Add(c1);
            datatable.Columns.Add(c2);
            datatable.Columns.Add(c3);



            for (int i = 0; i < lvKho.Items.Count; i++)
            {
                DataRow dtorw = datatable.NewRow();
                for (int j = 0; j < 3; j++)
                {
                    dtorw[j] = lvKho.Items[i].SubItems[j].Text;
                }
                datatable.Rows.Add(dtorw);
            }

            ExportFile(datatable, "Danh sach", "QUẢN LÝ KHO");
        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {

        }
    }
}
