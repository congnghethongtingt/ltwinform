
namespace Lab03
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPause = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.thôngTinToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(6, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(216, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuThoat});
            this.MenuItemFile.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemFile.Image")));
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(66, 27);
            this.MenuItemFile.Text = "File";
            // 
            // MenuFile
            // 
            this.MenuFile.Image = ((System.Drawing.Image)(resources.GetObject("MenuFile.Image")));
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuFile.Size = new System.Drawing.Size(208, 26);
            this.MenuFile.Text = "Open File";
            this.MenuFile.Click += new System.EventHandler(this.MenuFile_Click);
            // 
            // MenuThoat
            // 
            this.MenuThoat.Image = ((System.Drawing.Image)(resources.GetObject("MenuThoat.Image")));
            this.MenuThoat.Name = "MenuThoat";
            this.MenuThoat.Size = new System.Drawing.Size(208, 26);
            this.MenuThoat.Text = "Exit";
            this.MenuThoat.Click += new System.EventHandler(this.MenuThoat_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinToolStripMenuItem.Image")));
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(106, 27);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPlay,
            this.MenuPause,
            this.MenuStop});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(36, 27);
            this.toolStripMenuItem2.Text = "...";
            // 
            // MenuPlay
            // 
            this.MenuPlay.Image = ((System.Drawing.Image)(resources.GetObject("MenuPlay.Image")));
            this.MenuPlay.Name = "MenuPlay";
            this.MenuPlay.Size = new System.Drawing.Size(139, 28);
            this.MenuPlay.Text = "Play";
            this.MenuPlay.Click += new System.EventHandler(this.MenuPlay_Click);
            // 
            // MenuPause
            // 
            this.MenuPause.Image = ((System.Drawing.Image)(resources.GetObject("MenuPause.Image")));
            this.MenuPause.Name = "MenuPause";
            this.MenuPause.Size = new System.Drawing.Size(139, 28);
            this.MenuPause.Text = "Pause";
            this.MenuPause.Click += new System.EventHandler(this.MenuPause_Click);
            // 
            // MenuStop
            // 
            this.MenuStop.Image = ((System.Drawing.Image)(resources.GetObject("MenuStop.Image")));
            this.MenuStop.Name = "MenuStop";
            this.MenuStop.Size = new System.Drawing.Size(139, 28);
            this.MenuStop.Text = "Stop";
            this.MenuStop.Click += new System.EventHandler(this.MenuStop_Click);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(0, 34);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(1075, 389);
            this.MediaPlayer.TabIndex = 3;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.LinkVisited = true;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 22);
            this.toolStripStatusLabel1.Text = "Ngày giờ";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1075, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1075, 553);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Media Player Classic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuThoat;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuPlay;
        private System.Windows.Forms.ToolStripMenuItem MenuPause;
        private System.Windows.Forms.ToolStripMenuItem MenuStop;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

