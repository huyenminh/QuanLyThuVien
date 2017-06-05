create table thuthu
(
matt char(10) primary key,
tentt nvarchar(50) not null,
diachi nvarchar(50),
ngaysinh date,
mags char(10)
)
create table nganhhoc (
manganh int identity ,
tennganh nvarchar(50) primary key 
)
create table lop (
malop int identity ,
tenlop char(20) primary key 
)
create table loaidocgia(
maloai int identity ,
loaidg nvarchar(50) primary key 
)
create table docgia
(
madg char(10) primary key,
tendg nvarchar(50) not null,
ngaysinh date,
diachi nvarchar(50), 
nganh nvarchar(50) references nganhhoc(tennganh) ,
Lop char(20) references lop(tenlop), 
khoahoc char(30),
ngaycapnhat datetime , 
loaidg nvarchar(50) references loaidocgia(loaidg)
) 
  
create table nxb
(
manxb char(10) primary key,
tennxb nvarchar(50),
diachi nvarchar(50)
)
 
create table ngonngu (
mangonngu int identity ,
tenngonngu nvarchar(50) primary key 
)
create table tacgia
(
matg char(10) primary key,
tentg nvarchar(50),
diachi nvarchar(50)
)
create table dausach
( 
masach char(10) primary key ,
tensach nvarchar(50),
manxb char(10) references nxb(manxb), 
sotrang int,
giabia int,
nganhhoc nvarchar(50),
ngonngu nvarchar(50),
namxuatban datetime, 
tinhtrang nvarchar(50) ,
matg char(10)  references tacgia (matg),
soluongtaiban int
)
create table phieumuontra
(
maphieu char(10) primary key, 
socuonmuonve int ,
madg char(10) references docgia(madg), 
matt char(10) references thuthu(matt) 
  )
 
create table cuonsach
(
macs char(10) primary key,
tinhtrang nvarchar(50), 
maphieu char(10) references phieumuontra(maphieu),
masach char(10) references dausach(masach),
tentg nvarchar(50),
coluongcon int
 )
  
create table chitietphieumuon
(
id int identity ,
macs char(10) references cuonsach(macs),
maphieu char(10) references phieumuontra(maphieu),
tinhtrangtruocchomuon nvarchar(50),
tinhtrangsauchomuon nvarchar(50),
ngaymuon date,
ngaytra date ,
ngayhentra date,
songayhethan int,
socuon int
)
create table nguoidung(
STT int identity primary key,
tendangnhap nvarchar(50),
matkhau nvarchar(50),
)