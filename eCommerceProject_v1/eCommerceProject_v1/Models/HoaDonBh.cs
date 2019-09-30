using System;
using System.Collections.Generic;

namespace eCommerceProject_v1.Models
{
    public partial class HoaDonBh
    {
        public int Mahd { get; set; }
        public string Nguoimua { get; set; }
        public string Nguoiban { get; set; }
        public string HotenNguoinhan { get; set; }
        public string DiachiNguoinhan { get; set; }
        public string Sdt { get; set; }
        public string Ghichu { get; set; }
        public double? Phivanchuyen { get; set; }
        public double? Tongtien { get; set; }
        public string Loaithanhtoan { get; set; }
        public bool? TrangthaiXuly { get; set; }

        public Trangthaitt LoaithanhtoanNavigation { get; set; }
        public DangkiNcc NguoibanNavigation { get; set; }
        public NguoiDung NguoimuaNavigation { get; set; }
    }
}
