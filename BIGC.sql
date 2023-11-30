create database BigC

USE BigC
GO

create table TaiKhoan
(
    MaTaiKhoan char(10) primary key,
    TenTaiKhoan nvarchar(100),
    LoaiTaiKhoan nvarchar(50) not null,
    SoDu bigint not null
)

create table ChiNhanh 
(
    MaChiNhanh char(10) primary key,
    TenChiNhanh nvarchar(30) unique,
    DiaChi nvarchar(100) unique
)

create table QuanLy
(
    MaQuanLy char(10) primary key,
    TenQuanLy nvarchar(50) not null,
    NgaySinh DateTime not null,
    DiaChi nvarchar(100) not null,
    SDT char(13) unique,
    CCCD char(15) unique,
    NgayVaoLam DateTime not null,
    SoNgayLam int CHECK (SoNgayLam > 0), 
    MaChiNhanh char(10),
    constraint FK_QuanLy foreign key (MaChiNhanh) references ChiNhanh(MaChiNhanh)
)

create table NhanVien
(
    MaNhanVien char(10) primary key,
    TenNhanVien nvarchar(50) not null,
    NgaySinh DateTime not null,
    DiaChi nvarchar(100) not null,
    SDT char(13) unique,
    CCCD char(15) unique,
    NgayVaoLam DateTime not null,
    SoNgayLam int CHECK (SoNgayLam > 0), 
    MaChiNhanh char(10),
    constraint FK_NhanVien foreign key (MaChiNhanh) references ChiNhanh(MaChiNhanh)
)

create table NhaCungCap(
    MaNhaCungCap char(10) primary key,
    TenNhaCungCap nvarchar(100),
    DiaChi nvarchar(100)
)

create table HangHoa
(
    MaHangHoa char(10) primary key,
    TenHangHoa nvarchar(100),
    DonGia int,
    MaNhaCungCap char(10),
    constraint PK_HangHoa foreign key(MaNhaCungCap) references NhaCungCap(MaNhaCungCap)
)

create table PhieuMuaHang
(
    MaPhieu char(10),
    MaHangHoa char(10),
    NgayDat DateTime,
    NgayGiao DateTime,
    SoLuong int,
    TongTien int,
    Mota nvarchar(100),
    constraint FK_PhieuMuaHang_HangHoa foreign key (MaHangHoa) references HangHoa(MaHangHoa),
)

create table PhieuLuong
(
	MaPhieu char(10) primary key,
	MaNhanVien char(10),
	LuongHienTai int,
	SoGioLam int,
	SoGioTangCa int,
	PhuCap int,
	TroCap int,
	TongLuong int,
	ThangLuong date,
	constraint FK_PhieuLuong_NhanVien foreign key(MaNhanVien) references NhanVien(MaNhanVien)
)

create table Kho
(
	MaChiNhanh char(10),
	MaHangHoa char(10),
	SoLuong int,
	constraint FK_Kho_ChiNhanh foreign key(MaChiNhanh) references ChiNhanh(MaChiNhanh),
	constraint FK_Kho_HangHoa foreign key(MaHangHoa) references HangHoa(MaHangHoa)
)

create table PhieuBanHang
(
	MaPhieu char(10) primary key,
    MaHangHoa char(10),
    MaNhanVien char(10),
    NgayBan DateTime,
    SoLuong int,
    TongTien int,
	constraint FK_PhieuBanHang_NhanVien foreign key(MaNhanVien) references NhanVien(MaNhanVien),
	constraint FK_PhieuBanHang_HangHoa foreign key(MaHangHoa) references HangHoa(MaHangHoa)
)

