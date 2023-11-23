using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cong_ty_C
{
    public class PhongBan
    {
        public string MaPB { get; set; } // primary key 
        public string TenPB { get; set; }
        public PhongBan() {
            this.DsNhanVien = new List<NhanVien>();
            this.DsDuAn = new List<DuAn>();
            this.DsDiaDiem = new List<DiaDiem_Phong>();
        }
        public PhongBan(String MaPB, String TenPB, ICollection<NhanVien> DsNhanVien,ICollection<DuAn> DsDuAn, ICollection<DiaDiem_Phong> DsDiaDiem)
        {
            this.MaPB = MaPB;
            this.TenPB = TenPB;
            this.DsNhanVien = DsNhanVien;
            this.DsDuAn = DsDuAn;
            this.DsDiaDiem = DsDiaDiem;
        }
        public PhongBan(PhongBan pb)
        {
            this.MaPB = pb.MaPB;
            this.TenPB = pb.TenPB;
            this.DsNhanVien = pb.DsNhanVien;
            this.DsDuAn = pb.DsDuAn;
            this.DsDiaDiem = pb.DsDiaDiem;
        }
        public ICollection<NhanVien> DsNhanVien { get; set; }
        public ICollection<DuAn> DsDuAn { get; set; }
        public ICollection<DiaDiem_Phong> DsDiaDiem { get; set; }

    }
}
