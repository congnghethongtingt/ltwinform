using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LietKeCacSoNguyenToNhoHonN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        bool LaNT(int k)
        {
            for (int i = 2; i <= k / 2; i++)
                if (k % i == 0)
                    return false;
            return true;
        }

        void LietKeSoNguyenTo(int n)
        {
            long s = 0;
            for (int i = 2; i < n; i++)
                if (LaNT(i)==true)
                {
                    txtDanhSach.Text = txtDanhSach.Text + i.ToString() + ", ";
                    s = s + i;
                }
            txtTong.Text = s.ToString();
        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtSoN.Text);
                LietKeSoNguyenTo(n);
            }
            catch
            {

            }


        }

        private void btTiep_Click(object sender, EventArgs e)
        {
            txtSoN.Text = "";
            txtDanhSach.Text = "";
            txtTong.Text = "";
            txtSoN.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.White)
                button.BackColor = Color.Red;
        }
    }
}
