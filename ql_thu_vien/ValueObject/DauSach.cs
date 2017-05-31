using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ql_thu_vien.ValueObject
{
   public class DauSach
    {
        public string maSach { set; get; }
        public string tenSach { set; get; }
        public string manxb { set; get; }
        public string vitri { set; get; }
        public string sotrang { get; set; }
        public string giabia { get; set; }
        public string nganhhoc { get; set; }
        public string ngonngu { get; set; }
        public DateTime namxuatban { get; set; }
        public string tinhtrang { get; set; }
        public string matg { get; set; }
        public string soluongtaiban { get; set; }
    }
}
