using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimSoDao
{
    public partial class TimSoDao : Form
    {
        public TimSoDao()
        {
            InitializeComponent();
        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            int m = 0;
            while(n != 0)
            {
                m = m * 10 + n % 10;
                n = n / 10;
            }
            txtSoDao.Text = m.ToString();
        }

        private void btTiep_Click(object sender, EventArgs e)
        {
            txtSoN.Text = "";
            txtSoDao.Text = "";
            txtSoN.Focus();
        }

        private void TimSoDao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban co muon dong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
