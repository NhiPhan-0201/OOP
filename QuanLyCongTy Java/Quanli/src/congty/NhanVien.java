package congty;

import java.util.ArrayList;
import java.util.List;

public class NhanVien {

	public NhanVien() { }
	public NhanVien(String MaNV,String TenNV,String DChi,String GioiTinh,int Luong,String MaNQL,String MaPB,PhongBan PB, List<ThanNhan>DsThanNhan,List<PhanCong>DsPhanCong,List<DuAn>DsDuAn) 
	{
		this.MaNV = MaNV;
        this.TenNV = TenNV;
        this.Dchi = DChi;
        this.GioiTinh = GioiTinh;
        this.Luong = Luong;
        this.MaNQL = MaNQL;
        this.MaPB = MaPB;
        this.PB = PB;
	}
	public NhanVien(NhanVien nv ) {
		this.MaNV = nv.MaNV;
        this.TenNV = nv.TenNV;
        this.Dchi = nv.Dchi;
        this.GioiTinh = nv.GioiTinh;
        this.Luong = nv.Luong;
        this.MaNQL = nv.MaNQL;
        this.MaPB = nv.MaPB;
        this.PB = nv.PB;
        this.DsThanNhan=nv.DsThanNhan;
        this.DsPhanCong=nv.DsPhanCong;
        this.DsDuAn=nv.DsDuAn;
	}
	public String MaNV;
	public String TenNV;
	public String Dchi;
	public String GioiTinh;
	public int Luong;
	public String MaNQL;
	public String MaPB;
	public PhongBan PB;
	List<ThanNhan>DsThanNhan = new ArrayList<ThanNhan>();
	List<PhanCong>DsPhanCong = new ArrayList<PhanCong>();
	List<DuAn>DsDuAn = new ArrayList<DuAn>();
	
	public String getMaNV()
	{
		return MaNV;
	}
	public void setMaNV(String maNV)
	{
		MaNV = maNV;
	}
	public String getTenNV() {
		return TenNV;
	}
	public void setTenNv(String tenNV) {
		TenNV = tenNV;
	}
	public String getDchi() {
		return Dchi;
	}
	public void setDchi(String dchi) {
		Dchi = dchi;
	}
	public String getGioiTinh() {
		return GioiTinh;
	}
	public void setGioiTinh(String gioiTinh) {
		GioiTinh = gioiTinh;
	}
	public int getLuong() {
		return Luong;
	}
	public void setLuong(int luong) {
		Luong = luong;
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
	public List<ThanNhan> getDsThanNhan(){
		return DsThanNhan;
	}
	public void setDsThanNhan(List<ThanNhan> dsThanNhan) {
		DsThanNhan=dsThanNhan;
	}
	public List<DuAn> getDsDuAn(){
		return DsDuAn;
	}
	public void setDsDuAn(List<DuAn> dsDuAn) {
		DsDuAn=dsDuAn;
	}	
}
