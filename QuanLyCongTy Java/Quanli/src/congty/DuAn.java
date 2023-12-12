package congty;

import java.util.ArrayList;
import java.util.List;

public class DuAn {

	public DuAn() { }
	public DuAn(String MaDA,String TenDA,String DiaDiem,String MaPB,PhongBan PB,List<PhanCong> DsPhanCong) {
		this.MaDA = MaDA;
		this.TenDA = TenDA;
		this.DiaDiem = DiaDiem;
		this.MaPB = MaPB;
		this.PB = PB;
		this.DsPhanCong = DsPhanCong;
	}
	public DuAn(DuAn da) {
		this.MaDA = da.MaDA;
		this.TenDA = da.TenDA;
		this.DiaDiem = da.DiaDiem;
		this.MaPB = da.MaPB;
		this.PB = da.PB;
		this.DsPhanCong = da.DsPhanCong;
	}
	
	public String MaDA;
	public String TenDA;
	public String DiaDiem;
	public String MaPB;
	PhongBan PB;
	
	List<PhanCong> DsPhanCong = new ArrayList<PhanCong>();
	
	
	public String getMaDA() {
		return MaDA;
	}
	public void setMaDA(String maDA) {
		MaDA = maDA;
	}
	public String getTenDA() {
		return TenDA;
	}
	public void setTenDA(String tenDuAn) {
		TenDA = tenDuAn;
	}
	public String getDiaDiem() {
		return DiaDiem;
	}
	public void setDiaDiem(String diaDiem) {
		DiaDiem = diaDiem;
	}
	public String getMaPB() {
		return MaPB;
	}
	public void setMaPB(String maPB) {
		MaPB = maPB;
	}
	public PhongBan getPB() {
		return PB;
	}
	public void setPB(PhongBan pB) {
		PB = pB;
	}
	public List<PhanCong> getDsPhanCong(){
		return DsPhanCong;
	}
	public void setDsPhanCong(List<PhanCong> dsPhanCong) {
		DsPhanCong = dsPhanCong;
	}
}
