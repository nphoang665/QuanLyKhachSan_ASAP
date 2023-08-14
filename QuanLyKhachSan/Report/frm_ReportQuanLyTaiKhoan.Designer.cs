namespace QuanLyKhachSan
{
    partial class frm_ReportQuanLyTaiKhoan
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
            this.rpv_quanlytaikhoan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpv_quanlytaikhoan
            // 
            this.rpv_quanlytaikhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_quanlytaikhoan.Location = new System.Drawing.Point(0, 0);
            this.rpv_quanlytaikhoan.Name = "rpv_quanlytaikhoan";
            this.rpv_quanlytaikhoan.ServerReport.BearerToken = null;
            this.rpv_quanlytaikhoan.Size = new System.Drawing.Size(1018, 566);
            this.rpv_quanlytaikhoan.TabIndex = 0;
            // 
            // frm_ReportQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 566);
            this.Controls.Add(this.rpv_quanlytaikhoan);
            this.Name = "frm_ReportQuanLyTaiKhoan";
            this.Text = "Report Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frm_ReportQuanLyTaiKhoan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_quanlytaikhoan;
    }
}