using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cong_ty_C
{
    public class DuAn
    {
        public string MaDA { get; set; } // primary key 
        public string TenDA { get; set; } // primary key
        public string DiaDiem { get; set; }
        public string MaPB { get; set; }
        public DuAn() {

            this.DsPhanCong = new List<PhanCong>();
        }
        public DuAn(string MaDA, string TenDA, string DiaDiem, string MaPB, PhongBan PB, ICollection<PhanCong> DsPhanCong)
        {
            this.MaDA = MaDA;
            this.TenDA = TenDA;
            this.DiaDiem = DiaDiem;
            this.MaPB = MaPB;
            this.DsPhanCong = DsPhanCong;
            this.PB = PB;
        }
        public DuAn(DuAn da)
        {
            this.MaDA = da.MaDA;
            this.TenDA = da.TenDA;
            this.DiaDiem = da.DiaDiem;
            this.MaPB = da.MaPB;
            this.DsPhanCong = da.DsPhanCong;
            this.PB = da.PB;
        }
        public ICollection<PhanCong> DsPhanCong { get; set; }
        public PhongBan PB { get; set; }
    }
}
