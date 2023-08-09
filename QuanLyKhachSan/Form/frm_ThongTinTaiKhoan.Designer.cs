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
            this.lbl_ChucVu = new System.Windows.Forms.Label();
            this.lbl_TenNhanVien = new System.Windows.Forms.Label();
            this.lbl_TenDangNhap = new System.Windows.Forms.Label();
            this.lbl_gioitinh = new System.Windows.Forms.Label();
            this.lbl_ngayvaolam = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_cmnd = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_mo = new System.Windows.Forms.Button();
            this.btn_KhoiPhucAvt = new System.Windows.Forms.Button();
            this.btn_XoaAvt = new System.Windows.Forms.Button();
            this.txt_NgaySinh = new CustormTextbox.RJConTrol.RJTextBox();
            this.txt_NgayVaoLam = new CustormTextbox.RJConTrol.RJTextBox();
            this.txt_diaChi = new CustormTextbox.RJConTrol.RJTextBox();
            this.txt_sdt = new CustormTextbox.RJConTrol.RJTextBox();
            this.txt_gioitinh = new CustormTextbox.RJConTrol.RJTextBox();
            this.txt_cmnd = new CustormTextbox.RJConTrol.RJTextBox();
            this.txt_ChucVu = new CustormTextbox.RJConTrol.RJTextBox();
            this.txt_TenNhanVien = new CustormTextbox.RJConTrol.RJTextBox();
            this.txt_TenDangNhap = new CustormTextbox.RJConTrol.RJTextBox();
            this.grp_thongtintaikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.grp_thongtintaikhoan.Location = new System.Drawing.Point(561, 32);
            this.grp_thongtintaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.grp_thongtintaikhoan.Name = "grp_thongtintaikhoan";
            this.grp_thongtintaikhoan.Padding = new System.Windows.Forms.Padding(4);
            this.grp_thongtintaikhoan.Size = new System.Drawing.Size(489, 313);
            this.grp_thongtintaikhoan.TabIndex = 1;
            this.grp_thongtintaikhoan.TabStop = false;
            this.grp_thongtintaikhoan.Text = "Thông tin tài khoản";
            // 
            // lbl_ChucVu
            // 
            this.lbl_ChucVu.AutoSize = true;
            this.lbl_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_ChucVu.Location = new System.Drawing.Point(48, 220);
            this.lbl_ChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ChucVu.Name = "lbl_ChucVu";
            this.lbl_ChucVu.Size = new System.Drawing.Size(85, 25);
            this.lbl_ChucVu.TabIndex = 3;
            this.lbl_ChucVu.Text = "Chức vụ";
            // 
            // lbl_TenNhanVien
            // 
            this.lbl_TenNhanVien.AutoSize = true;
            this.lbl_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_TenNhanVien.Location = new System.Drawing.Point(48, 124);
            this.lbl_TenNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenNhanVien.Name = "lbl_TenNhanVien";
            this.lbl_TenNhanVien.Size = new System.Drawing.Size(137, 25);
            this.lbl_TenNhanVien.TabIndex = 2;
            this.lbl_TenNhanVien.Text = "Tên nhân viên";
            // 
            // lbl_TenDangNhap
            // 
            this.lbl_TenDangNhap.AutoSize = true;
            this.lbl_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(48, 33);
            this.lbl_TenDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(145, 25);
            this.lbl_TenDangNhap.TabIndex = 0;
            this.lbl_TenDangNhap.Text = "Tên đăng nhập";
            // 
            // lbl_gioitinh
            // 
            this.lbl_gioitinh.AutoSize = true;
            this.lbl_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gioitinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_gioitinh.Location = new System.Drawing.Point(397, 357);
            this.lbl_gioitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gioitinh.Name = "lbl_gioitinh";
            this.lbl_gioitinh.Size = new System.Drawing.Size(82, 25);
            this.lbl_gioitinh.TabIndex = 4;
            this.lbl_gioitinh.Text = "Giới tính";
            // 
            // lbl_ngayvaolam
            // 
            this.lbl_ngayvaolam.AutoSize = true;
            this.lbl_ngayvaolam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngayvaolam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_ngayvaolam.Location = new System.Drawing.Point(767, 357);
            this.lbl_ngayvaolam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ngayvaolam.Name = "lbl_ngayvaolam";
            this.lbl_ngayvaolam.Size = new System.Drawing.Size(137, 25);
            this.lbl_ngayvaolam.TabIndex = 5;
            this.lbl_ngayvaolam.Text = "Ngày vào làm:";
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(52, 432);
            this.lbl_SoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(126, 25);
            this.lbl_SoDienThoai.TabIndex = 6;
            this.lbl_SoDienThoai.Text = "Số điện thoại";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_DiaChi.Location = new System.Drawing.Point(399, 432);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(71, 25);
            this.lbl_DiaChi.TabIndex = 7;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(768, 432);
            this.lbl_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(105, 25);
            this.lbl_NgaySinh.TabIndex = 8;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.male_information1;
            this.pictureBox1.Location = new System.Drawing.Point(153, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_cmnd
            // 
            this.lbl_cmnd.AutoSize = true;
            this.lbl_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cmnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_cmnd.Location = new System.Drawing.Point(52, 357);
            this.lbl_cmnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cmnd.Name = "lbl_cmnd";
            this.lbl_cmnd.Size = new System.Drawing.Size(72, 25);
            this.lbl_cmnd.TabIndex = 3;
            this.lbl_cmnd.Text = "CMND";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_mo
            // 
            this.btn_mo.BackColor = System.Drawing.Color.Silver;
            this.btn_mo.Location = new System.Drawing.Point(70, 294);
            this.btn_mo.Name = "btn_mo";
            this.btn_mo.Size = new System.Drawing.Size(100, 51);
            this.btn_mo.TabIndex = 47;
            this.btn_mo.Text = "Đổi Avatar";
            this.btn_mo.UseVisualStyleBackColor = false;
            this.btn_mo.Click += new System.EventHandler(this.btn_mo_Click);
            // 
            // btn_KhoiPhucAvt
            // 
            this.btn_KhoiPhucAvt.BackColor = System.Drawing.Color.Silver;
            this.btn_KhoiPhucAvt.Location = new System.Drawing.Point(401, 294);
            this.btn_KhoiPhucAvt.Name = "btn_KhoiPhucAvt";
            this.btn_KhoiPhucAvt.Size = new System.Drawing.Size(99, 51);
            this.btn_KhoiPhucAvt.TabIndex = 48;
            this.btn_KhoiPhucAvt.Text = "Khôi phục Avatar";
            this.btn_KhoiPhucAvt.UseVisualStyleBackColor = false;
            this.btn_KhoiPhucAvt.Click += new System.EventHandler(this.btn_KhoiPhucAvt_Click);
            // 
            // btn_XoaAvt
            // 
            this.btn_XoaAvt.BackColor = System.Drawing.Color.Silver;
            this.btn_XoaAvt.Location = new System.Drawing.Point(233, 294);
            this.btn_XoaAvt.Name = "btn_XoaAvt";
            this.btn_XoaAvt.Size = new System.Drawing.Size(100, 51);
            this.btn_XoaAvt.TabIndex = 49;
            this.btn_XoaAvt.Text = "Xóa Avatar";
            this.btn_XoaAvt.UseVisualStyleBackColor = false;
            this.btn_XoaAvt.Click += new System.EventHandler(this.btn_XoaAvt_Click);
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.BackColor = System.Drawing.SystemColors.Control;
            this.txt_NgaySinh.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_NgaySinh.BorderFocusColor = System.Drawing.Color.Magenta;
            this.txt_NgaySinh.BorderSize = 2;
            this.txt_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgaySinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_NgaySinh.Location = new System.Drawing.Point(771, 454);
            this.txt_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NgaySinh.Multiline = false;
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_NgaySinh.PasswordChar = false;
            this.txt_NgaySinh.Size = new System.Drawing.Size(293, 43);
            this.txt_NgaySinh.TabIndex = 22;
            this.txt_NgaySinh.Texts = "";
            this.txt_NgaySinh.UnderLineStyle = true;
            // 
            // txt_NgayVaoLam
            // 
            this.txt_NgayVaoLam.BackColor = System.Drawing.SystemColors.Control;
            this.txt_NgayVaoLam.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_NgayVaoLam.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_NgayVaoLam.BorderSize = 2;
            this.txt_NgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NgayVaoLam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_NgayVaoLam.Location = new System.Drawing.Point(771, 380);
            this.txt_NgayVaoLam.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NgayVaoLam.Multiline = false;
            this.txt_NgayVaoLam.Name = "txt_NgayVaoLam";
            this.txt_NgayVaoLam.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_NgayVaoLam.PasswordChar = false;
            this.txt_NgayVaoLam.Size = new System.Drawing.Size(293, 43);
            this.txt_NgayVaoLam.TabIndex = 21;
            this.txt_NgayVaoLam.Texts = "";
            this.txt_NgayVaoLam.UnderLineStyle = true;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.BackColor = System.Drawing.SystemColors.Control;
            this.txt_diaChi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_diaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_diaChi.BorderSize = 2;
            this.txt_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_diaChi.Location = new System.Drawing.Point(401, 454);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diaChi.Multiline = false;
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_diaChi.PasswordChar = false;
            this.txt_diaChi.Size = new System.Drawing.Size(293, 43);
            this.txt_diaChi.TabIndex = 20;
            this.txt_diaChi.Texts = "";
            this.txt_diaChi.UnderLineStyle = true;
            this.txt_diaChi._TextChanged += new System.EventHandler(this.txt_diaChi__TextChanged);
            // 
            // txt_sdt
            // 
            this.txt_sdt.BackColor = System.Drawing.SystemColors.Control;
            this.txt_sdt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_sdt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_sdt.BorderSize = 2;
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_sdt.Location = new System.Drawing.Point(57, 454);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sdt.Multiline = false;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_sdt.PasswordChar = false;
            this.txt_sdt.Size = new System.Drawing.Size(296, 43);
            this.txt_sdt.TabIndex = 19;
            this.txt_sdt.Texts = "";
            this.txt_sdt.UnderLineStyle = true;
            this.txt_sdt._TextChanged += new System.EventHandler(this.txt_sdt__TextChanged);
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.BackColor = System.Drawing.SystemColors.Control;
            this.txt_gioitinh.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_gioitinh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_gioitinh.BorderSize = 2;
            this.txt_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioitinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_gioitinh.Location = new System.Drawing.Point(404, 380);
            this.txt_gioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gioitinh.Multiline = false;
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_gioitinh.PasswordChar = false;
            this.txt_gioitinh.Size = new System.Drawing.Size(293, 43);
            this.txt_gioitinh.TabIndex = 18;
            this.txt_gioitinh.Texts = "";
            this.txt_gioitinh.UnderLineStyle = true;
            this.txt_gioitinh._TextChanged += new System.EventHandler(this.txt_gioitinh__TextChanged);
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cmnd.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_cmnd.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_cmnd.BorderSize = 2;
            this.txt_cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_cmnd.Location = new System.Drawing.Point(57, 380);
            this.txt_cmnd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cmnd.Multiline = false;
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_cmnd.PasswordChar = false;
            this.txt_cmnd.Size = new System.Drawing.Size(296, 43);
            this.txt_cmnd.TabIndex = 17;
            this.txt_cmnd.Texts = "";
            this.txt_cmnd.UnderLineStyle = true;
            this.txt_cmnd._TextChanged += new System.EventHandler(this.txt_cmnd__TextChanged);
            // 
            // txt_ChucVu
            // 
            this.txt_ChucVu.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ChucVu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_ChucVu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_ChucVu.BorderSize = 2;
            this.txt_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChucVu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ChucVu.Location = new System.Drawing.Point(53, 244);
            this.txt_ChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ChucVu.Multiline = false;
            this.txt_ChucVu.Name = "txt_ChucVu";
            this.txt_ChucVu.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_ChucVu.PasswordChar = false;
            this.txt_ChucVu.Size = new System.Drawing.Size(333, 43);
            this.txt_ChucVu.TabIndex = 9;
            this.txt_ChucVu.Texts = "";
            this.txt_ChucVu.UnderLineStyle = true;
            this.txt_ChucVu._TextChanged += new System.EventHandler(this.txt_ChucVu__TextChanged);
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TenNhanVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_TenNhanVien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenNhanVien.BorderSize = 2;
            this.txt_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_TenNhanVien.Location = new System.Drawing.Point(53, 146);
            this.txt_TenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenNhanVien.Multiline = false;
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_TenNhanVien.PasswordChar = false;
            this.txt_TenNhanVien.Size = new System.Drawing.Size(333, 43);
            this.txt_TenNhanVien.TabIndex = 8;
            this.txt_TenNhanVien.Texts = "";
            this.txt_TenNhanVien.UnderLineStyle = true;
            this.txt_TenNhanVien._TextChanged += new System.EventHandler(this.txt_TenNhanVien__TextChanged);
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TenDangNhap.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_TenDangNhap.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenDangNhap.BorderSize = 2;
            this.txt_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_TenDangNhap.Location = new System.Drawing.Point(53, 60);
            this.txt_TenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenDangNhap.Multiline = false;
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_TenDangNhap.PasswordChar = false;
            this.txt_TenDangNhap.Size = new System.Drawing.Size(333, 43);
            this.txt_TenDangNhap.TabIndex = 7;
            this.txt_TenDangNhap.Texts = "";
            this.txt_TenDangNhap.UnderLineStyle = true;
            this.txt_TenDangNhap._TextChanged += new System.EventHandler(this.txt_TenDangNhap__TextChanged);
            // 
            // frm_ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1083, 537);
            this.Controls.Add(this.btn_XoaAvt);
            this.Controls.Add(this.btn_KhoiPhucAvt);
            this.Controls.Add(this.btn_mo);
            this.Controls.Add(this.txt_NgaySinh);
            this.Controls.Add(this.txt_NgayVaoLam);
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
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lbl_ChucVu;
        private System.Windows.Forms.Label lbl_TenNhanVien;
        private System.Windows.Forms.Label lbl_TenDangNhap;
        private System.Windows.Forms.Label lbl_gioitinh;
        private System.Windows.Forms.Label lbl_ngayvaolam;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_cmnd;
        private CustormTextbox.RJConTrol.RJTextBox txt_TenDangNhap;
        private CustormTextbox.RJConTrol.RJTextBox txt_TenNhanVien;
        private CustormTextbox.RJConTrol.RJTextBox txt_ChucVu;
        private CustormTextbox.RJConTrol.RJTextBox txt_cmnd;
        private CustormTextbox.RJConTrol.RJTextBox txt_gioitinh;
        private CustormTextbox.RJConTrol.RJTextBox txt_sdt;
        private CustormTextbox.RJConTrol.RJTextBox txt_diaChi;
        private CustormTextbox.RJConTrol.RJTextBox txt_NgayVaoLam;
        private CustormTextbox.RJConTrol.RJTextBox txt_NgaySinh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_mo;
        private System.Windows.Forms.Button btn_KhoiPhucAvt;
        private System.Windows.Forms.Button btn_XoaAvt;
    }
}