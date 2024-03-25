create database CuaHangTruyen
use CuaHangTruyen

create table truyen (
	tentruyen nvarchar(100) primary key,
	giatruyen int
);

create table khachhang (
	stt int identity,
	tenkhach nvarchar(100),
	sdt varchar(100),
	tentruyen nvarchar(100) references truyen(tentruyen),
	dongia int,
	ngaymuon date,
	ngaytra date,
	thanhtien int,
	ghichu nvarchar(100)
);

select * from khachhang

insert into truyen values('doremon', 50000)
insert into truyen values('conan', 100000)
insert into truyen values('shin',50008)
insert into truyen values('naruto',50008)
insert into truyen values('bleach',50008)
insert into truyen values('mono',50008)
insert into truyen values('maokai',50008)

select * from truyen

drop table khachhang


select stt as 'STT', tenkhach as 'Tên khách', sdt as 'Số điện thoại', khachhang.tentruyen as 'Tên truyện', ngaymuon as 'Ngày mượn', ngaytra as 'Ngày trả', thanhtien as 'Thành tiền', ghichu as 'Ghi chú', truyen.giatruyen from khachhang join truyen on khachhang.tentruyen = truyen.tentruyen
select truyen.giatruyen, stt as 'STT', tenkhach as 'Tên khách', sdt as 'Số điện thoại', khachhang.tentruyen as 'Tên truyện', ngaymuon as 'Ngày mượn', ngaytra as 'Ngày trả', thanhtien as 'Thành tiền', ghichu as 'Ghi chú' from khachhang join truyen on khachhang.tentruyen = truyen.tentruyen

select truyen.giatruyen, stt as 'STT', tenkhach as 'Tên khách', sdt as 'Số điện thoại', khachhang.tentruyen as 'Tên truyện', ngaymuon as 'Ngày mượn', '' as 'Ngày trả', '' as 'Thành tiền', ghichu as 'Ghi chú' from khachhang join truyen on khachhang.tentruyen = truyen.tentruyen

insert into khachhang (tenkhach, sdt, tentruyen, ngaymuon, ngaytra, thanhtien, ghichu) values ('nhật', '0123456789', 'doremon', '2024/12/1', '2024/12/17', 90000, 'Chưa trả');
insert into khachhang (tenkhach, sdt, tentruyen, ngaymuon, ngaytra, thanhtien, ghichu) values ('nhật', '0123456789', 'naruto', '2024/12/1', '2024/12/17', 200000, 'Chưa trả');
insert into khachhang (tenkhach, sdt, tentruyen, ngaymuon, ngaytra, thanhtien, ghichu) values ('nhật', '0123456789', 'bleach', '2024/12/1', '2024/12/17', 10000, 'Chưa trả');
insert into khachhang (tenkhach, sdt, tentruyen, ngaymuon, ngaytra, thanhtien, ghichu) values ('nhật', '0123456789', 'mono', '2024/12/1', '2024/12/17', 90000, 'Chưa trả');
insert into khachhang (tenkhach, sdt, tentruyen, ngaymuon, ngaytra, thanhtien, ghichu) values ('nhật', '0123456789', 'maokai', '2024/12/1', '2024/12/17', 90000, 'Chưa trả');

select truyen.giatruyen from truyen inner join khachhang on khachhang.tentruyen = truyen.tentruyen where truyen.tentruyen = 'mono'


insert into khachhang (tenkhach, sdt, tentruyen, ghichu) values ('test123', '0123456789', 'maokai', 'Chưa trả');
select truyen.giatruyen, stt as 'STT', tenkhach as 'Tên khách', sdt as 'Số điện thoại', khachhang.tentruyen as 'Tên truyện', ngaymuon as 'Ngày mượn', case when ghichu = 'Chưa trả' then '' else ngaytra end as 'Ngày trả', case when ghichu = 'Chưa trả' then '' else thanhtien end as 'Thành tiền', ghichu as 'Ghi chú' from khachhang join truyen on khachhang.tentruyen = truyen.tentruyen 


SELECT 
    truyen.giatruyen, 
    stt AS 'STT', 
    tenkhach AS 'Tên khách', 
    sdt AS 'Số điện thoại', 
    khachhang.tentruyen AS 'Tên truyện', 
    ngaymuon AS 'Ngày mượn', 
    CASE 
        WHEN ghichu = 'Chưa trả' THEN NULL 
        ELSE ngaytra 
    END AS 'Ngày trả', 
    CASE 
        WHEN ghichu = 'Chưa trả' THEN NULL
        ELSE thanhtien
    END AS 'Thành tiền', 
    ghichu AS 'Ghi chú' 
FROM 
    khachhang 
JOIN 
    truyen ON khachhang.tentruyen = truyen.tentruyen;


select thanhtien 
case when ghichu = 'Chưa trả' then '' else thanhtien end
from khachhang