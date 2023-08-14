using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    public class DA_NhanSu
    {
        QuanLyKhachSanEntities db;
        public DA_NhanSu()
        {
            db = new QuanLyKhachSanEntities();
        }
        public void LayNhanVien(DataGridView dtgv)
        {
            dtgv.Rows.Clear();
            var ds = db.NhanSus.Select(s => new
            {
                s.MaNhanSu,
                s.TenNhanSu,
                s.GioiTinh,
                s.DiaChi,
                s.SoDienThoai,
                s.NgaySinh,
                s.NgayVaoLam,
                s.ChucVu,
                s.CCCD

            }).ToList();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaNhanSu;
                row.Cells[1].Value = ns.TenNhanSu;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh.Value.ToShortDateString();
                row.Cells[5].Value = ns.NgayVaoLam.Value.ToShortDateString();
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;
                row.Cells[8].Value = ns.CCCD;

            }
        }
        public void ThemNhanSu(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu, PictureBox pi, string cccd)
        {
            using (MemoryStream steam = new MemoryStream())
            {
                pi.Image.Save(steam, ImageFormat.Jpeg);
                var nhansu = new NhanSu
                {
                    MaNhanSu = mans,
                    TenNhanSu = tenvn,
                    GioiTinh = gioitinh,
                    DiaChi = diachi,
                    SoDienThoai = sdt,
                    NgaySinh = ngaysinh,
                    NgayVaoLam = ngayvaolam,
                    ChucVu = chucvu,
                    AnhNhanVien = steam.ToArray(),
                    CCCD = cccd

                };
                db.NhanSus.Add(nhansu);
                db.SaveChanges();
            }
        }
        public void SuaNhanSu(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu, PictureBox pi, string cccd)
        {
            var nhanSu = db.NhanSus.FirstOrDefault(ns => ns.MaNhanSu == mans);
            if (nhanSu != null)
            {
                nhanSu.TenNhanSu = tenvn;
                nhanSu.GioiTinh = gioitinh;
                nhanSu.DiaChi = diachi;
                nhanSu.SoDienThoai = sdt;
                nhanSu.NgaySinh = ngaysinh;
                nhanSu.NgayVaoLam = ngayvaolam;
                nhanSu.ChucVu = chucvu;
                nhanSu.CCCD = cccd;

                if (pi != null && pi.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        try
                        {
                            pi.Image.Save(ms, ImageFormat.Jpeg);
                            byte[] newImage = ms.ToArray();
                            if (nhanSu.AnhNhanVien == null || !nhanSu.AnhNhanVien.SequenceEqual(newImage))
                            {
                                nhanSu.AnhNhanVien = newImage;
                            }
                        }
                        catch (Exception ex)
                        {
                            File.AppendAllText("error.log", ex.ToString() + Environment.NewLine);
                        }
                    }
                }

                db.SaveChanges();
            }
        }





        public void XoaNhanSu(string mans)
    {
        var nhansu = db.NhanSus.FirstOrDefault(ns => ns.MaNhanSu == mans);
        if (nhansu != null)
        {
            db.NhanSus.Remove(nhansu);
            db.SaveChanges();
        }
    }
    public void TimTheoTenNhanSu(string hoten, DataGridView dtgv)
    {
        var ds = db.NhanSus.Where(ns => ns.TenNhanSu.Contains(hoten)).ToList();
        dtgv.Rows.Clear();
        foreach (var ns in ds)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();

            int ViTri = dtgv.Rows.Add();
            DataGridViewRow row = dtgv.Rows[ViTri];
            row.Cells[0].Value = ns.MaNhanSu;
            row.Cells[1].Value = ns.TenNhanSu;
            row.Cells[2].Value = ns.GioiTinh;
            row.Cells[3].Value = ns.ChucVu;
            row.Cells[4].Value = ns.NgaySinh.Value.ToShortDateString();
            row.Cells[5].Value = ns.NgayVaoLam.Value.ToShortDateString();
            row.Cells[6].Value = ns.DiaChi;
            row.Cells[7].Value = ns.SoDienThoai;
            row.Cells[8].Value = ns.CCCD;

        }

    }
    public void TimTheoChucVuNhanSu(string chucvu, DataGridView dtgv)
    {
        var ds = db.NhanSus.Where(ns => ns.ChucVu.Contains(chucvu)).ToList();
        dtgv.Rows.Clear();
        foreach (var ns in ds)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();

            int ViTri = dtgv.Rows.Add();
            DataGridViewRow row = dtgv.Rows[ViTri];
            row.Cells[0].Value = ns.MaNhanSu;
            row.Cells[1].Value = ns.TenNhanSu;
            row.Cells[2].Value = ns.GioiTinh;
            row.Cells[3].Value = ns.ChucVu;
            row.Cells[4].Value = ns.NgaySinh.Value.ToShortDateString();
            row.Cells[5].Value = ns.NgayVaoLam.Value.ToShortDateString();
            row.Cells[6].Value = ns.DiaChi;
            row.Cells[7].Value = ns.SoDienThoai;
            row.Cells[8].Value = ns.CCCD;

        }

    }
    public void TimTheoGioiTinhNhanSu(string gioitinh, DataGridView dtgv)
    {
        var ds = db.NhanSus.Where(ns => ns.GioiTinh == gioitinh).ToList();
        dtgv.Rows.Clear();
        foreach (var ns in ds)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();

            int ViTri = dtgv.Rows.Add();
            DataGridViewRow row = dtgv.Rows[ViTri];
            row.Cells[0].Value = ns.MaNhanSu;
            row.Cells[1].Value = ns.TenNhanSu;
            row.Cells[2].Value = ns.GioiTinh;
            row.Cells[3].Value = ns.ChucVu;
            row.Cells[4].Value = ns.NgaySinh.Value.ToShortDateString();
            row.Cells[5].Value = ns.NgayVaoLam.Value.ToShortDateString();
            row.Cells[6].Value = ns.DiaChi;
            row.Cells[7].Value = ns.SoDienThoai;
            row.Cells[8].Value = ns.CCCD;

        }

    }
    public void TimTheosdtNhanSu(string sdt, DataGridView dtgv)
    {
        var ds = db.NhanSus.Where(ns => ns.SoDienThoai.Contains(sdt)).ToList();
        dtgv.Rows.Clear();
        foreach (var ns in ds)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();

            int ViTri = dtgv.Rows.Add();
            DataGridViewRow row = dtgv.Rows[ViTri];
            row.Cells[0].Value = ns.MaNhanSu;
            row.Cells[1].Value = ns.TenNhanSu;
            row.Cells[2].Value = ns.GioiTinh;
            row.Cells[3].Value = ns.ChucVu;
            row.Cells[4].Value = ns.NgaySinh.Value.ToShortDateString();
            row.Cells[5].Value = ns.NgayVaoLam.Value.ToShortDateString();
            row.Cells[6].Value = ns.DiaChi;
            row.Cells[7].Value = ns.SoDienThoai;
            row.Cells[8].Value = ns.CCCD;

        }

    }
    public void layanhNV(string manv, PictureBox pic)
    {
        var sv = db.NhanSus.FirstOrDefault(a => a.MaNhanSu == manv);
        if (sv == null)
        {
            MessageBox.Show("Không có");
            return;
        }
        using (MemoryStream stream = new MemoryStream(sv.AnhNhanVien))
        {
            pic.Image = Image.FromStream(stream);
        }
    }

    public bool KiemTraKhoa(string manhansu)
    {
        var nhansu = db.NhanSus.Any(ns => ns.MaNhanSu == manhansu);
        if (nhansu)
        {
            MessageBox.Show("Trùng mã nhân sự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        return true;
    }
    public bool checksdt(string sdt)
    {
        var data = db.NhanSus.Any(ns => ns.SoDienThoai == sdt);
        if (data)
        {
            MessageBox.Show("Số điện thoại này đã được sử dụng!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else
        {
            return true;
        }

    }
    public bool checkcccd(string cccd)
    {
        var data = db.NhanSus.Any(ns => ns.CCCD == cccd);
        if (data)
        {
            MessageBox.Show("Số căn cước công dân đã được sử dụng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else
        {
            return true;
        }

    }
        public bool dodaicccd(string cccd)
        {

            if (cccd.Length != 12)
            {
                MessageBox.Show("Căn cước công dân không hợp lệ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool dodaisdt(string cccd)
        {

            if (cccd.Length < 10 || cccd.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
