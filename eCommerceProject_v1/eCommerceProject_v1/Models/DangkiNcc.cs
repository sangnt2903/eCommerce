using System;
using System.Collections.Generic;

namespace eCommerceProject_v1.Models
{
    public partial class DangkiNcc
    {
        public DangkiNcc()
        {
            HangHoa = new HashSet<HangHoa>();
            HoaDonBh = new HashSet<HoaDonBh>();
        }

        public string Mancc { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string TenNcc { get; set; }
        public string Diachi { get; set; }
        public string Mota { get; set; }
        public DateTime? DangkiGpmbAt { get; set; }

        public NguoiDung EmailNavigation { get; set; }
        public ICollection<HangHoa> HangHoa { get; set; }
        public ICollection<HoaDonBh> HoaDonBh { get; set; }
    }
}
