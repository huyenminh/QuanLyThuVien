create table nguoidung(
STT int identity primary key,
tendangnhap nvarchar(50),
matkhau nvarchar(50),
)
--them người dùng
alter proc themnd @tendangnhap nvarchar(50),@matkhau nvarchar(50)
as
begin
insert into nguoidung(tendangnhap,matkhau)
values(@tendangnhap,@matkhau)
end
--sửa
create proc suand @STT int,@tendangnhap nvarchar(50),@matkhau nvarchar(50)
as
begin
update nguoidung set tendangnhap=@tendangnhap,matkhau=@matkhau
where  STT=@STT
end
--xóa
create proc xoand @stt int
as
begin
delete nguoidung
where STT=@STT
end