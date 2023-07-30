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
            this.tabControl_Phong = new System.Windows.Forms.TabControl();
            this.tabPage_ThemPhong = new System.Windows.Forms.TabPage();
            this.cbo_TinhTrang = new System.Windows.Forms.ComboBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_LoaiPhong = new System.Windows.Forms.TextBox();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_DanhSachPhong = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_TimPhong = new System.Windows.Forms.TabPage();
            this.cbo_MaPhong = new System.Windows.Forms.ComboBox();
            this.cbo_TinhTrang1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_DanhSachPhong1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage_Sua_XoaPhong = new System.Windows.Forms.TabPage();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.cbo_Tinhtrang2 = new System.Windows.Forms.ComboBox();
            this.txt_DonGia2 = new System.Windows.Forms.TextBox();
            this.txt_LoaiPhong2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_DanhSachPhong2 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl_Phong.SuspendLayout();
            this.tabPage_ThemPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhong)).BeginInit();
            this.tabPage_TimPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhong1)).BeginInit();
            this.tabPage_Sua_XoaPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhong2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Phong
            // 
            this.tabControl_Phong.Controls.Add(this.tabPage_ThemPhong);
            this.tabControl_Phong.Controls.Add(this.tabPage_TimPhong);
            this.tabControl_Phong.Controls.Add(this.tabPage_Sua_XoaPhong);
            this.tabControl_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Phong.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Phong.Name = "tabControl_Phong";
            this.tabControl_Phong.SelectedIndex = 0;
            this.tabControl_Phong.Size = new System.Drawing.Size(1114, 511);
            this.tabControl_Phong.TabIndex = 1;
            // 
            // tabPage_ThemPhong
            // 
            this.tabPage_ThemPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_ThemPhong.Controls.Add(this.cbo_TinhTrang);
            this.tabPage_ThemPhong.Controls.Add(this.txt_DonGia);
            this.tabPage_ThemPhong.Controls.Add(this.txt_LoaiPhong);
            this.tabPage_ThemPhong.Controls.Add(this.txt_MaPhong);
            this.tabPage_ThemPhong.Controls.Add(this.label4);
            this.tabPage_ThemPhong.Controls.Add(this.label5);
            this.tabPage_ThemPhong.Controls.Add(this.dgv_DanhSachPhong);
            this.tabPage_ThemPhong.Controls.Add(this.btn_Them);
            this.tabPage_ThemPhong.Controls.Add(this.label6);
            this.tabPage_ThemPhong.Controls.Add(this.label2);
            this.tabPage_ThemPhong.Controls.Add(this.label1);
            this.tabPage_ThemPhong.Location = new System.Drawing.Point(4, 26);
            this.tabPage_ThemPhong.Name = "tabPage_ThemPhong";
            this.tabPage_ThemPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThemPhong.Size = new System.Drawing.Size(1106, 481);
            this.tabPage_ThemPhong.TabIndex = 0;
            this.tabPage_ThemPhong.Text = "Thêm phòng";
            this.tabPage_ThemPhong.UseVisualStyleBackColor = true;
            // 
            // cbo_TinhTrang
            // 
            this.cbo_TinhTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_TinhTrang.FormattingEnabled = true;
            this.cbo_TinhTrang.Location = new System.Drawing.Point(657, 73);
            this.cbo_TinhTrang.Name = "cbo_TinhTrang";
            this.cbo_TinhTrang.Size = new System.Drawing.Size(193, 25);
            this.cbo_TinhTrang.TabIndex = 6;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DonGia.Location = new System.Drawing.Point(657, 110);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(193, 25);
            this.txt_DonGia.TabIndex = 8;
            // 
            // txt_LoaiPhong
            // 
            this.txt_LoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_LoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LoaiPhong.Location = new System.Drawing.Point(204, 110);
            this.txt_LoaiPhong.Name = "txt_LoaiPhong";
            this.txt_LoaiPhong.Size = new System.Drawing.Size(193, 25);
            this.txt_LoaiPhong.TabIndex = 4;
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaPhong.Location = new System.Drawing.Point(204, 73);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(193, 25);
            this.txt_MaPhong.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(510, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tình trạng:";
            // 
            // dgv_DanhSachPhong
            // 
            this.dgv_DanhSachPhong.AllowUserToAddRows = false;
            this.dgv_DanhSachPhong.AllowUserToDeleteRows = false;
            this.dgv_DanhSachPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachPhong.Location = new System.Drawing.Point(49, 224);
            this.dgv_DanhSachPhong.Name = "dgv_DanhSachPhong";
            this.dgv_DanhSachPhong.ReadOnly = true;
            this.dgv_DanhSachPhong.Size = new System.Drawing.Size(1005, 235);
            this.dgv_DanhSachPhong.TabIndex = 10;
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
            this.btn_Them.Location = new System.Drawing.Point(926, 78);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(129, 43);
            this.btn_Them.TabIndex = 9;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Loại phòng:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM PHÒNG:";
            // 
            // tabPage_TimPhong
            // 
            this.tabPage_TimPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_TimPhong.Controls.Add(this.cbo_MaPhong);
            this.tabPage_TimPhong.Controls.Add(this.cbo_TinhTrang1);
            this.tabPage_TimPhong.Controls.Add(this.label7);
            this.tabPage_TimPhong.Controls.Add(this.dgv_DanhSachPhong1);
            this.tabPage_TimPhong.Controls.Add(this.label9);
            this.tabPage_TimPhong.Controls.Add(this.label10);
            this.tabPage_TimPhong.Location = new System.Drawing.Point(4, 26);
            this.tabPage_TimPhong.Name = "tabPage_TimPhong";
            this.tabPage_TimPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TimPhong.Size = new System.Drawing.Size(1106, 481);
            this.tabPage_TimPhong.TabIndex = 1;
            this.tabPage_TimPhong.Text = "Tìm phòng";
            this.tabPage_TimPhong.UseVisualStyleBackColor = true;
            // 
            // cbo_MaPhong
            // 
            this.cbo_MaPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_MaPhong.FormattingEnabled = true;
            this.cbo_MaPhong.Location = new System.Drawing.Point(516, 62);
            this.cbo_MaPhong.Name = "cbo_MaPhong";
            this.cbo_MaPhong.Size = new System.Drawing.Size(193, 25);
            this.cbo_MaPhong.TabIndex = 2;
            // 
            // cbo_TinhTrang1
            // 
            this.cbo_TinhTrang1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_TinhTrang1.FormattingEnabled = true;
            this.cbo_TinhTrang1.Location = new System.Drawing.Point(516, 109);
            this.cbo_TinhTrang1.Name = "cbo_TinhTrang1";
            this.cbo_TinhTrang1.Size = new System.Drawing.Size(193, 25);
            this.cbo_TinhTrang1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(395, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tình trạng:";
            // 
            // dgv_DanhSachPhong1
            // 
            this.dgv_DanhSachPhong1.AllowUserToAddRows = false;
            this.dgv_DanhSachPhong1.AllowUserToDeleteRows = false;
            this.dgv_DanhSachPhong1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachPhong1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachPhong1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachPhong1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachPhong1.Location = new System.Drawing.Point(49, 224);
            this.dgv_DanhSachPhong1.Name = "dgv_DanhSachPhong1";
            this.dgv_DanhSachPhong1.ReadOnly = true;
            this.dgv_DanhSachPhong1.Size = new System.Drawing.Size(1005, 235);
            this.dgv_DanhSachPhong1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(395, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã phòng:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label10.Location = new System.Drawing.Point(39, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "TÌM PHÒNG:";
            // 
            // tabPage_Sua_XoaPhong
            // 
            this.tabPage_Sua_XoaPhong.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Sua_XoaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_Sua_XoaPhong.Controls.Add(this.btn_Xoa);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.btn_Sua);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.cbo_Tinhtrang2);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.txt_DonGia2);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.txt_LoaiPhong2);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.label3);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.label8);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.dgv_DanhSachPhong2);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.label11);
            this.tabPage_Sua_XoaPhong.Controls.Add(this.label13);
            this.tabPage_Sua_XoaPhong.Location = new System.Drawing.Point(4, 26);
            this.tabPage_Sua_XoaPhong.Name = "tabPage_Sua_XoaPhong";
            this.tabPage_Sua_XoaPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Sua_XoaPhong.Size = new System.Drawing.Size(1106, 481);
            this.tabPage_Sua_XoaPhong.TabIndex = 2;
            this.tabPage_Sua_XoaPhong.Text = "Sửa, Xóa phòng";
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
            this.btn_Xoa.Location = new System.Drawing.Point(740, 116);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(146, 43);
            this.btn_Xoa.TabIndex = 8;
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
            this.btn_Sua.Location = new System.Drawing.Point(740, 42);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(146, 43);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // cbo_Tinhtrang2
            // 
            this.cbo_Tinhtrang2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Tinhtrang2.FormattingEnabled = true;
            this.cbo_Tinhtrang2.Location = new System.Drawing.Point(404, 93);
            this.cbo_Tinhtrang2.Name = "cbo_Tinhtrang2";
            this.cbo_Tinhtrang2.Size = new System.Drawing.Size(193, 25);
            this.cbo_Tinhtrang2.TabIndex = 4;
            // 
            // txt_DonGia2
            // 
            this.txt_DonGia2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DonGia2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DonGia2.Location = new System.Drawing.Point(404, 130);
            this.txt_DonGia2.Name = "txt_DonGia2";
            this.txt_DonGia2.Size = new System.Drawing.Size(193, 25);
            this.txt_DonGia2.TabIndex = 6;
            // 
            // txt_LoaiPhong2
            // 
            this.txt_LoaiPhong2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_LoaiPhong2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LoaiPhong2.Location = new System.Drawing.Point(404, 53);
            this.txt_LoaiPhong2.Name = "txt_LoaiPhong2";
            this.txt_LoaiPhong2.Size = new System.Drawing.Size(193, 25);
            this.txt_LoaiPhong2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tình trạng:";
            // 
            // dgv_DanhSachPhong2
            // 
            this.dgv_DanhSachPhong2.AllowUserToAddRows = false;
            this.dgv_DanhSachPhong2.AllowUserToDeleteRows = false;
            this.dgv_DanhSachPhong2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachPhong2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachPhong2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachPhong2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachPhong2.Location = new System.Drawing.Point(49, 224);
            this.dgv_DanhSachPhong2.Name = "dgv_DanhSachPhong2";
            this.dgv_DanhSachPhong2.ReadOnly = true;
            this.dgv_DanhSachPhong2.Size = new System.Drawing.Size(1005, 235);
            this.dgv_DanhSachPhong2.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(257, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Loại phòng:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label13.Location = new System.Drawing.Point(39, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "SỬA, XÓA PHÒNG:";
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Phong";
            this.tabControl_Phong.ResumeLayout(false);
            this.tabPage_ThemPhong.ResumeLayout(false);
            this.tabPage_ThemPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhong)).EndInit();
            this.tabPage_TimPhong.ResumeLayout(false);
            this.tabPage_TimPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhong1)).EndInit();
            this.tabPage_Sua_XoaPhong.ResumeLayout(false);
            this.tabPage_Sua_XoaPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachPhong2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Phong;
        private System.Windows.Forms.TabPage tabPage_ThemPhong;
        private System.Windows.Forms.ComboBox cbo_TinhTrang;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_LoaiPhong;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_DanhSachPhong;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage_TimPhong;
        private System.Windows.Forms.ComboBox cbo_MaPhong;
        private System.Windows.Forms.ComboBox cbo_TinhTrang1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_DanhSachPhong1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage_Sua_XoaPhong;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.ComboBox cbo_Tinhtrang2;
        private System.Windows.Forms.TextBox txt_DonGia2;
        private System.Windows.Forms.TextBox txt_LoaiPhong2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_DanhSachPhong2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}