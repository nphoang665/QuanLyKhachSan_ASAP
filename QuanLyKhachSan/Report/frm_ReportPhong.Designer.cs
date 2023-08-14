namespace QuanLyKhachSan
{
    partial class frm_ReportPhong
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
            this.rpv_Phong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpv_Phong
            // 
            this.rpv_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_Phong.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.Report_KhachHang.rdlc";
            this.rpv_Phong.Location = new System.Drawing.Point(0, 0);
            this.rpv_Phong.Name = "rpv_Phong";
            this.rpv_Phong.ServerReport.BearerToken = null;
            this.rpv_Phong.Size = new System.Drawing.Size(1040, 523);
            this.rpv_Phong.TabIndex = 1;
            this.rpv_Phong.Load += new System.EventHandler(this.rpv_Phong_Load);
            // 
            // frm_ReportPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 523);
            this.Controls.Add(this.rpv_Phong);
            this.Name = "frm_ReportPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ReportPhong";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_Phong;
    }
}