create database QL_BigC

USE QL_BigC
GO

create table ChiNhanh 
(
	MaChiNhanh char(10) primary key,
	TenChiNhanh nvarchar(30) unique,
	DiaChi nvarchar(100) unique,
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
	SoNhanVienQuanLy int CHECK (SoNhanVienQuanLy > 0),
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
	MaQuanLy char(10),
	constraint FK_NhanVien foreign key (MaQuanLy) references QuanLy(MaQuanLy)
)


create table QL_NhanVien
(
	MaNhanVien char(10),
	MaQuanLy char(10),
	constraint FK_QL foreign key (MaNhanVien) references NhanVien(MaNhanVien),
	constraint FK_QL2 foreign key (MaQuanLy) references QuanLy(MaQuanLy)
)



create table Luong
(
	MaNhanVien char(10),
	MaLuong char(10) primary key,
	MaQuanLy char(10),
	MaChiNhanh char(10),
	Luong int,
	Thue float,
	ChietKhau float,
	TongLuong int,
	constraint FK_Luong foreign key (MaQuanLy) references QuanLy(MaQuanLy),
	constraint FK_Luong1 foreign key (MaNhanVien) references NhanVien(MaNhanVien),
	constraint FK_Luong2 foreign key (MaChiNhanh) references ChiNhanh(MaChiNhanh)
)

Create table UserLogin
(
	UserName char(50) primary key,
	Pass char(50)
)


insert into ChiNhanh values 
('CN01',N'Big C Trường Chinh','144 Trường Chinh , Tân Phú, TPHCM')

insert into QuanLy values 
('QL01',N'Hồ Thanh Hải','2003-08-27',N'55a Nguyễn Đỗ Cung','0384631254','052203011677','2021-05-15',28,'CN01',21)

insert into NhanVien values
('NV01',N'Nguyễn Ngọc Hải','2003-01-27',N'77 Lê Trọng Tấn','0366985488','053365448484','2022-03-02',15,'QL01'),
('NV02',N'Nguyễn Ngọc Hải1','2003-01-27',N'77 Lê Trọng Tấn','0366985483','053365448481','2022-03-02',15,'QL01'),
('NV03',N'Nguyễn Ngọc Hải2','2003-01-27',N'77 Lê Trọng Tấn','0366985484','053365448482','2022-03-02',12,'QL01'),
('NV04',N'Nguyễn Ngọc Hải3','2003-01-27',N'77 Lê Trọng Tấn','0366985485','053365448485','2022-03-02',19,'QL01'),
('NV05',N'Nguyễn Ngọc Hải4','2003-01-27',N'77 Lê Trọng Tấn','0366985486','053365448489','2022-03-02',16,'QL01'),
('NV06',N'Nguyễn Ngọc Hải5','2003-01-27',N'77 Lê Trọng Tấn','0366985487','053365448486','2022-03-02',18,'QL01')

