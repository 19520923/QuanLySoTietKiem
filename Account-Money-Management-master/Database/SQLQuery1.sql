create database QuanLySoTietKiem
use QuanLySoTietKiem
set dateformat dmy

CREATE TABLE TaiKhoan
(
	TenDangnhap VARCHAR(100) NOT NULL,
	MatKhau VARCHAR(100) NOT NULL
)
CREATE TABLE KhachHang
(
	MaKhachHang VARCHAR(20) NOT NULL PRIMARY KEY,
	HoTen NVARCHAR(100) NOT NULL,
	GioiTinh NVARCHAR(3) NOT NULL,
	NgaySinh DATETIME NOT NULL,
	DiaChi NVARCHAR(256) NOT NULL,
	SoDienThoai NVARCHAR(10) NOT NULL,
	CMND NVARCHAR(40) NOT NULL,
	NgayCap DATETIME NOT NULL,
	NoiCap NVARCHAR(256) NOT NULL,
)	

CREATE TABLE LoaiTietKiem
(
	MaLoaiTietKiem VARCHAR(20) NOT NULL PRIMARY KEY,
	TenLoaiTietKiem NVARCHAR(100) NOT NULL,
	KyHan INT NOT NULL,
	LaiSuat FLOAT NOT NULL,
)
CREATE TABLE SoTietKiem
(
	MaSoTietKiem VARCHAR(20) NOT NULL PRIMARY KEY,
	MaKhachHang VARCHAR(20) NOT NULL,
	MaLoaiTietKiem VARCHAR(20) NOT NULL,
	NgayMoSo DATETIME NOT NULL,
	SoTienGuiTietKiem INT NOT NULL,
	SoLanDaoHan INT NOT NULL,
	TienLai INT NOT NULL,
	SoDu INT NOT NULL,
	TrangThaiSo INT NOT NULL,
)
CREATE TABLE PhieuGuiTien
(
	MaPhieuGui VARCHAR(20) NOT NULL PRIMARY KEY,
	MaSoTietKiem VARCHAR(20) NOT NULL,
	SoTienGui VARCHAR(100) NOT NULL,
	NgayGui DATETIME NOT NULL,	
)

CREATE TABLE PhieuRutTien
(
	MaPhieuRut VARCHAR(20) NOT NULL PRIMARY KEY,
	MaSoTietKiem VARCHAR(20) NOT NULL,
	SoTienRut VARCHAR(100) NOT NULL,
	NgayRut DATETIME NOT NULL,	
)

CREATE TABLE ChiTietBaoCaoNgay
(
	MaChiTietBaoCao VARCHAR(20) NOT NULL PRIMARY KEY,
	MaLoaiTietKiem VARCHAR(20) NOT NULL,
	SoTienThu INT NOT NULL,
	SoTienChi INT NOT NULL,
	ChenhLech INT NOT NULL,
	NgayLap DATETIME NOT NULL,	
)
CREATE TABLE ChiTietBaoCaoThang
(
	MaChiTietBaoCaoThang VARCHAR(20) NOT NULL PRIMARY KEY,
	NgayMoSo DATETIME NOT NULL,	
	MaSoTietKiem VARCHAR(20) NOT NULL,
	MaLoaiTietKiem VARCHAR(20) NOT NULL,
	SoMo INT NOT NULL,
	SoDong INT NOT NULL,
	ChenhLech INT NOT NULL,
)

CREATE TABLE ThamSo
(
	MaThamSo VARCHAR(20) NOT NULL PRIMARY KEY,
	SoTienGuiToiThieu INT NOT NULL,
	SoTienGuiThemToiThieu INT NOT NULL,
	ThoiGianGuiToiThieu INT NOT NULL,
)

alter table SoTietKiem add constraint FK_STK_KH foreign key (MaKhachHang) references KhachHang (MaKhachHang)
alter table SoTietKiem add constraint FK_STK_LTK foreign key (MaLoaiTietKiem) references LoaiTietKiem (MaLoaiTietKiem)

alter table PhieuGuiTien add constraint FK_PGT_STK foreign key (MaSoTietKiem) references SoTietKiem (MaSoTietKiem)
alter table PhieuRutTien add constraint FK_PRT_STK foreign key (MaSoTietKiem) references SoTietKiem (MaSoTietKiem)

alter table ChiTietBaoCaoNgay add constraint FK_BCN_LTK foreign key (MaLoaiTietKiem) references LoaiTietKiem (MaLoaiTietKiem)
alter table ChiTietBaoCaoThang add constraint FK_BCT_LTK foreign key (MaLoaiTietKiem) references LoaiTietKiem (MaLoaiTietKiem)
alter table ChiTietBaoCaoThang add constraint FK_BCT_STK foreign key (MaSoTietKiem) references SoTietKiem (MaSoTietKiem)
 
insert into TaiKhoan(TenDangnhap,MatKhau) values ('admin1', '123456')
insert into TaiKhoan(TenDangnhap,MatKhau) values ('admin2', '123456')

insert into KhachHang(MaKhachHang,HoTen,GioiTinh,NgaySinh,DiaChi,SoDienThoai,CMND,NgayCap,NoiCap) values ('KH001', 'Nguyen Van A', 'Nam', '23-1-2006', 'Quan 1, TP.Ho Chi Minh', '0364768956', '215564895', '26/8/2010', 'TP.Ho Chi Minh' )
insert into KhachHang(MaKhachHang,HoTen,GioiTinh,NgaySinh,DiaChi,SoDienThoai,CMND,NgayCap,NoiCap) values ('KH002','Le Thi B', 'Nu', '23-1-1996', 'Quan 9, TP. TP.Ho Chi Minh', '0364768956', '215564895', '26/8/2010', 'TP.Ho Chi Minh' )
insert into KhachHang(MaKhachHang,HoTen,GioiTinh,NgaySinh,DiaChi,SoDienThoai,CMND,NgayCap,NoiCap) values ('KH003', N'Lê Thị C', N'Nữ', '23-1-1996', N'Quận 9, TP. TP.Hồ Chí Minh', N'0364768956', N'215564895', '26/8/2010', N'TP.Hồ Chí Minh' )

insert into LoaiTietKiem(MaLoaiTietKiem,TenLoaiTietKiem,KyHan,LaiSuat) values ('LTK001', N'Không Kỳ Hạn', 0, 0.15)
insert into LoaiTietKiem(MaLoaiTietKiem,TenLoaiTietKiem,KyHan,LaiSuat) values ('LTK002', N'3 Tháng', 3, 0.5)
insert into LoaiTietKiem(MaLoaiTietKiem,TenLoaiTietKiem,KyHan,LaiSuat) values ('LTK003', N'6 Tháng', 6, 0.55)

insert into SoTietKiem(MaSoTietKiem,MaKhachHang,MaLoaiTietKiem,NgayMoSo,SoTienGuiTietKiem,SoLanDaoHan,TienLai, SoDu,TrangThaiSo) values ('STK001', 'KH001', 'LTK002', '12-05-2020', 1000000, 0, 0, 1000000, 1)

insert into PhieuGuiTien(MaPhieuGui,MaSoTietKiem,SoTienGui,NgayGui) values ('PG001', 'STK001', 1000000, '12-5-2015')
insert into PhieuRutTien(MaPhieuRut,MaSoTietKiem,SoTienRut,NgayRut) values ('PR001', 'STK002', 1000000, '12-5-2020')

insert into ThamSo(MaThamSo,SoTienGuiToiThieu,SoTienGuiThemToiThieu,ThoiGianGuiToiThieu) values ('TH001', 100000, 100000, 15)