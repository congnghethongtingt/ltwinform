
namespace ThongKeReport
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtThang = new System.Windows.Forms.DateTimePicker();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.btXem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoTuNgayDenNgay = new System.Windows.Forms.RadioButton();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.rdoNgay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(2, 249);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1202, 367);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtThang
            // 
            this.dtThang.CustomFormat = "yyyy-MM";
            this.dtThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThang.Location = new System.Drawing.Point(368, 85);
            this.dtThang.Margin = new System.Windows.Forms.Padding(4);
            this.dtThang.Name = "dtThang";
            this.dtThang.Size = new System.Drawing.Size(136, 22);
            this.dtThang.TabIndex = 16;
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "yyyy-MM-dd";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(366, 30);
            this.dtNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(136, 22);
            this.dtNgay.TabIndex = 14;
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(997, 200);
            this.btXem.Margin = new System.Windows.Forms.Padding(4);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(100, 28);
            this.btXem.TabIndex = 15;
            this.btXem.Text = "In / Xem";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtTuNgay);
            this.groupBox1.Controls.Add(this.dtDenNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoTuNgayDenNgay);
            this.groupBox1.Controls.Add(this.rdoThang);
            this.groupBox1.Controls.Add(this.rdoNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtThang);
            this.groupBox1.Controls.Add(this.dtNgay);
            this.groupBox1.Location = new System.Drawing.Point(214, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 209);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "yyyy-MM-dd";
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(368, 145);
            this.dtTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(136, 22);
            this.dtTuNgay.TabIndex = 31;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "yyyy-MM-dd";
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(540, 145);
            this.dtDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(136, 22);
            this.dtDenNgay.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "~";
            // 
            // rdoTuNgayDenNgay
            // 
            this.rdoTuNgayDenNgay.AutoSize = true;
            this.rdoTuNgayDenNgay.Location = new System.Drawing.Point(207, 146);
            this.rdoTuNgayDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.rdoTuNgayDenNgay.Name = "rdoTuNgayDenNgay";
            this.rdoTuNgayDenNgay.Size = new System.Drawing.Size(112, 21);
            this.rdoTuNgayDenNgay.TabIndex = 30;
            this.rdoTuNgayDenNgay.TabStop = true;
            this.rdoTuNgayDenNgay.Tag = "3";
            this.rdoTuNgayDenNgay.Text = "Xem từ ngày:";
            this.rdoTuNgayDenNgay.UseVisualStyleBackColor = true;
            this.rdoTuNgayDenNgay.CheckedChanged += new System.EventHandler(this.rdoTuNgayDenNgay_CheckedChanged);
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.Location = new System.Drawing.Point(207, 88);
            this.rdoThang.Margin = new System.Windows.Forms.Padding(4);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(133, 21);
            this.rdoThang.TabIndex = 29;
            this.rdoThang.Tag = "2";
            this.rdoThang.Text = "Xem theo tháng:";
            this.rdoThang.UseVisualStyleBackColor = true;
            this.rdoThang.CheckedChanged += new System.EventHandler(this.rdoThang_CheckedChanged);
            // 
            // rdoNgay
            // 
            this.rdoNgay.AutoSize = true;
            this.rdoNgay.Location = new System.Drawing.Point(207, 35);
            this.rdoNgay.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNgay.Name = "rdoNgay";
            this.rdoNgay.Size = new System.Drawing.Size(128, 21);
            this.rdoNgay.TabIndex = 28;
            this.rdoNgay.TabStop = true;
            this.rdoNgay.Tag = "1";
            this.rdoNgay.Text = "Xem theo ngày:";
            this.rdoNgay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 621);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtThang;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoTuNgayDenNgay;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.RadioButton rdoNgay;
    }
}

