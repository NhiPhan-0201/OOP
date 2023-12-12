package congty;

public class PhanCong {
	public PhanCong() { }
	public PhanCong(String MaNV,String MaDA,DuAn DA,NhanVien NV) {
		this.MaNV = MaNV;
		this.MaDA = MaDA;
		this.DA = DA;
		this.NV = NV;
	}
	public PhanCong(PhanCong pc) {
		this.MaNV = pc.MaNV;
		this.MaDA = pc.MaDA;
		this.DA = pc.DA;
		this.NV = pc.NV;
	}
	
	public String MaNV;
	public String MaDA;
	DuAn DA;
	NhanVien NV;
	
	public String getMaNV() {
		return MaNV;
	}
	public void setMaNV(String maNV) {
		MaNV = maNV;
	}
	public String getMaDA() {
		return MaDA;
	}
	public void setMaDA(String maDA) {
		MaDA = maDA;
	}
	public DuAn getDA() {
		return DA;
	}
	public void setDA(DuAn dA) {
		DA = dA;
	}
	public NhanVien getNV() {
		return NV;
	}
	public void setNV(NhanVien nV) {
		NV = nV;
	}
}
