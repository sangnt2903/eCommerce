using System;
using System.Collections.Generic;

namespace eCommerceProject_v1.Models
{
    public partial class HangHoa
    {
        public string Mahh { get; set; }
        public string Mancc { get; set; }
        public string Tenhh { get; set; }
        public string Hinh { get; set; }
        public double? Dongia { get; set; }
        public double? Giamgia { get; set; }
        public string Mota { get; set; }
        public string Maloai { get; set; }
        public int? Soluongton { get; set; }
        public bool? TrangthaiHd { get; set; }
    }
}
