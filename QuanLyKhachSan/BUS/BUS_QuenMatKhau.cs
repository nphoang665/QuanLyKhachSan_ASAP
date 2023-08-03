using QuanLyKhachSan.DA;

public class BUS_QuenMatKhau
{
    DA_QuenMatKhau da;
    public BUS_QuenMatKhau()
    {
        da = new DA_QuenMatKhau();
    }
    public bool kiemTraTenDangNhap(string tenDangNhap)
    {
        return da.layTaiKhoan(tenDangNhap) != null;
    }
    public void doiMatKhau(string tenDangNhap, string matKhauMoi)
    {
        da.capNhatMatKhau(tenDangNhap, matKhauMoi);
    }
}
