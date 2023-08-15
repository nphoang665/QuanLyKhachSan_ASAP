using QuanLyKhachSan.DA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    public class BUS_QuanLyTaiKhoan
    {
        DA_QuanLyTaiKhoan DA_;
        public BUS_QuanLyTaiKhoan()
        {
            DA_ = new DA_QuanLyTaiKhoan();
        }
        public void LoadDsTk(DataGridView dgv)
        {
            dgv.DataSource = DA_.LayDsTk();
        }
        public void ThemTaiKhoan(string tenDangNhap, string matKhau, string phanQuyen, string maNhanSu)
        {
            DA_.ThemTaiKhoan(tenDangNhap, matKhau, phanQuyen, maNhanSu);
        }

        public void SuaTaiKhoan(string tenDangNhap, string matKhau, string phanQuyen, string maNhanSu)
        {
            DA_.SuaTaiKhoan(tenDangNhap, matKhau, phanQuyen, maNhanSu);
        }

        public void XoaTaiKhoan(string id)
        {
            DA_.XoaTaiKhoan(id);
        }

        public IList TimTaiKhoan(string timKiem)
        {
            return DA_.TimTaiKhoan(timKiem);
        }

        public TaiKhoan LayTaiKhoan(string id)
        {
            return DA_.LayTaiKhoan(id);
        }
        public bool KiemTraPhanQuyen(string MaNhanSu, string PhanQuyen)
        {
            return DA_.KiemTraPhanQuyen(MaNhanSu, PhanQuyen);
        }
        public bool KiemTraTenDangNhap(string tenDangNhap)
        {
            return DA_.KiemTraTenDangNhap(tenDangNhap);
        }

        public bool KiemTraMaNhanSu(string maNhanSu)
        {
            return DA_.KiemTraMaNhanSu(maNhanSu);
        }
        public DataTable LoadDsTkData()
        {
            return DA_.LayDsTkData();
        }
        public void CapNhatDsTk(DataTable dataTable)
        {
            DA_.CapNhatDsTk(dataTable);
        }
        public void LoadDsTk_Data(DataGridView dgv)
        {
            dgv.DataSource = DA_.LayDsTk_Data();
        }

        public void ThemTaiKhoan_Data(string tenDangNhap, string matKhau, string phanQuyen, string maNhanSu)
        {
            TaiKhoan taiKhoan = new TaiKhoan
            {
                TenDangNhap = tenDangNhap,
                MatKhau = matKhau,
                PhanQuyen = phanQuyen,
                MaNhanSu = maNhanSu
            };
            DA_.ThemTaiKhoan_Data(taiKhoan);
            MessageBox.Show(taiKhoan.ToString());
        }
        public string LayPhanQuyen(string mns)
        {
            return DA_.LayPhanQuyen(mns);
        }
        string tk;
        public void SaveData(DataGridView dataGridView)
        {
            bool frag = true;
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            HashSet<string> tenDangNhapSet = new HashSet<string>();
            bool hasDuplicateTenDangNhap = false;
            bool maNhanSuNotExists = false;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string tenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
                    string matKhau = row.Cells["MatKhau"].Value.ToString();
                    string phanQuyen = row.Cells["PhanQuyen"].Value.ToString();
                    string maNhanSu = row.Cells["MaNhanSu"].Value.ToString();
                    tk = tenDangNhap;
                    if (tenDangNhap == "")
                    {
                        MessageBox.Show("Bạn chưa nhập dữ liệu ở dòng: " + (row.Index + 1) + ", cột: TenDangNhap", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frag = false;
                        break;
                    }
                    if (matKhau == "")
                    {
                        MessageBox.Show("Bạn chưa nhập dữ liệu ở dòng: " + (row.Index + 1) + ", cột: MatKhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frag = false;
                        break;
                    }
                    if (tenDangNhap.Length < 5 || tenDangNhap.Length > 20)
                    {
                        MessageBox.Show("Tên đăng nhập phải có độ dài từ 5 đến 20 ký tự! Dòng: " + (row.Index + 1) + ", cột: TenDangNhap", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frag = false;
                        break;
                    }
                    if (matKhau.Length < 5 || matKhau.Length > 20)
                    {
                        MessageBox.Show("Mật khẩu phải có độ dài từ 5 đến 20 ký tự! Dòng: " + (row.Index + 1) + ", cột: MatKhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frag = false;
                        break;
                    }
                    if (maNhanSu == "")
                    {
                        MessageBox.Show("Bạn chưa nhập dữ liệu ở dòng: " + (row.Index + 1) + ", cột: MaNhanSu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frag = false;
                        break;
                    }

                    if (!tenDangNhapSet.Add(tenDangNhap))
                    {
                        hasDuplicateTenDangNhap = true;
                        frag = false;
                        break;
                    }

                    if (!DA_.CheckMaNhanSu(maNhanSu))
                    {
                        maNhanSuNotExists = true;
                        frag = false;
                        break;
                    }

                    TaiKhoan taiKhoan = new TaiKhoan
                    {
                        TenDangNhap = tenDangNhap,
                        MatKhau = matKhau,
                        PhanQuyen = phanQuyen,
                        MaNhanSu = maNhanSu,
                        TinhTrang = "ThanhCong"
                    };
                    taiKhoans.Add(taiKhoan);
                }
            }

            try
            {
                if (hasDuplicateTenDangNhap)
                {
                    throw new Exception("Hệ thông đã tồn tại tài khoản này: " + tk);
                }
                else if (maNhanSuNotExists)
                {
                    throw new Exception("Mã nhân sự không tồn tại");
                }
                else if (frag == true && taiKhoans.Count > 0)
                {
                    DA_.SaveData(taiKhoans);
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }





        public bool checkmanhansu(string Manhansu)
        {
            return DA_.CheckMaNhanSu(Manhansu);

        }
        public bool checktendangnhap(string TenDangNhap)
        {
            return DA_.CheckTenDangNhap(TenDangNhap);

        }
    }
}
