using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MenuFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "File MP4 | *.mp4| MPEG File | *.mpeg";
            if (file.ShowDialog() == DialogResult.OK)
                MediaPlayer.URL = file.FileName;
        }

        private void MenuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuPlay_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.play();
        }

        private void MenuPause_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.pause();
        }

        private void MenuStop_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format($"Ngày:{DateTime.Now.ToString("dd/MM/yyyy")}" +
                                                   $" Giờ:{DateTime.Now.ToString("HH:mm:ss")}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
