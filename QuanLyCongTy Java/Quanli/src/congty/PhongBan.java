package congty;

import java.util.ArrayList;
import java.util.List;

public class PhongBan
{
	public PhongBan() { }
	public PhongBan(String MaPB,String TenPB,List<NhanVien> DsNhanVien,List<DuAn> DsDuAn,List<DiaDiem_Phong> DsDiaDiem)
	{
		this.MaPB = MaPB;
		this.TenPB = TenPB;
		this.DsNhanVien = DsNhanVien;
		this.DsDuAn = DsDuAn;
		this.DsDiaDiem = DsDiaDiem;
	}
	public PhongBan(PhongBan pb) {
		this.MaPB = pb.MaPB;
		this.TenPB = pb.TenPB;
		this.DsNhanVien = pb.DsNhanVien;
		this.DsDuAn = pb.DsDuAn;
		this.DsDiaDiem = pb.DsDiaDiem;
	}
	public String MaPB;
	public String TenPB;
	List<NhanVien> DsNhanVien = new ArrayList<NhanVien>();
	List<DuAn> DsDuAn = new ArrayList<DuAn>();
	List<DiaDiem_Phong> DsDiaDiem = new ArrayList<DiaDiem_Phong>();
	
	public String getMaPB() {
		return MaPB;
	}
	public void setMaPB(String maPB) {
		MaPB = maPB;
	}
	public String getTenPB() {
		return TenPB;
	}
	public void setTenPB(String tenPB) {
		TenPB=tenPB;
	}
	public List<NhanVien> getDsNhanVien(){
		return DsNhanVien;
	}
	public void setDsNhanVien(List<NhanVien> dsNhanVien) {
		DsNhanVien = dsNhanVien;
	}
	public List<DuAn> getDsDuAn(){
		return DsDuAn;
	}
	public void setDsDuAn(List<DuAn> dsDuAn) {
		DsDuAn = dsDuAn;
	}
	public List<DiaDiem_Phong> getDsDiaDiem(){
		return DsDiaDiem;
	}
	public void setDsDiaDiem(List<DiaDiem_Phong> dsDiaDiem) {
		DsDiaDiem = dsDiaDiem;
	}
}
