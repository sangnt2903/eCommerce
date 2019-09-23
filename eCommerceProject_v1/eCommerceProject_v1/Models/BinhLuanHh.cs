using System;
using System.Collections.Generic;

namespace eCommerceProject_v1.Models
{
    public partial class BinhLuanHh
    {
        public int Mabl { get; set; }
        public string Nguoidung { get; set; }
        public string Mahh { get; set; }
        public string Noidung { get; set; }
        public string Hinh { get; set; }
        public DateTime? Ngaydang { get; set; }
        public double? Diemdanhgia { get; set; }
    }
}
