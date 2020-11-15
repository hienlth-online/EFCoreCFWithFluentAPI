using System;
using System.Collections.Generic;

namespace EFCoreCFWithFluentAPI.Entities
{
    public class DonHang
    {
        public Guid MaDh { get; set; }
        public DateTime NgayDat { get; set; }
        public string NguoiNhan { get; set; }
        public string DiaChiGiao { get; set; }
        public double TongTien { get; set; }
        public int TinhTrangDonHang { get; set; }

        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; }

        public DonHang()
        {
            DonHangChiTiets = new HashSet<DonHangChiTiet>();
        }
    }
}