CREATE TABLE LichLam
(
    MaNhanVien char(10),
    NgayLam DATE,
    Ca int,
    CONSTRAINT FK_LichLam_NhanVien FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

create table Account
(
	MaNhanVien char(10) primary key,
	pass varchar(100),
	Constraint FK_Account_NhanVien Foreign key (MaNhanVien) references NhanVien(MaNhanVien)
)


create trigger ChangeSoDu on PhieuBanHang
after insert
as
begin
	declare @tien int = (select TongTien from inserted)
	update TaiKhoan
	set SoDu = SoDu + @tien
end

create trigger ChangeSoDu1 on PhieuBanHang
after delete
as
begin
	declare @tien int = (select TongTien from deleted)
	update TaiKhoan
	set SoDu = SoDu - @tien
end

create trigger ChangeSoDuTru on PhieuMuaHang
after insert
as
begin
	declare @tien int = (select TongTien from inserted)
	update TaiKhoan
	set SoDu = SoDu - @tien
end

create trigger ChangeSoDuTru1 on PhieuMuaHang
after insert
as
begin
	declare @tien int = (select TongTien from inserted)
	update TaiKhoan
	set SoDu = SoDu + @tien
end


INSERT INTO TaiKhoan (MaTaiKhoan, TenTaiKhoan, LoaiTaiKhoan, SoDu)
VALUES ('TK001', 'Tong cuc Big C', 'Thanh toan', 100000000);

INSERT INTO ChiNhanh (MaChiNhanh, TenChiNhanh, DiaChi)
VALUES
('CN001', 'Big C Miền Đông', '268 Tô Hiến Thành, Phường 15, Quận 10, TP. Hồ Chí Minh'),
('CN002', 'Big C Trường Chinh', '1/1 Trường Chinh, Phường Tây Thạnh, Quận Tân Phú, TP. Hồ Chí Minh'),
('CN003', 'GO! Gò Vấp', '792 Nguyễn Kiệm, Phường 3, Quận Gò Vấp, TP. Hồ Chí Minh'),
('CN004', 'Big C An Lạc', '1231 Quốc lộ 1A, Phường Bình Trị Đông B, Quận Bình Tân, TP. Hồ Chí Minh'),
('CN005', 'Big C Phú Thạnh', '685 Âu Cơ, Phường Tân Thành, Quận Tân Phú, TP. Hồ Chí Minh'),
('CN006', 'Big C Thảo Điền', '199 Nguyễn Văn Hưởng, Phường Thảo Điền, Quận 2, TP. Hồ Chí Minh');


INSERT INTO QuanLy (MaQuanLy, TenQuanLy, NgaySinh, DiaChi, SDT, CCCD, NgayVaoLam, SoNgayLam, MaChiNhanh)
VALUES 
    ('QL01', 'Nguyễn Hoàng Long', '1990-01-15', 'Bình Tân, TPHCM', '0938894913', '23817382', '2022-01-01', 30, 'CN001'),
    ('QL02', 'Phạm Thị Ngọc Hằng', '1985-06-20', 'Quận 10, TPHCM', '0782543210', '23019291', '2023-02-01', 28, 'CN001'),
    ('QL03', 'Trần Văn An', '1988-09-12', 'Quận 5, TPHCM', '0912345678', '11223344', '2022-03-15', 25, 'CN003'),
    ('QL04', 'Nguyễn Thị Lan Anh', '2003-09-12', 'Quận 5, TPHCM', '0982345678', '11923344', '2022-03-15', 25, 'CN002'),
    ('QL05', 'Ngụy Hữu Tài', '2000-02-23', 'Quận 7, TPHCM', '0912376678', '11229344', '2022-03-15', 25, 'CN003'),
    ('QL06', 'Nguyễn Xuân Diệu', '1990-07-03', 'Quận 12, TPHCM', '0915345678', '91223344', '2022-03-15', 25, 'CN004'),
    ('QL07', 'Bùi Xuân Huấn', '1999-04-02', 'Quận 5, TPHCM', '0932345678', '11223349', '2022-03-15', 25, 'CN004'),
    ('QL08', 'Lê Lý Lan Hương', '2000-08-11', 'Quận Phú Nhuận, TPHCM', '0312395278', '19223344', '2022-03-15', 25, 'CN005'),
    ('QL09', 'Nguyễn Thị Mai', '1992-05-21', 'Quận Tân Phú, TPHCM', '0917654321', '55667988', '2022-07-10', 22, 'CN006');


INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, DiaChi, SDT, CCCD, NgayVaoLam, SoNgayLam, MaChiNhanh)
VALUES ('NV01', 'Nguyễn Thanh Hào', '1995-08-10', 'TP.HCM', '0938762364', '2301203821', '2023-01-01', 25, 'CN001'),
       ('NV02', 'Phan Hữu Tài', '1998-03-05', 'Bình Thuận', '0789299621', '2392929391', '2023-02-01', 26, 'CN001'),
	   ('NV03', 'Trương Mỹ Ánh', '1998-03-05', 'Quận 1, TP HCM', '0789036321', '2891929391', '2023-02-01', 26, 'CN001'),
	   ('NV04', 'Cao Nhật Hoài Bảo', '1998-03-05', 'Tiền Giang', '0769966321', '2391929371', '2023-02-01', 26, 'CN001'),
	   ('NV05', 'Nguyễn Trường Chinh', '1998-03-05', 'Củ Chi', '9968299321', '2391029391', '2023-02-01', 26, 'CN001'),
	   ('NV06', 'Dương Hoàng Du', '1998-03-05', 'Đồng Nai', '0789250991', '2391949391', '2023-02-01', 26, 'CN001'),
	   ('NV07', 'Võ Nguyễn Hữu Duy', '1998-03-05', 'Quận 7, TP HCM', '0781889321', '2396929391', '2023-02-01', 26, 'CN002'),
	   ('NV08', 'Trần Tiến Đạt', '1998-03-05', 'Quận Phú Nhuận, TP HCM', '0758299321', '2393929391', '2023-02-01', 26, 'CN002'),
	   ('NV09', 'Nguyễn Anh Hào', '1998-03-05', 'An Giang', '0789299321', '2335928391', '2023-02-01', 26, 'CN002'),
	   ('NV010', 'Nguyễn Thị Ngọc Hân', '1998-03-05', 'Quận Tân Phú, TP HCM', '0889999321', '2301929391', '2023-02-01', 26, 'CN002'),
	   ('NV011', 'Phan Hoài Thanh Hiển', '1998-03-05', 'Quận Tân Phú, TP HCM', '0509299321', '2391929391', '2023-02-01', 26, 'CN002'),
	   ('NV012', 'Nguyễn Ngọc Hoàng', '1998-03-05', 'Quận 2, TP HCM', '0769299321', '0321929391', '2023-02-01', 26, 'CN002'),
	   ('NV013', 'Trần Huy Hoàng', '1998-03-05', 'Quận 7, TP HCM', '0789296321', '2099929391', '2023-02-01', 26, 'CN002'),
	   ('NV014', 'Kiều Thị Mỹ Ly', '1998-03-05', 'Quận Tân Phú, TP HCM', '0769399321', '2381929391', '2023-02-01', 26, 'CN002'),
       ('NV015', 'Nguyễn Thị Thu Thảo', '1997-12-20', 'Tây Ninh', '0102727318', '230699636', '2023-01-15', 28, 'CN002');

INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, DiaChi)
VALUES 
('NCC03', 'HT Sài Gòn', 'Số 52 Phạm Đăng Giảng, Bình Hưng Hoà, quận Bình Tân, thành phố Hồ Chí Minh'),
('NCC04', 'Công ty CP Tiêu dùng Masan', '39 Lê Duẩn, phường Bến Nghé, quận 1, thành phố Hồ Chí Minh'),
('NCC05', 'Thực phẩm giá sỉ Anh Thư', 'Số 14B đường Trung Mỹ Tây 13A, KP5, phường Trung Mỹ Tây, quận 12, thành phố Hồ Chí Minh'),
('NCC06', 'Công Ty TNHH Conamo Việt Nam', 'Ngách 57, ngõ 241, đường Liên Mạc, phường Liên Mạc, quận Bắc Từ Liêm, Hà Nội'),
('NCC07', 'Công Ty CP XNK A Tuấn Khang', 'Số 144 đường số 1A, phường Bình Trị Đông B, quận Bình Tân, thành phố Hồ Chí Minh'),
('NCC08', 'Công Ty Ajinomoto Việt Nam', 'Tầng 5, Golden Tower, 6 Nguyễn Thị Minh Khai, phường Đa Kao, quận 1, thành phố Hồ Chí Minh'),
('NCC09', 'Công ty nước giải khát Pepsico', 'Số 124, Lê Lai, phường 3, quận Gò Vấp, thành phố Hồ Chí Minh'),
('NCC10', 'Công ty gia vị Nam Phương Group', 'Số 2, phường 12, quận Tân Phú, thành phố Hồ Chí Minh');

