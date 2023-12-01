using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIG_C.Models
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }

        public string TenNhanVien { get; set; }

        public DateTime NgaySinh { get; set; }

        public string DiaChi { get; set; }

        public string SDT { get; set; }

        public string CCCD { get; set; }

        public DateTime NgayVaoLam { get; set; }

        public int SoNgayLam { get; set; }

        public string MaChiNhanh { get; set; }
    }
}
