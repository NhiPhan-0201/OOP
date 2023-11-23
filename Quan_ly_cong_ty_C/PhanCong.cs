using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cong_ty_C
{
    public class PhanCong
    {
        public string MaNV { get; set; }
        public string MaDA { get; set; }
        public DuAn DA { get; set; }
        public NhanVien NV { get; set; }
        public PhanCong() { }
        public PhanCong(string MaNV, string MaDA, NhanVien NV, DuAn DA)
        {
            this.MaNV = MaNV;
            this.MaDA = MaDA;
            this.DA = DA;
            this.NV = NV;
        }
        public PhanCong(PhanCong pc)
        {
            this.MaNV = pc.MaNV;
            this.MaDA = pc.MaDA;
            this.DA = pc.DA;
            this.NV = pc.NV;
        }

    }
}
