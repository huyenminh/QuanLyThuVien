using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ql_thu_vien.DataAccessLayer;
using ql_thu_vien.ValueObject;


namespace ql_thu_vien.BusinessLogicLayer
{
    class Bus
    {
        //DOCGIA
        public static DataTable Getlistdocgia()
        {
            return Dao.Getlistdocgia();
        }
        public static int InsertProfile(docgia dg)
        {
            return Dao.InsertProfile(dg);
        }
        public static int UpdateProfile(docgia dg)
        { 
            return Dao.UpdateProfile(dg);
        }
        public static int DeleteProfile(docgia dg)
        {
            return Dao.DeleteProfile(dg);
        }
        public static DataTable Timkiemdg(string  ten)
        {
            return Dao.Timkiemdg(ten) ;
        }
        //PHIEUMUONTRA
        public static DataTable Getlistphieumuontra()
        {
            return Dao.Getlistphieumuontra();
        }
        public static int InsertProfile(phieumuontra pmt)
        {
            return Dao.InsertProfile(pmt);
        }
        public static int UpdateProfile(phieumuontra pmt)
        {
            return Dao.UpdateProfile(pmt);
        }
        public static int DeleteProfile(phieumuontra pmt)
        {
            return Dao.DeleteProfile(pmt);
        }
        public static DataTable Timkiempmt(string ma)
        {
            return Dao.Timkiempmt(ma);
        }
        //CHITIETPHIEUMUON
        public static DataTable Getlistchitietphieumuon()
        {
            return Dao.Getlistchitietphieumuon();
        }
        public static int InsertProfile(chitietphieumuon ctpm)
        {
            return Dao.InsertProfile(ctpm);
        }
        public static int UpdateProfile(chitietphieumuon ctpm)
        {
            return Dao.UpdateProfile(ctpm);
        }
        public static int DeleteProfile(chitietphieumuon ctpm)
        {
            return Dao.DeleteProfile(ctpm);
        }
        public static DataTable Timkiemctpm(string ma)
        {
            return Dao.Timkiemctpm(ma);
        }
        //DAU SACH
        public static int InsertDausach(DauSach ds)
        {
            return Dao.InsertDausach(ds);
        }

        public static DataTable GetListNXB()
        {
            return Dao.GetListNXB();
        }

        public static DataTable GetListDausach()
        {
            return Dao.GetListDausach();
        }

        public static DataTable GetListHoadon()
        {
            return Dao.GetListHoadon();
        }

        public static DataTable GetListKesach()
        {
            return Dao.GetListKesach();
        }

        public static int UpdateDausach(DauSach ds)
        {
            return Dao.UpdateDausach(ds);
        }

        public static int DeleteDausach(DauSach ds)
        {
            return Dao.DeleteDausach(ds);
        }

        public static DataTable SearchDauSach(string dausach)
        {
            return Dao.SearchDauSach(dausach);
        }

        //CUON SACH
        public static DataTable GetListCuonSach()
        {
            return Dao.GetListCuonSach();
        }

        public static DataTable GetListPhieumuontra()
        {
            return Dao.GetListPhieumuontra();
        }

        public static int InsertCuonsach(Cuonsach cs)
        {
            return Dao.InsertCuonsach(cs);
        }

        public static int UpdateCuonsach(Cuonsach cs)
        {
            return Dao.UpdateCuonsach(cs);
        }

        public static DataTable SearchCuonSach(string cuonsach)
        {
            return Dao.SearchCuonSach(cuonsach);
        }

        public static int DeleteCuonsach(Cuonsach cs)
        {
            return Dao.DeleteCuonsach(cs);
        }

        //HOA DON
        public static DataTable GetListThuthu()
        {
            return Dao.GetListThuthu();
        }

        public static int InsertHoadon(Hoadon hd)
        {
            return Dao.InsertHoadon(hd);
        }

        public static int UpdateHoadon(Hoadon hd)
        {
            return Dao.UpdateHoadon(hd);
        }

        public static DataTable SearchHoadon(string hoadon)
        {
            return Dao.SearchHoadon(hoadon);
        }

        public static int DeleteHoadon(Hoadon hd)
        {
            return Dao.DeleteHoadon(hd);
        }

        //THỦ THƯ
        public static DataTable Getlistthuthu()
        {
            return Dao.Getlistthuthu();
        }
        public static int InsertProfile(Thuthu tt)
        {
            return Dao.InsertProfile(tt);
        }
        public static int UpdateProfile(Thuthu tt)
        {
            return Dao.UpdateProfile(tt);
        }
        public static int DeleteProfile(Thuthu tt)
        {
            return Dao.DeleteProfile(tt);
        }
        public static DataTable Timkiem_tt(string ten)
        {
            return Dao.Timkiem_tt(ten);
        }
        // THẺ ĐỘC GIẢ
        public static DataTable Getlistthedocgia()
        {
            return Dao.Getlistthedocgia();
        }
        public static int InsertProfile(Thedocgia tdg)
        {
            return Dao.InsertProfile(tdg);
        }
        public static int UpdateProfile(Thedocgia tdg)
        {
            return Dao.UpdateProfile(tdg);
        }
        public static int DeleteProfile(Thedocgia tdg)
        {
            return Dao.DeleteProfile(tdg);
        }
        public static DataTable Timkiem_tdg(string ma)
        {
            return Dao.Timkiem_tdg(ma);
        }
        //KỆ SÁCH
        public static DataTable Getlistkesach()
        {
            return Dao.Getlistkesach();
        }
        public static int InsertProfile(Kesach ks)
        {
            return Dao.InsertProfile(ks);
        }
        public static int UpdateProfile(Kesach ks)
        {
            return Dao.UpdateProfile(ks);
        }
        public static int DeleteProfile(Kesach ks)
        {
            return Dao.DeleteProfile(ks);
        }
        public static DataTable Timkiem_ks(string ma)
        {
            return Dao.Timkiem_ks(ma);
        }

        //NXB
        public static DataTable GetListnxb()
        {
            return Dao.GetListnxb();
        }
        public static int InsertProfile(Nxb n)
        {
            return Dao.InsertProfile(n);
        }
        public static int UpdateProfile(Nxb n)
        {
            return Dao.UpdateProfile(n);
        }
        public static int DeleteProfile(Nxb n)
        {
            return Dao.DeleteProfile(n);
        }
        public static DataTable Timkiem_nxb(string ten)
        {
            return Dao.Timkiem_nxb(ten);
        }
        //TAC GIA
        public static DataTable GetListtacgia()
        {
            return Dao.GetListtacgia();
        }
        public static int InsertProfile(Tacgia tg)
        {
            return Dao.InsertProfile(tg);
        }
        public static int UpdateProfile(Tacgia tg)
        {
            return Dao.UpdateProfile(tg);
        }
        public static int DeleteProfile(Tacgia tg)
        {
            return Dao.DeleteProfile(tg);
        }
        public static DataTable Timkiem_tg(string ten)
        {
            return Dao.Timkiem_tg(ten);
        }
        //DSST
        public static DataTable GetListdsst()
        {
            return Dao.GetListdsst();
        }
        public static int InsertProfile(Danhsachsangtac dsst)
        {
            return Dao.InsertProfile(dsst);
        }
        public static int UpdateProfile(Danhsachsangtac dsst)
        {
            return Dao.UpdateProfile(dsst);
        }
        public static int DeleteProfile(Danhsachsangtac dsst)
        {
            return Dao.DeleteProfile(dsst);
        }
        public static DataTable Timkiem_dsst(string ma)
        {
            return Dao.Timkiem_dsst(ma);
        }
    }

}
