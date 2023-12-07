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
    public partial class PhieuBanUser : UserControl
    {
        
        CompanyDB db = new CompanyDB();
        public string manv = null;
        SqlConnection connection = null;
        public PhieuBanUser()
        {
            InitializeComponent();
        }

        public PhieuBanUser(string id)
        {
            manv = id;
            InitializeComponent();
        }

        private void PhieuBanUser_Load(object sender, EventArgs e)
        {
            List<PhieuBanHang> phieuBanHangs = db.GetPhieuBanHangs().Where(row => row.MaNhanVien.TrimEnd() == manv.TrimEnd()).ToList();
            List<HangHoa> hangHoas = db.GetHangHoas();
            cboHangHoa.Items.Clear();
            foreach (var item in hangHoas)
            {
                cboHangHoa.Items.Add(item.TenHangHoa);
            }
            lvPhieuBan.Items.Clear();
            foreach (var item in phieuBanHangs)
            {
                ListViewItem item1 = new ListViewItem(item.MaPhieu);
                item1.SubItems.Add(db.GetNameHangHoa(item.MaHangHoa));
                item1.SubItems.Add(db.GetNameNhanVien(item.MaNhanVien));
                item1.SubItems.Add(item.NgayBan.ToString());
                item1.SubItems.Add(item.SoLuong.ToString());
                item1.SubItems.Add(item.TongTien.ToString());
                lvPhieuBan.Items.Add(item1);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu!");
            }
            else
            {
                List<PhieuBanHang> phieuBanHangs = db.GetPhieuBanHangs().Where(row => row.MaNhanVien.TrimEnd() == manv.TrimEnd()).ToList();
                phieuBanHangs = phieuBanHangs.Where(row => row.MaHangHoa.TrimEnd().Contains(txtSearch.Text.TrimEnd())).ToList();
                lvPhieuBan.Items.Clear();
                foreach (var item in phieuBanHangs)
                {
                    ListViewItem item1 = new ListViewItem(item.MaPhieu);
                    item1.SubItems.Add(db.GetNameHangHoa(item.MaHangHoa));
                    item1.SubItems.Add(db.GetNameNhanVien(item.MaNhanVien));
                    item1.SubItems.Add(item.NgayBan.ToString());
                    item1.SubItems.Add(item.SoLuong.ToString());
                    item1.SubItems.Add(item.TongTien.ToString());
                    lvPhieuBan.Items.Add(item1);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            List<PhieuBanHang> phieuBanHangs = db.GetPhieuBanHangs().Where(row => row.MaNhanVien.TrimEnd() == manv.TrimEnd()).ToList();
            lvPhieuBan.Items.Clear();
            foreach (var item in phieuBanHangs)
            {
                ListViewItem item1 = new ListViewItem(item.MaPhieu);
                item1.SubItems.Add(db.GetNameHangHoa(item.MaHangHoa));
                item1.SubItems.Add(db.GetNameNhanVien(item.MaNhanVien));
                item1.SubItems.Add(item.NgayBan.ToString());
                item1.SubItems.Add(item.SoLuong.ToString());
                item1.SubItems.Add(item.TongTien.ToString());
                lvPhieuBan.Items.Add(item1);
            }
            txtMa.Text = "";
            cboHangHoa.Text = "";
            txtSoLuong.Text = "";
            txtTongTien.Text = "";
            txtSearch.Text = "";
        }

        private void lvPhieuBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPhieuBan.SelectedItems.Count > 0)
            {
                txtMa.Text = lvPhieuBan.SelectedItems[0].SubItems[0].Text.TrimEnd();
                cboHangHoa.Text = lvPhieuBan.SelectedItems[0].SubItems[1].Text.TrimEnd();
                dtNgayBan.Value = DateTime.Parse(lvPhieuBan.SelectedItems[0].SubItems[3].Text.TrimEnd());
                txtSoLuong.Text = lvPhieuBan.SelectedItems[0].SubItems[4].Text.TrimEnd();
                txtTongTien.Text = lvPhieuBan.SelectedItems[0].SubItems[5].Text.TrimEnd();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
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
            command.CommandText = "insert into PhieuBanHang values (@ma,@mahh,@manv,@nb,@sl,@tt)";
            command.Connection = connection;

            command.Parameters.Add("@ma", SqlDbType.Char).Value = txtMa.Text.TrimEnd();
            command.Parameters.Add("@mahh", SqlDbType.Char).Value = db.GetIDHangHoa(cboHangHoa.Text.TrimEnd());
            command.Parameters.Add("@manv", SqlDbType.Char).Value = manv.TrimEnd();
            command.Parameters.Add("@nb", SqlDbType.DateTime).Value = dtNgayBan.Value;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = int.Parse(txtSoLuong.Text.TrimEnd());
            command.Parameters.Add("@tt", SqlDbType.Int).Value = int.Parse(txtTongTien.Text);

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                MessageBox.Show("Thêm thành công!");
                txtMa.Text = "";
                cboHangHoa.Text = "";
                txtSoLuong.Text = "";
                txtTongTien.Text = "";
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        public bool checkTrungID(string id)
        {
            List<PhieuBanHang> pb = db.GetPhieuBanHangs();
            foreach(var item in pb)
            {
                if (item.MaPhieu.TrimEnd() == id.TrimEnd())
                    return true;
            }
            return false;
        }

        private void txtMa_Leave(object sender, EventArgs e)
        {
            if(checkTrungID(txtMa.Text.TrimEnd()))
            {
                MessageBox.Show("Mã này đã tồn tại!");
            }    
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            txtTongTien.Text = (int.Parse(txtSoLuong.Text) * db.GetPriceHangHoa(db.GetIDHangHoa(cboHangHoa.Text.TrimEnd()))) * 1.15 + "";
        }
    }
}
