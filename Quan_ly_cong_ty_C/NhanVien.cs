using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cong_ty_C
{
    public class NhanVien
    {
        public string MaNV { get; set; } //primary key 
        public string TenNV { get; set; }
        public string Dchi { get; set; }
        public string GioiTinh { get; set; }
        public int Luong { get; set; }
        public string MaNQL { get; set; }
        public string MaPB { get; set; }
        public NhanVien() {

            this.DsThanNhan = new List<ThanNhan>();
            this.DsPhanCong = new List<PhanCong>();
            this.DsDuAn = new List<DuAn>();
        }
        public NhanVien(string MaNV, string TenNV, string Dchi, string GioiTinh, int Luong, string MaNQL, string MaPB, PhongBan PB, ICollection<ThanNhan> DsThanNhan, ICollection<PhanCong> DsPhanCong, ICollection<DuAn> DsDuAn)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.Dchi = Dchi;
            this.GioiTinh = GioiTinh;
            this.Luong = Luong;
            this.MaNQL = MaNQL;
            this.MaPB = MaPB;
            this.PB = PB;
            this.DsPhanCong = DsPhanCong;
            this.DsThanNhan = DsThanNhan;
            this.DsDuAn = DsDuAn;
        }
        public NhanVien(NhanVien nv)
        {
            this.MaNV = nv.MaNV;
            this.TenNV = nv.TenNV;
            this.Dchi = nv.Dchi;
            this.GioiTinh = nv.GioiTinh;
            this.Luong = nv.Luong;
            this.MaNQL = nv.MaNQL;
            this.MaPB = nv.MaPB;
            this.PB = nv.PB;
            this.DsThanNhan = nv.DsThanNhan;
            this.DsPhanCong = nv.DsPhanCong;
            this.DsDuAn = nv.DsDuAn;
        }
        public PhongBan PB { get; set; }
        public ICollection<ThanNhan> DsThanNhan { get; set; }
        public ICollection<PhanCong> DsPhanCong { get; set; }
        public ICollection<DuAn> DsDuAn { get; set; }

    }
}
