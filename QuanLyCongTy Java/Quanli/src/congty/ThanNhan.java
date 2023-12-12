package congty;

public class ThanNhan {

	public ThanNhan() { }
	public ThanNhan(String MaNV,String TenTN,String QuanHe,NhanVien NV) {
		this.MaNV = MaNV;
		this.TenTN = TenTN;
		this.QuanHe = QuanHe;
		this.NV = NV;
	}
	public ThanNhan(ThanNhan tn) {
		this.MaNV = tn.MaNV;
		this.TenTN = tn.TenTN;
		this.QuanHe = tn.QuanHe;
		this.NV = tn.NV;
	}
	
	public String MaNV;
	public String TenTN;
	public String QuanHe;
	NhanVien NV;
	
	public String getMaNV() {
		return MaNV;
	}
	public void setMaNV(String maNV) {
		MaNV = maNV;
	}
	public String getTenNV() {
		return TenTN;
	}
	public void setTenTN(String tenTN) {
		TenTN = tenTN;
	}
	public String getQuanHe() {
		return QuanHe;
	}
	public void setQuanHe(String quanHe) {
		QuanHe = quanHe;
	}
	public NhanVien getNV() {
		return NV;
	}
	public void setNV(NhanVien nV) {
		NV = nV;
	}

}
