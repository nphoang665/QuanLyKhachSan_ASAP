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
            this.lbl_mahoadon = new System.Windows.Forms.Label();
            this.lbl_KQTongTien = new System.Windows.Forms.Label();
            this.lbl_KQSoNgay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_DanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.lbl_mathanhtoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_kqmathanhtoan = new System.Windows.Forms.Label();
            this.lbl_kqmahd = new System.Windows.Forms.Label();
            this.lbl_kqmakhachhang = new System.Windows.Forms.Label();
            this.lbl_kqngaythue = new System.Windows.Forms.Label();
            this.lbl_KQngaytra = new System.Windows.Forms.Label();
            this.lbl_ngaytra = new System.Windows.Forms.Label();
            this.MaThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhacHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl_HoaDon.SuspendLayout();
            this.tabPage_HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHoaDon)).BeginInit();
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
            this.tabPage_HoaDon.Controls.Add(this.lbl_KQngaytra);
            this.tabPage_HoaDon.Controls.Add(this.lbl_ngaytra);
            this.tabPage_HoaDon.Controls.Add(this.lbl_kqngaythue);
            this.tabPage_HoaDon.Controls.Add(this.lbl_kqmakhachhang);
            this.tabPage_HoaDon.Controls.Add(this.lbl_kqmahd);
            this.tabPage_HoaDon.Controls.Add(this.lbl_kqmathanhtoan);
            this.tabPage_HoaDon.Controls.Add(this.lbl_mahoadon);
            this.tabPage_HoaDon.Controls.Add(this.lbl_KQTongTien);
            this.tabPage_HoaDon.Controls.Add(this.lbl_KQSoNgay);
            this.tabPage_HoaDon.Controls.Add(this.label6);
            this.tabPage_HoaDon.Controls.Add(this.label8);
            this.tabPage_HoaDon.Controls.Add(this.label4);
            this.tabPage_HoaDon.Controls.Add(this.label5);
            this.tabPage_HoaDon.Controls.Add(this.dgv_DanhSachHoaDon);
            this.tabPage_HoaDon.Controls.Add(this.lbl_mathanhtoan);
            this.tabPage_HoaDon.Controls.Add(this.label1);
            this.tabPage_HoaDon.Location = new System.Drawing.Point(4, 26);
            this.tabPage_HoaDon.Name = "tabPage_HoaDon";
            this.tabPage_HoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HoaDon.Size = new System.Drawing.Size(1106, 481);
            this.tabPage_HoaDon.TabIndex = 0;
            this.tabPage_HoaDon.Text = "Hóa đơn";
            this.tabPage_HoaDon.Click += new System.EventHandler(this.tabPage_HoaDon_Click);
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
            // lbl_KQTongTien
            // 
            this.lbl_KQTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQTongTien.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQTongTien.Location = new System.Drawing.Point(656, 124);
            this.lbl_KQTongTien.Name = "lbl_KQTongTien";
            this.lbl_KQTongTien.Size = new System.Drawing.Size(197, 22);
            this.lbl_KQTongTien.TabIndex = 14;
            this.lbl_KQTongTien.Text = "---";
            this.lbl_KQTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KQSoNgay
            // 
            this.lbl_KQSoNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQSoNgay.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQSoNgay.Location = new System.Drawing.Point(656, 87);
            this.lbl_KQSoNgay.Name = "lbl_KQSoNgay";
            this.lbl_KQSoNgay.Size = new System.Drawing.Size(197, 22);
            this.lbl_KQSoNgay.TabIndex = 12;
            this.lbl_KQSoNgay.Text = "---";
            this.lbl_KQSoNgay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã khách hàng:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(513, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số ngày:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày thuê:";
            // 
            // dgv_DanhSachHoaDon
            // 
            this.dgv_DanhSachHoaDon.AllowUserToAddRows = false;
            this.dgv_DanhSachHoaDon.AllowUserToDeleteRows = false;
            this.dgv_DanhSachHoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThanhToan,
            this.MaHoaDon,
            this.MaKhacHang,
            this.NgayThue,
            this.SoNgay,
            this.TongTien,
            this.NgayLap});
            this.dgv_DanhSachHoaDon.Location = new System.Drawing.Point(49, 224);
            this.dgv_DanhSachHoaDon.Name = "dgv_DanhSachHoaDon";
            this.dgv_DanhSachHoaDon.ReadOnly = true;
            this.dgv_DanhSachHoaDon.Size = new System.Drawing.Size(1005, 235);
            this.dgv_DanhSachHoaDon.TabIndex = 16;
            this.dgv_DanhSachHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachHoaDon_CellClick);
            // 
            // lbl_mathanhtoan
            // 
            this.lbl_mathanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_mathanhtoan.AutoSize = true;
            this.lbl_mathanhtoan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mathanhtoan.Location = new System.Drawing.Point(74, 87);
            this.lbl_mathanhtoan.Name = "lbl_mathanhtoan";
            this.lbl_mathanhtoan.Size = new System.Drawing.Size(121, 20);
            this.lbl_mathanhtoan.TabIndex = 7;
            this.lbl_mathanhtoan.Text = "Mã Thanh Toán:";
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
            // lbl_kqmathanhtoan
            // 
            this.lbl_kqmathanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kqmathanhtoan.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kqmathanhtoan.Location = new System.Drawing.Point(231, 85);
            this.lbl_kqmathanhtoan.Name = "lbl_kqmathanhtoan";
            this.lbl_kqmathanhtoan.Size = new System.Drawing.Size(197, 22);
            this.lbl_kqmathanhtoan.TabIndex = 18;
            this.lbl_kqmathanhtoan.Text = "---";
            this.lbl_kqmathanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lbl_kqmakhachhang
            // 
            this.lbl_kqmakhachhang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kqmakhachhang.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kqmakhachhang.Location = new System.Drawing.Point(229, 127);
            this.lbl_kqmakhachhang.Name = "lbl_kqmakhachhang";
            this.lbl_kqmakhachhang.Size = new System.Drawing.Size(197, 22);
            this.lbl_kqmakhachhang.TabIndex = 21;
            this.lbl_kqmakhachhang.Text = "---";
            this.lbl_kqmakhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_kqngaythue
            // 
            this.lbl_kqngaythue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kqngaythue.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kqngaythue.Location = new System.Drawing.Point(656, 51);
            this.lbl_kqngaythue.Name = "lbl_kqngaythue";
            this.lbl_kqngaythue.Size = new System.Drawing.Size(197, 22);
            this.lbl_kqngaythue.TabIndex = 23;
            this.lbl_kqngaythue.Text = "---";
            this.lbl_kqngaythue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KQngaytra
            // 
            this.lbl_KQngaytra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQngaytra.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQngaytra.Location = new System.Drawing.Point(656, 163);
            this.lbl_KQngaytra.Name = "lbl_KQngaytra";
            this.lbl_KQngaytra.Size = new System.Drawing.Size(197, 22);
            this.lbl_KQngaytra.TabIndex = 25;
            this.lbl_KQngaytra.Text = "---";
            this.lbl_KQngaytra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ngaytra
            // 
            this.lbl_ngaytra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ngaytra.AutoSize = true;
            this.lbl_ngaytra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaytra.Location = new System.Drawing.Point(513, 163);
            this.lbl_ngaytra.Name = "lbl_ngaytra";
            this.lbl_ngaytra.Size = new System.Drawing.Size(76, 20);
            this.lbl_ngaytra.TabIndex = 24;
            this.lbl_ngaytra.Text = "Ngày Trả:";
            // 
            // MaThanhToan
            // 
            this.MaThanhToan.HeaderText = "Mã Thanh Toán";
            this.MaThanhToan.Name = "MaThanhToan";
            this.MaThanhToan.ReadOnly = true;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            // 
            // MaKhacHang
            // 
            this.MaKhacHang.HeaderText = "Mã Khách Hàng";
            this.MaKhacHang.Name = "MaKhacHang";
            this.MaKhacHang.ReadOnly = true;
            // 
            // NgayThue
            // 
            this.NgayThue.HeaderText = "Ngày Thuê";
            this.NgayThue.Name = "NgayThue";
            this.NgayThue.ReadOnly = true;
            // 
            // SoNgay
            // 
            this.SoNgay.HeaderText = "Số Ngày";
            this.SoNgay.Name = "SoNgay";
            this.SoNgay.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiên";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "Ngày Trả";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_HoaDon;
        private System.Windows.Forms.TabPage tabPage_HoaDon;
        private System.Windows.Forms.Label lbl_KQTongTien;
        private System.Windows.Forms.Label lbl_KQSoNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_DanhSachHoaDon;
        private System.Windows.Forms.Label lbl_mathanhtoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_mahoadon;
        private System.Windows.Forms.Label lbl_kqngaythue;
        private System.Windows.Forms.Label lbl_kqmakhachhang;
        private System.Windows.Forms.Label lbl_kqmahd;
        private System.Windows.Forms.Label lbl_kqmathanhtoan;
        private System.Windows.Forms.Label lbl_KQngaytra;
        private System.Windows.Forms.Label lbl_ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhacHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
    }
}