create database QLCAFE
use QLCAFE

create table dathang (
	madh nvarchar(10) primary key,
	soban nvarchar(20),
	douong nvarchar(50),
	soluong int,
	gia int,
	ngay date
);

insert into dathang values('n12', 'ban1', 'cafe', 5, 10000, '2004-12-9')
insert into dathang values('n13', 'ban1', 'coca', 5, 10000, '2004-12-9')
insert into dathang values('n14', 'ban1', 'pepsi', 5, 10000, '2004-12-9')
insert into dathang values('n15', 'ban1', 'cafe', 5, 10000, '2004-12-9')
insert into dathang values('b52', 'ban1', 'cafe', 5, 10000, '2004-12-9')
insert into dathang values('af2', 'ban1', 'cafe', 5, 10000, '2004-12-9')
insert into dathang values('ssf2', 'ban1', 'cafe', 5, 10000, '2004-12-9')
insert into dathang values('vs2', 'ban1', 'cafe', 5, 10000, '2004-12-9')
insert into dathang values('fs2', 'ban1', 'cafe', 5, 10000, '2004-12-9')
insert into dathang values('av2', 'ban1', 'cafe', 5, 10000, '2004-12-9')