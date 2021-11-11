using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txtA.Text);
                float b = float.Parse(txtB.Text);
                float ketQua = a + b;
                txtKetQua.Text = ketQua.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txtA.Text);
                float b = float.Parse(txtB.Text);
                float ketQua = a - b;
                txtKetQua.Text = ketQua.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Dữ liệu vừa nhập không hợp lệ!!!");
            }
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txtA.Text);
                float b = float.Parse(txtB.Text);
                float ketQua = a * b;
                txtKetQua.Text = ketQua.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txtA.Text);
                float b = float.Parse(txtB.Text);
                float ketQua = (float)a / b;
                txtKetQua.Text = ketQua.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkNum(string text)
        {
            bool temp = float.TryParse(text, out float txtKetQua);
            if (temp)
                return true;
            return false;
        }
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (!checkNum(txtA.Text))
                      MessageBox.Show("Vui lòng đừng nhập định dạng!", "Cảnh báo",
                      MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (!checkNum(txtA.Text))
                MessageBox.Show("Vui lòng đừng nhập định dạng!", "Cảnh báo",
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }
    }
}
