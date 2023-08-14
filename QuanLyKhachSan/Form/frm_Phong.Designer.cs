namespace QuanLyKhachSan
{
    partial class frm_Phong
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
            this.components = new System.ComponentModel.Container();
            this.tabControl_Phong = new System.Windows.Forms.TabControl();
            this.tabPage_TimPhong = new System.Windows.Forms.TabPage();
            this.btn_Report = new System.Windows.Forms.Button();
            this.txt_TimLoaiPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_timtinhtrang = new System.Windows.Forms.TextBox();
            this.txt_timphong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_phong2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage_Sua_XoaPhong = new System.Windows.Forms.TabPage();
            this.cbo_loaiphong_sua = new System.Windows.Forms.ComboBox();
            this.lbl_KQTinhTrang = new System.Windows.Forms.Label();
            this.lbl_KQPhong = new System.Windows.Forms.Label();
            this.lbl_maphong_sua = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_dongia_sua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_phong3 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.KiemLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl_Phong.SuspendLayout();
            this.tabPage_TimPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong2)).BeginInit();
            this.tabPage_Sua_XoaPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiemLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Phong
            // 
            this.tabControl_Phong.Controls.Add(this.tabPage_TimPhong);
            this.tabControl_Phong.Controls.Add(this.tabPage_Sua_XoaPhong);
            this.tabControl_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Phong.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Phong.Name = "tabControl_Phong";
            this.tabControl_Phong.SelectedIndex = 0;
            this.tabControl_Phong.Size = new System.Drawing.Size(1114, 511);
            this.tabControl_Phong.TabIndex = 1;
            // 
            // tabPage_TimPhong
            // 
            this.tabPage_TimPhong.BackColor = System.Drawing.Color.White;
            this.tabPage_TimPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_TimPhong.Controls.Add(this.btn_Report);
            this.tabPage_TimPhong.Controls.Add(this.txt_TimLoaiPhong);
            this.tabPage_TimPhong.Controls.Add(this.label5);
            this.tabPage_TimPhong.Controls.Add(this.txt_timtinhtrang);
            this.tabPage_TimPhong.Controls.Add(this.txt_timphong);
            this.tabPage_TimPhong.Controls.Add(this.label7);
            this.tabPage_TimPhong.Controls.Add(this.dgv_phong2);
            this.tabPage_TimPhong.Controls.Add(this.label9);
            this.tabPage_TimPhong.Controls.Add(this.label10);
            this.tabPage_TimPhong.Location = new System.Drawing.Point(4, 26);
            this.tabPage_TimPhong.Name = "tabPage_TimPhong";
            this.tabPage_TimPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TimPhong.Size = new System.Drawing.Size(1106, 481);
            this.tabPage_TimPhong.TabIndex = 1;
            this.tabPage_TimPhong.Text = "Tìm phòng";
            // 
            // btn_Report
            // 
            this.btn_Report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Report.FlatAppearance.BorderSize = 0;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Report.Location = new System.Drawing.Point(843, 84);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(134, 43);
            this.btn_Report.TabIndex = 64;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = false;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // txt_TimLoaiPhong
            // 
            this.txt_TimLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TimLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimLoaiPhong.Location = new System.Drawing.Point(523, 98);
            this.txt_TimLoaiPhong.Name = "txt_TimLoaiPhong";
            this.txt_TimLoaiPhong.Size = new System.Drawing.Size(193, 29);
            this.txt_TimLoaiPhong.TabIndex = 63;
            this.txt_TimLoaiPhong.TextChanged += new System.EventHandler(this.txt_TimLoaiPhong_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 62;
            this.label5.Text = "Loại phòng:";
            // 
            // txt_timtinhtrang
            // 
            this.txt_timtinhtrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_timtinhtrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timtinhtrang.Location = new System.Drawing.Point(523, 143);
            this.txt_timtinhtrang.Name = "txt_timtinhtrang";
            this.txt_timtinhtrang.Size = new System.Drawing.Size(193, 29);
            this.txt_timtinhtrang.TabIndex = 61;
            this.txt_timtinhtrang.TextChanged += new System.EventHandler(this.txt_timtinhtrang_TextChanged);
            // 
            // txt_timphong
            // 
            this.txt_timphong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_timphong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timphong.Location = new System.Drawing.Point(523, 53);
            this.txt_timphong.Name = "txt_timphong";
            this.txt_timphong.Size = new System.Drawing.Size(193, 29);
            this.txt_timphong.TabIndex = 58;
            this.txt_timphong.TextChanged += new System.EventHandler(this.txt_timphong_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 60;
            this.label7.Text = "Tình trạng:";
            // 
            // dgv_phong2
            // 
            this.dgv_phong2.AllowUserToAddRows = false;
            this.dgv_phong2.AllowUserToDeleteRows = false;
            this.dgv_phong2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_phong2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phong2.BackgroundColor = System.Drawing.Color.White;
            this.dgv_phong2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_phong2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phong2.Location = new System.Drawing.Point(7, 207);
            this.dgv_phong2.Name = "dgv_phong2";
            this.dgv_phong2.Size = new System.Drawing.Size(1090, 252);
            this.dgv_phong2.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 57;
            this.label9.Text = "Mã phòng:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label10.Location = new System.Drawing.Point(43, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 21);
            this.label10.TabIndex = 56;
            this.label10.Text = "TÌM PHÒNG:";
            // 
            // tabPage_Sua_XoaPhong
            // 
            this.tabPage_Sua_XoaPhong.BackColor = System.Drawing.Color.White;
            this.tabPage_Sua_XoaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_Sua_XoaPhong.Controls.Add(this.cbo_loaiphong_sua);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.lbl_KQTinhTrang);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.lbl_KQPhong);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.lbl_maphong_sua);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.btn_Sua);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.txt_dongia_sua);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.label3);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.label8);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.dgv_phong3);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.label11);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.label13);
            this.tabPage_Sua_XoaPhong.Location = new System.Drawing.Point(4, 26);
            this.tabPage_Sua_XoaPhong.Name = "tabPage_Sua_XoaPhong";
            this.tabPage_Sua_XoaPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Sua_XoaPhong.Size = new System.Drawing.Size(1106, 481);
            this.tabPage_Sua_XoaPhong.TabIndex = 2;
            this.tabPage_Sua_XoaPhong.Text = "Sửa, Xóa phòng";
            // 
            // cbo_loaiphong_sua
            // 
            this.cbo_loaiphong_sua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loaiphong_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_loaiphong_sua.FormattingEnabled = true;
            this.cbo_loaiphong_sua.Location = new System.Drawing.Point(425, 65);
            this.cbo_loaiphong_sua.Name = "cbo_loaiphong_sua";
            this.cbo_loaiphong_sua.Size = new System.Drawing.Size(193, 29);
            this.cbo_loaiphong_sua.TabIndex = 95;
            // 
            // lbl_KQTinhTrang
            // 
            this.lbl_KQTinhTrang.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_KQTinhTrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQTinhTrang.Location = new System.Drawing.Point(425, 106);
            this.lbl_KQTinhTrang.Name = "lbl_KQTinhTrang";
            this.lbl_KQTinhTrang.Size = new System.Drawing.Size(193, 25);
            this.lbl_KQTinhTrang.TabIndex = 91;
            this.lbl_KQTinhTrang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_KQPhong
            // 
            this.lbl_KQPhong.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_KQPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQPhong.Location = new System.Drawing.Point(425, 28);
            this.lbl_KQPhong.Name = "lbl_KQPhong";
            this.lbl_KQPhong.Size = new System.Drawing.Size(193, 25);
            this.lbl_KQPhong.TabIndex = 90;
            this.lbl_KQPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_maphong_sua
            // 
            this.lbl_maphong_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_maphong_sua.AutoSize = true;
            this.lbl_maphong_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maphong_sua.Location = new System.Drawing.Point(278, 27);
            this.lbl_maphong_sua.Name = "lbl_maphong_sua";
            this.lbl_maphong_sua.Size = new System.Drawing.Size(92, 21);
            this.lbl_maphong_sua.TabIndex = 88;
            this.lbl_maphong_sua.Text = "Mã phòng:";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(751, 45);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(153, 43);
            this.btn_Sua.TabIndex = 85;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_dongia_sua
            // 
            this.txt_dongia_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_dongia_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dongia_sua.Location = new System.Drawing.Point(425, 144);
            this.txt_dongia_sua.Name = "txt_dongia_sua";
            this.txt_dongia_sua.Size = new System.Drawing.Size(193, 29);
            this.txt_dongia_sua.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 82;
            this.label3.Text = "Đơn giá:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 83;
            this.label8.Text = "Tình trạng:";
            // 
            // dgv_phong3
            // 
            this.dgv_phong3.AllowUserToAddRows = false;
            this.dgv_phong3.AllowUserToDeleteRows = false;
            this.dgv_phong3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_phong3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phong3.BackgroundColor = System.Drawing.Color.White;
            this.dgv_phong3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_phong3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phong3.Location = new System.Drawing.Point(7, 207);
            this.dgv_phong3.Name = "dgv_phong3";
            this.dgv_phong3.ReadOnly = true;
            this.dgv_phong3.Size = new System.Drawing.Size(1090, 252);
            this.dgv_phong3.TabIndex = 81;
            this.dgv_phong3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phong3_CellClick);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(278, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 79;
            this.label11.Text = "Loại phòng:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label13.Location = new System.Drawing.Point(38, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 21);
            this.label13.TabIndex = 78;
            this.label13.Text = "SỬA, XÓA PHÒNG:";
            // 
            // KiemLoi
            // 
            this.KiemLoi.ContainerControl = this;
            // 
            // frm_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 511);
            this.Controls.Add(this.tabControl_Phong);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Phong";
            this.Load += new System.EventHandler(this.frm_Phong_Load);
            this.tabControl_Phong.ResumeLayout(false);
            this.tabPage_TimPhong.ResumeLayout(false);
            this.tabPage_TimPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong2)).EndInit();
            this.tabPage_Sua_XoaPhong.ResumeLayout(false);
            this.tabPage_Sua_XoaPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiemLoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Phong;
        private System.Windows.Forms.TabPage tabPage_TimPhong;
        private System.Windows.Forms.TabPage tabPage_Sua_XoaPhong;
        private System.Windows.Forms.TextBox txt_timtinhtrang;
        private System.Windows.Forms.TextBox txt_timphong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_phong2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_maphong_sua;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_dongia_sua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_phong3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ErrorProvider KiemLoi;
        private System.Windows.Forms.TextBox txt_TimLoaiPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_KQPhong;
        private System.Windows.Forms.Label lbl_KQTinhTrang;
        private System.Windows.Forms.ComboBox cbo_loaiphong_sua;
        private System.Windows.Forms.Button btn_Report;
    }
}