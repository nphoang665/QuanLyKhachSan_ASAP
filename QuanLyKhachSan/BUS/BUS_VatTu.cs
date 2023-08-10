using QuanLyKhachSan.DA;
using System.Windows.Forms;

public class BUS_VatTu
{
    DA_VatTu DA_;
    public BUS_VatTu()
    {
        DA_ = new DA_VatTu();
    }
    public void LoadDsTk(DataGridView dgv)
    {
        dgv.DataSource = DA_.LayVatTu();
    }
    public void LoadNhanSu(ComboBox cbo)
    {
        cbo.DataSource = DA_.LayNhanSu();
        cbo.DisplayMember = "TenNhanVien";
        cbo.ValueMember = "MaNhanSu";
    }
    public void LoadVatTu(ComboBox cbo)
    {
        cbo.DataSource = DA_.LayVatTu1();
        cbo.DisplayMember = "MaVatTu";
        cbo.ValueMember = "TenVatTu"; 
    }

    public void ThemVatTu(string maVatTu, string tenVatTu, string nhaCungCap, string nguoiQuanLy, string ghiChu)
    {
        DA_.ThemVatTu(maVatTu, tenVatTu, nhaCungCap, nguoiQuanLy, ghiChu);
    }
    public void SuaVatTu(string maVatTu, string tenVatTu, string nhaCungCap, string nguoiQuanLy, string ghiChu)
    {
        DA_.SuaVatTu(maVatTu, tenVatTu, nhaCungCap, nguoiQuanLy, ghiChu);
    }

    public void XoaVatTu(string maVatTu)
    {
        DA_.XoaVatTu(maVatTu);
    }
    public dynamic TimVatTuTheoMa(string maVatTu)
    {
        return DA_.TimVatTuTheoMa(maVatTu);
    }

    public dynamic TimVatTuTheoTen(string tenVatTu)
    {
        return DA_.TimVatTuTheoTen(tenVatTu);
    }

    public dynamic TimVatTuTheoNguoiQuanLy(string nguoiQuanLy)
    {
        return DA_.TimVatTuTheoNguoiQuanLy(nguoiQuanLy);
    }
}
