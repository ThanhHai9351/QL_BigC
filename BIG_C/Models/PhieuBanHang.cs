using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIG_C.Models
{
    public class PhieuBanHang
    {
        public string MaPhieu { get; set; }

        public string MaHangHoa { get; set; }

        public string MaNhanVien { get; set; }

        public DateTime NgayBan { get; set; }

        public int SoLuong { get; set; }

        public int TongTien { get; set; }
    }
}
