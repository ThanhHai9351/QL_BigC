using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIG_C.Models
{
    public class PhieuLuong
    {
        public string MaPhieu { get; set; }

        public string MaNhanVien { get; set; }

        public int LuongHienTai { get; set; }

        public int SoGioLam { get; set; }

        public int SoGioTangCa { get; set; }

        public int PhuCap { get; set; }

        public int TroCap { get; set; }

        public int TongLuong { get; set; }

        public DateTime ThangLuong { get; set; }
    }
}
