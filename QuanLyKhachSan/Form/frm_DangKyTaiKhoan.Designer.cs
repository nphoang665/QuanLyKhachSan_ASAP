﻿namespace QuanLyKhachSan
{
    partial class frm_DangKyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangKyTaiKhoan));
            this.KiemLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_Show = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.lbl_mk = new System.Windows.Forms.Label();
            this.lbl_Tendn = new System.Windows.Forms.Label();
            this.pic_Hide = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MatKhau = new CustormTextbox.RJConTrol.RJTextBox();
            this.txt_TenDangNhap = new CustormTextbox.RJConTrol.RJTextBox();
            this.txt_cccd = new CustormTextbox.RJConTrol.RJTextBox();
            this.lbl_mk_chkerr = new System.Windows.Forms.Label();
            this.lbl_tk_checkerr = new System.Windows.Forms.Label();
            this.lbl_cccd_chkerr = new System.Windows.Forms.Label();
            this.lbl_DangNhap = new System.Windows.Forms.Label();
            this.lbl_cccd = new System.Windows.Forms.Label();
            this.pnl_keo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_khachsan = new System.Windows.Forms.PictureBox();
            this.lbl_notice_successfull = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KiemLoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hide)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnl_keo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_khachsan)).BeginInit();
            this.SuspendLayout();
            // 
            // KiemLoi
            // 
            this.KiemLoi.ContainerControl = this;
            // 
            // pic_Show
            // 
            this.pic_Show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Show.Image = global::QuanLyKhachSan.Properties.Resources.icons8_eye_60;
            this.pic_Show.Location = new System.Drawing.Point(390, 212);
            this.pic_Show.Name = "pic_Show";
            this.pic_Show.Size = new System.Drawing.Size(32, 31);
            this.pic_Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Show.TabIndex = 4;
            this.pic_Show.TabStop = false;
            this.pic_Show.Click += new System.EventHandler(this.pic_Show_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(571, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 489);
            this.panel2.TabIndex = 10;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_DangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangKy.FlatAppearance.BorderSize = 0;
            this.btn_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangKy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.White;
            this.btn_DangKy.Location = new System.Drawing.Point(94, 268);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(296, 47);
            this.btn_DangKy.TabIndex = 3;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // lbl_mk
            // 
            this.lbl_mk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_mk.AutoSize = true;
            this.lbl_mk.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mk.Location = new System.Drawing.Point(91, 190);
            this.lbl_mk.Name = "lbl_mk";
            this.lbl_mk.Size = new System.Drawing.Size(79, 18);
            this.lbl_mk.TabIndex = 0;
            this.lbl_mk.Text = "Mật khẩu:";
            // 
            // lbl_Tendn
            // 
            this.lbl_Tendn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Tendn.AutoSize = true;
            this.lbl_Tendn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tendn.Location = new System.Drawing.Point(91, 118);
            this.lbl_Tendn.Name = "lbl_Tendn";
            this.lbl_Tendn.Size = new System.Drawing.Size(121, 18);
            this.lbl_Tendn.TabIndex = 0;
            this.lbl_Tendn.Text = "Tên đăng nhập:";
            // 
            // pic_Hide
            // 
            this.pic_Hide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Hide.Image = global::QuanLyKhachSan.Properties.Resources._3844443_disable_eye_inactive_see_show_view_watch_110296;
            this.pic_Hide.Location = new System.Drawing.Point(390, 212);
            this.pic_Hide.Name = "pic_Hide";
            this.pic_Hide.Size = new System.Drawing.Size(32, 31);
            this.pic_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Hide.TabIndex = 4;
            this.pic_Hide.TabStop = false;
            this.pic_Hide.Click += new System.EventHandler(this.pic_Hide_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(3, 14);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(171, 13);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Hệ thống quản lý khách sạn A$AP";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Controls.Add(this.txt_TenDangNhap);
            this.groupBox1.Controls.Add(this.txt_cccd);
            this.groupBox1.Controls.Add(this.lbl_mk_chkerr);
            this.groupBox1.Controls.Add(this.lbl_tk_checkerr);
            this.groupBox1.Controls.Add(this.lbl_cccd_chkerr);
            this.groupBox1.Controls.Add(this.lbl_DangNhap);
            this.groupBox1.Controls.Add(this.lbl_cccd);
            this.groupBox1.Controls.Add(this.pic_Show);
            this.groupBox1.Controls.Add(this.btn_DangKy);
            this.groupBox1.Controls.Add(this.lbl_mk);
            this.groupBox1.Controls.Add(this.lbl_Tendn);
            this.groupBox1.Controls.Add(this.pic_Hide);
            this.groupBox1.Location = new System.Drawing.Point(44, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 360);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Ký";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_MatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MatKhau.BorderSize = 2;
            this.txt_MatKhau.ForeColor = System.Drawing.Color.Black;
            this.txt_MatKhau.Location = new System.Drawing.Point(94, 212);
            this.txt_MatKhau.Multiline = false;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Padding = new System.Windows.Forms.Padding(7);
            this.txt_MatKhau.PasswordChar = false;
            this.txt_MatKhau.Size = new System.Drawing.Size(296, 31);
            this.txt_MatKhau.TabIndex = 13;
            this.txt_MatKhau.Texts = "";
            this.txt_MatKhau.UnderLineStyle = true;
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_TenDangNhap.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenDangNhap.BorderSize = 2;
            this.txt_TenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.txt_TenDangNhap.Location = new System.Drawing.Point(96, 139);
            this.txt_TenDangNhap.Multiline = false;
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Padding = new System.Windows.Forms.Padding(7);
            this.txt_TenDangNhap.PasswordChar = false;
            this.txt_TenDangNhap.Size = new System.Drawing.Size(294, 31);
            this.txt_TenDangNhap.TabIndex = 12;
            this.txt_TenDangNhap.Texts = "";
            this.txt_TenDangNhap.UnderLineStyle = true;
            // 
            // txt_cccd
            // 
            this.txt_cccd.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_cccd.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_cccd.BorderSize = 2;
            this.txt_cccd.ForeColor = System.Drawing.Color.Black;
            this.txt_cccd.Location = new System.Drawing.Point(96, 57);
            this.txt_cccd.Multiline = false;
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Padding = new System.Windows.Forms.Padding(7);
            this.txt_cccd.PasswordChar = false;
            this.txt_cccd.Size = new System.Drawing.Size(294, 31);
            this.txt_cccd.TabIndex = 11;
            this.txt_cccd.Texts = "";
            this.txt_cccd.UnderLineStyle = true;
            // 
            // lbl_mk_chkerr
            // 
            this.lbl_mk_chkerr.AutoSize = true;
            this.lbl_mk_chkerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mk_chkerr.ForeColor = System.Drawing.Color.Red;
            this.lbl_mk_chkerr.Location = new System.Drawing.Point(93, 246);
            this.lbl_mk_chkerr.Name = "lbl_mk_chkerr";
            this.lbl_mk_chkerr.Size = new System.Drawing.Size(11, 13);
            this.lbl_mk_chkerr.TabIndex = 10;
            this.lbl_mk_chkerr.Text = "*";
            this.lbl_mk_chkerr.Visible = false;
            // 
            // lbl_tk_checkerr
            // 
            this.lbl_tk_checkerr.AutoSize = true;
            this.lbl_tk_checkerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tk_checkerr.ForeColor = System.Drawing.Color.Red;
            this.lbl_tk_checkerr.Location = new System.Drawing.Point(93, 173);
            this.lbl_tk_checkerr.Name = "lbl_tk_checkerr";
            this.lbl_tk_checkerr.Size = new System.Drawing.Size(11, 13);
            this.lbl_tk_checkerr.TabIndex = 9;
            this.lbl_tk_checkerr.Text = "*";
            this.lbl_tk_checkerr.Visible = false;
            // 
            // lbl_cccd_chkerr
            // 
            this.lbl_cccd_chkerr.AutoSize = true;
            this.lbl_cccd_chkerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cccd_chkerr.ForeColor = System.Drawing.Color.Red;
            this.lbl_cccd_chkerr.Location = new System.Drawing.Point(93, 97);
            this.lbl_cccd_chkerr.Name = "lbl_cccd_chkerr";
            this.lbl_cccd_chkerr.Size = new System.Drawing.Size(11, 13);
            this.lbl_cccd_chkerr.TabIndex = 8;
            this.lbl_cccd_chkerr.Text = "*";
            this.lbl_cccd_chkerr.Visible = false;
            // 
            // lbl_DangNhap
            // 
            this.lbl_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DangNhap.AutoSize = true;
            this.lbl_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_DangNhap.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.lbl_DangNhap.Location = new System.Drawing.Point(202, 335);
            this.lbl_DangNhap.Name = "lbl_DangNhap";
            this.lbl_DangNhap.Size = new System.Drawing.Size(89, 18);
            this.lbl_DangNhap.TabIndex = 7;
            this.lbl_DangNhap.Text = "Đăng nhập";
            this.lbl_DangNhap.Click += new System.EventHandler(this.lbl_DangNhap_Click);
            // 
            // lbl_cccd
            // 
            this.lbl_cccd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_cccd.AutoSize = true;
            this.lbl_cccd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cccd.Location = new System.Drawing.Point(91, 35);
            this.lbl_cccd.Name = "lbl_cccd";
            this.lbl_cccd.Size = new System.Drawing.Size(158, 18);
            this.lbl_cccd.TabIndex = 5;
            this.lbl_cccd.Text = "Căn cước công dân";
            // 
            // pnl_keo
            // 
            this.pnl_keo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_keo.Controls.Add(this.lbl_title);
            this.pnl_keo.Location = new System.Drawing.Point(0, 545);
            this.pnl_keo.Name = "pnl_keo";
            this.pnl_keo.Size = new System.Drawing.Size(1132, 41);
            this.pnl_keo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(1141, 686);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = " A$AP";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label5.Location = new System.Drawing.Point(1042, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hệ thống quản lý khách sạn";
            // 
            // pic_khachsan
            // 
            this.pic_khachsan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_khachsan.Image = global::QuanLyKhachSan.Properties.Resources.hotel_building_isolated_city_street_vector_illustration_flat_cartoon_101884_680;
            this.pic_khachsan.Location = new System.Drawing.Point(615, 93);
            this.pic_khachsan.Name = "pic_khachsan";
            this.pic_khachsan.Size = new System.Drawing.Size(517, 390);
            this.pic_khachsan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_khachsan.TabIndex = 12;
            this.pic_khachsan.TabStop = false;
            // 
            // lbl_notice_successfull
            // 
            this.lbl_notice_successfull.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_notice_successfull.AutoSize = true;
            this.lbl_notice_successfull.Font = new System.Drawing.Font("Segoe Script", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notice_successfull.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_notice_successfull.Location = new System.Drawing.Point(65, 478);
            this.lbl_notice_successfull.Name = "lbl_notice_successfull";
            this.lbl_notice_successfull.Size = new System.Drawing.Size(459, 64);
            this.lbl_notice_successfull.TabIndex = 15;
            this.lbl_notice_successfull.Text = "Đăng ký thành công";
            this.lbl_notice_successfull.Visible = false;
            // 
            // frm_DangKyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 586);
            this.Controls.Add(this.lbl_notice_successfull);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pic_khachsan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_keo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DangKyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký Tài khoản";
            this.Load += new System.EventHandler(this.frm_DangKyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KiemLoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hide)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_keo.ResumeLayout(false);
            this.pnl_keo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_khachsan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider KiemLoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_Show;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Label lbl_mk;
        private System.Windows.Forms.Label lbl_Tendn;
        private System.Windows.Forms.PictureBox pic_Hide;
        private System.Windows.Forms.Panel pnl_keo;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic_khachsan;
        private System.Windows.Forms.Label lbl_cccd;
        private System.Windows.Forms.Label lbl_DangNhap;
        private System.Windows.Forms.Label lbl_tk_checkerr;
        private System.Windows.Forms.Label lbl_cccd_chkerr;
        private System.Windows.Forms.Label lbl_mk_chkerr;
        private System.Windows.Forms.Label lbl_notice_successfull;
        private CustormTextbox.RJConTrol.RJTextBox txt_cccd;
        private CustormTextbox.RJConTrol.RJTextBox txt_TenDangNhap;
        private CustormTextbox.RJConTrol.RJTextBox txt_MatKhau;
    }
}