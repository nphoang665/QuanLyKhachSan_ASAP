namespace QuanLyKhachSan
{
    partial class frm_HoaDon
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
            this.tabControl_HoaDon = new System.Windows.Forms.TabControl();
            this.tabPage_HoaDon = new System.Windows.Forms.TabPage();
            this.lbl_KQTienDichVu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_KQSDT = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_kqMaPhong = new System.Windows.Forms.Label();
            this.lbl_kqCCCD = new System.Windows.Forms.Label();
            this.lbl_kqmahd = new System.Windows.Forms.Label();
            this.lbl_kqTenKhachHang = new System.Windows.Forms.Label();
            this.lbl_mahoadon = new System.Windows.Forms.Label();
            this.lbl_KQNgayTra = new System.Windows.Forms.Label();
            this.lbl_KQNgayThue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_DanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_tenkhachhang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_thanhtoan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl_HoaDon.SuspendLayout();
            this.tabPage_HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_HoaDon
            // 
            this.tabControl_HoaDon.Controls.Add(this.tabPage_HoaDon);
            this.tabControl_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_HoaDon.Location = new System.Drawing.Point(0, 0);
            this.tabControl_HoaDon.Name = "tabControl_HoaDon";
            this.tabControl_HoaDon.SelectedIndex = 0;
            this.tabControl_HoaDon.Size = new System.Drawing.Size(1114, 511);
            this.tabControl_HoaDon.TabIndex = 1;
            // 
            // tabPage_HoaDon
            // 
            this.tabPage_HoaDon.BackColor = System.Drawing.Color.White;
            this.tabPage_HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_HoaDon.Controls.Add(this.groupBox1);
            this.tabPage_HoaDon.Controls.Add(this.label2);
            this.tabPage_HoaDon.Controls.Add(this.lbl_KQTienDichVu);
            this.tabPage_HoaDon.Controls.Add(this.label3);
            this.tabPage_HoaDon.Controls.Add(this.lbl_KQSDT);
            this.tabPage_HoaDon.Controls.Add(this.lbl_SDT);
            this.tabPage_HoaDon.Controls.Add(this.lbl_kqMaPhong);
            this.tabPage_HoaDon.Controls.Add(this.lbl_kqCCCD);
            this.tabPage_HoaDon.Controls.Add(this.lbl_kqmahd);
            this.tabPage_HoaDon.Controls.Add(this.lbl_kqTenKhachHang);
            this.tabPage_HoaDon.Controls.Add(this.lbl_mahoadon);
            this.tabPage_HoaDon.Controls.Add(this.lbl_KQNgayTra);
            this.tabPage_HoaDon.Controls.Add(this.lbl_KQNgayThue);
            this.tabPage_HoaDon.Controls.Add(this.label6);
            this.tabPage_HoaDon.Controls.Add(this.label8);
            this.tabPage_HoaDon.Controls.Add(this.label4);
            this.tabPage_HoaDon.Controls.Add(this.label5);
            this.tabPage_HoaDon.Controls.Add(this.dgv_DanhSachHoaDon);
            this.tabPage_HoaDon.Controls.Add(this.lbl_tenkhachhang);
            this.tabPage_HoaDon.Controls.Add(this.label1);
            this.tabPage_HoaDon.Location = new System.Drawing.Point(4, 26);
            this.tabPage_HoaDon.Name = "tabPage_HoaDon";
            this.tabPage_HoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HoaDon.Size = new System.Drawing.Size(1106, 481);
            this.tabPage_HoaDon.TabIndex = 0;
            this.tabPage_HoaDon.Text = "Hóa đơn";
            this.tabPage_HoaDon.Click += new System.EventHandler(this.tabPage_HoaDon_Click);
            // 
            // lbl_KQTienDichVu
            // 
            this.lbl_KQTienDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQTienDichVu.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQTienDichVu.Location = new System.Drawing.Point(656, 167);
            this.lbl_KQTienDichVu.Name = "lbl_KQTienDichVu";
            this.lbl_KQTienDichVu.Size = new System.Drawing.Size(197, 22);
            this.lbl_KQTienDichVu.TabIndex = 27;
            this.lbl_KQTienDichVu.Text = "---";
            this.lbl_KQTienDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tiền Dịch Vụ:";
            // 
            // lbl_KQSDT
            // 
            this.lbl_KQSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQSDT.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQSDT.Location = new System.Drawing.Point(229, 167);
            this.lbl_KQSDT.Name = "lbl_KQSDT";
            this.lbl_KQSDT.Size = new System.Drawing.Size(197, 22);
            this.lbl_KQSDT.TabIndex = 25;
            this.lbl_KQSDT.Text = "---";
            this.lbl_KQSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(72, 169);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(109, 20);
            this.lbl_SDT.TabIndex = 24;
            this.lbl_SDT.Text = "Số Điện Thoại:";
            // 
            // lbl_kqMaPhong
            // 
            this.lbl_kqMaPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kqMaPhong.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kqMaPhong.Location = new System.Drawing.Point(656, 51);
            this.lbl_kqMaPhong.Name = "lbl_kqMaPhong";
            this.lbl_kqMaPhong.Size = new System.Drawing.Size(197, 22);
            this.lbl_kqMaPhong.TabIndex = 23;
            this.lbl_kqMaPhong.Text = "---";
            this.lbl_kqMaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_kqCCCD
            // 
            this.lbl_kqCCCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kqCCCD.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kqCCCD.Location = new System.Drawing.Point(229, 127);
            this.lbl_kqCCCD.Name = "lbl_kqCCCD";
            this.lbl_kqCCCD.Size = new System.Drawing.Size(197, 22);
            this.lbl_kqCCCD.TabIndex = 21;
            this.lbl_kqCCCD.Text = "---";
            this.lbl_kqCCCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_kqmahd
            // 
            this.lbl_kqmahd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kqmahd.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kqmahd.Location = new System.Drawing.Point(231, 49);
            this.lbl_kqmahd.Name = "lbl_kqmahd";
            this.lbl_kqmahd.Size = new System.Drawing.Size(197, 22);
            this.lbl_kqmahd.TabIndex = 19;
            this.lbl_kqmahd.Text = "---";
            this.lbl_kqmahd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_kqTenKhachHang
            // 
            this.lbl_kqTenKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kqTenKhachHang.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kqTenKhachHang.Location = new System.Drawing.Point(231, 85);
            this.lbl_kqTenKhachHang.Name = "lbl_kqTenKhachHang";
            this.lbl_kqTenKhachHang.Size = new System.Drawing.Size(197, 22);
            this.lbl_kqTenKhachHang.TabIndex = 18;
            this.lbl_kqTenKhachHang.Text = "---";
            this.lbl_kqTenKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mahoadon
            // 
            this.lbl_mahoadon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_mahoadon.AutoSize = true;
            this.lbl_mahoadon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mahoadon.Location = new System.Drawing.Point(72, 51);
            this.lbl_mahoadon.Name = "lbl_mahoadon";
            this.lbl_mahoadon.Size = new System.Drawing.Size(100, 20);
            this.lbl_mahoadon.TabIndex = 17;
            this.lbl_mahoadon.Text = "Mã Hoá Đơn:";
            // 
            // lbl_KQNgayTra
            // 
            this.lbl_KQNgayTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQNgayTra.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQNgayTra.Location = new System.Drawing.Point(656, 124);
            this.lbl_KQNgayTra.Name = "lbl_KQNgayTra";
            this.lbl_KQNgayTra.Size = new System.Drawing.Size(197, 22);
            this.lbl_KQNgayTra.TabIndex = 14;
            this.lbl_KQNgayTra.Text = "---";
            this.lbl_KQNgayTra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KQNgayThue
            // 
            this.lbl_KQNgayThue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQNgayThue.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQNgayThue.Location = new System.Drawing.Point(656, 87);
            this.lbl_KQNgayThue.Name = "lbl_KQNgayThue";
            this.lbl_KQNgayThue.Size = new System.Drawing.Size(197, 22);
            this.lbl_KQNgayThue.TabIndex = 12;
            this.lbl_KQNgayThue.Text = "---";
            this.lbl_KQNgayThue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "CMND/CCCD:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(513, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ngày Trả:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày Thuê:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã Phòng:";
            // 
            // dgv_DanhSachHoaDon
            // 
            this.dgv_DanhSachHoaDon.AllowUserToAddRows = false;
            this.dgv_DanhSachHoaDon.AllowUserToDeleteRows = false;
            this.dgv_DanhSachHoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.TenKhachHang,
            this.CMND,
            this.SoDienThoai,
            this.MaPhong,
            this.NgayThue,
            this.NgayTra,
            this.TongTienDichVu,
            this.TongTienThanhToan});
            this.dgv_DanhSachHoaDon.Location = new System.Drawing.Point(7, 207);
            this.dgv_DanhSachHoaDon.Name = "dgv_DanhSachHoaDon";
            this.dgv_DanhSachHoaDon.ReadOnly = true;
            this.dgv_DanhSachHoaDon.Size = new System.Drawing.Size(1090, 252);
            this.dgv_DanhSachHoaDon.TabIndex = 16;
            this.dgv_DanhSachHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachHoaDon_CellClick);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND/CCCD";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // NgayThue
            // 
            this.NgayThue.HeaderText = "Ngày Thuê";
            this.NgayThue.Name = "NgayThue";
            this.NgayThue.ReadOnly = true;
            // 
            // NgayTra
            // 
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // TongTienDichVu
            // 
            this.TongTienDichVu.HeaderText = "Tiền Dịch Vụ";
            this.TongTienDichVu.Name = "TongTienDichVu";
            this.TongTienDichVu.ReadOnly = true;
            // 
            // TongTienThanhToan
            // 
            this.TongTienThanhToan.HeaderText = "Thanh Toán";
            this.TongTienThanhToan.Name = "TongTienThanhToan";
            this.TongTienThanhToan.ReadOnly = true;
            // 
            // lbl_tenkhachhang
            // 
            this.lbl_tenkhachhang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tenkhachhang.AutoSize = true;
            this.lbl_tenkhachhang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenkhachhang.Location = new System.Drawing.Point(74, 87);
            this.lbl_tenkhachhang.Name = "lbl_tenkhachhang";
            this.lbl_tenkhachhang.Size = new System.Drawing.Size(126, 20);
            this.lbl_tenkhachhang.TabIndex = 7;
            this.lbl_tenkhachhang.Text = "Tên Khách Hàng:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN:";
            // 
            // lbl_thanhtoan
            // 
            this.lbl_thanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_thanhtoan.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thanhtoan.Location = new System.Drawing.Point(26, 80);
            this.lbl_thanhtoan.Name = "lbl_thanhtoan";
            this.lbl_thanhtoan.Size = new System.Drawing.Size(197, 22);
            this.lbl_thanhtoan.TabIndex = 31;
            this.lbl_thanhtoan.Text = "---";
            this.lbl_thanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Thanh Toán";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_thanhtoan);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(836, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 138);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1017, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "---";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 511);
            this.Controls.Add(this.tabControl_HoaDon);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_HoaDon";
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.tabControl_HoaDon.ResumeLayout(false);
            this.tabPage_HoaDon.ResumeLayout(false);
            this.tabPage_HoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_HoaDon;
        private System.Windows.Forms.TabPage tabPage_HoaDon;
        private System.Windows.Forms.Label lbl_KQNgayTra;
        private System.Windows.Forms.Label lbl_KQNgayThue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_DanhSachHoaDon;
        private System.Windows.Forms.Label lbl_tenkhachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_mahoadon;
        private System.Windows.Forms.Label lbl_kqMaPhong;
        private System.Windows.Forms.Label lbl_kqCCCD;
        private System.Windows.Forms.Label lbl_kqmahd;
        private System.Windows.Forms.Label lbl_kqTenKhachHang;
        private System.Windows.Forms.Label lbl_KQSDT;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienThanhToan;
        private System.Windows.Forms.Label lbl_KQTienDichVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_thanhtoan;
        private System.Windows.Forms.Label label2;
    }
}