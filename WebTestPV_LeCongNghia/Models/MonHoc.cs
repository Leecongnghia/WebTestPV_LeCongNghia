using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTestPV_LeCongNghia.Models
{
    public class MonHoc
    {
        public int ID { get; set; }
        public string TenMonHoc { get; set; }
        public string MoTa { get; set; }
        public int KhoaHocID { get; set; }
    }
}