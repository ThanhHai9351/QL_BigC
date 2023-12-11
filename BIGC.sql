create database BigC

USE BigC
GO

create table TaiKhoan
(
    MaTaiKhoan char(10) primary key,
    TenTaiKhoan nvarchar(100),
    LoaiTaiKhoan nvarchar(50) not null,
    SoDu int not null
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
	MaChiNhanh char(10),
    MaHangHoa char(10),
    NgayDat DateTime,
    NgayGiao DateTime,
    SoLuong int,
    TongTien int,
    Mota nvarchar(100),
    constraint FK_PhieuMuaHang_HangHoa foreign key (MaHangHoa) references HangHoa(MaHangHoa),
	constraint PhieuMuahang_ChiNhanh foreign key(MaChiNhanh) references ChiNhanh(MaChiNhanh)
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
	TrangThai char(3),
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
	constraint FK_PhieuBanHang_HangHoa foreign key(MaHangHoa) references HangHoa(MaHangHoa),

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




INSERT INTO TaiKhoan (MaTaiKhoan, TenTaiKhoan, LoaiTaiKhoan, SoDu)
VALUES ('156', 'Buy', 'Thanh toan', 100000000),
('511', 'Sell', 'Thanh toan', 0),
('334', 'Salary', 'Thanh toan', 100000000)

select * from TaiKhoan

INSERT INTO ChiNhanh (MaChiNhanh, TenChiNhanh, DiaChi)
VALUES
('CN001', N'Big C Miền Đông', N'268 Tô Hiến Thành, Phường 15, Quận 10, TP. Hồ Chí Minh'),
('CN002', N'Big C Trường Chinh', N'1/1 Trường Chinh, Phường Tây Thạnh, Quận Tân Phú, TP. Hồ Chí Minh'),
('CN003', N'GO! Gò Vấp', N'792 Nguyễn Kiệm, Phường 3, Quận Gò Vấp, TP. Hồ Chí Minh'),
('CN004', N'Big C An Lạc', N'1231 Quốc lộ 1A, Phường Bình Trị Đông B, Quận Bình Tân, TP. Hồ Chí Minh'),
('CN005', N'Big C Phú Thạnh', N'685 Âu Cơ, Phường Tân Thành, Quận Tân Phú, TP. Hồ Chí Minh'),
('CN006', N'Big C Thảo Điền', N'199 Nguyễn Văn Hưởng, Phường Thảo Điền, Quận 2, TP. Hồ Chí Minh');


INSERT INTO QuanLy (MaQuanLy, TenQuanLy, NgaySinh, DiaChi, SDT, CCCD, NgayVaoLam, SoNgayLam, MaChiNhanh)
VALUES 
    ('QL01', N'Nguyễn Hoàng Long', '1990-01-15', N'Bình Tân, TPHCM', '0938894913', '23817382', '2022-01-01', 30, 'CN001'),
    ('QL02', N'Phạm Thị Ngọc Hằng', '1985-06-20', N'Quận 10, TPHCM', '0782543210', '23019291', '2023-02-01', 28, 'CN001'),
    ('QL03', N'Trần Văn An', '1988-09-12', N'Quận 5, TPHCM', '0912345678', '11223344', '2022-03-15', 25, 'CN003'),
    ('QL04', N'Nguyễn Thị Lan Anh', '2003-09-12', N'Quận 5, TPHCM', '0982345678', '11923344', '2022-03-15', 25, 'CN002'),
    ('QL05', N'Ngụy Hữu Tài', '2000-02-23', N'Quận 7, TPHCM', '0912376678', '11229344', '2022-03-15', 25, 'CN003'),
    ('QL06', N'Nguyễn Xuân Diệu', '1990-07-03', N'Quận 12, TPHCM', '0915345678', '91223344', '2022-03-15', 25, 'CN004'),
    ('QL07', N'Bùi Xuân Huấn', '1999-04-02', N'Quận 5, TPHCM', '0932345678', '11223349', '2022-03-15', 25, 'CN004'),
    ('QL08', N'Lê Lý Lan Hương', '2000-08-11', N'Quận Phú Nhuận, TPHCM', '0312395278', '19223344', '2022-03-15', 25, 'CN005'),
    ('QL09', N'Nguyễn Thị Mai', '1992-05-21', N'Quận Tân Phú, TPHCM', '0917654321', '55667988', '2022-07-10', 22, 'CN006');


INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, DiaChi, SDT, CCCD, NgayVaoLam, SoNgayLam, MaChiNhanh)
VALUES ('NV01', N'Nguyễn Thanh Hào', '1995-08-10', N'TP.HCM', '0938762364', '2301203821', '2023-01-01', 25, 'CN001'),
       ('NV02', N'Phan Hữu Tài', '1998-03-05', N'Bình Thuận', '0789299621', '2392929391', '2023-02-01', 26, 'CN001'),
	   ('NV03', N'Trương Mỹ Ánh', '1998-03-05', N'Quận 1, TP HCM', '0789036321', '2891929391', '2023-02-01', 26, 'CN001'),
	   ('NV04', N'Cao Nhật Hoài Bảo', '1998-03-05', N'Tiền Giang', '0769966321', '2391929371', '2023-02-01', 26, 'CN001'),
	   ('NV05', N'Nguyễn Trường Chinh', '1998-03-05', N'Củ Chi', '9968299321', '2391029391', '2023-02-01', 26, 'CN001'),
	   ('NV06', N'Dương Hoàng Du', '1998-03-05', N'Đồng Nai', '0789250991', '2391949391', '2023-02-01', 26, 'CN001'),
	   ('NV07', N'Võ Nguyễn Hữu Duy', '1998-03-05', N'Quận 7, TP HCM', '0781889321', '2396929391', '2023-02-01', 26, 'CN002'),
	   ('NV08', N'Trần Tiến Đạt', '1998-03-05', N'Quận Phú Nhuận, TP HCM', '0758299321', '2393929391', '2023-02-01', 26, 'CN002'),
	   ('NV09', N'Nguyễn Anh Hào', '1998-03-05', N'An Giang', '0789299321', '2335928391', '2023-02-01', 26, 'CN002'),
	   ('NV010', N'Nguyễn Thị Ngọc Hân', '1998-03-05', N'Quận Tân Phú, TP HCM', '0889999321', '2301929391', '2023-02-01', 26, 'CN002'),
	   ('NV011', N'Phan Hoài Thanh Hiển', '1998-03-05', N'Quận Tân Phú, TP HCM', '0509299321', '2391929391', '2023-02-01', 26, 'CN002'),
	   ('NV012', N'Nguyễn Ngọc Hoàng', '1998-03-05', N'Quận 2, TP HCM', '0769299321', '0321929391', '2023-02-01', 26, 'CN002'),
	   ('NV013', N'Trần Huy Hoàng', '1998-03-05', N'Quận 7, TP HCM', '0789296321', '2099929391', '2023-02-01', 26, 'CN002'),
	   ('NV014', N'Kiều Thị Mỹ Ly', '1998-03-05', N'Quận Tân Phú, TP HCM', '0769399321', '2381929391', '2023-02-01', 26, 'CN002'),
       ('NV015', N'Nguyễn Thị Thu Thảo', '1997-12-20', N'Tây Ninh', '0102727318', '230699636', '2023-01-15', 28, 'CN002');

INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, DiaChi)
VALUES 
('NCC03', N'HT Sài Gòn', N'Số 52 Phạm Đăng Giảng, Bình Hưng Hoà, quận Bình Tân, thành phố Hồ Chí Minh'),
('NCC04', N'Công ty CP Tiêu dùng Masan', N'39 Lê Duẩn, phường Bến Nghé, quận 1, thành phố Hồ Chí Minh'),
('NCC05', N'Thực phẩm giá sỉ Anh Thư', N'Số 14B đường Trung Mỹ Tây 13A, KP5, phường Trung Mỹ Tây, quận 12, thành phố Hồ Chí Minh'),
('NCC06', N'Công Ty TNHH Conamo Việt Nam', N'Ngách 57, ngõ 241, đường Liên Mạc, phường Liên Mạc, quận Bắc Từ Liêm, Hà Nội'),
('NCC07', N'Công Ty CP XNK A Tuấn Khang', N'Số 144 đường số 1A, phường Bình Trị Đông B, quận Bình Tân, thành phố Hồ Chí Minh'),
('NCC08', N'Công Ty Ajinomoto Việt Nam', N'Tầng 5, Golden Tower, 6 Nguyễn Thị Minh Khai, phường Đa Kao, quận 1, thành phố Hồ Chí Minh'),
('NCC09', N'Công ty nước giải khát Pepsico', N'Số 124, Lê Lai, phường 3, quận Gò Vấp, thành phố Hồ Chí Minh'),
('NCC10', N'Công ty gia vị Nam Phương Group', N'Số 2, phường 12, quận Tân Phú, thành phố Hồ Chí Minh');


