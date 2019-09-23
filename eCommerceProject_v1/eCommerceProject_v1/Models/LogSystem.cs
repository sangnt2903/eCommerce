using System;
using System.Collections.Generic;

namespace eCommerceProject_v1.Models
{
    public partial class LogSystem
    {
        public int MalogSystem { get; set; }
        public string TenLog { get; set; }
        public string NoidungLog { get; set; }
        public string NguoiThaoTac { get; set; }
        public DateTime? Ngaygio { get; set; }
    }
}
