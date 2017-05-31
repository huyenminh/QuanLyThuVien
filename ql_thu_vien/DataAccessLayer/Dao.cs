using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ql_thu_vien.BusinessLogicLayer;
using ql_thu_vien.ValueObject;

namespace ql_thu_vien.DataAccessLayer
{
    class Dao
    {
        //NGƯỜI DÙNG
        public static DataTable Getlistnguoidung()
        { return DataProvider.GetData("select * from nguoidung");
        }
        public static int InsertProfile(nguoidung nd)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@tendangnhap",nd.tendangnhap),
                    new SqlParameter("@matkhau",nd.matkhau),
                };
            return DataProvider.ExecuteNonQuery("themnd", para);
        }
        public static int UpdateProfile(nguoidung nd)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@STT",nd.STT),
                    new SqlParameter("@tendangnhap",nd.tendangnhap),
                    new SqlParameter("@matkhau",nd.matkhau),
                };
            return DataProvider.ExecuteNonQuery("suand", para);
        }
        public static int DeleteProfile(nguoidung nd)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@STT",nd.STT),
                   
                };
            return DataProvider.ExecuteNonQuery("xoand", para);
        }


        //DOCGIA
        public static DataTable Getlistdocgia()
        {
            return DataProvider.GetData("select*from docgia");
        }
        public static int InsertProfile(docgia dg)
        {
            SqlParameter[] para =new SqlParameter[]
            {
                new SqlParameter("@madg",dg.madg),
                new SqlParameter("@ten",dg.tendg),
                new SqlParameter("@diachi",dg.diachi),
                new SqlParameter("@ngaysinh",dg.ngaysinh),
                new SqlParameter("@kh",dg.khoahoc),
                new SqlParameter("@nganh",dg.nganh),
                new SqlParameter("@lop",dg.Lop),
                new SqlParameter("@ncn",dg.ngaycapnhat),
                new SqlParameter("@loaidg",dg.loaidg)
            };
            return DataProvider.ExecuteNonQuery("themdocgia",para);
        }

        internal static DataTable Timkiemdg()
        {
            throw new NotImplementedException();
        }

        public static int UpdateProfile(docgia dg)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter ("@ma",dg.madg),
                new SqlParameter ("@ten",dg.tendg),
                new SqlParameter ("@diachi",dg.diachi)
            };
            return DataProvider.ExecuteNonQuery("suadocgia", para);
        }
        public static int DeleteProfile(docgia dg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@ma",dg.madg),
                new SqlParameter("@ten",dg.tendg)
            };
            return DataProvider.ExecuteNonQuery("xoadocgia", para);
        }

        internal static DataTable TimkiemDG()
        {
            throw new NotImplementedException();
        }

        public  static DataTable Timkiemdg(string ma)
        {
            return DataProvider.GetData("select * from docgia " + ma );
        }
        public static DataTable Hienthidg(string ma)
        {
            return DataProvider.GetData("select * from docgia" + ma);
        }
        //PHIEUMUONTRA
        public static DataTable Getlistphieumuontra()
        {
            return DataProvider.GetData("select *from phieumuontra");
        }
        public static int InsertProfile(phieumuontra pmt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",pmt.maphieu), 
                new SqlParameter("@scmv",pmt.socuonmuonve), 
                new SqlParameter("@matt",pmt.matt),
                new SqlParameter("@madg",pmt.madg),
               
            };
            return DataProvider.ExecuteNonQuery("themphieumuontra",para);
        }
        public static int UpdateProfile(phieumuontra pmt)
        {
            SqlParameter[] para=new SqlParameter[]
            {
                new SqlParameter("@ma",pmt.maphieu),
                new SqlParameter("@socuonmuonve",pmt.socuonmuonve),
            };
            return DataProvider.ExecuteNonQuery("suaphieumuontra",para);

        }
        public static int DeleteProfile(phieumuontra pmt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",pmt.maphieu)
            };
            return DataProvider.ExecuteNonQuery("xoaphieumuontra",para);
        }
        public static DataTable Timkiempmt(string ma)
        {
            return DataProvider.GetData("select * from phieumuontra " + ma );
        }
        public static DataTable TimkiemDG(string ma)
        {
            return DataProvider.GetData("select * from docgia " + ma);
        }


        //CHITIETPHIEUMUON
        public static DataTable Getlistchitietphieumuon()
        {
            return DataProvider.GetData("select*from chitietphieumuon");
        }
        public static int InsertProfile(chitietphieumuon ctpm)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter("@macs",ctpm.macs),
                new SqlParameter("@maphieu",ctpm.maphieu), 
                new SqlParameter("@tinhtrangtruoc",ctpm.tinhtrangtruocchomuon),
                new SqlParameter("@tinhtrangsau",ctpm.tinhtrangsauchomuon),
                new SqlParameter("@ngaymuon",ctpm.ngaymuon),
                new SqlParameter("@ngaytra",ctpm.ngaytra),
                new SqlParameter("@ngayhentra",ctpm.ngayhentra),
                new SqlParameter("@songayhethan",ctpm.songayhethan),
                new SqlParameter("@socuon",ctpm.socuon), 

            };

            return DataProvider.ExecuteNonQuery("themchitietphieumuon",para);
        }
        public static int UpdateProfile(chitietphieumuon ctpm)
        {
            SqlParameter[] para = new SqlParameter[]
            {
               new SqlParameter("@maphieu",ctpm.maphieu),
                new SqlParameter("@macs",ctpm.macs), 
                new SqlParameter("@tinhtrangsau",ctpm.tinhtrangsauchomuon),
               
            };
            return DataProvider.ExecuteNonQuery("suachitietphieumuon", para);
        }
        public static int DeleteProfile(chitietphieumuon ctpm)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter("@maphieu",ctpm.maphieu),
                new SqlParameter("@macs",ctpm.macs), 
            };
            return DataProvider.ExecuteNonQuery("xoachitietphieumuon",para);
        }
        public static DataTable Timkiemctpm(string ma)
        {
            return DataProvider.GetData("select * from chitietphieumuon " + ma);
        }

        //ĐẦU SÁCH
        public static DataTable GetListDausach()
        {
            return DataProvider.GetData("select * from dausach ");
        }

        public static DataTable GetListHoadon()
        {
            return DataProvider.GetData("select * from hoadon ");
        }
 
        public static DataTable GetListNXB()
        {
            return DataProvider.GetData("select * from nxb ");
        }

        public static int InsertDausach(DauSach ds)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madausach", ds.maSach),
                new SqlParameter("@tendausach", ds.tenSach),
                new SqlParameter("@manxb", ds.manxb), 
                new SqlParameter("@st",ds.sotrang),
                new SqlParameter("@giabia",ds.giabia),
                new SqlParameter("@nganhhoc",ds.nganhhoc),
                new SqlParameter("@nn",ds.ngonngu),
                new SqlParameter("@namxb",ds.namxuatban),
                new SqlParameter("@tt",ds.tinhtrang),
                new SqlParameter("@matg",ds.matg),
                new SqlParameter("@sltaiban",ds.soluongtaiban)

            };
            return DataProvider.ExecuteNonQuery("Themdausach", para);
        }

        public static int UpdateDausach(DauSach ds)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madausach", ds.maSach),
                new SqlParameter("@tendausach", ds.tenSach),
                new SqlParameter("@manxb", ds.manxb)
            };
            return DataProvider.ExecuteNonQuery("Suadausach", para);
        }

        internal object Timkiemdg(int v1, string v2, int v3)
        {
            throw new NotImplementedException();
        }

        public static DataTable SearchDauSach(string dausach)
        {
            return DataProvider.GetData("select * from dausach " + dausach);
        }

        public static int DeleteDausach(DauSach ds)
        {
            SqlParameter[] para = new SqlParameter[]
        {
             new SqlParameter("@madausach", ds.maSach)
        };
            return DataProvider.ExecuteNonQuery("Xoadausach", para);
        }


        //CUỐN SÁCH

        public static DataTable GetListPhieumuontra()
        {
            return DataProvider.GetData("select * from phieumuontra ");
        }

        public static DataTable GetListCuonSach()
        {
            return DataProvider.GetData("select * from cuonsach ");
        }


        public static int InsertCuonsach(Cuonsach cs)
        {
            SqlParameter[] para = new SqlParameter[]
            {
            new SqlParameter("@macs", cs.maCuonsach),
            new SqlParameter("@tinhtrang", cs.tinhTrang),
            new SqlParameter("@mp", cs.maPhieu),
            new SqlParameter("@masach", cs.maSach),
             new SqlParameter("@tentg", cs.tentg),
            new SqlParameter("@soluongcon", cs.coluongcon)
            };
            return DataProvider.ExecuteNonQuery("Themcuonsach", para);
        
        }

        public static int UpdateCuonsach(Cuonsach cs)
        {
            SqlParameter[] para = new SqlParameter[]
            {
            new SqlParameter("@macs", cs.maCuonsach),
            new SqlParameter("@tinhtrang", cs.tinhTrang), 
            new SqlParameter("@masach", cs.maSach), 
            new SqlParameter("@soluoncon", cs.coluongcon)
            };
            return DataProvider.ExecuteNonQuery("Suacuonsach", para);
        }


        public static DataTable SearchCuonSach(string cuonsach)
        {
            return DataProvider.GetData("select * from cuonsach " + cuonsach);
        }


        public static int DeleteCuonsach(Cuonsach cs)
        {
            SqlParameter[] para = new SqlParameter[]
        {
             new SqlParameter("@macuonsach", cs.maCuonsach)
        };
            return DataProvider.ExecuteNonQuery("Xoacuonsach", para);
        }
        
        // HÓA ĐƠN

        public static DataTable GetListThuthu()
        {
            return DataProvider.GetData("select * from thuthu ");
        }


        public static int InsertHoadon(Hoadon hd)
        { 
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mahoadon", hd.mahd),
                new SqlParameter("@ngaynhap", hd.ngaynhap),
                new SqlParameter("@matt", hd.matt)        
            };
            return DataProvider.ExecuteNonQuery("Themhoadon", para);
        }

        public static int UpdateHoadon(Hoadon hd)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mahoadon", hd.mahd),
                new SqlParameter("@ngaynhap", hd.ngaynhap),
                new SqlParameter("@matt", hd.matt)        
            };
            return DataProvider.ExecuteNonQuery("Suahoadon", para);
        }


        public static DataTable SearchHoadon(string hoadon)
        {
            return DataProvider.GetData("select * from hoadon " + hoadon);
        }

        public static int DeleteHoadon(Hoadon hd)
        {
            SqlParameter[] para = new SqlParameter[]
        {
             new SqlParameter("@mahoadon", hd.mahd)
        };
            return DataProvider.ExecuteNonQuery("Xoahoadon", para);
        }

        //THỦ THƯ
        public static DataTable Getlistthuthu()
        {
            return DataProvider.GetData("select *from thuthu");
        }
        public static int InsertProfile(Thuthu tt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
             new SqlParameter ("@matt",tt.matt),
             new SqlParameter ("@ten",tt.tentt),
             new SqlParameter("@ngaysinh",tt.ngaysinh),
             new SqlParameter("@diachi",tt.diachi),
             new SqlParameter("@mags",tt.mags)
            };
            return DataProvider.ExecuteNonQuery("themthuthu", para);
        }
        public static int UpdateProfile(Thuthu tt)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter("@matt",tt.matt),
                new SqlParameter("@ten",tt.tentt),
                new SqlParameter("@diachi",tt.diachi),
            };
            return DataProvider.ExecuteNonQuery("suathuthu", para);
        }
        public static int DeleteProfile(Thuthu tt)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter("@matt",tt.matt),
                new SqlParameter("@tentt",tt.tentt)
            };
            return DataProvider.ExecuteNonQuery("xoathuthu", para);
        }
        public static DataTable Timkiem_tt(string ten)
        {
            return DataProvider.GetData("select * from thuthu " + ten );
        }
        //KỆ SÁCH
     /*   public static DataTable Getlistkesach()
        {
            return DataProvider.GetData("select *from kesach");
        }
        public static int InsertProfile(Kesach ks)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter("@vitri ",ks.vitri),
                new SqlParameter("@songan ",ks.songan),
                new SqlParameter("@matt ",ks.matt)
            };
            return DataProvider.ExecuteNonQuery("themkesach", para);
        }
        public static int UpdateProfile(Kesach ks)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                 new SqlParameter("@vitri ",ks.vitri),
                new SqlParameter("@songan ",ks.songan),
              
            };
            return DataProvider.ExecuteNonQuery("suakesach", para);
        }
        public static int DeleteProfile(Kesach ks)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                 new SqlParameter("@vitri ",ks.vitri),
                new SqlParameter("@songan ",ks.songan),
               
            };
            return DataProvider.ExecuteNonQuery("xoakesach", para);
        }
        public static DataTable Timkiem_ks(string ma)
        {
            return DataProvider.GetData("select * from kesach " + ma);
        }
        */

        //THẺ ĐỘC GIẢ
    /*    public static DataTable Getlistthedocgia()
        {
            return DataProvider.GetData("select *from thedocgia");
        }
        public static int InsertProfile(Thedocgia tdg)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter("@sothe",tdg.sothe),
                new SqlParameter("@ngaylam",tdg.ngaylam),
                new SqlParameter("@ngayhethan",tdg.ngayhethan),
                new SqlParameter("@madg ",tdg.madg),
                new SqlParameter("@matt ",tdg.matt),

            };
            return DataProvider.ExecuteNonQuery("themthedocgia", para);
        }
        public static int UpdateProfile(Thedocgia tdg)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter("@sothe",tdg.sothe),
                new SqlParameter("@ngaylam",tdg.ngaylam),
                   
            };
            return DataProvider.ExecuteNonQuery("suathedocgia", para);
        }
        public static int DeleteProfile(Thedocgia tdg)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                 new SqlParameter("@sothe",tdg.sothe),     
            };
            return DataProvider.ExecuteNonQuery("xoathedocgia", para);
        }
        public static DataTable Timkiem_tdg(string ma)
        {
            return DataProvider.GetData("select * from thedocgia" + ma);
        }
        */
        //   Nha Xuất bản
         public static DataTable GetListnxb()
        {
            return DataProvider.GetData("select *from nxb");
        }

        public static int InsertProfile(Nxb n)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",n.manxb),
                new SqlParameter("@ten",n.tennxb),
                new SqlParameter("@diachi",n.diachi)
            };
            return DataProvider.ExecuteNonQuery("themNXB", para);

        }
        public static int UpdateProfile(Nxb n)
        {
            SqlParameter[] para = new SqlParameter[]
           {
               new SqlParameter ("@ma", n.manxb),
               new SqlParameter ("@ten",n.tennxb)
               
           };
            return DataProvider.ExecuteNonQuery("suaNXB", para);

        }

        public static int DeleteProfile(Nxb n)
        {
            SqlParameter[] para = new SqlParameter[]{
                new SqlParameter("@ma",n.manxb),
                new SqlParameter("@ten",n.tennxb)
            };
            return DataProvider.ExecuteNonQuery("xoaNXB", para);
             
        }
        public static DataTable Timkiem_nxb(string ten)
        {
            return DataProvider.GetData("select * from nxb "  + ten);
        }
        
        // TACGIA
        public static DataTable GetListtacgia()
        {
            return DataProvider.GetData("select *from tacgia");
        }
        public static int InsertProfile( Tacgia tg)
        {
            SqlParameter[] para = new SqlParameter[]{
                new SqlParameter("@ma",tg.matg),
                new SqlParameter("@ten",tg.tentg),
                new SqlParameter("@diachi",tg.diachi),
            };
            return DataProvider.ExecuteNonQuery("themtacgia", para);

        }
        public static int UpdateProfile(Tacgia tg)
        {
            SqlParameter[] para = new SqlParameter[]
           {
               new SqlParameter ("@ma", tg.matg),
               new SqlParameter ("@ten",tg.tentg)
           };
            return DataProvider.ExecuteNonQuery("suatacgia", para);
        }
        public static int DeleteProfile(Tacgia tg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",tg.matg),
                new SqlParameter("@ten",tg.tentg),
               
            };
            return DataProvider.ExecuteNonQuery("xoatacgia", para);

        }
        public static int SelectProfile(Tacgia tg)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",tg.matg),
                new SqlParameter("@ten",tg.tentg),
                new SqlParameter("@diachi",tg.diachi),
            };
            return DataProvider.ExecuteNonQuery("tktacgia", para);
        }
        public static DataTable Timkiem_tg(string ten)
        {
            return DataProvider.GetData("select *from tacgia " + ten);
        }
        //                                          DSST
        /* public static DataTable GetListdsst()
          {
              return DataProvider.GetData("select * from danhsachsangtac");
          }
          public static int InsertProfile(Danhsachsangtac dsst)
          {
              SqlParameter[] para = new SqlParameter[]{
                  new SqlParameter("@ma2",dsst.masach),

                  new SqlParameter("@ma",dsst.matg),
                  new SqlParameter("@chubien",dsst.chubien),
              };
              return DataProvider.ExecuteNonQuery("themdsst", para);

          }
          public static int UpdateProfile(Danhsachsangtac dsst)
          {
              SqlParameter[] para = new SqlParameter[]
             {
                new SqlParameter("@ma2",dsst.masach),

                  new SqlParameter("@ma",dsst.matg),
                 new SqlParameter("@sotrang", dsst.chubien)
                  };
              return DataProvider.ExecuteNonQuery("suadsst", para);

          }
          public static int DeleteProfile(Danhsachsangtac dsst)
          {
              SqlParameter[] para = new SqlParameter[]{
               new SqlParameter("@ma2",dsst.masach),

                  new SqlParameter("@ma",dsst.matg),
                  new SqlParameter("@st",dsst.chubien),};

              return DataProvider.ExecuteNonQuery("xoadsst", para);

          }
          public static DataTable Timkiem_dsst (string ma)
          {
              return DataProvider.GetData("select * from danhsachsangtac" + ma);
          }
          */
        // Lớp
        public static DataTable GetListlop()
        {
            return DataProvider.GetData("select *from lop");
        }
        // ngành học 
        public static DataTable GetListnganhhoc()
        {
            return DataProvider.GetData("select *from nganhhoc");
        }
        // ngôn ngữ
        public static DataTable GetListngonngu()
        {
            return DataProvider.GetData("select *from ngonngu");
        }
        // loai độc giả
        public static DataTable GetListloaidocgia()
        {
            return DataProvider.GetData("select *from loaidocgia");
        }



    }
}
         
    
    

