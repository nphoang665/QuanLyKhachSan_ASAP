namespace QuanLyKhachSan
{
    partial class frm_ThongTinPhong
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
            this.lbl_TongSoTienDichVu = new System.Windows.Forms.Label();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_Phong = new System.Windows.Forms.Label();
            this.lbl_TieuDeQLThuePhong = new System.Windows.Forms.Label();
            this.grp_DichVuDaThue = new System.Windows.Forms.GroupBox();
            this.lstv_DichVuDaSuDung = new System.Windows.Forms.ListView();
            this.grp_ThôngTinKhachHang = new System.Windows.Forms.GroupBox();
            this.lbl_KQDiaChi = new System.Windows.Forms.Label();
            this.lbl_KQCMND = new System.Windows.Forms.Label();
            this.lbl_KQTenKhachHang = new System.Windows.Forms.Label();
            this.dtp_NgayThue = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgayThue = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_TenKhachHang = new System.Windows.Forms.Label();
            this.lbl_CMND = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grp_DichVuDaThue.SuspendLayout();
            this.grp_ThôngTinKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TongSoTienDichVu
            // 
            this.lbl_TongSoTienDichVu.AutoSize = true;
            this.lbl_TongSoTienDichVu.BackColor = System.Drawing.Color.White;
            this.lbl_TongSoTienDichVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongSoTienDichVu.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TongSoTienDichVu.Location = new System.Drawing.Point(113, 559);
            this.lbl_TongSoTienDichVu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TongSoTienDichVu.Name = "lbl_TongSoTienDichVu";
            this.lbl_TongSoTienDichVu.Size = new System.Drawing.Size(19, 21);
            this.lbl_TongSoTienDichVu.TabIndex = 49;
            this.lbl_TongSoTienDichVu.Text = "...";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.BackColor = System.Drawing.Color.White;
            this.lbl_TongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TongTien.Location = new System.Drawing.Point(31, 559);
            this.lbl_TongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(78, 21);
            this.lbl_TongTien.TabIndex = 48;
            this.lbl_TongTien.Text = "Tổng tiền:";
            // 
            // lbl_Phong
            // 
            this.lbl_Phong.AutoSize = true;
            this.lbl_Phong.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phong.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Phong.Location = new System.Drawing.Point(424, 9);
            this.lbl_Phong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Phong.Name = "lbl_Phong";
            this.lbl_Phong.Size = new System.Drawing.Size(28, 30);
            this.lbl_Phong.TabIndex = 47;
            this.lbl_Phong.Text = "...";
            // 
            // lbl_TieuDeQLThuePhong
            // 
            this.lbl_TieuDeQLThuePhong.AutoSize = true;
            this.lbl_TieuDeQLThuePhong.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDeQLThuePhong.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TieuDeQLThuePhong.Location = new System.Drawing.Point(210, 9);
            this.lbl_TieuDeQLThuePhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TieuDeQLThuePhong.Name = "lbl_TieuDeQLThuePhong";
            this.lbl_TieuDeQLThuePhong.Size = new System.Drawing.Size(208, 30);
            this.lbl_TieuDeQLThuePhong.TabIndex = 46;
            this.lbl_TieuDeQLThuePhong.Text = "THÔNG TIN PHÒNG:";
            // 
            // grp_DichVuDaThue
            // 
            this.grp_DichVuDaThue.Controls.Add(this.lstv_DichVuDaSuDung);
            this.grp_DichVuDaThue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_DichVuDaThue.Location = new System.Drawing.Point(9, 216);
            this.grp_DichVuDaThue.Margin = new System.Windows.Forms.Padding(2);
            this.grp_DichVuDaThue.Name = "grp_DichVuDaThue";
            this.grp_DichVuDaThue.Padding = new System.Windows.Forms.Padding(2);
            this.grp_DichVuDaThue.Size = new System.Drawing.Size(650, 323);
            this.grp_DichVuDaThue.TabIndex = 45;
            this.grp_DichVuDaThue.TabStop = false;
            this.grp_DichVuDaThue.Text = "Dịch vụ đã sử dụng";
            // 
            // lstv_DichVuDaSuDung
            // 
            this.lstv_DichVuDaSuDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstv_DichVuDaSuDung.GridLines = true;
            this.lstv_DichVuDaSuDung.HideSelection = false;
            this.lstv_DichVuDaSuDung.Location = new System.Drawing.Point(2, 20);
            this.lstv_DichVuDaSuDung.Margin = new System.Windows.Forms.Padding(2);
            this.lstv_DichVuDaSuDung.Name = "lstv_DichVuDaSuDung";
            this.lstv_DichVuDaSuDung.Size = new System.Drawing.Size(646, 301);
            this.lstv_DichVuDaSuDung.TabIndex = 0;
            this.lstv_DichVuDaSuDung.UseCompatibleStateImageBehavior = false;
            // 
            // grp_ThôngTinKhachHang
            // 
            this.grp_ThôngTinKhachHang.Controls.Add(this.lbl_KQDiaChi);
            this.grp_ThôngTinKhachHang.Controls.Add(this.lbl_KQCMND);
            this.grp_ThôngTinKhachHang.Controls.Add(this.lbl_KQTenKhachHang);
            this.grp_ThôngTinKhachHang.Controls.Add(this.dtp_NgayThue);
            this.grp_ThôngTinKhachHang.Controls.Add(this.lbl_NgayThue);
            this.grp_ThôngTinKhachHang.Controls.Add(this.lbl_DiaChi);
            this.grp_ThôngTinKhachHang.Controls.Add(this.lbl_TenKhachHang);
            this.grp_ThôngTinKhachHang.Controls.Add(this.lbl_CMND);
            this.grp_ThôngTinKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThôngTinKhachHang.Location = new System.Drawing.Point(9, 63);
            this.grp_ThôngTinKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.grp_ThôngTinKhachHang.Name = "grp_ThôngTinKhachHang";
            this.grp_ThôngTinKhachHang.Padding = new System.Windows.Forms.Padding(2);
            this.grp_ThôngTinKhachHang.Size = new System.Drawing.Size(647, 147);
            this.grp_ThôngTinKhachHang.TabIndex = 44;
            this.grp_ThôngTinKhachHang.TabStop = false;
            this.grp_ThôngTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // lbl_KQDiaChi
            // 
            this.lbl_KQDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQDiaChi.Location = new System.Drawing.Point(287, 82);
            this.lbl_KQDiaChi.Name = "lbl_KQDiaChi";
            this.lbl_KQDiaChi.Size = new System.Drawing.Size(192, 25);
            this.lbl_KQDiaChi.TabIndex = 37;
            this.lbl_KQDiaChi.Text = "---";
            this.lbl_KQDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KQCMND
            // 
            this.lbl_KQCMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQCMND.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQCMND.Location = new System.Drawing.Point(286, 52);
            this.lbl_KQCMND.Name = "lbl_KQCMND";
            this.lbl_KQCMND.Size = new System.Drawing.Size(192, 25);
            this.lbl_KQCMND.TabIndex = 36;
            this.lbl_KQCMND.Text = "---";
            this.lbl_KQCMND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KQTenKhachHang
            // 
            this.lbl_KQTenKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQTenKhachHang.Location = new System.Drawing.Point(286, 22);
            this.lbl_KQTenKhachHang.Name = "lbl_KQTenKhachHang";
            this.lbl_KQTenKhachHang.Size = new System.Drawing.Size(192, 25);
            this.lbl_KQTenKhachHang.TabIndex = 35;
            this.lbl_KQTenKhachHang.Text = "---";
            this.lbl_KQTenKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_NgayThue
            // 
            this.dtp_NgayThue.Location = new System.Drawing.Point(286, 112);
            this.dtp_NgayThue.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayThue.Name = "dtp_NgayThue";
            this.dtp_NgayThue.Size = new System.Drawing.Size(192, 25);
            this.dtp_NgayThue.TabIndex = 34;
            // 
            // lbl_NgayThue
            // 
            this.lbl_NgayThue.AutoSize = true;
            this.lbl_NgayThue.BackColor = System.Drawing.Color.White;
            this.lbl_NgayThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayThue.ForeColor = System.Drawing.Color.Blue;
            this.lbl_NgayThue.Location = new System.Drawing.Point(170, 114);
            this.lbl_NgayThue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NgayThue.Name = "lbl_NgayThue";
            this.lbl_NgayThue.Size = new System.Drawing.Size(85, 21);
            this.lbl_NgayThue.TabIndex = 33;
            this.lbl_NgayThue.Text = "Ngày thuê:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.BackColor = System.Drawing.Color.White;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.ForeColor = System.Drawing.Color.Blue;
            this.lbl_DiaChi.Location = new System.Drawing.Point(170, 84);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(60, 21);
            this.lbl_DiaChi.TabIndex = 31;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // lbl_TenKhachHang
            // 
            this.lbl_TenKhachHang.AutoSize = true;
            this.lbl_TenKhachHang.BackColor = System.Drawing.Color.White;
            this.lbl_TenKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenKhachHang.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TenKhachHang.Location = new System.Drawing.Point(170, 24);
            this.lbl_TenKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenKhachHang.Name = "lbl_TenKhachHang";
            this.lbl_TenKhachHang.Size = new System.Drawing.Size(120, 21);
            this.lbl_TenKhachHang.TabIndex = 27;
            this.lbl_TenKhachHang.Text = "Tên khách hàng:";
            // 
            // lbl_CMND
            // 
            this.lbl_CMND.AutoSize = true;
            this.lbl_CMND.BackColor = System.Drawing.Color.White;
            this.lbl_CMND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CMND.ForeColor = System.Drawing.Color.Blue;
            this.lbl_CMND.Location = new System.Drawing.Point(170, 54);
            this.lbl_CMND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CMND.Name = "lbl_CMND";
            this.lbl_CMND.Size = new System.Drawing.Size(107, 21);
            this.lbl_CMND.TabIndex = 28;
            this.lbl_CMND.Text = "CMND/CCCD:";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_ThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(401, 549);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(124, 40);
            this.btn_ThanhToan.TabIndex = 50;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(547, 549);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(109, 40);
            this.btn_Thoat.TabIndex = 51;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_ThongTinPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 604);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.lbl_TongSoTienDichVu);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.lbl_Phong);
            this.Controls.Add(this.lbl_TieuDeQLThuePhong);
            this.Controls.Add(this.grp_DichVuDaThue);
            this.Controls.Add(this.grp_ThôngTinKhachHang);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ThongTinPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.Load += new System.EventHandler(this.frm_ThongTinPhong_Load);
            this.grp_DichVuDaThue.ResumeLayout(false);
            this.grp_ThôngTinKhachHang.ResumeLayout(false);
            this.grp_ThôngTinKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TongSoTienDichVu;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label lbl_Phong;
        private System.Windows.Forms.Label lbl_TieuDeQLThuePhong;
        private System.Windows.Forms.GroupBox grp_DichVuDaThue;
        private System.Windows.Forms.ListView lstv_DichVuDaSuDung;
        private System.Windows.Forms.GroupBox grp_ThôngTinKhachHang;
        private System.Windows.Forms.DateTimePicker dtp_NgayThue;
        private System.Windows.Forms.Label lbl_NgayThue;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_TenKhachHang;
        private System.Windows.Forms.Label lbl_CMND;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_KQDiaChi;
        private System.Windows.Forms.Label lbl_KQCMND;
        private System.Windows.Forms.Label lbl_KQTenKhachHang;
    }
}