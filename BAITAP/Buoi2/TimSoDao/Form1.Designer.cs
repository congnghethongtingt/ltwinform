
namespace TimSoDao
{
    partial class TimSoDao
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
            this.btGiai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btTiep = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtSoDao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btGiai
            // 
            this.btGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGiai.Location = new System.Drawing.Point(30, 202);
            this.btGiai.Name = "btGiai";
            this.btGiai.Size = new System.Drawing.Size(96, 38);
            this.btGiai.TabIndex = 1;
            this.btGiai.Text = "Giải";
            this.btGiai.UseVisualStyleBackColor = true;
            this.btGiai.Click += new System.EventHandler(this.btGiai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số n:";
            // 
            // txtSoN
            // 
            this.txtSoN.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoN.Location = new System.Drawing.Point(146, 94);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(162, 27);
            this.txtSoN.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số đảo:";
            // 
            // btTiep
            // 
            this.btTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTiep.Location = new System.Drawing.Point(149, 202);
            this.btTiep.Name = "btTiep";
            this.btTiep.Size = new System.Drawing.Size(96, 38);
            this.btTiep.TabIndex = 2;
            this.btTiep.Text = "Tiếp";
            this.btTiep.UseVisualStyleBackColor = true;
            this.btTiep.Click += new System.EventHandler(this.btTiep_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(269, 202);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(96, 38);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // txtSoDao
            // 
            this.txtSoDao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSoDao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDao.Location = new System.Drawing.Point(146, 144);
            this.txtSoDao.Name = "txtSoDao";
            this.txtSoDao.ReadOnly = true;
            this.txtSoDao.Size = new System.Drawing.Size(162, 27);
            this.txtSoDao.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "TÌM SỐ ĐẢO";
            // 
            // TimSoDao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 280);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoDao);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTiep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGiai);
            this.Name = "TimSoDao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimSoDao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimSoDao_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGiai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTiep;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtSoDao;
        private System.Windows.Forms.Label label3;
    }
}

