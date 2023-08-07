namespace QuanLyKhachSan
{
    partial class frm_ThongTinTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grp_thongtintaikhoan = new System.Windows.Forms.GroupBox();
            this.lbl_TenDangNhap = new System.Windows.Forms.Label();
            this.lbl_TenNhanVien = new System.Windows.Forms.Label();
            this.lbl_ChucVu = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.txt_ChucVu = new System.Windows.Forms.TextBox();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.lbl_ngayvaolam = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_gioitinh = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.dtp_NgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_cmnd = new System.Windows.Forms.Label();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.grp_thongtintaikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Tài Khoản";
            // 
            // grp_thongtintaikhoan
            // 
            this.grp_thongtintaikhoan.Controls.Add(this.txt_ChucVu);
            this.grp_thongtintaikhoan.Controls.Add(this.txt_TenNhanVien);
            this.grp_thongtintaikhoan.Controls.Add(this.txt_TenDangNhap);
            this.grp_thongtintaikhoan.Controls.Add(this.lbl_ChucVu);
            this.grp_thongtintaikhoan.Controls.Add(this.lbl_TenNhanVien);
            this.grp_thongtintaikhoan.Controls.Add(this.lbl_TenDangNhap);
            this.grp_thongtintaikhoan.Location = new System.Drawing.Point(421, 24);
            this.grp_thongtintaikhoan.Name = "grp_thongtintaikhoan";
            this.grp_thongtintaikhoan.Size = new System.Drawing.Size(367, 240);
            this.grp_thongtintaikhoan.TabIndex = 1;
            this.grp_thongtintaikhoan.TabStop = false;
            this.grp_thongtintaikhoan.Text = "Thông tin tài khoản";
            // 
            // lbl_TenDangNhap
            // 
            this.lbl_TenDangNhap.AutoSize = true;
            this.lbl_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDangNhap.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(36, 25);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(116, 20);
            this.lbl_TenDangNhap.TabIndex = 0;
            this.lbl_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // lbl_TenNhanVien
            // 
            this.lbl_TenNhanVien.AutoSize = true;
            this.lbl_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TenNhanVien.Location = new System.Drawing.Point(36, 95);
            this.lbl_TenNhanVien.Name = "lbl_TenNhanVien";
            this.lbl_TenNhanVien.Size = new System.Drawing.Size(108, 20);
            this.lbl_TenNhanVien.TabIndex = 2;
            this.lbl_TenNhanVien.Text = "Tên nhân viên";
            // 
            // lbl_ChucVu
            // 
            this.lbl_ChucVu.AutoSize = true;
            this.lbl_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChucVu.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ChucVu.Location = new System.Drawing.Point(36, 168);
            this.lbl_ChucVu.Name = "lbl_ChucVu";
            this.lbl_ChucVu.Size = new System.Drawing.Size(66, 20);
            this.lbl_ChucVu.TabIndex = 3;
            this.lbl_ChucVu.Text = "Chức vụ";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Enabled = false;
            this.txt_TenDangNhap.Location = new System.Drawing.Point(37, 59);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(186, 20);
            this.txt_TenDangNhap.TabIndex = 4;
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.Enabled = false;
            this.txt_TenNhanVien.Location = new System.Drawing.Point(37, 126);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(189, 20);
            this.txt_TenNhanVien.TabIndex = 5;
            // 
            // txt_ChucVu
            // 
            this.txt_ChucVu.Enabled = false;
            this.txt_ChucVu.Location = new System.Drawing.Point(37, 204);
            this.txt_ChucVu.Name = "txt_ChucVu";
            this.txt_ChucVu.Size = new System.Drawing.Size(186, 20);
            this.txt_ChucVu.TabIndex = 6;
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioitinh.Location = new System.Drawing.Point(298, 273);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(67, 20);
            this.lbl_gioitinh.TabIndex = 4;
            this.lbl_gioitinh.Text = "Giới tính";
            // 
            // lbl_ngayvaolam
            // 
            this.lbl_ngayvaolam.AutoSize = true;
            this.lbl_ngayvaolam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngayvaolam.Location = new System.Drawing.Point(575, 273);
            this.lbl_ngayvaolam.Name = "lbl_ngayvaolam";
            this.lbl_ngayvaolam.Size = new System.Drawing.Size(107, 20);
            this.lbl_ngayvaolam.TabIndex = 5;
            this.lbl_ngayvaolam.Text = "Ngày vào làm:";
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(39, 331);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(102, 20);
            this.lbl_SoDienThoai.TabIndex = 6;
            this.lbl_SoDienThoai.Text = "Số điện thoại";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(299, 331);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(57, 20);
            this.lbl_DiaChi.TabIndex = 7;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(576, 331);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(82, 20);
            this.lbl_NgaySinh.TabIndex = 8;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.male_information1;
            this.pictureBox1.Location = new System.Drawing.Point(123, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.Enabled = false;
            this.txt_gioitinh.Location = new System.Drawing.Point(302, 296);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(186, 20);
            this.txt_gioitinh.TabIndex = 11;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Enabled = false;
            this.txt_sdt.Location = new System.Drawing.Point(43, 364);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(186, 20);
            this.txt_sdt.TabIndex = 13;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Enabled = false;
            this.txt_diaChi.Location = new System.Drawing.Point(303, 364);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(186, 20);
            this.txt_diaChi.TabIndex = 14;
            // 
            // dtp_NgayVaoLam
            // 
            this.dtp_NgayVaoLam.Enabled = false;
            this.dtp_NgayVaoLam.Location = new System.Drawing.Point(579, 296);
            this.dtp_NgayVaoLam.Name = "dtp_NgayVaoLam";
            this.dtp_NgayVaoLam.Size = new System.Drawing.Size(200, 20);
            this.dtp_NgayVaoLam.TabIndex = 15;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Enabled = false;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(580, 364);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtp_NgaySinh.TabIndex = 16;
            // 
            // lbl_cmnd
            // 
            this.lbl_cmnd.AutoSize = true;
            this.lbl_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cmnd.Location = new System.Drawing.Point(39, 273);
            this.lbl_cmnd.Name = "lbl_cmnd";
            this.lbl_cmnd.Size = new System.Drawing.Size(56, 20);
            this.lbl_cmnd.TabIndex = 3;
            this.lbl_cmnd.Text = "CMND";
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Enabled = false;
            this.txt_cmnd.Location = new System.Drawing.Point(42, 296);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(186, 20);
            this.txt_cmnd.TabIndex = 10;
            // 
            // frm_ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 410);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.dtp_NgayVaoLam);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_gioitinh);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_NgaySinh);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_SoDienThoai);
            this.Controls.Add(this.lbl_ngayvaolam);
            this.Controls.Add(this.lbl_gioitinh);
            this.Controls.Add(this.lbl_cmnd);
            this.Controls.Add(this.grp_thongtintaikhoan);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ThongTinTaiKhoan";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.frm_ThongTinTaiKhoan_Load);
            this.grp_thongtintaikhoan.ResumeLayout(false);
            this.grp_thongtintaikhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_thongtintaikhoan;
        private System.Windows.Forms.TextBox txt_ChucVu;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label lbl_ChucVu;
        private System.Windows.Forms.Label lbl_TenNhanVien;
        private System.Windows.Forms.Label lbl_TenDangNhap;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.Label lbl_ngayvaolam;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_gioitinh;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.DateTimePicker dtp_NgayVaoLam;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label lbl_cmnd;
        private System.Windows.Forms.TextBox txt_cmnd;
    }
}