INSERT INTO HangHoa (MaHangHoa, TenHangHoa, DonGia,MaNhaCungCap) VALUES
('HH001', N'Sữa tươi Vinamilk 100% nguyên chất 1L', 29000,'NCC03'),
('HH002', N'Gạo tám thơm ST25 5kg', 120000,'NCC03'),
('HH003', N'Thịt heo tươi thăn mông', 120000,'NCC03'),
('HH004', N'Cá hồi fillet Nauy 300g', 250000,'NCC03'),
('HH005', N'Xúc xích Đứcc 400g', 100000,'NCC03'),
('HH006', N'Bánh mì ttươii Pháp 500g', 30000,'NCC03'),
('HH007', N'Trà xanh Oolong Đài Loan 200g', 300000,'NCC03'),
('HH008', N'NNướcc giặt Tide 3.8kg', 150000,'NCC03'),
('HH009', N'Bột giặt Ariel 4kg', 150000,'NCC03'),
('HH010', N'Sữa chua Vinamilk hương dâu 100g', 15000,'NCC03'),
('HH011', N'Nước mắm Phú Quốc Knorr 500ml', 25000,'NCC03'),
('HH012', N'Dầu ăn Neptune Light 1L', 65000,'NCC03'),
('HH013', N'Bánh gạo Hàn Quốc O''Food 220g', 12000,'NCC03'),
('HH014', N'Mì gói Hảo Hảo tôm chua cay 75g', 10000,'NCC03'),
('HH015', N'Kem đánh răng Colgate Total 123 160g', 45000,'NCC03'),
('HH016', N'Dầu gội Sunsilk Mềm Mượt & Bóng 480g', 55000,'NCC03'),
('HH017', N'Sữa tắm Dove Dưỡng Ẩm 500g', 65000,'NCC03'),
('HH018', N'Nước rửa chén Sunlight Chanh & Sả 400ml', 45000,'NCC03'),
('HH019', N'Xà phòng tắm Lifebuoy Hương Trà Xanh 9', 5000,'NCC03');


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


INSERT INTO PhieuMuaHang (MaPhieu,MaChiNhanh, MaHangHoa, NgayDat, NgayGiao, SoLuong, TongTien, Mota)
VALUES ('PMH01','CN001', 'HH001' ,'2023-03-01', '2023-03-15', 100, 10000, N'Mua hàng l?n ??u')
INSERT INTO PhieuMuaHang (MaPhieu, MaChiNhanh,MaHangHoa, NgayDat, NgayGiao, SoLuong, TongTien, Mota)
VALUES  ('PMH02','CN002', 'HH002', '2023-03-05', '2023-03-20', 50, 7500, N'Mua hàng l?n ??u')


