using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace BIG_C.Models
{
    public class CompanyDB
    {
        public string strcon = "SERVER = THANHHAI; DATABASE = BigC; Integrated security = true";

        public SqlConnection connection = null;

        public List<Account> GetAccounts ()
        {
            if(connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            List<Account> accounts = new List<Account>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Account";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Account account = new Account();
                account.MaNhanVien = reader.GetString(0);
                account.Pass = reader.GetString(1);
                accounts.Add(account);
            }
            reader.Close();
            return accounts;
        }

        public bool checkIsvalidAccount(string name,string pass)
        {
            List<Account> accounts = GetAccounts();
            foreach(var item in accounts)
            {
                if (item.MaNhanVien.TrimEnd() == name.TrimEnd() && item.Pass.TrimEnd() == pass.TrimEnd())
                    return true;
            }
            return false;
        }

        public List<ChiNhanh> GetChiNhanhs()
        {
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            List<ChiNhanh> chiNhanhs = new List<ChiNhanh>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from ChiNhanh";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ChiNhanh chinhanh = new ChiNhanh();
                chinhanh.MaChiNhanh = reader.GetString(0);
                chinhanh.TenChiNhanh = reader.GetString(1);
                chinhanh.DiaChi = reader.GetString(2);
                chiNhanhs.Add(chinhanh);
            }
            reader.Close();
            return chiNhanhs;
        }

        public List<HangHoa> GetHangHoas()
        {
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            List<HangHoa> hangHoas = new List<HangHoa>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from HangHoa";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                HangHoa hh = new HangHoa();
                hh.MaHangHoa = reader.GetString(0);
                hh.TenHangHoa = reader.GetString(1);
                hh.DonGia = reader.GetInt32(2);
                hh.MaNhaCungCap = reader.GetString(3);
                hangHoas.Add(hh);
            }
            reader.Close();
            return hangHoas;
        }

        public List<Kho> GetKhos()
        {
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            List<Kho> Khos = new List<Kho>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Kho";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Kho k = new Kho();
                k.MaChiNhanh = reader.GetString(0);
                k.MaHangHoa = reader.GetString(1);
                k.SoLuong = reader.GetInt32(2);
                Khos.Add(k);
            }
            reader.Close();
            return Khos;
        }

        public List<LichLam> GetLichLams()
        {
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            List<LichLam> lichLams = new List<LichLam>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from LichLam";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LichLam ll = new LichLam();
                ll.MaNhanVien = reader.GetString(0);
                ll.NgayLam = reader.GetDateTime(1);
                ll.CaLam = reader.GetInt32(2);
                lichLams.Add(ll);
            }
            reader.Close();
            return lichLams;
        }

        public List<NhaCungCap> GetNhaCungCaps()
        {
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from NhaCungCap";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNhaCungCap = reader.GetString(0);
                ncc.TenNhaCungCap = reader.GetString(1);
                ncc.DiaChi = reader.GetString(2);
                nhaCungCaps.Add(ncc);
            }
            reader.Close();
            return nhaCungCaps;
        }

        public List<NhanVien> GetNhanViens()
        {
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            List<NhanVien> nhanViens = new List<NhanVien>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from NhanVien";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                NhanVien nv = new NhanVien();
                nv.MaNhanVien = reader.GetString(0);
                nv.TenNhanVien = reader.GetString(1);
                nv.NgaySinh = reader.GetDateTime(2);
                nv.DiaChi = reader.GetString(3);
                nv.SDT = reader.GetString(4);
                nv.CCCD = reader.GetString(5);
                nv.NgayVaoLam = reader.GetDateTime(6);
                nv.SoNgayLam = reader.GetInt32(7);
                nv.MaChiNhanh = reader.GetString(8);
                nhanViens.Add(nv);
            }
            reader.Close();
            return nhanViens;
        }

        public List<PhieuBanHang> GetPhieuBanHangs()
        {
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            List<PhieuBanHang> phieuBanHangs = new List<PhieuBanHang>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from PhieuBanHang";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PhieuBanHang ph = new PhieuBanHang();
                ph.MaPhieu = reader.GetString(0);
                ph.MaHangHoa = reader.GetString(1);
                ph.MaNhanVien = reader.GetString(2);
                ph.NgayBan = reader.GetDateTime(3);
                ph.SoLuong = reader.GetInt32(4);
                ph.TongTien = reader.GetInt32(5);
                phieuBanHangs.Add(ph);
            }
            reader.Close();
            return phieuBanHangs;
        }


        public List<PhieuLuong> GetPhieuLuongs()
        {
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            List<PhieuLuong> phieuLuongs = new List<PhieuLuong>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from PhieuLuong";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PhieuLuong ph = new PhieuLuong();
                ph.MaPhieu = reader.GetString(0);
                ph.MaNhanVien = reader.GetString(1);
                ph.LuongHienTai = reader.GetInt32(2);
                ph.SoGioLam = reader.GetInt32(3);
                ph.SoGioTangCa = reader.GetInt32(4);
                ph.PhuCap = reader.GetInt32(5);
                ph.TroCap = reader.GetInt32(6);
                ph.TongLuong = reader.GetInt32(7);
                ph.ThangLuong = reader.GetDateTime(8);
                ph.TrangThai = reader.GetString(9);
                phieuLuongs.Add(ph);
            }
            reader.Close();
            return phieuLuongs;
        }

        public List<PhieuMuaHang> GetPhieuMuaHangs()
        {
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            List<PhieuMuaHang> phieuMuaHangs = new List<PhieuMuaHang>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from PhieuMuaHang";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PhieuMuaHang ph = new PhieuMuaHang();
                ph.MaPhieu = reader.GetString(0);
                ph.MaChiNhanh = reader.GetString(1);
                ph.MaHangHoa = reader.GetString(2);
                ph.NgayDat = reader.GetDateTime(3);
                ph.NgayGiao = reader.GetDateTime(4);
                ph.SoLuong = reader.GetInt32(5);
                ph.TongTien = reader.GetInt32(6);
                ph.MoTa = reader.GetString(7);
                phieuMuaHangs.Add(ph);
            }
            reader.Close();
            return phieuMuaHangs;
        }

        public List<QuanLy> GetQuanLies()
        {
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            List<QuanLy> nhanViens = new List<QuanLy>();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from QuanLy";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                QuanLy nv = new QuanLy();
                nv.MaNhanVien = reader.GetString(0);
                nv.TenNhanVien = reader.GetString(1);
                nv.NgaySinh = reader.GetDateTime(2);
                nv.DiaChi = reader.GetString(3);
                nv.SDT = reader.GetString(4);
                nv.CCCD = reader.GetString(5);
                nv.NgayVaoLam = reader.GetDateTime(6);
                nv.SoNgayLam = reader.GetInt32(7);
                nv.MaChiNhanh = reader.GetString(8);
                nhanViens.Add(nv);
            }
            reader.Close();
            return nhanViens;
        }

        public TaiKhoan GetTaiKhoan()
        {
            if (connection == null)
            {
                connection = new SqlConnection(strcon);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            TaiKhoan tk = new TaiKhoan();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from TaiKhoan";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                tk.MaTaiKhoan = reader.GetString(0);
                tk.TenTaiKhoan = reader.GetString(1);
                tk.LoaiTaiKhoan = reader.GetString(2);
                tk.SoDu = reader.GetInt64(3);
            }
            reader.Close();
            return tk;
        }

        public string GetNameChiNhanh(string id)
        {
            List<ChiNhanh> chiNhanhs = GetChiNhanhs();
            foreach(var item in chiNhanhs)
            {
                if(item.MaChiNhanh.TrimEnd()==id.TrimEnd())
                {
                    return item.TenChiNhanh;
                }    
            }
            return "";
        }

        public string GetIDChiNhanh(string name)
        {
            List<ChiNhanh> chiNhanhs = GetChiNhanhs();
            foreach (var item in chiNhanhs)
            {
                if (item.TenChiNhanh.TrimEnd() == name.TrimEnd())
                {
                    return item.MaChiNhanh;
                }
            }
            return "0";
        }

        public string GetIDNhanVien(string name)
        {
            List<NhanVien> nhanViens = GetNhanViens();
            foreach (var item in nhanViens)
            {
                if (item.TenNhanVien.TrimEnd() == name.TrimEnd())
                {
                    return item.MaNhanVien;
                }
            }
            return "";
        }

        public string GetNameNhanVien (string id)
        {
            List<NhanVien> nhanViens = GetNhanViens();
            foreach(var item in nhanViens)
            {
                if(item.MaNhanVien.TrimEnd()== id.TrimEnd())
                {
                    return item.TenNhanVien;
                }    
            }
            return "";
        }

        public string GetNameHangHoa(string id)
        {
            List<HangHoa> hangHoas = GetHangHoas();
            foreach (var item in hangHoas)
            {
                if (item.MaHangHoa.TrimEnd() == id.TrimEnd())
                {
                    return item.TenHangHoa;
                }
            }
            return "";
        }

        public string GetIDHangHoa(string name)
        {
            List<HangHoa> hangHoas = GetHangHoas();
            foreach (var item in hangHoas)
            {
                if (item.TenHangHoa.TrimEnd() == name.TrimEnd())
                {
                    return item.MaHangHoa;
                }
            }
            return "";
        }

        public int GetPriceHangHoa(string id)
        {
            List<HangHoa> hangHoas = GetHangHoas();
            foreach (var item in hangHoas)
            {
                if (item.MaHangHoa.TrimEnd() == id.TrimEnd())
                {
                    return item.DonGia;
                }
            }
            return 0;
        }

        public int GetSoSPDaBan()
        {
            List<PhieuBanHang> phieuBanHangs = GetPhieuBanHangs();
            int sum = phieuBanHangs.Sum(row => row.SoLuong);
            return sum;
        }

        public int GetSoTienDaBan()
        {
            List<PhieuBanHang> phieuBanHangs = GetPhieuBanHangs();
            int sum = phieuBanHangs.Sum(row => row.TongTien);
            return sum;
        }

        public int GetSoSPTrongKho()
        {
            List<Kho> khos = GetKhos();
            int sum = khos.Sum(row => row.SoLuong);
            return sum;
        }

        public int GetSoTienDaDat()
        {
            List<PhieuMuaHang> phieuMuaHangs = GetPhieuMuaHangs();
            int sum = phieuMuaHangs.Sum(row => row.TongTien);
            return sum;
        }

        public int GetAllLuongNhanVien()
        {
            List<PhieuLuong> phieuLuongs = GetPhieuLuongs();
            phieuLuongs = phieuLuongs.Where(row => row.TrangThai.TrimEnd() == "Yes").ToList();
            int sum = phieuLuongs.Sum(row => row.TongLuong);
            return sum;
        }
    }
}
