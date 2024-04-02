create database quancafe
use quancafe

create table douong (
	tendouong nvarchar(50) primary key,
	gia int
)

create table ban (
	stt int identity,
	soban nvarchar(10),
	tendouong nvarchar(50) foreign key references douong(tendouong),
	ghichu nvarchar(50),
	soluong int,
	thanhtien int
)

drop table ban
drop table douong
select douong.gia, soban as 'Số bàn', ban.tendouong as 'Tên đồ uống', ghichu as 'Ghi chú', soluong as 'Số lượng', thanhtien as 'Thành tiền' from ban join douong on ban.tendouong = douong.tendouong

select douong.gia from douong where tendouong = 'nâu đen' 

insert into douong(tendouong, gia) values('sting', 25000), ('pepsi', 30000), ('cola', 45000), ('7up', 55000), ('fanta', 70000)
select * from douong
select gia from douong where tendouong = 'nâu den' 
insert into ban values('Bàn 1', 'nâu đen', '', 2, 25000, 50000)
insert into ban values('Bàn 2', 'nâu đá', '', 2, 30000, 60000)
insert into ban values('Bàn 3', 'chồn', '', 2, 45000, 90000)
insert into ban values('Bàn 4', 'coffee', '', 2, 55000, 110000)
insert into ban values('Bàn 5', 'coca', '', 2, 70000, 140000)