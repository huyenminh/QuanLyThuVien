using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ql_thu_vien.ValueObject
{
    class phieumuontra
    {
        private string strmaphieu = "";
        public string maphieu
        {
            get { return strmaphieu; }
            set { strmaphieu = value; }
        }
        
        private string strmatt = "";
        public string matt
        {
            get { return strmatt; }
            set { strmatt = value; }
        }
        private string strmadg = "";
        public string madg
        {
            get { return strmadg; }
            set {  strmadg= value; }
        }
        private int intsosachmuonve  = 0;
        public int socuonmuonve
        {
            get { return intsosachmuonve; }
            set { intsosachmuonve = value; }
        }
        
        // thông tin sách
        public string macs { set; get; }
        public string tensach { get; set; }
        public string tinhtrang { set; get; }
        public string maPhieu { set; get; }
        public string maSach { set; get; }
        private int intSoLuongCon = 0;
        public int SoLuongCon
        {
            get { return intSoLuongCon; }
            set { intSoLuongCon = value; }
        }
        private int intGiaBia = 0;
        public int GiaBia
        {
            get { return intGiaBia; }
            set { intGiaBia = value; }
        }

        public string tentg { get; set; }

    }
}
