using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cong_ty_C
{
    public class ThanNhan
    {
        public string MaNV { get; set; }
        public string TenThanNhan { get; set; }
        public string QuanHe { get; set; }
        public ThanNhan() {}
        public ThanNhan(string maNV, string tenThanNhan, string quanHe, NhanVien NV)
        {
            this.MaNV = maNV;
            this.TenThanNhan = tenThanNhan;
            this.QuanHe = quanHe;
            this.NV = NV;
        }
        public ThanNhan(ThanNhan tn)
        {
            this.MaNV = tn.MaNV;
            this.TenThanNhan = tn.TenThanNhan;
            this.QuanHe = tn.QuanHe;
            this.NV = tn.NV;
        }
        public NhanVien NV { get; set; }
    }
}
