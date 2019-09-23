using System;
using System.Collections.Generic;

namespace eCommerceProject_v1.Models
{
    public partial class QuanTriVien
    {
        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }
        public string Manv { get; set; }
        public bool? IsAdmin { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}
