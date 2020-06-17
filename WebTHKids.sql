CREATE DATABASE WebTHKids
ON PRIMARY 
(
	size = 40Mb,
	filegrowth = 10%,
	maxsize = 50Mb,
	filename = 'D:\WebTHKids\WebTHKids.mdf',
	name = WebTHKids_1
)
LOG ON
(
	size = 10Mb,
	filegrowth=10%,
	maxsize = 15Mb,
	filename = 'D:\WebTHKids\WebTHKids.ldf',
	name = WebTHKids_1_log
)
go

USE WebTHKids
GO
CREATE TABLE QuanTriVien(
		ID char(15) not null primary key,
		username nvarchar (50) not null unique,
		pass nvarchar (30) not null
		)
CREATE TABLE NhanVien(
       MaNhanVien char(15) not null primary key,
	   HoTen nvarchar(50) not null,
	   TenDangNhap nvarchar(30) not null,
	   MatKhau nvarchar(30) not null,
	   NgayVaoLam date null
	   )

CREATE TABLE KhachHang(
       MaKhachHang char(15) not null primary key,
	   HoTen nvarchar(50) not null,
	   Email nvarchar(50) not null,
	   DiaChi nvarchar(1000) not null,
	   SoDienThoai int not null,
	   TenDangNhap varchar(500) null,
	   MatKhau varchar(50) null,
	   NgaySinh smalldatetime null,
	   GioiTinh bit null,
	   ThoiGianDangKy date null
	   )

CREATE TABLE DanhMuc(
       MaDanhMuc char(15) not null primary key,
	   TenDanhMuc nvarchar(50) not null unique
	   )

CREATE TABLE DanhMucSanPham(
       MaDMSP char(15) primary key not null,
	   MaDanhMuc char(15) references DanhMuc(MaDanhMuc) null,
	   TenDMSP nvarchar(50) not null unique
	   )

CREATE TABLE KichCo
(
	MaKichCo char(10) not null primary key,
	TenKichCo nvarchar(100) not null unique,
)

CREATE TABLE ChatLieu
(
	MaChatLieu char(10) not null primary key,
	TenChatLieu nvarchar (100) not null unique
)

CREATE TABLE NhaSanXuat
(
	MaNhaSanXuat char(10) not null primary key,
	TenNhaSanXuat nvarchar (100) not null unique,
	DiaChiNSX nvarchar (200) null,
	SoDienThoaiNSX int null
)


CREATE TABLE SanPham(
       MaSanPham char(15) not null primary key,
	   MaDMSP char(15) references DanhMucSanPham(MaDMSP) not null,
	   MaKichCo char(10) references KichCo (MaKichCo) null,
	   MaChatLieu char(10) references ChatLieu(MaChatLieu) null,
	   MaNhaSanXuat char(10) references NhaSanXuat(MaNhaSanXuat) null,
	   TenSanPham nvarchar(50) not null,
	   GiaSanPham money not null,
	   GiaChietKhau money null,
	   SoLuong int null,
	   SoLuongBan int null,
	   LinkAnh varchar(50) not null,
	   LinkListAnh text not null,
	   ThongTinSP ntext null,
	   NgayCapNhat smalldatetime null,
	   LuotXem int null,
	   LuotMua int null
	   )

CREATE TABLE DonHang(
       MaDonHang char(15) not null primary key,
	   MaNhanVien char(15) references NhanVien(MaNhanVien) not null,
	   MaKhachHang char(15) references KhachHang(MaKhachHang) not null,
	   TrangThaiDon nvarchar(50) not null,
	   TongTien money not null,
	   ThoiGianTaoDonHang date null,
	   ThoiGianThanhToan date not null,
	   ThoiGianGiaoHang date null,
	   GhiChu nvarchar(50) null
	   )

CREATE TABLE ChiTietDonHang(
       SoHieuDonHang char(15) not null primary key,
	   MaDonHang char(15) references DonHang(MaDonHang) not null,
	   MaSanPham char(15) references SanPham(MaSanPham) not null,
	   SoLuongSanPham int not null,
	   GiaSanPham money not null,
	   GhiChu nvarchar(MAX) null
	   )


