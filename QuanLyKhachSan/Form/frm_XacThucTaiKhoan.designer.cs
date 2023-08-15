namespace QuanLyKhachSan
{
    partial class frm_XacThucTaiKhoan
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
            this.dgv_tkChuaXacThuc = new System.Windows.Forms.DataGridView();
            this.dgv_TaiKhoanDaDuocXacThuc = new System.Windows.Forms.DataGridView();
            this.btn_DongY = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_tkchuaxacthuc = new System.Windows.Forms.Label();
            this.lbl_tk_xacthuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkChuaXacThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoanDaDuocXacThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tkChuaXacThuc
            // 
            this.dgv_tkChuaXacThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tkChuaXacThuc.Location = new System.Drawing.Point(12, 158);
            this.dgv_tkChuaXacThuc.Name = "dgv_tkChuaXacThuc";
            this.dgv_tkChuaXacThuc.ReadOnly = true;
            this.dgv_tkChuaXacThuc.Size = new System.Drawing.Size(335, 215);
            this.dgv_tkChuaXacThuc.TabIndex = 0;
            this.dgv_tkChuaXacThuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tkChuaXacThuc_CellClick);
            this.dgv_tkChuaXacThuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tkChuaXacThuc_CellContentClick);
            this.dgv_tkChuaXacThuc.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_tkChuaXacThuc_DataBindingComplete);
            // 
            // dgv_TaiKhoanDaDuocXacThuc
            // 
            this.dgv_TaiKhoanDaDuocXacThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaiKhoanDaDuocXacThuc.Enabled = false;
            this.dgv_TaiKhoanDaDuocXacThuc.Location = new System.Drawing.Point(479, 158);
            this.dgv_TaiKhoanDaDuocXacThuc.Name = "dgv_TaiKhoanDaDuocXacThuc";
            this.dgv_TaiKhoanDaDuocXacThuc.ReadOnly = true;
            this.dgv_TaiKhoanDaDuocXacThuc.Size = new System.Drawing.Size(332, 215);
            this.dgv_TaiKhoanDaDuocXacThuc.TabIndex = 1;
            // 
            // btn_DongY
            // 
            this.btn_DongY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_DongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DongY.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_DongY.Location = new System.Drawing.Point(371, 158);
            this.btn_DongY.Name = "btn_DongY";
            this.btn_DongY.Size = new System.Drawing.Size(102, 85);
            this.btn_DongY.TabIndex = 5;
            this.btn_DongY.Text = "Đồng Ý";
            this.btn_DongY.UseVisualStyleBackColor = false;
            this.btn_DongY.Click += new System.EventHandler(this.btn_DongY_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Red;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(371, 288);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(102, 85);
            this.btn_Huy.TabIndex = 6;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.lbl_title.Location = new System.Drawing.Point(272, 57);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(308, 37);
            this.lbl_title.TabIndex = 26;
            this.lbl_title.Text = "XÁC THỰC TÀI KHOẢN";
            // 
            // lbl_tkchuaxacthuc
            // 
            this.lbl_tkchuaxacthuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tkchuaxacthuc.AutoSize = true;
            this.lbl_tkchuaxacthuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tkchuaxacthuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.lbl_tkchuaxacthuc.Location = new System.Drawing.Point(75, 135);
            this.lbl_tkchuaxacthuc.Name = "lbl_tkchuaxacthuc";
            this.lbl_tkchuaxacthuc.Size = new System.Drawing.Size(216, 20);
            this.lbl_tkchuaxacthuc.TabIndex = 27;
            this.lbl_tkchuaxacthuc.Text = "Tài khoản chưa được xác thực";
            // 
            // lbl_tk_xacthuc
            // 
            this.lbl_tk_xacthuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tk_xacthuc.AutoSize = true;
            this.lbl_tk_xacthuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tk_xacthuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.lbl_tk_xacthuc.Location = new System.Drawing.Point(556, 135);
            this.lbl_tk_xacthuc.Name = "lbl_tk_xacthuc";
            this.lbl_tk_xacthuc.Size = new System.Drawing.Size(199, 20);
            this.lbl_tk_xacthuc.TabIndex = 28;
            this.lbl_tk_xacthuc.Text = "Tài khoản đã được xác thực";
            // 
            // frm_XacThucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 462);
            this.Controls.Add(this.lbl_tk_xacthuc);
            this.Controls.Add(this.lbl_tkchuaxacthuc);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_DongY);
            this.Controls.Add(this.dgv_TaiKhoanDaDuocXacThuc);
            this.Controls.Add(this.dgv_tkChuaXacThuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_XacThucTaiKhoan";
            this.Text = "frm_XacThucTaiKhoan";
            this.Load += new System.EventHandler(this.frm_XacThucTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkChuaXacThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoanDaDuocXacThuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tkChuaXacThuc;
        private System.Windows.Forms.DataGridView dgv_TaiKhoanDaDuocXacThuc;
        private System.Windows.Forms.Button btn_DongY;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_tkchuaxacthuc;
        private System.Windows.Forms.Label lbl_tk_xacthuc;
    }
}