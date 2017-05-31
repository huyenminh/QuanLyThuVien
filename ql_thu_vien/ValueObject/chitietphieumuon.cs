using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ql_thu_vien.ValueObject
{
    class chitietphieumuon
    {
        public string maphieu{get;set;}
        public string macs { get; set; }
        public string tinhtrangtruocchomuon { get; set; }
        public string tinhtrangsauchomuon { get; set; }
        public DateTime ngaymuon { get; set; }
        public DateTime ngaytra { get; set; }
        public DateTime ngayhentra { get; set; }
        public string songayhethan { get; set; }
        public string socuon { get; set; }
    }
}
