namespace QuanLyKhachSan
{
    partial class frm_ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_doanhthu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_nam = new System.Windows.Forms.Label();
            this.lbl_thang = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_ngaybatdau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_doanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_doanhthu
            // 
            this.chart_doanhthu.BorderlineColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea2.Name = "ChartArea1";
            this.chart_doanhthu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_doanhthu.Legends.Add(legend2);
            this.chart_doanhthu.Location = new System.Drawing.Point(62, 63);
            this.chart_doanhthu.Margin = new System.Windows.Forms.Padding(4);
            this.chart_doanhthu.Name = "chart_doanhthu";
            this.chart_doanhthu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_doanhthu.Series.Add(series2);
            this.chart_doanhthu.Size = new System.Drawing.Size(1004, 424);
            this.chart_doanhthu.TabIndex = 0;
            this.chart_doanhthu.Text = "chart1";
            // 
            // lbl_nam
            // 
            this.lbl_nam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nam.AutoSize = true;
            this.lbl_nam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nam.Location = new System.Drawing.Point(66, -131);
            this.lbl_nam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nam.Name = "lbl_nam";
            this.lbl_nam.Size = new System.Drawing.Size(47, 20);
            this.lbl_nam.TabIndex = 8;
            this.lbl_nam.Text = "Năm:";
            // 
            // lbl_thang
            // 
            this.lbl_thang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_thang.AutoSize = true;
            this.lbl_thang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thang.Location = new System.Drawing.Point(518, -131);
            this.lbl_thang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_thang.Name = "lbl_thang";
            this.lbl_thang.Size = new System.Drawing.Size(57, 20);
            this.lbl_thang.TabIndex = 9;
            this.lbl_thang.Text = "Tháng:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(417, 30);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 25);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_ngaybatdau
            // 
            this.lbl_ngaybatdau.AutoSize = true;
            this.lbl_ngaybatdau.Location = new System.Drawing.Point(324, 36);
            this.lbl_ngaybatdau.Name = "lbl_ngaybatdau";
            this.lbl_ngaybatdau.Size = new System.Drawing.Size(56, 17);
            this.lbl_ngaybatdau.TabIndex = 12;
            this.lbl_ngaybatdau.Text = "Bắt Đầu:";
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 511);
            this.Controls.Add(this.lbl_ngaybatdau);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_thang);
            this.Controls.Add(this.lbl_nam);
            this.Controls.Add(this.chart_doanhthu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ThongKe";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.frm_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_doanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_doanhthu;
        private System.Windows.Forms.Label lbl_nam;
        private System.Windows.Forms.Label lbl_thang;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_ngaybatdau;
    }
}