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

namespace BIG_C.UserControls
{
    public partial class LichLamUser : UserControl
    {
        public string manv = null;
        CompanyDB db = new CompanyDB();
        public LichLamUser()
        {
            InitializeComponent();
        }

        public LichLamUser(string id)
        {
            manv = id;
            InitializeComponent();
        }

        private void LichLamUser_Load(object sender, EventArgs e)
        {
            lbNameNhanVien.Text = db.GetNameNhanVien(manv.TrimEnd());
            List<LichLam> lichLams = db.GetLichLams().Where(row => row.MaNhanVien.TrimEnd() == manv.TrimEnd()).ToList();
            lvLichLam.Items.Clear();
            foreach (var item in lichLams)
            {
                ListViewItem item1 = new ListViewItem(item.NgayLam.ToString());
                if (item.CaLam == 1)
                {
                    item1.SubItems.Add("X");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                }
                if (item.CaLam == 2)
                {
                    item1.SubItems.Add("");
                    item1.SubItems.Add("X");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                }
                if (item.CaLam == 3)
                {
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("X");
                    item1.SubItems.Add("");
                }
                if (item.CaLam == 4)
                {
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("X");
                }
                lvLichLam.Items.Add(item1);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            List<LichLam> lichLams = db.GetLichLams().Where(row => row.MaNhanVien.TrimEnd() == manv.TrimEnd()).ToList();
            lvLichLam.Items.Clear();
            foreach (var item in lichLams)
            {
                ListViewItem item1 = new ListViewItem(item.NgayLam.ToString());
                if (item.CaLam == 1)
                {
                    item1.SubItems.Add("X");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                }
                if (item.CaLam == 2)
                {
                    item1.SubItems.Add("");
                    item1.SubItems.Add("X");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                }
                if (item.CaLam == 3)
                {
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("X");
                    item1.SubItems.Add("");
                }
                if (item.CaLam == 4)
                {
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("");
                    item1.SubItems.Add("X");
                }
                lvLichLam.Items.Add(item1);
            }
        }
    }
}
