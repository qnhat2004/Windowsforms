create database CuaHangTruyen
use CuaHangTruyen

create table thongtin (
	stt int primary key,
	tenkhach nvarchar(100),
	sdt int,
	tentruyen nvarchar(100),
	ngaymuon datetime,
	ngaytra datetime,
	thanhtien int,
	ghichu nvarchar(100)
);
