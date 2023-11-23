using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cong_ty_C
{
    public class DiaDiem_Phong
    {
        public string MaPB { get; set; }// primary key = foreign key 
        public string DiaDiem { get; set; } //primary 
        public DiaDiem_Phong() { }
        public DiaDiem_Phong(string MaPB, string DiaDiem, PhongBan PB)
        {
            this.MaPB = MaPB;
            this.DiaDiem = DiaDiem;
            this.PB = PB;
        }
        public DiaDiem_Phong(DiaDiem_Phong dd)
        {
            this.MaPB = dd.MaPB;
            this.DiaDiem = dd.DiaDiem;
            this.PB = dd.PB;
        }
        public PhongBan PB { get; set; }
    }
}
