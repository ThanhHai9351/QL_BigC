using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_C.Model
{
    public class NhanVien
    {
        public string maNV { get; set; }

        public string tenNV { get; set; }

        public DateTime NgaySinh { get; set; }

        public string diaChi { get; set; }

        public string SDT { get; set; }

        public string CCCD { get; set; }

        public DateTime ngayVaoLam { get; set; }

        public int soNgayLam { get; set; }

        public string maQuanLy { get; set; }
    }
}
