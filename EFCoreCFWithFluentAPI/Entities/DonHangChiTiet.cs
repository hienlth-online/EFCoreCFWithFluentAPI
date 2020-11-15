using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCFWithFluentAPI.Entities
{
    public class DonHangChiTiet
    {
        public Guid MaDh { get; set; }
        public Guid MaHh { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }

        public DonHang DonHang { get; set; }
        public HangHoa HangHoa { get; set; }
    }
}
