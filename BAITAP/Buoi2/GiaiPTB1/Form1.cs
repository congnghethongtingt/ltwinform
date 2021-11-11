using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPTB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtHeSoA.Text);
            int b = int.Parse(txtHeSoB.Text);
            if (a == 0)
                if (b == 0)
                    txtKetQua.Text = "PT vo nghiem";
                else
                    txtKetQua.Text = "PT vo so nghiem";
            else
            {
                float kq = (float)-b / a;
                txtKetQua.Text = "PT co nghiem:-b/a ";
                txtNghiem.Text = kq.ToString();
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHeSoA.Text = "";
            txtHeSoB.Text = "";
            txtKetQua.Text = "";
            txtNghiem.Text = "";
            txtHeSoA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban muon thoat ra?","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                Close();
        }
    }
}
