using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTongDaySo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            int m = int.Parse(txtSoM.Text);
            int kq = 0;
            for (int i = n; i <= m; i++)
                kq = kq + i;
            txtKetQua.Text = kq.ToString();
        }
    }
}