INSERT INTO HangHoa (MaHangHoa, TenHangHoa, DonGia) VALUES
('HH001', 'Sữa tươi Vinamilk 100% nguyên chất 1L', 29000),
('HH002', 'Gạo tám thơm ST25 5kg', 120000),
('HH003', 'Thịt heo tươi thăn mông', 120000),
('HH004', 'Cá hồi fillet Nauy 300g', 250000),
('HH005', 'Xúc xích Đức 400g', 100000),
('HH006', 'Bánh mì tươi Pháp 500g', 30000),
('HH007', 'Trà xanh Oolong Đài Loan 200g', 300000),
('HH008', 'Nước giặt Tide 3.8kg', 150000),
('HH009', 'Bột giặt Ariel 4kg', 150000),
('HH010', 'Sữa chua Vinamilk hương dâu 100g', 15000),
('HH011', 'Nước mắm Phú Quốc Knorr 500ml', 25000),
('HH012', 'Dầu ăn Neptune Light 1L', 65000),
('HH013', 'Bánh gạo Hàn Quốc O''Food 220g', 12000),
('HH014', 'Mì gói Hảo Hảo tôm chua cay 75g', 10000),
('HH015', 'Kem đánh răng Colgate Total 123 160g', 45000),
('HH016', 'Dầu gội Sunsilk Mềm Mượt & Bóng 480g', 55000),
('HH017', 'Sữa tắm Dove Dưỡng Ẩm 500g', 65000),
('HH018', 'Nước rửa chén Sunlight Chanh & Sả 400ml', 45000),
('HH019', 'Xà phòng tắm Lifebuoy Hương Trà Xanh 9', 5000);

INSERT INTO LichLam (MaNhanVien, NgayLam, Ca)
VALUES
    ('NV01', '2023-11-29', 1),
    ('NV02', '2023-11-29', 2),
    ('NV03', '2023-11-30', 3),
	('NV04', '2023-11-29', 4),
    ('NV05', '2023-11-28', 2),
    ('NV06', '2023-11-30', 2),
	('NV07', '2023-11-28', 1),
    ('NV08', '2023-11-28', 2),
    ('NV09', '2023-11-30', 2),
	('NV010', '2023-11-27', 1),
    ('NV011', '2023-11-27', 2),
    ('NV012', '2023-11-30', 4),
	('NV013', '2023-11-28', 3),
    ('NV014', '2023-11-29', 3),
    ('NV015', '2023-11-30', 4);
 


INSERT INTO PhieuMuaHang (MaPhieu, MaHangHoa, NgayDat, NgayGiao, SoLuong, TongTien, Mota)
VALUES ('PMH01', 'HH001', '2023-03-01', '2023-03-15', 100, 10000, 'Mua hàng lần đầu')
INSERT INTO PhieuMuaHang (MaPhieu, MaHangHoa, NgayDat, NgayGiao, SoLuong, TongTien, Mota)
VALUES  ('PMH02', 'HH002', '2023-03-05', '2023-03-20', 50, 7500, 'Mua hàng lần đầu')

