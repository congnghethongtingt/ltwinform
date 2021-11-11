using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT4._3
{
    public partial class Form1 : Form
    {
        float Tu, Tu1, Tu2, Mau, Mau1, Mau2, USC, kq, kq1;

        PS pS = new PS();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtTuSo1.Clear();
            txtTuSo2.Clear();
            txtTuSo3.Clear();
            txtMauSo1.Clear();
            txtMauSo2.Clear();
            txtMauSo3.Clear();
            gbKQ.Text = "Kết quả";

        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (txtMauSo1.Text == "" || txtTuSo1.Text == "" || txtMauSo2.Text == "" || txtTuSo2.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtTuSo1 != null)
            {
                Tu1 = float.Parse(txtTuSo1.Text);
                Tu2 = float.Parse(txtTuSo2.Text);
                Mau1 = float.Parse(txtMauSo1.Text);
                Mau2 = float.Parse(txtMauSo2.Text);

                Tu = Tu1 * Mau2;
                Mau = Tu2 * Mau1;
                USC = PS.USCLN(Tu, Mau);

                kq = Tu / USC;
                kq1 = Mau / USC;

                txtTuSo3.Text = kq.ToString();
                txtMauSo3.Text = kq1.ToString();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            this.gbKQ.Text = "Kết quả trừ";
            if (txtMauSo1.Text == "" || txtTuSo1.Text == "" || txtMauSo2.Text == "" || txtTuSo2.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtTuSo1 != null)
            {
                Tu1 = float.Parse(txtTuSo1.Text);
                Tu2 = float.Parse(txtTuSo2.Text);
                Mau1 = float.Parse(txtMauSo1.Text);
                Mau2 = float.Parse(txtMauSo2.Text);

                Tu = (Tu1 * Mau2) - (Tu2 * Mau1);
                Mau = Mau1 * Mau2;
                USC = PS.USCLN(Tu, Mau);

                kq = Tu / USC;
                kq1 = Mau / USC;

                txtTuSo3.Text = kq.ToString();
                txtMauSo3.Text = kq1.ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            this.gbKQ.Text = "Kết quả nhân";
            if (txtMauSo1.Text == "" || txtTuSo1.Text == "" || txtMauSo2.Text == "" || txtTuSo2.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtTuSo1 != null)
            {
                Tu1 = float.Parse(txtTuSo1.Text);
                Tu2 = float.Parse(txtTuSo2.Text);
                Mau1 = float.Parse(txtMauSo1.Text);
                Mau2 = float.Parse(txtMauSo2.Text);

                Tu = Tu1 * Mau2;
                Mau = Mau1 * Mau2;
                USC = PS.USCLN(Tu, Mau);

                kq = Tu / USC;
                kq1 = Mau / USC;

                txtTuSo3.Text = kq.ToString();
                txtMauSo3.Text = kq1.ToString();
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            this.gbKQ.Text = "Kết quả cộng";
            if (txtMauSo1.Text == "" || txtTuSo1.Text == "" || txtMauSo2.Text == "" || txtTuSo2.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ!!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtTuSo1 != null)
            {
                Tu1 = float.Parse(txtTuSo1.Text);
                Tu2 = float.Parse(txtTuSo2.Text);
                Mau1 = float.Parse(txtMauSo1.Text);
                Mau2 = float.Parse(txtMauSo2.Text);

                Tu = (Tu1 * Mau2) + (Tu2 * Mau1);
                Mau = Mau1 * Mau2;
                USC = PS.USCLN(Tu, Mau);

                kq = Tu / USC;
                kq1 = Mau / USC;

                txtTuSo3.Text = kq.ToString();
                txtMauSo3.Text = kq1.ToString();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
