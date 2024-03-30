create database bacsinhakhoa
use bacsinhakhoa

create table bacsi (
	id int primary key identity,
	hoten nvarchar(50),
	gioitinh nvarchar(10),
	quequan nvarchar(50),
	chucdanh nvarchar(50),
	ngaysinh date
)

drop table bacsi

insert into bacsi(hoten, gioitinh, quequan, chucdanh, ngaysinh) values ('nhat', 'Nam', 'vn', 'học sinh', '2004-8-17')