INSERT INTO PhieuLuong (MaPhieu, MaNhanVien, LuongHienTai, SoGioLam, SoGioTangCa, PhuCap, TroCap, TongLuong,ThangLuong,TrangThai)
VALUES ('PL01', 'NV01', 48000, 160, 2,5000000, 0, 0,'2023-11-11','Yes'),
       ('PL02', 'NV02', 57000, 180, 0,6000000, 0, 0,'2023-11-11','Yes'),
       ('PL03', 'NV03', 53000, 176, 3,5500000, 0, 0,'2023-11-11','Yes'),
	   ('PL04', 'NV04', 48000, 160, 2,5000000, 0, 0,'2023-12-11','Yes'),
       ('PL05', 'NV05', 57000, 180, 0,6000000, 0, 0,'2023-12-11','Yes'),
       ('PL06', 'NV06', 53000, 176, 3,5500000, 0, 0,'2023-10-11','Yes'),
	   ('PL07', 'NV07', 48000, 160, 2,5000000, 0, 0,'2023-11-11','No'),
       ('PL08', 'NV08', 57000, 180, 0,6000000, 0, 0,'2023-12-11','No'),
       ('PL09', 'NV09', 53000, 176, 3,5500000, 0, 0,'2023-10-11','No'),
	   ('PL10', 'NV010', 48000, 160, 2,5000000, 0, 0,'2023-10-11','No'),
       ('PL11', 'NV011', 57000, 180, 0,6000000, 0, 0,'2023-11-11','No'),
       ('PL12', 'NV012', 53000, 176, 3,5500000, 0, 0,'2023-08-11','No'),
	   ('PL13', 'NV013', 48000, 160, 2,5000000, 0, 0,'2023-08-11','No'),
       ('PL14', 'NV014', 57000, 180, 0,6000000, 0, 0,'2023-08-11','No'),
       ('PL15', 'NV015', 53000, 176, 3,5500000, 0, 0,'2023-08-11','No');

--Không cần
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

-- c?p nh?t l??ng cho Phi?u l??ng
update PhieuLuong 
set TongLuong = LuongHienTai * (SoGioLam + SoGioTangCa) + PhuCap + TroCap;


create trigger updateKhoAfterSell on PhieuBanHang 
after insert
as
begin 
	declare @macn char(10),@mahh char(10),@sl int
	select @mahh = MaHangHoa,@macn = MaChiNhanh,@sl = SoLuong from inserted join NhanVien on NhanVien.MaNhanVien = inserted.MaNhanVien
	update Kho
	set SoLuong = SoLuong - @sl
	where MaChiNhanh = @macn AND MaHangHoa = @mahh
end
go


create trigger changeMoneyafterSalary ON PhieuLuong
after insert
as
begin
	declare @salary int,@tt char(2)
	select @salary = TongLuong , @tt = TrangThai from inserted
	update TaiKhoan
	set SoDu = SoDu - @salary
	where MaTaiKhoan = '334'
end
go

create trigger changeMoneyafterSalary1 ON PhieuLuong
after delete
as
begin
	declare @salary int,@tt char(2)
	select @salary = TongLuong , @tt = TrangThai from deleted
	update TaiKhoan
	set SoDu = SoDu + @salary
	where MaTaiKhoan = '334' 
end
go

create trigger ChangeSoDu on PhieuBanHang
after insert
as
begin
	declare @tien int = (select TongTien from inserted)
	update TaiKhoan
	set SoDu = SoDu + @tien
	where MaTaiKhoan = '511'
end
go

create trigger ChangeSoDu1 on PhieuBanHang
after delete
as
begin
	declare @tien int = (select TongTien from deleted)
	update TaiKhoan
	set SoDu = SoDu - @tien
	where MaTaiKhoan = '511'
end
go

create trigger ChangeSoDuTru on PhieuMuaHang
after insert
as
begin
	declare @tien int = (select TongTien from inserted)
	update TaiKhoan
	set SoDu = SoDu - @tien
	where MaTaiKhoan = '156'
end
go

create trigger ChangeSoDuTru1 on PhieuMuaHang
after delete
as
begin
	declare @tien int = (select TongTien from deleted)
	update TaiKhoan
	set SoDu = SoDu + @tien
	where MaTaiKhoan = '156'
end
go

create trigger addKho on PhieuMuaHang
after insert
as
begin 
	declare @macn char(10),@mahh char(10), @sl int;
	select @macn = MaChiNhanh, @mahh = MaHangHoa,@sl = SoLuong from inserted;
	insert into Kho values (@macn,@mahh,@sl);
end
go

select * from TaiKhoan where MaTaiKhoan = '156'
INSERT INTO PhieuMuaHang (MaPhieu,MaChiNhanh, MaHangHoa, NgayDat, NgayGiao, SoLuong, TongTien, Mota)
VALUES ('PMH04','CN001', 'HH001' ,'2023-03-01', '2023-03-15', 100, 10000, N'Mua hàng l?n ??u')
