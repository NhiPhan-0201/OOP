using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_cong_ty_C
{
    public class Program
    {
        // Tao du lieu 
        public static List<NhanVien> NV = new List<NhanVien>();
        public static List<PhongBan> PB = new List<PhongBan>();
        public static List<ThanNhan> TN = new List<ThanNhan>();
        public static List<DiaDiem_Phong> DD = new List<DiaDiem_Phong>();
        public static List<DuAn> DA = new List<DuAn>();
        public static List<PhanCong> PC = new List<PhanCong>();
        public static void TaodsNhanVien()
        {
            TaodsPhongBan();

            NV.Add(new NhanVien("NV01", "Kim Chi ", "Quận 8", "Nữ", 3000, "nv01", PB[0].MaPB, PB[0], new List<ThanNhan>(), new List<PhanCong>(), new List<DuAn>()));//1
            NV.Add(new NhanVien("NV02", "Yen Nhi", "Quan Gò Vấp", "Nữ", 2000, "nv01", PB[0].MaPB, PB[1], new List<ThanNhan>(), new List<PhanCong>(), new List<DuAn>()));//2
            NV.Add(new NhanVien("NV03", "Gia Bao", "Tiền Giang", "Nam", 5000, "nv02", PB[1].MaPB, PB[1], new List<ThanNhan>(), new List<PhanCong>(), new List<DuAn>()));//3
            NV.Add(new NhanVien("NV04", "Minh Tien", "Quận 8", "Nam", 4000, "nv03", PB[2].MaPB, PB[2], new List<ThanNhan>(), new List<PhanCong>(), new List<DuAn>()));//4
            NV.Add(new NhanVien("NV05", "Xuan Quyen", "Phú Hữu", "Nữ", 3000, "nv03", PB[3].MaPB, PB[3], new List<ThanNhan>(), new List<PhanCong>(), new List<DuAn>()));//5
            NV.Add(new NhanVien("NV06", "Kim Sang", "Tân Hương", "Nữ", 5000, "nv04", PB[5].MaPB, PB[5], new List<ThanNhan>(), new List<PhanCong>(), new List<DuAn>()));//6
            NV.Add(new NhanVien("NV07", "My Xuyen", "Phú Nhuận", "Nữ", 4000, "nv05", PB[6].MaPB, PB[6], new List<ThanNhan>(), new List<PhanCong>(), new List<DuAn>()));//7
            NV.Add(new NhanVien("NV08", "Hoang Khang", "Quận 8", "Nam", 4000, "nv06", PB[4].MaPB, PB[4], new List<ThanNhan>(), new List<PhanCong>(), new List<DuAn>()));

            PB[0].DsNhanVien.Add(NV[0]);
            PB[0].DsNhanVien.Add(NV[1]);
            PB[1].DsNhanVien.Add(NV[2]);

            PB[2].DsNhanVien.Add(NV[3]);

            PB[3].DsNhanVien.Add(NV[4]);

            PB[5].DsNhanVien.Add(NV[5]);

            PB[6].DsNhanVien.Add(NV[6]);

            PB[4].DsNhanVien.Add(NV[7]);
        }
        public static void TaodsPhongBan()
        {
            PB.Add(new PhongBan("PB1", "Nghien cuu", new List<NhanVien>(), new List<DuAn>(), new List<DiaDiem_Phong>()));
            PB.Add(new PhongBan("PB2", "Tai chinh", new List<NhanVien>(), new List<DuAn>(), new List<DiaDiem_Phong>()));
            PB.Add(new PhongBan("PB3", "Ke toan", new List<NhanVien>(), new List<DuAn>(), new List<DiaDiem_Phong>()));
            PB.Add(new PhongBan("PB4", "Marketing", new List<NhanVien>(), new List<DuAn>(), new List<DiaDiem_Phong>()));
            PB.Add(new PhongBan("PB5", "Ke hoach", new List<NhanVien>(), new List<DuAn>(), new List<DiaDiem_Phong>()));
            PB.Add(new PhongBan("PB6", "Dao tao", new List<NhanVien>(), new List<DuAn>(), new List<DiaDiem_Phong>()));
            PB.Add(new PhongBan("PB1", "Kinh te", new List<NhanVien>(), new List<DuAn>(), new List<DiaDiem_Phong>()));
        }
        public static void TaodsDuAn()
        {
            TaodsPhongBan();

            DA.Add(new DuAn("DA01", "Cap thoat nuoc", "Thu Duc", PB[0].MaPB, PB[0], new List<PhanCong>()));//1
            DA.Add(new DuAn("DA02", "Ban chung cu", "Thu Thiem", PB[0].MaPB, PB[0], new List<PhanCong>()));//2

            DA.Add(new DuAn("DA03", "Xay biet thu", "Quan 6", PB[1].MaPB, PB[1], new List<PhanCong>()));//3

            DA.Add(new DuAn("DA04", "Xay ho boi ", "Quan 9", PB[2].MaPB, PB[2], new List<PhanCong>())); //4

            DA.Add(new DuAn("DA05", "Xay ki tuc xa ", "Thu Duc", PB[4].MaPB, PB[4], new List<PhanCong>()));//5

            // Them PB vao Du An 
            PB[0].DsDuAn.Add(DA[0]);
            PB[0].DsDuAn.Add(DA[1]);
            PB[1].DsDuAn.Add(DA[2]);
            PB[2].DsDuAn.Add(DA[3]);
            PB[4].DsDuAn.Add(DA[4]);
        }
        public static void TaodsThanNhan()
        {
            TaodsNhanVien();

            TN.Add(new ThanNhan(NV[0].MaNV, "Giờ", "Chị", NV[0]));
            TN.Add(new ThanNhan(NV[1].MaNV, "Mai", "Chị", NV[1]));
            TN.Add(new ThanNhan(NV[2].MaNV, "Lan", "Em", NV[2]));
            TN.Add(new ThanNhan(NV[3].MaNV, "Thúy", "Chị họ ", NV[3]));
            TN.Add(new ThanNhan(NV[4].MaNV, "Cam", "Anh", NV[4]));
            TN.Add(new ThanNhan(NV[5].MaNV, "Ổi", "Cô", NV[5]));
            TN.Add(new ThanNhan(NV[6].MaNV, "Mạnh", "Chú", NV[6]));
            // them than nhan vao nhan vien 
            NV[0].DsThanNhan.Add(TN[0]);
            NV[1].DsThanNhan.Add(TN[1]);
            NV[2].DsThanNhan.Add(TN[2]);
            NV[3].DsThanNhan.Add(TN[3]);
            NV[4].DsThanNhan.Add(TN[4]);
            NV[5].DsThanNhan.Add(TN[5]);
            NV[6].DsThanNhan.Add(TN[6]);
        }
        public static void TaodsPhanCong()
        {
            PC.Add(new PhanCong(NV[0].MaNV, DA[0].MaDA, NV[0], DA[0]));
            PC.Add(new PhanCong(NV[1].MaNV, DA[0].MaDA, NV[1], DA[0]));
            PC.Add(new PhanCong(NV[1].MaNV, DA[1].MaDA, NV[1], DA[1]));
            PC.Add(new PhanCong(NV[2].MaNV, DA[2].MaDA, NV[2], DA[2]));
            PC.Add(new PhanCong(NV[3].MaNV, DA[2].MaDA, NV[3], DA[2]));
            PC.Add(new PhanCong(NV[4].MaNV, DA[3].MaDA, NV[4], DA[3]));
            PC.Add(new PhanCong(NV[5].MaNV, DA[4].MaDA, NV[5], DA[4]));

            // Them NV vao DA
            NV[0].DsDuAn.Add(DA[0]);
            NV[1].DsDuAn.Add(DA[0]);
            NV[1].DsDuAn.Add(DA[1]);
            NV[2].DsDuAn.Add(DA[2]);
            NV[3].DsDuAn.Add(DA[2]);
            NV[4].DsDuAn.Add(DA[3]);
            NV[5].DsDuAn.Add(DA[4]);
        }
        public static void TaodsDiaDiem_Phong()
        {
            DD.Add(new DiaDiem_Phong(PB[0].MaPB, "Khu A", PB[0]));
            DD.Add(new DiaDiem_Phong(PB[1].MaPB, "Khu B", PB[1]));
            DD.Add(new DiaDiem_Phong(PB[2].MaPB, "Khu C", PB[2]));
            DD.Add(new DiaDiem_Phong(PB[3].MaPB, "Khu D", PB[3]));
            DD.Add(new DiaDiem_Phong(PB[4].MaPB, "Khu A", PB[4]));
            // PB vao DD
            PB[0].DsDiaDiem.Add(DD[0]);
            PB[1].DsDiaDiem.Add(DD[1]);
            PB[2].DsDiaDiem.Add(DD[2]);
            PB[3].DsDiaDiem.Add(DD[3]);
            PB[4].DsDiaDiem.Add(DD[4]);
        }




        // (--------------------------------Bai lam-----------------------------------)
        // Phan Thị Yến Nhi _ MSSV: 21110268
        // 1.Tìm nhân viên có địa chi tại Quận 8
        public static void Cau1()
        {
            Console.WriteLine("--1.Tìm nhân viên có địa chi tại Quận 8 ");
            var p = (from nv in NV
                    where nv.Dchi == "Quận 8"
                    select new { ID = nv.MaNV, Name = nv.TenNV }).Distinct();
            foreach (var kq in p)
            {
                Console.WriteLine("\tMã nhân viên: {0}", kq.ID);
                Console.WriteLine("\tTên nhân viên: {0}", kq.Name);
            }
        }
        //2.Hãy cho biết tên các dự án mà nhân viên có mã ‘NV01’ tham gia
        public static void Cau2()
        {
            Console.WriteLine("--2.Hãy cho biết tên các dự án mà nhân viên có mã ‘NV01’ tham gia");
            var p = (from pc in PC
                     join da in DA on pc.MaDA equals da.MaDA
                     where pc.MaNV == "NV01"
                     select new { Da = pc.MaDA , Nv = pc.MaNV, t = da.TenDA}).Distinct();
            foreach (var kq in p)
            {
                Console.WriteLine("\tMã dự án : {0}", kq.Da);
                Console.WriteLine("\tMã nhân viên : {0}", kq.Nv);
                Console.WriteLine("\tTên dự án : {0}", kq.t);
            }
        }
        //3.Cho biết mã nhân viên, họ và tên của các nhân viên của phòng “Nghiên cứu” có
        //mức lương từ 1000
        public static void Cau3()
        {
            Console.WriteLine("--3.Cho biết mã nhân viên, họ và tên của các nhân viên của phòng “Nghiên cứu” có mức lương từ 1000");
            var p = (from nv in NV
                     join pb in PB on nv.MaPB equals pb.MaPB
                     where pb.TenPB == "Nghien cuu" && nv.Luong >= 1000 
                     select new { m = nv.MaNV, t = nv.TenNV, p = pb.TenPB, l = nv.Luong }).Distinct();
            foreach (var kq in p)
            {
                Console.WriteLine("\tMã nhân viên : {0}", kq.m);
                Console.WriteLine("\tTên nhân viên : {0}", kq.t);
                Console.WriteLine("\tTên phòng ban : {0}", kq.p);
                Console.WriteLine("\tLuong : {0}", kq.l);

            }
        }
        //--4.  Cho biết họ tên của nhân viên có thân nhân
        public static void Cau4()
        {
            Console.WriteLine("--4.Cho biết họ tên của nhân viên có thân nhân");
            var p = (from tn in TN
                     join nv in NV on tn.MaNV equals nv.MaNV
                     select new { t = tn.MaNV , a = nv.TenNV, c = tn.TenThanNhan, d = tn.QuanHe }).Distinct();
            foreach (var kq in p)
            {
                Console.WriteLine("\tMã nhân viên : {0}", kq.t);
                Console.WriteLine("\tTên nhân viên : {0}", kq.a);
                Console.WriteLine("\tTên Thân nhân : {0}", kq.c);
                Console.WriteLine("\tQuan hệ : {0}", kq.d);

            }
        }
        // 5. Liệt kê  nhân viên có giới tính là nữ
        public static void Cau5()
        {
            Console.WriteLine("--5. Liệt kê họ tên nhân viên có giới tính là nữ");
            var p = (from nv in NV
                     where nv.GioiTinh == "Nữ"
                     select new { t = nv.MaNV, a = nv.TenNV, c = nv.GioiTinh }).Distinct();
            foreach (var kq in p)
            {
                Console.WriteLine("\tMã nhân viên : {0}", kq.t);
                Console.WriteLine("\tTên nhân viên : {0}", kq.a);
                Console.WriteLine("\tGiới tính : {0}", kq.c);


            }

        }
        //6.Cho biết tên dự án và tên phòng ban 
        public static void Cau6()
        {
            Console.WriteLine("--6.Cho biết tên dự án và tên phòng ban");
            var p = (from da in DA
                     join pb in PB on da.MaPB equals pb.MaPB
                     select new { t = da.MaDA, a = da.TenDA, c = pb.TenPB}).Distinct();
            foreach (var kq in p)
                Console.WriteLine("\tMã dự án : {0}", kq.t + " ,Tên dư án: " + kq.a + " , Tên Phòng Ban: " + kq.c);


        }
        // 7. Tính tổng nhân viên ở phòng nghiên cứu 
        public static void Cau7()
        {
            Console.WriteLine("--7.Tính tổng nhân viên ở phòng nghiên cứu ");

            var p = (from nv in NV
                     join pb in PB on nv.MaPB equals pb.MaPB
                     where pb.TenPB == "Nghien cuu"
                     select nv.MaNV).Distinct();
            var TongNV = p.Count();
            Console.WriteLine("Tổng nhân viên: " + TongNV);


        }
        // Tim nhan vien co luong cao nhat
        public static void Cau8()
        {
            Console.WriteLine("--8.Tim nhan vien co luong cao nhat ");

            var p = (from nv in NV
                     select nv.Luong).Distinct();
            var LuongCaoNhat = p.Max();
            var NVLuongCaoNhat = NV.Where(n => n.Luong == LuongCaoNhat).Distinct();
            Console.WriteLine("\tThông tin nhân viên có lương cao nhất ");
            foreach (var kq in NVLuongCaoNhat)
                Console.WriteLine("\t\tMã nhân viên: " + kq.MaNV + ",Tên nhân viên: " + kq.TenNV + ", Lương: " + kq.Luong);


        }
        // Liệt kê địa điểm của từng phòng ban 
        public static void Cau9()
        {
            Console.WriteLine("--9.Liệt kê địa điểm của từng phòng ban ");
            var p = (from dd in DD
                     select new { M = dd.MaPB, D = dd.DiaDiem }).Distinct();
            foreach (var kq in p)
                Console.WriteLine("\tMã phòng ban: " + kq.M + ",Địa điểm: " + kq.D);


        }
        // In danh sách nhân viên theo thứ tự lương giảm 
        public static void Cau10()
        {
            Console.WriteLine("--10.In danh sách nhân viên theo thứ tự giảm  dần  ");
            var p = (from nv in NV
                    orderby nv.Luong descending
                    select new { M = nv.MaNV, N = nv.TenNV, C = nv.Dchi, D = nv.Luong }).Distinct();
            foreach (var kq in p)
                Console.WriteLine("\tMã Nhân viên: " + kq.M + ", Tên nhân viên: " + kq.N + ", Địa chỉ : " + kq.C + ", Lương: " + kq.D);


        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TaodsNhanVien();
            TaodsDuAn();
            TaodsPhongBan();
            TaodsThanNhan();
            TaodsPhanCong();
            TaodsDiaDiem_Phong();
            Cau1();
            Cau2();
            Cau3();
            Cau4();
            Cau5();
            Cau6();
            Cau7();
            Cau8();
            Cau9();
            Cau10();
        }
    }
}