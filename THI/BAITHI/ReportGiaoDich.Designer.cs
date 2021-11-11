
namespace BAITHI
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
            this.cbSTK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btXem = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // cbSTK
            // 
            this.cbSTK.FormattingEnabled = true;
            this.cbSTK.Location = new System.Drawing.Point(261, 50);
            this.cbSTK.Name = "cbSTK";
            this.cbSTK.Size = new System.Drawing.Size(219, 24);
            this.cbSTK.TabIndex = 0;
            this.cbSTK.SelectedIndexChanged += new System.EventHandler(this.cbSTK_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số TK";
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(515, 50);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(75, 24);
            this.btXem.TabIndex = 2;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_1911065391_LuuGiaThanh.Report.ReportGiaoDich.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 128);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 326);
            this.reportViewer1.TabIndex = 3;
            // 
            // ReportGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSTK);
            this.Name = "ReportGiaoDich";
            this.Text = "ReportGiaoDich";
            this.Load += new System.EventHandler(this.ReportGiaoDich_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXem;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}