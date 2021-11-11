
namespace ProductOrderRP
{
    partial class Lab052
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab052));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoPhieuGiaoHang = new System.Windows.Forms.RadioButton();
            this.cbMaGH = new System.Windows.Forms.ComboBox();
            this.rdoBaoGia = new System.Windows.Forms.RadioButton();
            this.btReport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProductOrderRP.Report.ReportDonHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 139);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1050, 580);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPhieuGiaoHang);
            this.groupBox1.Controls.Add(this.cbMaGH);
            this.groupBox1.Controls.Add(this.rdoBaoGia);
            this.groupBox1.Location = new System.Drawing.Point(238, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn loại xuất thông tin";
            // 
            // rdoPhieuGiaoHang
            // 
            this.rdoPhieuGiaoHang.AutoSize = true;
            this.rdoPhieuGiaoHang.Location = new System.Drawing.Point(102, 60);
            this.rdoPhieuGiaoHang.Name = "rdoPhieuGiaoHang";
            this.rdoPhieuGiaoHang.Size = new System.Drawing.Size(167, 21);
            this.rdoPhieuGiaoHang.TabIndex = 2;
            this.rdoPhieuGiaoHang.TabStop = true;
            this.rdoPhieuGiaoHang.Text = "Xem phiếu giao hàng:";
            this.rdoPhieuGiaoHang.UseVisualStyleBackColor = true;
            this.rdoPhieuGiaoHang.CheckedChanged += new System.EventHandler(this.rdoPhieuGiaoHang_CheckedChanged);
            // 
            // cbMaGH
            // 
            this.cbMaGH.FormattingEnabled = true;
            this.cbMaGH.Location = new System.Drawing.Point(275, 60);
            this.cbMaGH.Name = "cbMaGH";
            this.cbMaGH.Size = new System.Drawing.Size(142, 24);
            this.cbMaGH.TabIndex = 1;
            // 
            // rdoBaoGia
            // 
            this.rdoBaoGia.AutoSize = true;
            this.rdoBaoGia.Location = new System.Drawing.Point(102, 22);
            this.rdoBaoGia.Name = "rdoBaoGia";
            this.rdoBaoGia.Size = new System.Drawing.Size(214, 21);
            this.rdoBaoGia.TabIndex = 0;
            this.rdoBaoGia.TabStop = true;
            this.rdoBaoGia.Text = "Xem bảng báo giá sản phẩm:";
            this.rdoBaoGia.UseVisualStyleBackColor = true;
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(773, 95);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(108, 34);
            this.btReport.TabIndex = 2;
            this.btReport.Text = "Xuất Report";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // Lab052
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1048, 720);
            this.Controls.Add(this.btReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab052";
            this.Text = "ReportDonHang";
            this.Load += new System.EventHandler(this.Lab052_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPhieuGiaoHang;
        private System.Windows.Forms.ComboBox cbMaGH;
        private System.Windows.Forms.RadioButton rdoBaoGia;
        private System.Windows.Forms.Button btReport;
    }
}

