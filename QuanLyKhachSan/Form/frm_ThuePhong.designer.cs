﻿namespace QuanLyKhachSan
{
    partial class frm_ThuePhong
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
            this.tabControl_ThuePhong = new System.Windows.Forms.TabControl();
            this.tabPage_ThuePhong = new System.Windows.Forms.TabPage();
            this.btn_ThuePhong = new System.Windows.Forms.Button();
            this.tabControl_ThongTin = new System.Windows.Forms.TabControl();
            this.tabPage_ChiTiet = new System.Windows.Forms.TabPage();
            this.lsv_phongchon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.lstv_ChiTiet = new System.Windows.Forms.ListView();
            this.ThongTin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaTri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grp_PhongTrong = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_PhongTrong = new System.Windows.Forms.DataGridView();
            this.grp_ThuePhong = new System.Windows.Forms.GroupBox();
            this.dtp_NgayThue = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_MaKhachHang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage_DanhSachDaThue = new System.Windows.Forms.TabPage();
            this.dgv_DanhSachKhachDaThue = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl_ThuePhong.SuspendLayout();
            this.tabPage_ThuePhong.SuspendLayout();
            this.tabControl_ThongTin.SuspendLayout();
            this.tabPage_ChiTiet.SuspendLayout();
            this.grp_PhongTrong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhongTrong)).BeginInit();
            this.grp_ThuePhong.SuspendLayout();
            this.tabPage_DanhSachDaThue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhachDaThue)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_ThuePhong
            // 
            this.tabControl_ThuePhong.Controls.Add(this.tabPage_ThuePhong);
            this.tabControl_ThuePhong.Controls.Add(this.tabPage_DanhSachDaThue);
            this.tabControl_ThuePhong.Controls.Add(this.tabPage1);
            this.tabControl_ThuePhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_ThuePhong.Location = new System.Drawing.Point(0, 0);
            this.tabControl_ThuePhong.Name = "tabControl_ThuePhong";
            this.tabControl_ThuePhong.SelectedIndex = 0;
            this.tabControl_ThuePhong.Size = new System.Drawing.Size(1114, 511);
            this.tabControl_ThuePhong.TabIndex = 1;
            // 
            // tabPage_ThuePhong
            // 
            this.tabPage_ThuePhong.BackColor = System.Drawing.Color.White;
            this.tabPage_ThuePhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_ThuePhong.Controls.Add(this.btn_ThuePhong);
            this.tabPage_ThuePhong.Controls.Add(this.tabControl_ThongTin);
            this.tabPage_ThuePhong.Controls.Add(this.grp_PhongTrong);
            this.tabPage_ThuePhong.Controls.Add(this.grp_ThuePhong);
            this.tabPage_ThuePhong.Location = new System.Drawing.Point(4, 26);
            this.tabPage_ThuePhong.Name = "tabPage_ThuePhong";
            this.tabPage_ThuePhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThuePhong.Size = new System.Drawing.Size(1106, 481);
            this.tabPage_ThuePhong.TabIndex = 0;
            this.tabPage_ThuePhong.Text = "Thuê phòng";
            this.tabPage_ThuePhong.Click += new System.EventHandler(this.tabPage_ThuePhong_Click);
            // 
            // btn_ThuePhong
            // 
            this.btn_ThuePhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ThuePhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_ThuePhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThuePhong.FlatAppearance.BorderSize = 0;
            this.btn_ThuePhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThuePhong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThuePhong.ForeColor = System.Drawing.Color.White;
            this.btn_ThuePhong.Location = new System.Drawing.Point(945, 82);
            this.btn_ThuePhong.Name = "btn_ThuePhong";
            this.btn_ThuePhong.Size = new System.Drawing.Size(125, 64);
            this.btn_ThuePhong.TabIndex = 3;
            this.btn_ThuePhong.Text = "Thuê phòng";
            this.btn_ThuePhong.UseVisualStyleBackColor = false;
            this.btn_ThuePhong.Click += new System.EventHandler(this.btn_ThuePhong_Click);
            // 
            // tabControl_ThongTin
            // 
            this.tabControl_ThongTin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl_ThongTin.Controls.Add(this.tabPage_ChiTiet);
            this.tabControl_ThongTin.Location = new System.Drawing.Point(382, 6);
            this.tabControl_ThongTin.Name = "tabControl_ThongTin";
            this.tabControl_ThongTin.SelectedIndex = 0;
            this.tabControl_ThongTin.Size = new System.Drawing.Size(557, 469);
            this.tabControl_ThongTin.TabIndex = 2;
            // 
            // tabPage_ChiTiet
            // 
            this.tabPage_ChiTiet.BackColor = System.Drawing.Color.White;
            this.tabPage_ChiTiet.Controls.Add(this.lsv_phongchon);
            this.tabPage_ChiTiet.Controls.Add(this.label3);
            this.tabPage_ChiTiet.Controls.Add(this.lstv_ChiTiet);
            this.tabPage_ChiTiet.Location = new System.Drawing.Point(4, 26);
            this.tabPage_ChiTiet.Name = "tabPage_ChiTiet";
            this.tabPage_ChiTiet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ChiTiet.Size = new System.Drawing.Size(549, 439);
            this.tabPage_ChiTiet.TabIndex = 0;
            this.tabPage_ChiTiet.Text = "Chi tiết";
            // 
            // lsv_phongchon
            // 
            this.lsv_phongchon.BackColor = System.Drawing.Color.White;
            this.lsv_phongchon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsv_phongchon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_phongchon.FullRowSelect = true;
            this.lsv_phongchon.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsv_phongchon.HideSelection = false;
            this.lsv_phongchon.Location = new System.Drawing.Point(6, 295);
            this.lsv_phongchon.MultiSelect = false;
            this.lsv_phongchon.Name = "lsv_phongchon";
            this.lsv_phongchon.Scrollable = false;
            this.lsv_phongchon.Size = new System.Drawing.Size(537, 141);
            this.lsv_phongchon.TabIndex = 3;
            this.lsv_phongchon.UseCompatibleStateImageBehavior = false;
            this.lsv_phongchon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Thông tin";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá trị";
            this.columnHeader2.Width = 464;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng đã chọn";
            // 
            // lstv_ChiTiet
            // 
            this.lstv_ChiTiet.BackColor = System.Drawing.Color.White;
            this.lstv_ChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ThongTin,
            this.GiaTri});
            this.lstv_ChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_ChiTiet.FullRowSelect = true;
            this.lstv_ChiTiet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstv_ChiTiet.HideSelection = false;
            this.lstv_ChiTiet.Location = new System.Drawing.Point(6, 6);
            this.lstv_ChiTiet.MultiSelect = false;
            this.lstv_ChiTiet.Name = "lstv_ChiTiet";
            this.lstv_ChiTiet.Scrollable = false;
            this.lstv_ChiTiet.Size = new System.Drawing.Size(537, 266);
            this.lstv_ChiTiet.TabIndex = 0;
            this.lstv_ChiTiet.UseCompatibleStateImageBehavior = false;
            this.lstv_ChiTiet.View = System.Windows.Forms.View.Details;
            this.lstv_ChiTiet.SelectedIndexChanged += new System.EventHandler(this.lstv_ChiTiet_SelectedIndexChanged);
            // 
            // ThongTin
            // 
            this.ThongTin.Text = "Thông tin";
            this.ThongTin.Width = 500;
            // 
            // GiaTri
            // 
            this.GiaTri.Text = "Giá trị";
            this.GiaTri.Width = 464;
            // 
            // grp_PhongTrong
            // 
            this.grp_PhongTrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_PhongTrong.BackColor = System.Drawing.Color.White;
            this.grp_PhongTrong.Controls.Add(this.label5);
            this.grp_PhongTrong.Controls.Add(this.dgv_PhongTrong);
            this.grp_PhongTrong.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grp_PhongTrong.Location = new System.Drawing.Point(17, 233);
            this.grp_PhongTrong.Name = "grp_PhongTrong";
            this.grp_PhongTrong.Size = new System.Drawing.Size(334, 241);
            this.grp_PhongTrong.TabIndex = 1;
            this.grp_PhongTrong.TabStop = false;
            this.grp_PhongTrong.Text = "Danh sách phòng trống";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bấm vào để chọn phòng";
            // 
            // dgv_PhongTrong
            // 
            this.dgv_PhongTrong.AllowUserToAddRows = false;
            this.dgv_PhongTrong.AllowUserToDeleteRows = false;
            this.dgv_PhongTrong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhongTrong.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhongTrong.Location = new System.Drawing.Point(6, 44);
            this.dgv_PhongTrong.Name = "dgv_PhongTrong";
            this.dgv_PhongTrong.ReadOnly = true;
            this.dgv_PhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PhongTrong.Size = new System.Drawing.Size(322, 191);
            this.dgv_PhongTrong.TabIndex = 0;
            this.dgv_PhongTrong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhongTrong_CellClick);
            this.dgv_PhongTrong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhongTrong_CellContentClick);
            // 
            // grp_ThuePhong
            // 
            this.grp_ThuePhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_ThuePhong.BackColor = System.Drawing.Color.White;
            this.grp_ThuePhong.Controls.Add(this.dtp_NgayThue);
            this.grp_ThuePhong.Controls.Add(this.label2);
            this.grp_ThuePhong.Controls.Add(this.cbo_MaKhachHang);
            this.grp_ThuePhong.Controls.Add(this.label8);
            this.grp_ThuePhong.Location = new System.Drawing.Point(17, 5);
            this.grp_ThuePhong.Name = "grp_ThuePhong";
            this.grp_ThuePhong.Size = new System.Drawing.Size(333, 222);
            this.grp_ThuePhong.TabIndex = 0;
            this.grp_ThuePhong.TabStop = false;
            this.grp_ThuePhong.Text = "Phiếu thuê phòng";
            // 
            // dtp_NgayThue
            // 
            this.dtp_NgayThue.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayThue.Location = new System.Drawing.Point(114, 116);
            this.dtp_NgayThue.Name = "dtp_NgayThue";
            this.dtp_NgayThue.Size = new System.Drawing.Size(174, 25);
            this.dtp_NgayThue.TabIndex = 5;
            this.dtp_NgayThue.ValueChanged += new System.EventHandler(this.dtp_NgayThue_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(15, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày thuê:";
            // 
            // cbo_MaKhachHang
            // 
            this.cbo_MaKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaKhachHang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaKhachHang.FormattingEnabled = true;
            this.cbo_MaKhachHang.Location = new System.Drawing.Point(114, 48);
            this.cbo_MaKhachHang.Name = "cbo_MaKhachHang";
            this.cbo_MaKhachHang.Size = new System.Drawing.Size(174, 28);
            this.cbo_MaKhachHang.TabIndex = 1;
            this.cbo_MaKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbo_MaKhachHang_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(15, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Khách hàng";
            // 
            // tabPage_DanhSachDaThue
            // 
            this.tabPage_DanhSachDaThue.BackColor = System.Drawing.Color.White;
            this.tabPage_DanhSachDaThue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_DanhSachDaThue.Controls.Add(this.dgv_DanhSachKhachDaThue);
            this.tabPage_DanhSachDaThue.Location = new System.Drawing.Point(4, 26);
            this.tabPage_DanhSachDaThue.Name = "tabPage_DanhSachDaThue";
            this.tabPage_DanhSachDaThue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DanhSachDaThue.Size = new System.Drawing.Size(1106, 481);
            this.tabPage_DanhSachDaThue.TabIndex = 1;
            this.tabPage_DanhSachDaThue.Text = "Danh sách khách đang thuê";
            // 
            // dgv_DanhSachKhachDaThue
            // 
            this.dgv_DanhSachKhachDaThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachKhachDaThue.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachKhachDaThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKhachDaThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachKhachDaThue.Location = new System.Drawing.Point(3, 3);
            this.dgv_DanhSachKhachDaThue.Name = "dgv_DanhSachKhachDaThue";
            this.dgv_DanhSachKhachDaThue.Size = new System.Drawing.Size(1098, 473);
            this.dgv_DanhSachKhachDaThue.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1106, 481);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Report khách đang thuê";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1100, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // frm_ThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 511);
            this.Controls.Add(this.tabControl_ThuePhong);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ThuePhong";
            this.Load += new System.EventHandler(this.frm_ThuePhong_Load);
            this.tabControl_ThuePhong.ResumeLayout(false);
            this.tabPage_ThuePhong.ResumeLayout(false);
            this.tabControl_ThongTin.ResumeLayout(false);
            this.tabPage_ChiTiet.ResumeLayout(false);
            this.tabPage_ChiTiet.PerformLayout();
            this.grp_PhongTrong.ResumeLayout(false);
            this.grp_PhongTrong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhongTrong)).EndInit();
            this.grp_ThuePhong.ResumeLayout(false);
            this.grp_ThuePhong.PerformLayout();
            this.tabPage_DanhSachDaThue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhachDaThue)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_ThuePhong;
        private System.Windows.Forms.TabPage tabPage_ThuePhong;
        private System.Windows.Forms.Button btn_ThuePhong;
        private System.Windows.Forms.TabControl tabControl_ThongTin;
        private System.Windows.Forms.TabPage tabPage_ChiTiet;
        private System.Windows.Forms.ListView lstv_ChiTiet;
        private System.Windows.Forms.ColumnHeader ThongTin;
        private System.Windows.Forms.ColumnHeader GiaTri;
        private System.Windows.Forms.GroupBox grp_PhongTrong;
        private System.Windows.Forms.DataGridView dgv_PhongTrong;
        private System.Windows.Forms.GroupBox grp_ThuePhong;
        private System.Windows.Forms.DateTimePicker dtp_NgayThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_MaKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage_DanhSachDaThue;
        private System.Windows.Forms.DataGridView dgv_DanhSachKhachDaThue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lsv_phongchon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}