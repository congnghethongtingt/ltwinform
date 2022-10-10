using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _QuanLyTaiKhoan;

namespace _QuanLyTaiKhoan
{
    public partial class Form1 : Form
    {
        private List<TaiKhoan> listTaiKhoan;
        private List<GiaoDich> listGiaoDich;
        public Form1()
        {
            InitializeComponent();
            getListGD();
            cbGD.SelectedIndex = 0;
            //cbGD.Items.Insert(0,"Nhận tiền");
            //cbGD.Items.Insert(1,"Rút tiền");
        }

        private string loaiGiaoDich, STK;

        private void getListGD()
        {
            dgvGiaoDich.Rows.Clear();
            using (var dbcontext = new Model1())
            {
                listTaiKhoan = dbcontext.TaiKhoans.ToList();
            }
            using (var dbcontext = new Model1())
            {
                listGiaoDich = dbcontext.GiaoDiches.ToList();
            }
            if (listGiaoDich.Count <= 0) return;
            //Đổ dữ liệu ra bảng
            foreach (var giaodich in listGiaoDich)
            {
                int indexRow = dgvGiaoDich.Rows.Add();
                dgvGiaoDich.Rows[indexRow].Cells[0].Value = giaodich.Id;
                dgvGiaoDich.Rows[indexRow].Cells[1].Value = giaodich.SoTien > 0 ? "Nhận tiền" : "Rút tiền";
                dgvGiaoDich.Rows[indexRow].Cells[2].Value = Math.Abs(giaodich.SoTien);
                dgvGiaoDich.Rows[indexRow].Cells[3].Value = giaodich.NoiDung;
                dgvGiaoDich.Rows[indexRow].Cells[4].Value = giaodich.STK;
            }
            dgvGiaoDich.Rows[0].Selected = false;
            STK = listGiaoDich[0].STK;
            cbGD.Text = dgvGiaoDich.Rows[0].Cells[1].FormattedValue.ToString();

            cbSTK.DataSource = listTaiKhoan;
            cbSTK.DisplayMember = "STK";
            cbSTK.ValueMember = "STK";
        }

        private int tinhSoDuCuoiKi(string stk)
        {
            int soDuDauKi, soDuCuoiKi = 0;
            using (var dbcontext = new Model1())
            {
                var p = dbcontext.TaiKhoans.SingleOrDefault(taiKhoan => taiKhoan.STK == stk);
                soDuDauKi = (int)p.SoDuDauKy;
            }

            foreach (var gd in listGiaoDich)
            {
                if (gd.STK != stk) continue;
                soDuCuoiKi += gd.SoTien;
            }

            return soDuCuoiKi + soDuDauKi;
        }

        private void dgvGiaoDich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dgvGiaoDich.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;

            dgvGiaoDich.CurrentRow.Selected = true;
            cbGD.Text = dgvGiaoDich.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtSoTien.Text = dgvGiaoDich.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtNoiDung.Text = dgvGiaoDich.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            cbSTK.Text = dgvGiaoDich.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
        }

        private void menuGiaoDich_Click(object sender, EventArgs e)
        {
            using (var dbcontext = new Model1())
            {
                listTaiKhoan = dbcontext.TaiKhoans.ToList();
            }
            using (var dbcontext = new Model1())
            {
                listGiaoDich = dbcontext.GiaoDiches.ToList();
            }
            dgvGiaoDich.Rows.Clear();
            if (listGiaoDich.Count <= 0) return;
            //Đổ dữ liệu ra bảng
            foreach (var giaoDich in listGiaoDich)
            {
                if (giaoDich.SoTien <= 0) continue;
                int indexRow = dgvGiaoDich.Rows.Add();
                dgvGiaoDich.Rows[indexRow].Cells[0].Value = giaoDich.Id;
                dgvGiaoDich.Rows[indexRow].Cells[1].Value = giaoDich.SoTien > 0 ? "Nhận tiền" : "Rút tiền";
                dgvGiaoDich.Rows[indexRow].Cells[2].Value = Math.Abs(giaoDich.SoTien);
                dgvGiaoDich.Rows[indexRow].Cells[3].Value = giaoDich.NoiDung;
                dgvGiaoDich.Rows[indexRow].Cells[4].Value = giaoDich.STK;
            }
            dgvGiaoDich.Rows[0].Selected = false;
            STK = listGiaoDich[0].STK;

            cbGD.Text = dgvGiaoDich.Rows[0].Cells[1].FormattedValue.ToString();

            cbSTK.DataSource = listTaiKhoan;
            cbSTK.DisplayMember = "STK";
            cbSTK.ValueMember = "STK";
        }

        private void menuSoDuCuoiKi_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"STK: 1111111746 còn {tinhSoDuCuoiKi("1111111746")}" + Environment.NewLine + $"STK: 1111111812 còn {tinhSoDuCuoiKi("1111111812")}");
        }

        private void menuBaoCao_Click(object sender, EventArgs e)
        {
            ReportGiaoDich report = new ReportGiaoDich();
            report.ShowDialog();
        }

        private void XoaTT()
        {
            txtNoiDung.Text = "";
            txtSoTien.Text = "";
            cbGD.SelectedIndex = 0;
            cbSTK.SelectedIndex = 0;
        }

        private void cbSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedValue == null) return;
            STK = cb.SelectedValue.ToString();
        }

        private void cbGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedValue == null) return;
            loaiGiaoDich = cb.SelectedValue.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                var gd = new GiaoDich();

                if (txtSoTien.Text == "" || int.Parse(txtSoTien.Text) < 1 || int.Parse(txtSoTien.Text) > 100000000)
                {
                    MessageBox.Show("Vui lòng nhập số tiền từ 1-100000000!");
                    return;
                }

                if (cbGD.SelectedIndex == 1 && tinhSoDuCuoiKi(STK) < int.Parse(txtSoTien.Text))
                {
                    MessageBox.Show("Tài khoản không đủ số tiền để rút!");
                    return;
                }

                if (cbGD.SelectedIndex == 1)
                    gd.SoTien = 0 - int.Parse(txtSoTien.Text);
                else
                    gd.SoTien = int.Parse(txtSoTien.Text);


                gd.STK = STK;
                gd.NoiDung = txtNoiDung.Text;

                using (var dbcontext = new Model1())
                {
                    dbcontext.GiaoDiches.Add(gd);
                    dbcontext.SaveChanges();
                }

                MessageBox.Show("Thêm mới giao dịch thành công!");
                getListGD();
                XoaTT();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
