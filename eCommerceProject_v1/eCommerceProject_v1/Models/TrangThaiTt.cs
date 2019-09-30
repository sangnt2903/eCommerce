using System;
using System.Collections.Generic;

namespace eCommerceProject_v1.Models
{
    public partial class Trangthaitt
    {
        public Trangthaitt()
        {
            HoaDonBh = new HashSet<HoaDonBh>();
        }

        public string Maloaitt { get; set; }
        public string Tenloaitt { get; set; }
        public bool? Trangthaihd { get; set; }

        public ICollection<HoaDonBh> HoaDonBh { get; set; }
    }
}
