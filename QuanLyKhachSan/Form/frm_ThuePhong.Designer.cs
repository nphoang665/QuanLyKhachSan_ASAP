namespace QuanLyKhachSan
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Khách hàng", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Thuê phòng", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mã khách hàng",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tên khách hàng",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Giới tính",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ngày sinh",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "CMND/CCCD",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Địa chỉ",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Điện thoại",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ngày thuê",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ngày trả",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tiền cọc",
            ""}, -1);
            this.tabControl_ThuePhong = new System.Windows.Forms.TabControl();
            this.tabPage_ThuePhong = new System.Windows.Forms.TabPage();
            this.btn_ThuePhong = new System.Windows.Forms.Button();
            this.tabControl_ThongTin = new System.Windows.Forms.TabControl();
            this.tabPage_ChiTiet = new System.Windows.Forms.TabPage();
            this.lv_Phong = new System.Windows.Forms.ListView();
            this.lstv_ChiTiet = new System.Windows.Forms.ListView();
            this.ThongTin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaTri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grp_PhongTrong = new System.Windows.Forms.GroupBox();
            this.dgv_PhongTrong = new System.Windows.Forms.DataGridView();
            this.grp_ThuePhong = new System.Windows.Forms.GroupBox();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayThue = new System.Windows.Forms.DateTimePicker();
            this.txt_TienCoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_MaKhachHang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage_DanhSachDaThue = new System.Windows.Forms.TabPage();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl_ThuePhong.SuspendLayout();
            this.tabPage_ThuePhong.SuspendLayout();
            this.tabControl_ThongTin.SuspendLayout();
            this.tabPage_ChiTiet.SuspendLayout();
            this.grp_PhongTrong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhongTrong)).BeginInit();
            this.grp_ThuePhong.SuspendLayout();
            this.tabPage_DanhSachDaThue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_ThuePhong
            // 
            this.tabControl_ThuePhong.Controls.Add(this.tabPage_ThuePhong);
            this.tabControl_ThuePhong.Controls.Add(this.tabPage_DanhSachDaThue);
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
            // 
            // tabControl_ThongTin
            // 
            this.tabControl_ThongTin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl_ThongTin.Controls.Add(this.tabPage_ChiTiet);
            this.tabControl_ThongTin.Location = new System.Drawing.Point(346, 5);
            this.tabControl_ThongTin.Name = "tabControl_ThongTin";
            this.tabControl_ThongTin.SelectedIndex = 0;
            this.tabControl_ThongTin.Size = new System.Drawing.Size(557, 469);
            this.tabControl_ThongTin.TabIndex = 2;
            // 
            // tabPage_ChiTiet
            // 
            this.tabPage_ChiTiet.Controls.Add(this.lv_Phong);
            this.tabPage_ChiTiet.Controls.Add(this.lstv_ChiTiet);
            this.tabPage_ChiTiet.Location = new System.Drawing.Point(4, 26);
            this.tabPage_ChiTiet.Name = "tabPage_ChiTiet";
            this.tabPage_ChiTiet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ChiTiet.Size = new System.Drawing.Size(549, 439);
            this.tabPage_ChiTiet.TabIndex = 0;
            this.tabPage_ChiTiet.Text = "Chi tiết";
            this.tabPage_ChiTiet.UseVisualStyleBackColor = true;
            // 
            // lv_Phong
            // 
            this.lv_Phong.BackColor = System.Drawing.SystemColors.Control;
            this.lv_Phong.FullRowSelect = true;
            this.lv_Phong.GridLines = true;
            this.lv_Phong.HideSelection = false;
            this.lv_Phong.Location = new System.Drawing.Point(6, 298);
            this.lv_Phong.Name = "lv_Phong";
            this.lv_Phong.Scrollable = false;
            this.lv_Phong.Size = new System.Drawing.Size(537, 131);
            this.lv_Phong.TabIndex = 1;
            this.lv_Phong.UseCompatibleStateImageBehavior = false;
            this.lv_Phong.View = System.Windows.Forms.View.Details;
            // 
            // lstv_ChiTiet
            // 
            this.lstv_ChiTiet.BackColor = System.Drawing.SystemColors.Control;
            this.lstv_ChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ThongTin,
            this.GiaTri});
            this.lstv_ChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_ChiTiet.FullRowSelect = true;
            listViewGroup1.Header = "Khách hàng";
            listViewGroup1.Name = "listViewGroupKhachHang";
            listViewGroup2.Header = "Thuê phòng";
            listViewGroup2.Name = "listViewGroupThuePhong";
            this.lstv_ChiTiet.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lstv_ChiTiet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstv_ChiTiet.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.Group = listViewGroup1;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.Group = listViewGroup1;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.Group = listViewGroup1;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.Group = listViewGroup1;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.Group = listViewGroup1;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.Group = listViewGroup2;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.Group = listViewGroup2;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.Group = listViewGroup2;
            listViewItem10.StateImageIndex = 0;
            this.lstv_ChiTiet.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.lstv_ChiTiet.Location = new System.Drawing.Point(6, 6);
            this.lstv_ChiTiet.MultiSelect = false;
            this.lstv_ChiTiet.Name = "lstv_ChiTiet";
            this.lstv_ChiTiet.Scrollable = false;
            this.lstv_ChiTiet.Size = new System.Drawing.Size(537, 286);
            this.lstv_ChiTiet.TabIndex = 0;
            this.lstv_ChiTiet.UseCompatibleStateImageBehavior = false;
            this.lstv_ChiTiet.View = System.Windows.Forms.View.Details;
            // 
            // ThongTin
            // 
            this.ThongTin.Text = "Thông tin";
            this.ThongTin.Width = 180;
            // 
            // GiaTri
            // 
            this.GiaTri.Text = "Giá trị";
            this.GiaTri.Width = 464;
            // 
            // grp_PhongTrong
            // 
            this.grp_PhongTrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_PhongTrong.BackColor = System.Drawing.SystemColors.Control;
            this.grp_PhongTrong.Controls.Add(this.dgv_PhongTrong);
            this.grp_PhongTrong.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grp_PhongTrong.Location = new System.Drawing.Point(17, 233);
            this.grp_PhongTrong.Name = "grp_PhongTrong";
            this.grp_PhongTrong.Size = new System.Drawing.Size(310, 241);
            this.grp_PhongTrong.TabIndex = 1;
            this.grp_PhongTrong.TabStop = false;
            this.grp_PhongTrong.Text = "Danh sách phòng trống";
            // 
            // dgv_PhongTrong
            // 
            this.dgv_PhongTrong.AllowUserToAddRows = false;
            this.dgv_PhongTrong.AllowUserToDeleteRows = false;
            this.dgv_PhongTrong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhongTrong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_PhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhongTrong.Location = new System.Drawing.Point(6, 34);
            this.dgv_PhongTrong.Name = "dgv_PhongTrong";
            this.dgv_PhongTrong.ReadOnly = true;
            this.dgv_PhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PhongTrong.Size = new System.Drawing.Size(298, 191);
            this.dgv_PhongTrong.TabIndex = 0;
            // 
            // grp_ThuePhong
            // 
            this.grp_ThuePhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_ThuePhong.BackColor = System.Drawing.SystemColors.Control;
            this.grp_ThuePhong.Controls.Add(this.dtp_NgayTra);
            this.grp_ThuePhong.Controls.Add(this.dtp_NgayThue);
            this.grp_ThuePhong.Controls.Add(this.txt_TienCoc);
            this.grp_ThuePhong.Controls.Add(this.label1);
            this.grp_ThuePhong.Controls.Add(this.label2);
            this.grp_ThuePhong.Controls.Add(this.label4);
            this.grp_ThuePhong.Controls.Add(this.cbo_MaKhachHang);
            this.grp_ThuePhong.Controls.Add(this.label8);
            this.grp_ThuePhong.Location = new System.Drawing.Point(17, 5);
            this.grp_ThuePhong.Name = "grp_ThuePhong";
            this.grp_ThuePhong.Size = new System.Drawing.Size(309, 222);
            this.grp_ThuePhong.TabIndex = 0;
            this.grp_ThuePhong.TabStop = false;
            this.grp_ThuePhong.Text = "Phiếu thuê phòng";
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayTra.Location = new System.Drawing.Point(114, 156);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(174, 25);
            this.dtp_NgayTra.TabIndex = 7;
            // 
            // dtp_NgayThue
            // 
            this.dtp_NgayThue.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayThue.Location = new System.Drawing.Point(114, 116);
            this.dtp_NgayThue.Name = "dtp_NgayThue";
            this.dtp_NgayThue.Size = new System.Drawing.Size(174, 25);
            this.dtp_NgayThue.TabIndex = 5;
            // 
            // txt_TienCoc
            // 
            this.txt_TienCoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TienCoc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TienCoc.Location = new System.Drawing.Point(114, 71);
            this.txt_TienCoc.Name = "txt_TienCoc";
            this.txt_TienCoc.Size = new System.Drawing.Size(174, 27);
            this.txt_TienCoc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày trả:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(15, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tiền cọc";
            // 
            // cbo_MaKhachHang
            // 
            this.cbo_MaKhachHang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_MaKhachHang.FormattingEnabled = true;
            this.cbo_MaKhachHang.Location = new System.Drawing.Point(114, 28);
            this.cbo_MaKhachHang.Name = "cbo_MaKhachHang";
            this.cbo_MaKhachHang.Size = new System.Drawing.Size(174, 28);
            this.cbo_MaKhachHang.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(15, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Khách hàng";
            // 
            // tabPage_DanhSachDaThue
            // 
            this.tabPage_DanhSachDaThue.BackColor = System.Drawing.Color.White;
            this.tabPage_DanhSachDaThue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_DanhSachDaThue.Controls.Add(this.btn_Xoa);
            this.tabPage_DanhSachDaThue.Controls.Add(this.btn_Sua);
            this.tabPage_DanhSachDaThue.Controls.Add(this.dataGridView1);
            this.tabPage_DanhSachDaThue.Location = new System.Drawing.Point(4, 26);
            this.tabPage_DanhSachDaThue.Name = "tabPage_DanhSachDaThue";
            this.tabPage_DanhSachDaThue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DanhSachDaThue.Size = new System.Drawing.Size(1106, 481);
            this.tabPage_DanhSachDaThue.TabIndex = 1;
            this.tabPage_DanhSachDaThue.Text = "Danh sách đã thuê";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(900, 69);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(140, 43);
            this.btn_Xoa.TabIndex = 42;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(900, 15);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(140, 43);
            this.btn_Sua.TabIndex = 41;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(976, 328);
            this.dataGridView1.TabIndex = 0;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_ThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ThuePhong";
            this.tabControl_ThuePhong.ResumeLayout(false);
            this.tabPage_ThuePhong.ResumeLayout(false);
            this.tabControl_ThongTin.ResumeLayout(false);
            this.tabPage_ChiTiet.ResumeLayout(false);
            this.grp_PhongTrong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhongTrong)).EndInit();
            this.grp_ThuePhong.ResumeLayout(false);
            this.grp_ThuePhong.PerformLayout();
            this.tabPage_DanhSachDaThue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_ThuePhong;
        private System.Windows.Forms.TabPage tabPage_ThuePhong;
        private System.Windows.Forms.Button btn_ThuePhong;
        private System.Windows.Forms.TabControl tabControl_ThongTin;
        private System.Windows.Forms.TabPage tabPage_ChiTiet;
        private System.Windows.Forms.ListView lv_Phong;
        private System.Windows.Forms.ListView lstv_ChiTiet;
        private System.Windows.Forms.ColumnHeader ThongTin;
        private System.Windows.Forms.ColumnHeader GiaTri;
        private System.Windows.Forms.GroupBox grp_PhongTrong;
        private System.Windows.Forms.DataGridView dgv_PhongTrong;
        private System.Windows.Forms.GroupBox grp_ThuePhong;
        private System.Windows.Forms.DateTimePicker dtp_NgayTra;
        private System.Windows.Forms.DateTimePicker dtp_NgayThue;
        private System.Windows.Forms.TextBox txt_TienCoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_MaKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage_DanhSachDaThue;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}