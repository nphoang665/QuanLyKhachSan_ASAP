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
            this.tabControl_ThuePhong = new System.Windows.Forms.TabControl();
            this.tabPage_ThuePhong = new System.Windows.Forms.TabPage();
            this.btn_ThuePhong = new System.Windows.Forms.Button();
            this.tabControl_ThongTin = new System.Windows.Forms.TabControl();
            this.tabPage_ChiTiet = new System.Windows.Forms.TabPage();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lsv_phongchon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tabPage_ChiTiet.Controls.Add(this.lsv_phongchon);
            this.tabPage_ChiTiet.Controls.Add(this.label3);
            this.tabPage_ChiTiet.Controls.Add(this.lstv_ChiTiet);
            this.tabPage_ChiTiet.Location = new System.Drawing.Point(4, 26);
            this.tabPage_ChiTiet.Name = "tabPage_ChiTiet";
            this.tabPage_ChiTiet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ChiTiet.Size = new System.Drawing.Size(549, 439);
            this.tabPage_ChiTiet.TabIndex = 0;
            this.tabPage_ChiTiet.Text = "Chi tiết";
            this.tabPage_ChiTiet.UseVisualStyleBackColor = true;
            // 
            // lstv_ChiTiet
            // 
            this.lstv_ChiTiet.BackColor = System.Drawing.SystemColors.Control;
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
            this.grp_PhongTrong.Controls.Add(this.label5);
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
            this.dgv_PhongTrong.Location = new System.Drawing.Point(6, 44);
            this.dgv_PhongTrong.Name = "dgv_PhongTrong";
            this.dgv_PhongTrong.ReadOnly = true;
            this.dgv_PhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PhongTrong.Size = new System.Drawing.Size(298, 191);
            this.dgv_PhongTrong.TabIndex = 0;
            this.dgv_PhongTrong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhongTrong_CellClick);
            this.dgv_PhongTrong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhongTrong_CellContentClick);
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
            this.dtp_NgayTra.ValueChanged += new System.EventHandler(this.dtp_NgayTra_ValueChanged);
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
            // txt_TienCoc
            // 
            this.txt_TienCoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TienCoc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TienCoc.Location = new System.Drawing.Point(114, 71);
            this.txt_TienCoc.Name = "txt_TienCoc";
            this.txt_TienCoc.Size = new System.Drawing.Size(174, 27);
            this.txt_TienCoc.TabIndex = 3;
            this.txt_TienCoc.TextChanged += new System.EventHandler(this.txt_TienCoc_TextChanged);
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
            this.cbo_MaKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbo_MaKhachHang_SelectedIndexChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng đã chọn";
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
            // lsv_phongchon
            // 
            this.lsv_phongchon.BackColor = System.Drawing.SystemColors.Control;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lsv_phongchon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}