INSERT INTO PhieuLuong (MaPhieu, MaNhanVien, LuongHienTai, SoGioLam, SoGioTangCa, PhuCap, TroCap, TongLuong,ThangLuong)
VALUES ('PL01', 'NV01', 48000, 160, 2,5000000, 0, 0,'2023-11-11'),
       ('PL02', 'NV02', 57000, 180, 0,6000000, 0, 0,'2023-11-11'),
       ('PL03', 'NV03', 53000, 176, 3,5500000, 0, 0,'2023-11-11'),
	   ('PL04', 'NV04', 48000, 160, 2,5000000, 0, 0,'2023-12-11'),
       ('PL05', 'NV05', 57000, 180, 0,6000000, 0, 0,'2023-12-11'),
       ('PL06', 'NV06', 53000, 176, 3,5500000, 0, 0,'2023-10-11'),
	   ('PL07', 'NV07', 48000, 160, 2,5000000, 0, 0,'2023-11-11'),
       ('PL08', 'NV08', 57000, 180, 0,6000000, 0, 0,'2023-12-11'),
       ('PL09', 'NV09', 53000, 176, 3,5500000, 0, 0,'2023-10-11'),
	   ('PL10', 'NV010', 48000, 160, 2,5000000, 0, 0,'2023-10-11'),
       ('PL11', 'NV011', 57000, 180, 0,6000000, 0, 0,'2023-11-11'),
       ('PL12', 'NV012', 53000, 176, 3,5500000, 0, 0,'2023-08-11'),
	   ('PL13', 'NV013', 48000, 160, 2,5000000, 0, 0,'2023-08-11'),
       ('PL14', 'NV014', 57000, 180, 0,6000000, 0, 0,'2023-08-11'),
       ('PL15', 'NV015', 53000, 176, 3,5500000, 0, 0,'2023-08-11');

INSERT INTO Kho (MaChiNhanh, MaHangHoa, SoLuong)
VALUES ('CN001', 'HH001', 234),
       ('CN002', 'HH002', 145),
	   ('CN001', 'HH003', 200),
       ('CN001', 'HH004', 222),
	   ('CN003', 'HH005', 423),
       ('CN004', 'HH006', 123),
	   ('CN005', 'HH007', 222),
       ('CN002', 'HH008', 132),
	   ('CN002', 'HH009', 123),
       ('CN004', 'HH010', 103),
	   ('CN006', 'HH011', 412),
       ('CN006', 'HH012', 321),
	   ('CN006', 'HH013', 200),
       ('CN003', 'HH014', 132),
	   ('CN004', 'HH015', 245),
	   ('CN001', 'HH016', 265),
	   ('CN001', 'HH017', 300),
       ('CN005', 'HH018', 120),
	   ('CN005', 'HH019', 323);

INSERT INTO PhieuBanHang (MaPhieu, MaHangHoa, MaNhanVien, NgayBan, SoLuong, TongTien)
VALUES ('PBH01', 'HH001', 'NV01', '2023-03-10', 50, 5000)
INSERT INTO PhieuBanHang (MaPhieu, MaHangHoa, MaNhanVien, NgayBan, SoLuong, TongTien)
VALUES  ('PBH02', 'HH002', 'NV02', '2023-03-15', 30, 4500)

Insert Into Account 
values 
('NV01','123'),
('NV02','123'),
('NV03','123'),
('NV04','123'),
('NV05','123'),
('NV06','123'),
('NV07','123'),
('NV08','123'),
('NV09','123'),
('NV010','123'),
('NV011','123'),
('NV012','123'),
('NV013','123'),
('NV014','123'),
('NV015','123')


-- cập nhật lương cho Phiếu lương
update PhieuLuong 
set TongLuong = LuongHienTai * (SoGioLam + SoGioTangCa) + PhuCap + TroCap;

select*from TaiKhoan