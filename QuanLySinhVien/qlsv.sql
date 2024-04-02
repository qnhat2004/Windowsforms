create database QuanLySinhVien
use QuanLySinhVien

create table khoa (
	makhoa nchar(6) primary key,
	tenkhoa nchar(30)
);

---> 1: Nam, 0: Nu
create table sinhvien (
	maso int primary key identity,
	hoten nvarchar(50),
	ngaysinh datetime,
	gioitinh bit, 
	diachi nvarchar(50),
	dienthoai int,
	makhoa nchar(6) foreign key references khoa(makhoa)
)

create table mon (
	mamh nchar(6) primary key,
	tenmh nchar(50),
	sotiet int
);

create table ketqua (
	maso int,
	mamh nchar(6),
	diem int,
	primary key(maso, mamh),
	foreign key (maso) references sinhvien(maso),
	foreign key (mamh) references mon(mamh)
);

insert into khoa values('cntt', 'Cong nghe thong tin')
insert into khoa values('kt', 'Kinh te')
insert into khoa values('luat', 'luat va ly luan ct')
insert into khoa values('ketoan', 'Ke toan')
insert into khoa values('dulich', 'Du lich')

select * from khoa

insert into mon values('oop', 'Huong doi tuong', 35)
insert into mon values('nmlt', 'Nhap mon lap trinh', 35)
insert into mon values('mmt', 'Mang may tinh', 35)
insert into mon values('pttk', 'Phan tich thiet ke', 35)
insert into mon values('triet', 'Triet hoc Mac-Lenin', 35)

select * from mon

insert into sinhvien(hoten, ngaysinh, gioitinh, diachi, dienthoai, makhoa) values('nhat', '2004-8-17', 1, 'Ha Noi', 0123456789, 'cntt')
insert into sinhvien(hoten, ngaysinh, gioitinh, diachi, dienthoai, makhoa) values('hieu', '2004-8-17', 1, 'Ha Noi', 0123456789, 'dulich')
insert into sinhvien(hoten, ngaysinh, gioitinh, diachi, dienthoai, makhoa) values('quang', '2004-8-17', 1, 'Ha Noi', 0123456789, 'kt')
insert into sinhvien(hoten, ngaysinh, gioitinh, diachi, dienthoai, makhoa) values('khoa', '2004-8-17', 0, 'Ha Noi', 0123456789, 'luat')
insert into sinhvien(hoten, ngaysinh, gioitinh, diachi, dienthoai, makhoa) values('linh', '2004-8-17', 0, 'Ha Noi', 0123456789, 'ketoan')

select * from sinhvien

insert into ketqua values (1, 'oop', 10)
insert into ketqua values (2, 'mmt', 10)
insert into ketqua values (3, 'nmlt', 10)
insert into ketqua values (4, 'pttk', 10)
insert into ketqua values (5, 'triet', 10)

select * from ketqua