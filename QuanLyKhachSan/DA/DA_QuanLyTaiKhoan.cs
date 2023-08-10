
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    public  class DA_QuanLyTaiKhoan
    {
        QuanLyKhachSanEntities db;
        public DA_QuanLyTaiKhoan()
        {
            db = new QuanLyKhachSanEntities();
        }
        public dynamic LayDsTk()
        {
            var ds = db.TaiKhoans.Select(s =>
            new
            {
           
                s.TenDangNhap,
                s.MatKhau,
                s.PhanQuyen,
                s.MaNhanSu
            }
            ).ToList();
            return ds;
        }
        public void ThemTaiKhoan( string tenDangNhap, string matKhau, string phanQuyen,string manhansu)
        {
            var taiKhoan = new TaiKhoan
            {

                TenDangNhap = tenDangNhap,
                MatKhau = matKhau,
                PhanQuyen = phanQuyen,
                MaNhanSu = manhansu
               
            };
            db.TaiKhoans.Add(taiKhoan);
            db.SaveChanges();
        }

        public void SuaTaiKhoan( string tenDangNhap, string matKhau, string phanQuyen,string manhansu)
        {
            var taiKhoan = db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tenDangNhap);
            if (taiKhoan != null)
            {
                taiKhoan.TenDangNhap = tenDangNhap;
                taiKhoan.MatKhau = matKhau;
                taiKhoan.PhanQuyen = phanQuyen;
                taiKhoan.MaNhanSu = manhansu;
                db.SaveChanges();
            }
        }

        public void XoaTaiKhoan(string tendangnhap)
        {
            var taiKhoan = db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tendangnhap);
            if (taiKhoan != null)
            {
                db.TaiKhoans.Remove(taiKhoan);
                db.SaveChanges();
            }
        }

        public IList TimTaiKhoan(string timKiem)
        {
            var qr = db.TaiKhoans
                .Where(t => t.TenDangNhap.Contains(timKiem) || t.MaNhanSu.Contains(timKiem))
                .Select(t => new
                {
                    TenDangNhap = t.TenDangNhap,
                    MatKhau = t.MatKhau,
                    PhanQuyen = t.PhanQuyen,
                    MaNhanSu = t.MaNhanSu
                })
                .ToList();
            return qr;
        }

        public bool KiemTraPhanQuyen(string MaNhanSu,string PhanQuyen)
        {
            bool kiemTra = false;
            var PQ = db.NhanSus.FirstOrDefault(s => s.MaNhanSu == MaNhanSu);
            if( PhanQuyen==PQ.ChucVu)
            {
                kiemTra = true;

            }
            else
            {
                kiemTra = false;
            }
            return kiemTra;
        }




        public TaiKhoan LayTaiKhoan(string tendangnhap)
        {
            return db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tendangnhap);
        }
        public bool KiemTraTenDangNhap(string tenDangNhap)
        {
            // Query the database to see if a record with the given username already exists
            var taiKhoan = db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tenDangNhap);
            return taiKhoan != null;
        }

        public bool KiemTraMaNhanSu(string maNhanSu)
        {
            // Query the employee table to see if a record with the given employee code already exists
            var nhanSu = db.NhanSus.FirstOrDefault(n => n.MaNhanSu == maNhanSu);
            return nhanSu != null;
        }
        public DataTable LayDsTkData()
        {
            using (var context = new QuanLyKhachSanEntities())
            {
                var data = from tk in context.TaiKhoans
                           select new
                           {
                               tk.TenDangNhap,
                               tk.MatKhau,
                               tk.PhanQuyen,
                               tk.MaNhanSu
                           };

                // Convert the query result to a DataTable
                var dataTable = new DataTable();
                dataTable.Columns.Add("TenDangNhap");
                dataTable.Columns.Add("MatKhau");
dataTable.Columns.Add("MaNhanSu");
                dataTable.Columns.Add("PhanQuyen");
                

                foreach (var item in data)
                {
                    var row = dataTable.NewRow();
                    row["TenDangNhap"] = item.TenDangNhap;
                    row["MatKhau"] = item.MatKhau;
row["MaNhanSu"] = item.MaNhanSu;
                    row["PhanQuyen"] = item.PhanQuyen;
                    
                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
        }
        public void CapNhatDsTk(DataTable dataTable)
        {
            using (var context = new QuanLyKhachSanEntities())
            {
                // Loop through the rows of the DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    // Get the values from the row
                    string tenDangNhap = row["TenDangNhap"].ToString();
                    string matKhau = row["MatKhau"].ToString();
                    string maNhanSu = row["MaNhanSu"].ToString();

                    // Get the employee record from the database
                    var nhanSu = context.NhanSus.FirstOrDefault(n => n.MaNhanSu == maNhanSu);
                    if (nhanSu == null)
                    {
                        MessageBox.Show("Mã nhân sự không tồn tại: " + maNhanSu);
                        return;
                    }

                    // Get the role from the employee record
                    string phanQuyen = nhanSu.ChucVu;

                    // Check if the user account already exists in the database
                    var taiKhoan = context.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tenDangNhap);
                    if (taiKhoan != null)
                    {
                        // Update the existing user account
                        taiKhoan.MatKhau = matKhau;
                        taiKhoan.PhanQuyen = phanQuyen;
                        taiKhoan.MaNhanSu = maNhanSu;
                    }
                    else
                    {
                        // Add a new user account
                        taiKhoan = new TaiKhoan
                        {
                            TenDangNhap = tenDangNhap,
                            MatKhau = matKhau,
                            PhanQuyen = phanQuyen,
                            MaNhanSu = maNhanSu
                        };
                        context.TaiKhoans.Add(taiKhoan);
                    }
                }

                // Save changes to the database
                context.SaveChanges();
                MessageBox.Show("Lưu thông tin thành công");
            }
        }
        public List<TaiKhoan> LayDsTk_Data()
        {
            return db.TaiKhoans.ToList();
        }

        public void ThemTaiKhoan_Data(TaiKhoan taiKhoan)
        {
            db.TaiKhoans.Add(taiKhoan);
            db.SaveChanges();
        }
        public string LayPhanQuyen(string maNhanSu)
        {
            // Get the NhanSu record from the database
            var nhanSu = db.NhanSus.FirstOrDefault(n => n.MaNhanSu == maNhanSu);
            if (nhanSu == null)
                return null;

            // Get the PhanQuyen value from the NhanSu record
            string phanQuyen = nhanSu.ChucVu;

            return phanQuyen;
        }


    }
}
