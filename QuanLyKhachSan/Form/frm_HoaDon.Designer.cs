﻿namespace QuanLyKhachSan
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
            this.lbl_KQTongTien = new System.Windows.Forms.Label();
            this.lbl_KQSoNgay = new System.Windows.Forms.Label();
            this.dtp_NgayThue = new System.Windows.Forms.DateTimePicker();
            this.cbo_MaDichVu = new System.Windows.Forms.ComboBox();
            this.cbo_MaKhachHang = new System.Windows.Forms.ComboBox();
            this.cbo_MaNhanVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_DanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabPage_HoaDon.Controls.Add(this.lbl_KQTongTien);
            this.tabPage_HoaDon.Controls.Add(this.lbl_KQSoNgay);
            this.tabPage_HoaDon.Controls.Add(this.dtp_NgayThue);
            this.tabPage_HoaDon.Controls.Add(this.cbo_MaDichVu);
            this.tabPage_HoaDon.Controls.Add(this.cbo_MaKhachHang);
            this.tabPage_HoaDon.Controls.Add(this.cbo_MaNhanVien);
            this.tabPage_HoaDon.Controls.Add(this.label6);
            this.tabPage_HoaDon.Controls.Add(this.dtp_NgayLap);
            this.tabPage_HoaDon.Controls.Add(this.label7);
            this.tabPage_HoaDon.Controls.Add(this.label8);
            this.tabPage_HoaDon.Controls.Add(this.label4);
            this.tabPage_HoaDon.Controls.Add(this.label5);
            this.tabPage_HoaDon.Controls.Add(this.dgv_DanhSachHoaDon);
            this.tabPage_HoaDon.Controls.Add(this.btn_Them);
            this.tabPage_HoaDon.Controls.Add(this.label3);
            this.tabPage_HoaDon.Controls.Add(this.label2);
            this.tabPage_HoaDon.Controls.Add(this.label1);
            this.tabPage_HoaDon.Location = new System.Drawing.Point(4, 26);
            this.tabPage_HoaDon.Name = "tabPage_HoaDon";
            this.tabPage_HoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HoaDon.Size = new System.Drawing.Size(1106, 481);
            this.tabPage_HoaDon.TabIndex = 0;
            this.tabPage_HoaDon.Text = "Hóa đơn";
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
            // dtp_NgayThue
            // 
            this.dtp_NgayThue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_NgayThue.Location = new System.Drawing.Point(660, 49);
            this.dtp_NgayThue.Name = "dtp_NgayThue";
            this.dtp_NgayThue.Size = new System.Drawing.Size(193, 25);
            this.dtp_NgayThue.TabIndex = 10;
            // 
            // cbo_MaDichVu
            // 
            this.cbo_MaDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_MaDichVu.FormattingEnabled = true;
            this.cbo_MaDichVu.Location = new System.Drawing.Point(221, 160);
            this.cbo_MaDichVu.Name = "cbo_MaDichVu";
            this.cbo_MaDichVu.Size = new System.Drawing.Size(193, 25);
            this.cbo_MaDichVu.TabIndex = 8;
            // 
            // cbo_MaKhachHang
            // 
            this.cbo_MaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_MaKhachHang.FormattingEnabled = true;
            this.cbo_MaKhachHang.Location = new System.Drawing.Point(221, 86);
            this.cbo_MaKhachHang.Name = "cbo_MaKhachHang";
            this.cbo_MaKhachHang.Size = new System.Drawing.Size(193, 25);
            this.cbo_MaKhachHang.TabIndex = 4;
            // 
            // cbo_MaNhanVien
            // 
            this.cbo_MaNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_MaNhanVien.FormattingEnabled = true;
            this.cbo_MaNhanVien.Location = new System.Drawing.Point(221, 49);
            this.cbo_MaNhanVien.Name = "cbo_MaNhanVien";
            this.cbo_MaNhanVien.Size = new System.Drawing.Size(193, 25);
            this.cbo_MaNhanVien.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã khách hàng:";
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_NgayLap.Location = new System.Drawing.Point(221, 123);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(193, 25);
            this.dtp_NgayLap.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày lập:";
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
            this.dgv_DanhSachHoaDon.Location = new System.Drawing.Point(49, 224);
            this.dgv_DanhSachHoaDon.Name = "dgv_DanhSachHoaDon";
            this.dgv_DanhSachHoaDon.ReadOnly = true;
            this.dgv_DanhSachHoaDon.Size = new System.Drawing.Size(1005, 235);
            this.dgv_DanhSachHoaDon.TabIndex = 16;
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(921, 88);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(133, 43);
            this.btn_Them.TabIndex = 15;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã dịch vụ:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:";
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
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 511);
            this.Controls.Add(this.tabControl_HoaDon);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_HoaDon";
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
        private System.Windows.Forms.DateTimePicker dtp_NgayThue;
        private System.Windows.Forms.ComboBox cbo_MaDichVu;
        private System.Windows.Forms.ComboBox cbo_MaKhachHang;
        private System.Windows.Forms.ComboBox cbo_MaNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_DanhSachHoaDon;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}