
namespace _QuanLyTaiKhoan
{
    partial class ReportGiaoDich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportGiaoDich));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btXem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSTK = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_1911060013_HaGiaBao.Report.ReportGiaoDich.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 100);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(822, 427);
            this.reportViewer1.TabIndex = 7;
            // 
            // btXem
            // 
            this.btXem.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXem.ForeColor = System.Drawing.Color.Teal;
            this.btXem.Location = new System.Drawing.Point(553, 41);
            this.btXem.Margin = new System.Windows.Forms.Padding(2);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(56, 28);
            this.btXem.TabIndex = 6;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(231, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số TK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbSTK
            // 
            this.cbSTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSTK.FormattingEnabled = true;
            this.cbSTK.Location = new System.Drawing.Point(305, 41);
            this.cbSTK.Margin = new System.Windows.Forms.Padding(2);
            this.cbSTK.Name = "cbSTK";
            this.cbSTK.Size = new System.Drawing.Size(223, 28);
            this.cbSTK.TabIndex = 4;
            this.cbSTK.SelectedIndexChanged += new System.EventHandler(this.cbSTK_SelectedIndexChanged);
            // 
            // ReportGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 527);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportGiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportGiaoDich";
            this.Load += new System.EventHandler(this.ReportGiaoDich_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSTK;
    }
}