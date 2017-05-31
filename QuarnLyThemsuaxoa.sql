
                                    --THÊM PHIẾU MƯỢN TRẢ

create proc themphieumuontra @ma char(10),@scmv int,@madg char(10),@matt char(10)
as
begin
insert into phieumuontra(maphieu,socuonmuonve,madg,matt)
values (@ma,@scmv,@madg,@matt)
end
                            
                                   --SỬA PHIẾU MƯỢN TRẢ
create proc suaphieumuontra @ma char(10),@socuonmuonve int
as
begin
update phieumuontra
set socuonmuonve=@socuonmuonve
where maphieu=@ma
end
                 --XÓA PHIẾU MƯỢN TRẢ
create proc xoaphieumuontra @ma char(10)
as
begin
delete phieumuontra
where maphieu=@ma
end
                             --THÊM ĐỘC GIẢ
alter proc themdocgia (@madg char(10),@ten nvarchar(50),@ngaysinh date,@diachi nvarchar(50),@kh char(30),@nganh nvarchar(50),@lop char(20),@ncn datetime ,@loaidg nvarchar(50))
as
 begin
 insert into docgia(madg,tendg,ngaysinh,diachi,khoahoc,nganh,Lop,ngaycapnhat,loaidg)
 values(@madg,@ten,@ngaysinh,@diachi,@kh,@nganh,@lop,@ncn,@loaidg)
 end
                                     --SỬA ĐỘC GIẢ
create proc suadocgia @ma char(10),@ten nvarchar(50),@diachi nvarchar(50)
as 
begin
update docgia
set diachi=@diachi
where madg=@ma and tendg=@ten
end
         
                                    --XÓA ĐỘC GIẢ
create proc xoadocgia( @ma char(10),@ten nvarchar(50))
as
begin
delete docgia
where madg=@ma and tendg=@ten
end
                   --TÌM KIẾM ĐỘC GIẢ
create proc timkiemdocgia @ten nvarchar(50)
as
begin 
select *from docgia
where tendg like '%'+@ten+'%'
end 
                   --THÊM CHI TIẾT PHIẾU MƯa
alter   proc themchitietphieumuon @macs char(10),@maphieu char(10),@tinhtrangtruoc nvarchar(50),@tinhtrangsau nvarchar(50),@ngaymuon date ,@ngaytra date ,@ngayhentra date ,@songayhethan int,@socuon int
as
begin 
insert into chitietphieumuon(macs,maphieu,tinhtrangtruocchomuon,tinhtrangsauchomuon,ngaymuon,ngaytra,ngayhentra,songayhethan,socuon)
values (@macs,@maphieu,@tinhtrangtruoc,@tinhtrangsau,@ngaymuon,@ngaytra,@ngayhentra,@songayhethan,@socuon)
update phieumuontra  set
  socuonmuonve = socuonmuonve + '1'
end
             --SỬA CHI TIẾT PHIẾU MƯỢN
 create proc suachitietphieumuon @macs char(10),@maphieu char(10),@tinhtrangsau nvarchar(50)
as
begin
update chitietphieumuon
set tinhtrangsauchomuon=@tinhtrangsau
where macs=@macs and maphieu=@maphieu
end 
                --XÓA CHI TIẾT PHIẾU MƯỢN
alter proc xoachitietphieumuon @macs char(10),@maphieu char(10)
as
begin
delete chitietphieumuon
where macs=@macs and maphieu=@maphieu
update phieumuontra set socuonmuonve=socuonmuonve - '1'
end
 alter proc xemchitietmuontra(@ma char(10))
as
begin
select * from chitietphieumuon
where maphieu= @ma
end
                        

                                      -- ĐẦU SÁCH 

                                       --THÊM 

alter proc Themdausach(@madausach char(10), @tendausach nvarchar(50), @manxb char(10),@st int,@giabia int , @nganhhoc nvarchar(50),@nn nvarchar(50),@namxb datetime ,@tt nvarchar(50),@matg char(10),@sltaiban int)
as
 begin
 insert into dausach(masach, tensach, manxb,sotrang,giabia,nganhhoc,ngonngu,namxuatban,tinhtrang,matg,soluongtaiban)
 values (@madausach, @tendausach, @manxb,@st,@giabia,@nganhhoc,@nn,@namxb,@tt,@matg,@sltaiban)
 end

                           --SỬA
      create  proc Suadausach(@madausach char(10), @tendausach nvarchar(50), @manxb char(10))
	 as
	 begin
	 update dausach
	 set
	 tensach= @tendausach,
	 manxb= @manxb
	 where
		 masach= @madausach
		 and @manxb in (select manxb from nxb)
		  
		 end
		                --XÓA
create proc Xoadausach(@madausach char(10))
as
begin
delete dausach
where masach=@madausach
end
                    
					  
                                      --CUỐN SÁCH

                                      --THÊM
