
namespace _QuanLyTaiKhoan
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
            this.label5 = new System.Windows.Forms.Label();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiGDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGiaoDich = new System.Windows.Forms.DataGridView();
            this.SoTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbGD = new System.Windows.Forms.ComboBox();
            this.btThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSTK = new System.Windows.Forms.ComboBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSoDuCuoiKi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGiaoDich = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label5.Location = new System.Drawing.Point(259, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thông tin giao dịch";
            // 
            // NoiDung
            // 
            this.NoiDung.FillWeight = 147.5231F;
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // SoTien
            // 
            this.SoTien.FillWeight = 106.9519F;
            this.SoTien.HeaderText = "Số Tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            // 
            // LoaiGDich
            // 
            this.LoaiGDich.HeaderText = "Loại GD";
            this.LoaiGDich.MinimumWidth = 6;
            this.LoaiGDich.Name = "LoaiGDich";
            this.LoaiGDich.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.FillWeight = 52.99905F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // dgvGiaoDich
            // 
            this.dgvGiaoDich.AllowUserToAddRows = false;
            this.dgvGiaoDich.AllowUserToDeleteRows = false;
            this.dgvGiaoDich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoDich.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoDich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LoaiGDich,
            this.SoTien,
            this.NoiDung,
            this.SoTaiKhoan});
            this.dgvGiaoDich.Location = new System.Drawing.Point(266, 99);
            this.dgvGiaoDich.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGiaoDich.Name = "dgvGiaoDich";
            this.dgvGiaoDich.ReadOnly = true;
            this.dgvGiaoDich.RowHeadersWidth = 51;
            this.dgvGiaoDich.RowTemplate.Height = 24;
            this.dgvGiaoDich.Size = new System.Drawing.Size(526, 340);
            this.dgvGiaoDich.TabIndex = 11;
            this.dgvGiaoDich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoDich_CellClick);
            // 
            // SoTaiKhoan
            // 
            this.SoTaiKhoan.HeaderText = "Số TK";
            this.SoTaiKhoan.MinimumWidth = 6;
            this.SoTaiKhoan.Name = "SoTaiKhoan";
            this.SoTaiKhoan.ReadOnly = true;
            this.SoTaiKhoan.Visible = false;
            // 
            // cbGD
            // 
            this.cbGD.BackColor = System.Drawing.SystemColors.Control;
            this.cbGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGD.FormattingEnabled = true;
            this.cbGD.Items.AddRange(new object[] {
            "Nhận Tiền",
            "Rút Tiền"});
            this.cbGD.Location = new System.Drawing.Point(87, 87);
            this.cbGD.Margin = new System.Windows.Forms.Padding(2);
            this.cbGD.Name = "cbGD";
            this.cbGD.Size = new System.Drawing.Size(152, 21);
            this.cbGD.TabIndex = 9;
            this.cbGD.SelectedIndexChanged += new System.EventHandler(this.cbGD_SelectedIndexChanged);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(87, 256);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(60, 30);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "GD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số TK";
            // 
            // cbSTK
            // 
            this.cbSTK.BackColor = System.Drawing.SystemColors.Control;
            this.cbSTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSTK.FormattingEnabled = true;
            this.cbSTK.Location = new System.Drawing.Point(87, 44);
            this.cbSTK.Margin = new System.Windows.Forms.Padding(2);
            this.cbSTK.Name = "cbSTK";
            this.cbSTK.Size = new System.Drawing.Size(127, 21);
            this.cbSTK.TabIndex = 4;
            this.cbSTK.SelectedIndexChanged += new System.EventHandler(this.cbSTK_SelectedIndexChanged);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(87, 174);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(158, 63);
            this.txtNoiDung.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(87, 131);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(127, 20);
            this.txtSoTien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Tiền";
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuBaoCao.Size = new System.Drawing.Size(211, 22);
            this.menuBaoCao.Text = "Xuất Báo cáo";
            this.menuBaoCao.Click += new System.EventHandler(this.menuBaoCao_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // menuSoDuCuoiKi
            // 
            this.menuSoDuCuoiKi.Name = "menuSoDuCuoiKi";
            this.menuSoDuCuoiKi.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuSoDuCuoiKi.Size = new System.Drawing.Size(211, 22);
            this.menuSoDuCuoiKi.Text = "Số Dư Cuối Kỳ";
            this.menuSoDuCuoiKi.Click += new System.EventHandler(this.menuSoDuCuoiKi_Click);
            // 
            // menuGiaoDich
            // 
            this.menuGiaoDich.Name = "menuGiaoDich";
            this.menuGiaoDich.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuGiaoDich.Size = new System.Drawing.Size(211, 22);
            this.menuGiaoDich.Text = "Các giao dịch Gửi Tiền";
            this.menuGiaoDich.Click += new System.EventHandler(this.menuGiaoDich_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGiaoDich,
            this.menuSoDuCuoiKi,
            this.toolStripSeparator1,
            this.menuBaoCao});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGD);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSTK);
            this.groupBox1.Controls.Add(this.txtNoiDung);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoTien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(261, 340);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giao dịch";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvGiaoDich);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiGDich;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView dgvGiaoDich;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTaiKhoan;
        private System.Windows.Forms.ComboBox cbGD;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSTK;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuSoDuCuoiKi;
        private System.Windows.Forms.ToolStripMenuItem menuGiaoDich;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

