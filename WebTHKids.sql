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

CREATE TABLE ThuongHieu
(
	MaThuongHieu char(10) not null primary key,
	TenThuongHieu nvarchar (100) not null unique,
	DiaChi nvarchar (200) null,
	SoDienThoai int null
)


CREATE TABLE SanPham(
       MaSanPham char(15) not null primary key,
	   MaDMSP char(15) references DanhMucSanPham(MaDMSP) not null,
	   MaKichCo char(10) references KichCo (MaKichCo) null,
	   MaChatLieu char(10) references ChatLieu(MaChatLieu) null,
	   MaThuongHieu char(10) references ThuongHieu(MaThuongHieu) null,
	   TenSanPham nvarchar(50) not null,
	   GiaSanPham money not null,
	   GiaChietKhau money null,
	   SoLuong int null,
	   LinkAnh varchar(max) not null,
	   LinkListAnh text not null,
	   ThongTinSP nvarchar(max) null,
	   NgayCapNhat smalldatetime null,
	   SoLuongMua int null
	   )

CREATE TABLE TrangThaiDonHang(
       MaTrangThai char(15) not null primary key,
	   TenTrangThai nvarchar(50)
	   )

CREATE TABLE DonHang(
       MaDonHang char(15) not null primary key,
	   MaNhanVien char(15) references NhanVien(MaNhanVien) not null,
	   MaKhachHang char(15) references KhachHang(MaKhachHang) not null,
	   MaTrangThai char(15) references TrangThaiDonHang(MaTrangThai) not null,
	   TongTien money not null,
	   ThoiGianTaoDonHang date null,
	   ThoiGianThanhToan date not null,
	   ThoiGianGiaoHang date null,
	   GhiChu nvarchar(max) null
	   )

CREATE TABLE ChiTietDonHang(
       SoHieuDonHang char(15) not null primary key,
	   MaDonHang char(15) references DonHang(MaDonHang) not null,
	   MaSanPham char(15) references SanPham(MaSanPham) not null,
	   SoLuongSanPham int not null,
	   GiaSanPham money not null,
	   GhiChu nvarchar(MAX) null
	   )


