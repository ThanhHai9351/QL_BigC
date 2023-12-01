using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIG_C.Models
{
    public class PhieuMuaHang
    {
        public string MaPhieu { get; set; }
        
        public string MaChiNhanh { get; set; }

        public string MaHangHoa { get; set; }

        public DateTime NgayDat { get; set; }

        public DateTime NgayGiao { get; set; }

        public int SoLuong { get; set; }

        public int TongTien { get; set; }

        public string MoTa { get; set; }
    }
}
