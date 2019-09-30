using System;
using System.Collections.Generic;

namespace eCommerceProject_v1.Models
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            DangkiNcc = new HashSet<DangkiNcc>();
            HoaDonBh = new HashSet<HoaDonBh>();
        }

        public string Email { get; set; }
        public string Sdt { get; set; }
        public string Matkhau { get; set; }
        public DateTime? Ngaydangki { get; set; }
        public string Avatar { get; set; }
        public string Hoten { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public string Cmnd { get; set; }
        public bool? Trangthaihd { get; set; }

        public ICollection<DangkiNcc> DangkiNcc { get; set; }
        public ICollection<HoaDonBh> HoaDonBh { get; set; }
    }
}
