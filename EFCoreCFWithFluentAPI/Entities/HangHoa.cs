using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCFWithFluentAPI.Entities
{
    public class HangHoa
    {
        public Guid MaHh { get; set; }
        public string TenHh { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public string Hinh { get; set; }
        public string ChiTiet { get; set; }
        public string MoTa { get; set; }
        public int MaLoai { get; set; }

        public Loai Loai { get; set; }

        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; }

        public HangHoa()
        {
            DonHangChiTiets = new HashSet<DonHangChiTiet>();
        }
    }
}
