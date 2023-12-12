package congty;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class Program {
	
	public static List<NhanVien> NV = new ArrayList<NhanVien>();
	public static List<PhongBan> PB = new ArrayList<PhongBan>();
	public static List<ThanNhan> TN = new ArrayList<ThanNhan>();
	public static List<DuAn> DA = new ArrayList<DuAn>();
	public static List<PhanCong> PC = new ArrayList<PhanCong>();
	public static List<DiaDiem_Phong> DD = new ArrayList<DiaDiem_Phong>();
	public static void main(String[] args) {
			
			TaodsNhanVien();
			TaodsDuAn();
			TaodsPhongBan();
			TaodsPhanCong();
			TaodsThanNhan();
			TaodsDiaDiem_Phong();
			Cau1();
			Cau2();
			Cau3();
			Cau4();
			Cau5();	
		}
	public static void TaodsNhanVien() {
		TaodsPhongBan();
		
        NV.add(new NhanVien("NV01", "Kim Chi ", "Quận 8 ", "Nữ", 3000, "nv01", PB.get(0).MaPB, PB.get(0),new ArrayList<ThanNhan>(),new ArrayList<PhanCong>(), new ArrayList<DuAn>()));//1
        NV.add(new NhanVien("NV02", "Yen Nhi", "Quan Gò Vấp", "Nữ", 2000, "nv01", PB.get(0).MaPB, PB.get(0), new ArrayList<ThanNhan>(), new ArrayList<PhanCong>(),new ArrayList<DuAn>()));//2
        NV.add(new NhanVien("NV03", "Gia Bao", "Tiền Giang", "Nam", 5000, "nv02", PB.get(1).MaPB, PB.get(1), new ArrayList<ThanNhan>(), new ArrayList<PhanCong>(), new ArrayList<DuAn>()));//3
        NV.add(new NhanVien("NV04", "Minh Tien", "Phú Hữu", "Nam", 4000, "nv03", PB.get(2).MaPB, PB.get(2), new ArrayList<ThanNhan>(), new ArrayList<PhanCong>(), new ArrayList<DuAn>()));//4
        NV.add(new NhanVien("NV05", "Xuan Quyen", "Phú Hữu", "Nữ", 3000, "nv03", PB.get(3).MaPB, PB.get(3), new ArrayList<ThanNhan>(), new ArrayList<PhanCong>(), new ArrayList<DuAn>()));//5
        NV.add(new NhanVien("NV06", "Kim Sang", "Tân Hương","Nữ", 5000, "nv04", PB.get(5).MaPB, PB.get(5), new ArrayList<ThanNhan>(), new ArrayList<PhanCong>(), new ArrayList<DuAn>()));//6
        NV.add(new NhanVien("NV07", "My Xuyen", "Phú Nhuận", "Nữ", 4000, "nv05", PB.get(6).MaPB, PB.get(6), new ArrayList<ThanNhan>(), new ArrayList<PhanCong>(), new ArrayList<DuAn>()));//7
        NV.add(new NhanVien("NV08", "Hoang Khang", "Phú Nhuận","Nam", 4000, "nv06", PB.get(4).MaPB, PB.get(4), new ArrayList<ThanNhan>(), new ArrayList<PhanCong>(), new ArrayList<DuAn>()));//8

        PB.get(0).DsNhanVien.add(NV.get(0));
        PB.get(0).DsNhanVien.add(NV.get(1));;

        PB.get(1).DsNhanVien.add(NV.get(2));

        PB.get(2).DsNhanVien.add(NV.get(3));

        PB.get(3).DsNhanVien.add(NV.get(4));

        PB.get(5).DsNhanVien.add(NV.get(5));

        PB.get(6).DsNhanVien.add(NV.get(6));
        
        PB.get(4).DsNhanVien.add(NV.get(7));
	}
	public static void TaodsDuAn() {
		TaodsPhongBan();

        DA.add(new DuAn("DA01", "Cap thoat nuoc", "Thu Duc", PB.get(0).MaPB, PB.get(0), new ArrayList<PhanCong>()));//1
        DA.add(new DuAn("DA02", "Ban chung cu", "Thu Thiem", PB.get(0).MaPB,PB.get(0), new ArrayList<PhanCong>()));//2

        DA.add(new DuAn("DA03", "Xay biet thu", "Quan 6", PB.get(1).MaPB, PB.get(1), new ArrayList<PhanCong>()));//3

        DA.add(new DuAn("DA04","Xay ho boi ","Quan 9", PB.get(2).MaPB, PB.get(2),new ArrayList<PhanCong>())); //4

        DA.add(new DuAn("DA05","Xay ki tuc xa ","Thu Duc", PB.get(4).MaPB, PB.get(4),new ArrayList<PhanCong>()));//5

        PB.get(0).DsDuAn.add(DA.get(0));
        PB.get(0).DsDuAn.add(DA.get(1));
        PB.get(1).DsDuAn.add(DA.get(2));
        PB.get(2).DsDuAn.add(DA.get(3));
        PB.get(4).DsDuAn.add(DA.get(4));
	}
	public static void TaodsPhongBan() {
		
		PB.add(new PhongBan("PB1","Nghien cuu",new ArrayList<NhanVien>(),new ArrayList<DuAn>(),new ArrayList<DiaDiem_Phong>()));
		PB.add(new PhongBan("PB2","Tai chinh",new ArrayList<NhanVien>(),new ArrayList<DuAn>(),new ArrayList<DiaDiem_Phong>()));
		PB.add(new PhongBan("PB3","Ke toan",new ArrayList<NhanVien>(),new ArrayList<DuAn>(),new ArrayList<DiaDiem_Phong>()));
		PB.add(new PhongBan("PB4","Marketing",new ArrayList<NhanVien>(),new ArrayList<DuAn>(),new ArrayList<DiaDiem_Phong>()));
		PB.add(new PhongBan("PB5","Ke hoach",new ArrayList<NhanVien>(),new ArrayList<DuAn>(),new ArrayList<DiaDiem_Phong>()));
		PB.add(new PhongBan("PB6","Dao tao",new ArrayList<NhanVien>(),new ArrayList<DuAn>(),new ArrayList<DiaDiem_Phong>()));
		PB.add(new PhongBan("PB1","Kinh te",new ArrayList<NhanVien>(),new ArrayList<DuAn>(),new ArrayList<DiaDiem_Phong>()));
	}
	public static void TaodsPhanCong() {
		
		PC.add(new PhanCong(DA.get(0).MaDA,NV.get(0).MaNV,DA.get(0),NV.get(0)));
		PC.add(new PhanCong(DA.get(0).MaDA,NV.get(1).MaNV,DA.get(0),NV.get(1)));
		PC.add(new PhanCong(DA.get(1).MaDA,NV.get(1).MaNV,DA.get(0),NV.get(1)));
		PC.add(new PhanCong(DA.get(2).MaDA,NV.get(2).MaNV,DA.get(0),NV.get(2)));
		PC.add(new PhanCong(DA.get(3).MaDA,NV.get(4).MaNV,DA.get(3),NV.get(4)));
		PC.add(new PhanCong(DA.get(4).MaDA,NV.get(5).MaNV,DA.get(0),NV.get(5)));
	
	}
	public static void TaodsThanNhan() {
		
		TN.add(new ThanNhan(NV.get(0).MaNV,"Thúy","Chị",NV.get(0)));
		TN.add(new ThanNhan(NV.get(1).MaNV,"Đào","Chị",NV.get(1)));
		TN.add(new ThanNhan(NV.get(2).MaNV,"Duy","Anh",NV.get(2)));
		TN.add(new ThanNhan(NV.get(3).MaNV,"Tuấn","Bố",NV.get(3)));
		TN.add(new ThanNhan(NV.get(4).MaNV,"Đam","Cậu",NV.get(4)));
		TN.add(new ThanNhan(NV.get(5).MaNV,"Nhung","Mẹ",NV.get(5)));
		TN.add(new ThanNhan(NV.get(6).MaNV,"Hiếu","Anh",NV.get(6)));
		
		NV.get(0).DsThanNhan.add(TN.get(0));
		NV.get(1).DsThanNhan.add(TN.get(1));
		NV.get(2).DsThanNhan.add(TN.get(2));
		NV.get(3).DsThanNhan.add(TN.get(3));
		NV.get(4).DsThanNhan.add(TN.get(4));
		NV.get(5).DsThanNhan.add(TN.get(5));
		NV.get(6).DsThanNhan.add(TN.get(6));
		
	}
	public static void TaodsDiaDiem_Phong() {
		DD.add(new DiaDiem_Phong(PB.get(0).MaPB,"Khu A",PB.get(0)));
		DD.add(new DiaDiem_Phong(PB.get(1).MaPB,"Khu B",PB.get(1)));
		DD.add(new DiaDiem_Phong(PB.get(2).MaPB,"Khu C",PB.get(2)));
		DD.add(new DiaDiem_Phong(PB.get(3).MaPB,"Khu D",PB.get(3)));
		DD.add(new DiaDiem_Phong(PB.get(4).MaPB,"Khu E",PB.get(4)));
	}
	
	
	  // Phan Thị Yên Nhi MSSV : 21110268  
		/// (-----------------------------------------------Bài làm----------------------------------------)
	public static void Cau1() {
		
		List<NhanVien> DsNhanVien = NV.stream().collect(Collectors.toList());
		System.out.println("--1.Danh sách nhân viên có lương trên 3000 dola ");
		for (NhanVien kq : DsNhanVien) {
			if (kq.Luong >= 3000) {
				System.out.println("\tTen Nhan vien: " + kq.TenNV + " - " + "Luong: " + kq.Luong);
			}
		}

	}
	public static void Cau2() {
		System.out.println("---------------------------------------------------");
		System.out.println("--2.Liệt kê nhân viên làm việc cho phòng Nghien cuu ");
    	List <NhanVien> DsNhanVien = NV.stream().filter(x -> x.getPB().getTenPB() == "Nghien cuu").collect(Collectors.toList());
    	for(NhanVien sp : DsNhanVien)
    	{
    		System.out.println("\tMã nhân viên: " + sp.getMaNV() + " - " + "Tên Nhân Viên: " + sp.getTenNV());
    	}
	}
	public static void Cau3() {
		System.out.println("---------------------------------------------------");
		System.out.println("--3.Tổng số lượng nhân viên ở có lương lớn hơn 2000 dola");
		long list = NV 
				.stream()
				.filter(p -> p.getLuong() > 3000 )
				.count();
		System.out.println("\tTong la " + list );
	}
	public static void Cau4() {
		System.out.println("---------------------------------------------------");
		System.out.println("--4.Cho biết họ tên của nhân viên có thân nhân");
		List <NhanVien> DsNhanVien = NV.stream().collect(Collectors.toList());
		for (NhanVien sp : DsNhanVien) {
			System.out.println("Mã nhân viên: " + sp.getMaNV() + " - " + "Tên Nhân Viên: " + sp.getTenNV() + "\n\tHọ tên thân nhân là:");
			for(ThanNhan tn : sp.DsThanNhan) {
				System.out.println("\tTên thân nhân: " + tn.TenTN + " và " + " Quan hệ: " + tn.QuanHe);
			}
		}	
	}
	public static void Cau5() {
		System.out.println("---------------------------------------------------");
		System.out.println("--5.Liệt kê nhân viên có giới tính nữ ");
		List <NhanVien> DsNhanVien  = NV 
				.stream()
				.filter(x -> x.GioiTinh == "Nữ")
				.collect(Collectors.toList());
		for (NhanVien sp : DsNhanVien) {
			System.out.println("\tMã nhân viên: " + sp.MaNV + ", Tên nhân viên: " + sp.TenNV);
		}
	}
}
