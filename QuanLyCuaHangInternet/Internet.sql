create database QL_Internet;
use QL_Internet;

Create table BangKe (
	STT INT IDENTITY primary key,
	SoMay nvarchar(30),
	GioVao int,
	GioRa int,
	SoGio int,
	DonGia int, 
	ThanhTien int
);


INSERT INTO BangKe (SoMay, GioVao, GioRa, SoGio, DonGia, ThanhTien) VALUES ('Máy 1', 5, 12, 7, 5000, 35000);

Select STT, SoMay as 'Số máy', GioVao as 'Giờ vào', GioRa as 'Giờ ra', SoGio as 'Số giờ sử dụng', DonGia as 'Đơn giá/Giờ', ThanhTien as 'Thành tiền' From BangKe