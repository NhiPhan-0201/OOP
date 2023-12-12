package congty;

public class DiaDiem_Phong {
	
	public DiaDiem_Phong() { }
	public DiaDiem_Phong(String MaPB,String DiaDiem,PhongBan PB) {
		this.MaPB = MaPB;
		this.DiaDiem = DiaDiem;
		this.PB = PB;
	}
	public DiaDiem_Phong(DiaDiem_Phong dd) {
		this.MaPB = dd.MaPB;
		this.DiaDiem = dd.DiaDiem;
		this.PB = dd.PB;
	}
	
	public String MaPB;
	public String DiaDiem;
	PhongBan PB;
	
	public String getMaPB() {
		return MaPB;
	}
	public void setMaPB(String maPB) {
		MaPB = maPB;
	}
	public String getDiaDiem() {
		return DiaDiem;
	}
	public void setDiaDiem(String diaDiem) {
		DiaDiem = diaDiem;
	}
	public PhongBan getPB() {
		return PB;
	}
	public void setPB(PhongBan pB) {
		PB = pB;
	}
}
