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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DongY = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkChuaXacThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoanDaDuocXacThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tkChuaXacThuc
            // 
            this.dgv_tkChuaXacThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tkChuaXacThuc.Location = new System.Drawing.Point(12, 162);
            this.dgv_tkChuaXacThuc.Name = "dgv_tkChuaXacThuc";
            this.dgv_tkChuaXacThuc.ReadOnly = true;
            this.dgv_tkChuaXacThuc.Size = new System.Drawing.Size(335, 215);
            this.dgv_tkChuaXacThuc.TabIndex = 0;
            this.dgv_tkChuaXacThuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tkChuaXacThuc_CellClick);
            // 
            // dgv_TaiKhoanDaDuocXacThuc
            // 
            this.dgv_TaiKhoanDaDuocXacThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaiKhoanDaDuocXacThuc.Location = new System.Drawing.Point(479, 162);
            this.dgv_TaiKhoanDaDuocXacThuc.Name = "dgv_TaiKhoanDaDuocXacThuc";
            this.dgv_TaiKhoanDaDuocXacThuc.ReadOnly = true;
            this.dgv_TaiKhoanDaDuocXacThuc.Size = new System.Drawing.Size(332, 215);
            this.dgv_TaiKhoanDaDuocXacThuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "XÁC THỰC TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài khoản chưa được xác thực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(518, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tài khoản đã được xác thực";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_DongY
            // 
            this.btn_DongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DongY.Location = new System.Drawing.Point(362, 162);
            this.btn_DongY.Name = "btn_DongY";
            this.btn_DongY.Size = new System.Drawing.Size(102, 85);
            this.btn_DongY.TabIndex = 5;
            this.btn_DongY.Text = "Đồng Ý";
            this.btn_DongY.UseVisualStyleBackColor = true;
            this.btn_DongY.Click += new System.EventHandler(this.btn_DongY_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(362, 292);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(102, 85);
            this.btn_Huy.TabIndex = 6;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // frm_XacThucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 462);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_DongY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DongY;
        private System.Windows.Forms.Button btn_Huy;
    }
}