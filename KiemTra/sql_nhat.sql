create database db
use db

create table canbo(
	hoten nvarchar(100),
	gioitinh nvarchar(100),
	quequan nvarchar(100),
	donvi nvarchar(100),
	hocvi nvarchar(100)
)

drop table canbo
select hoten as 'Họ tên', gioitinh as 'Giới tính', quequan as 'Quê quán', donvi as 'Đơn vị', hocvi as 'Học hàm / Học vị' from canbo where quequan like 'ha noi'

select * from canbo 

insert into canbo values('nhat', 'nam', 'ha noi', 'tlu', 'hoc sinh')
insert into canbo values('nhat', 'nu', 'ha noi', 'tlu', 'hoc sinh')
insert into canbo values('nhat', 'nam', 'ha noi', 'tlu', 'hoc sinh')
insert into canbo values('nhat', 'nu', 'ha noi', 'tlu', 'hoc sinh')
insert into canbo values('nhat', 'nam', 'ha noi', 'tlu', 'hoc sinh')
insert into canbo values('nhat', 'nu', 'ha noi', 'tlu', 'hoc sinh')
insert into canbo values('nhat', 'nam', 'moc chau', 'tlu', 'hoc sinh')