create  proc Themcuonsach(@macs char(10), @tinhtrang nvarchar(50),@mp char(10),@masach char(10),@tentg nvarchar(50),@soluongcon int)
as
 begin
 insert into cuonsach(macs, tinhtrang,maphieu,masach,tentg,coluongcon)
 values (@macs, @tinhtrang,@mp,@masach,@tentg,@soluongcon)
 end

                              --SỬA
 create proc Suacuonsach(@macs char(10), @tinhtrang nvarchar(50), @masach char(10),@soluoncon int)
 as
  begin
  update cuonsach
  set
     tinhtrang=@tinhtrang,
	 masach=@masach,
	 coluongcon= @soluoncon
  where 
    macs= @macs
	and masach in (select masach from dausach)
end
                              
							  ----Xoa
create proc Xoacuonsach(@macuonsach char(10))
as
begin
delete
from cuonsach
where macs= @macuonsach 
end
                --THỦ THƯ
									 --THÊM THỦ THƯ

	create proc themthuthu @matt char(10),@ten nvarchar(50),@ngaysinh date,@diachi nvarchar(50),@mags char(10)
	as
	begin
	insert into thuthu
	values(@matt,@ten,@ngaysinh,@diachi,@mags)
	end
	select*from thuthu
									 --SỬA THỦ THƯ
   create proc suathuthu @matt char(10),@ten nvarchar(50),@diachi nvarchar(50)
   as
   begin
   update thuthu
   set diachi=@diachi
   where matt=@matt and tentt=@ten
   end

									 --XÓA THỦ THƯ
  create proc xoathuthu @matt char(10),@tentt nvarchar(50)
  as
  begin
  delete
  from thuthu
  where matt=@matt and tentt=@tentt
  end
         
                                   --TÁC GIẢ
                                   --SỬA TÁC GIẢ
create proc suatacgia(@ma char(10),@ten nvarchar(50))
as 
begin
update tacgia
set tentg=@ten
where matg=@ma
end
                                    --XÓA TÁC GIẢ
create proc xoatacgia(@ma char(10),@ten nvarchar(50))
as
begin
delete tacgia
where matg=@ma and tentg=@ten 
end
                                   -- THÊM TÁC GIẢ
create proc themtacgia(@ma char(10),@ten nvarchar(50),@diachi nvarchar(50))                    
as
begin
insert into tacgia(matg,tentg,diachi)
values(@ma,@ten,@diachi)
end
      
	  
                                  --NXB
                                  --SỬA NXB
create proc suaNXB(@ma char(10),@ten nvarchar(50))
as 
begin
update nxb
set tennxb=@ten
where manxb=@ma
end
                                --XÓA NXB
create proc xoaNXB(@ma char(10),@ten nvarchar(50))
as
begin
delete nxb
where manxb=@ma and tennxb=@ten
end
                               -- THÊM NXB
create proc themNXB(@ma char(10),@ten nvarchar(50),@diachi nvarchar(50))                    
as
begin
insert into nxb(manxb,tennxb,diachi)
values(@ma,@ten,@diachi)
end
                              -- tìm kiếm nhà xuất bản 
create proc tkNXB(@ma char(10),@ten nvarchar(50),@diachi nvarchar(50))
as
begin
select manxb ,tennxb,diachi
from nxb
where manxb=@ma
end
                              --DANH SÁCH SÁNG TÁC
                              -- SỬA
create proc suadsst(@ma char(10),@ma2 char(50), @chubien char(10) )
as 
begin
update danhsachsangtac
set chubien =@chubien
where matg=@ma and masach=@ma2
end

suadsst 'tg02', 'ms10', 50
                         -- XÓA 
create proc xoadsst(@ma char(10),@ma2 char(50),@chubien char(10))
as
begin
delete danhsachsangtac
where matg=@ma and masach=@ma2
end
                        -- THÊM
create proc themdsst(@ma char(10),@ma2 nvarchar(50),@chubien char(10))                    
as
begin
insert into danhsachsangtac(masach,matg,chubien)
values(@ma2,@ma,@chubien)
end
         
create proc xemchitietphieumuon(@ma char(10))
as
begin
select * from chitietphieumuon
where maphieu= @ma
end


=--- admin 
  				  --- thêm admin 
create proc themadmin @ma int ,@tendangnhap char(10)
as
begin
insert into admin(matkhau , tendangnhap)
values (@ma,@tendangnhap)
end        
                         ---- sửa admin 
create proc suaadmin @ma int ,@tendangnhap char(10)
as
begin
update admin
set  matkhau=@ma
where tendangnhap=@tendangnhap
end 			
                   --- xóa admin
create proc xoaadmin @ma int , @tendangnhap char(10)
as 
begin 
delete admin
where tendangnhap=@tendangnhap               
 end	
