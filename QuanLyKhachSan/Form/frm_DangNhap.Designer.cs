﻿namespace QuanLyKhachSan
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_Show = new System.Windows.Forms.PictureBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.lbl_QuenMatKhau = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_Hide = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KiemLoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiemLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 657);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 41);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ thống quản lý khách sạn A$AP";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(892, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = " A$AP";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label5.Location = new System.Drawing.Point(793, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hệ thống quản lý khách sạn";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(594, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 489);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.pic_Show);
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Controls.Add(this.btn_DangNhap);
            this.groupBox1.Controls.Add(this.lbl_QuenMatKhau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_TenDangNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pic_Hide);
            this.groupBox1.Location = new System.Drawing.Point(31, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 360);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Nhập";
            // 
            // pic_Show
            // 
            this.pic_Show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_Show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Show.Image = global::QuanLyKhachSan.Properties.Resources.icons8_eye_60;
            this.pic_Show.Location = new System.Drawing.Point(358, 163);
            this.pic_Show.Name = "pic_Show";
            this.pic_Show.Size = new System.Drawing.Size(32, 23);
            this.pic_Show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Show.TabIndex = 4;
            this.pic_Show.TabStop = false;
            this.pic_Show.Click += new System.EventHandler(this.pic_Show_Click);
            this.pic_Show.MouseHover += new System.EventHandler(this.pic_Show_MouseHover);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MatKhau.Location = new System.Drawing.Point(94, 163);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(265, 23);
            this.txt_MatKhau.TabIndex = 2;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangNhap.FlatAppearance.BorderSize = 0;
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.Location = new System.Drawing.Point(94, 256);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(296, 47);
            this.btn_DangNhap.TabIndex = 3;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // lbl_QuenMatKhau
            // 
            this.lbl_QuenMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_QuenMatKhau.AutoSize = true;
            this.lbl_QuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_QuenMatKhau.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuenMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.lbl_QuenMatKhau.Location = new System.Drawing.Point(173, 209);
            this.lbl_QuenMatKhau.Name = "lbl_QuenMatKhau";
            this.lbl_QuenMatKhau.Size = new System.Drawing.Size(128, 18);
            this.lbl_QuenMatKhau.TabIndex = 0;
            this.lbl_QuenMatKhau.Text = "Quên mật khẩu?";
            this.lbl_QuenMatKhau.Click += new System.EventHandler(this.lbl_QuenMatKhau_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenDangNhap.Location = new System.Drawing.Point(94, 89);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(296, 23);
            this.txt_TenDangNhap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // pic_Hide
            // 
            this.pic_Hide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_Hide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Hide.Image = global::QuanLyKhachSan.Properties.Resources._3844443_disable_eye_inactive_see_show_view_watch_110296;
            this.pic_Hide.Location = new System.Drawing.Point(358, 163);
            this.pic_Hide.Name = "pic_Hide";
            this.pic_Hide.Size = new System.Drawing.Size(32, 23);
            this.pic_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Hide.TabIndex = 4;
            this.pic_Hide.TabStop = false;
            this.pic_Hide.Click += new System.EventHandler(this.pic_Hide_Click);
            this.pic_Hide.MouseHover += new System.EventHandler(this.pic_Hide_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::QuanLyKhachSan.Properties.Resources.hotel_building_isolated_city_street_vector_illustration_flat_cartoon_101884_680;
            this.pictureBox1.Location = new System.Drawing.Point(652, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // KiemLoi
            // 
            this.KiemLoi.ContainerControl = this;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 698);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiemLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_Show;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label lbl_QuenMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_Hide;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider KiemLoi;
    }
}

