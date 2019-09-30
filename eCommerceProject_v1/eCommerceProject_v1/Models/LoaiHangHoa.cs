using System;
using System.Collections.Generic;

namespace eCommerceProject_v1.Models
{
    public partial class LoaiHangHoa
    {
        public LoaiHangHoa()
        {
            HangHoa = new HashSet<HangHoa>();
        }

        public string Maloai { get; set; }
        public string Tenloai { get; set; }

        public ICollection<HangHoa> HangHoa { get; set; }
    }
}
