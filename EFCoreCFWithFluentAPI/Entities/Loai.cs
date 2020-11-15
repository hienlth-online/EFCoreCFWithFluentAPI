using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCFWithFluentAPI.Entities
{
    public class Loai
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }

        public ICollection<HangHoa> HangHoas { get; set; }

        public Loai()
        {
            HangHoas = new HashSet<HangHoa>();
        }
    }
}
