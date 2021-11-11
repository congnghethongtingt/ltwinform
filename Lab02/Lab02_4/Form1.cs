using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab02_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Xoa()
        {
            txtSTK.Text = "";  //Sau khi thêm xong sẽ xóa thông tin vừa nhập trong bảng về rỗng
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtTien.Text = "";
            txtSTK.Focus(); //Dấu nháy trở về ở textbox STK
        }


        private void tinhTongTien()
        {
            long tongTien = 0;
            for (int i = 0; i < listViewDS.Items.Count; i++)
            {
                tongTien += long.Parse(listViewDS.Items[i].SubItems[4].Text);
            }
            txtTongTien.Text = tongTien.ToString();
        }

        private int timSoTaiKhoan(string soTaiKhoan)
        {
            for (int i = 0; i < listViewDS.Items.Count; i++)
            {
                if (listViewDS.Items[i].SubItems[1].Text == soTaiKhoan)
                    return i;
            }
            return -1;
        }


        private void capNhatThongTin(int sttSoTaiKhoan)
        {
            listViewDS.Items[sttSoTaiKhoan].SubItems[1].Text = txtSTK.Text;
            listViewDS.Items[sttSoTaiKhoan].SubItems[2].Text = txtTenKH.Text;
            listViewDS.Items[sttSoTaiKhoan].SubItems[3].Text = txtDiaChi.Text;
            listViewDS.Items[sttSoTaiKhoan].SubItems[4].Text = txtTien.Text;
        }

        private void Binding(int selectedIndex)
        {
            if (selectedIndex == -1) return;
            txtSTK.Text = listViewDS.Items[selectedIndex].SubItems[1].Text;
            txtTenKH.Text = listViewDS.Items[selectedIndex].SubItems[2].Text;
            txtDiaChi.Text = listViewDS.Items[selectedIndex].SubItems[3].Text;
            txtTien.Text = listViewDS.Items[selectedIndex].SubItems[4].Text;
        }

        private int stt = 1;

        private void btnThemCN_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSTK.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "" || txtTien.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                ListViewItem item = new ListViewItem(new string[] { (stt).ToString(), txtSTK.Text, txtTenKH.Text, txtDiaChi.Text, txtTien.Text });
                if (timSoTaiKhoan(txtSTK.Text) == -1)
                {
                    listViewDS.Items.Add(item);
                            stt++;
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    capNhatThongTin(timSoTaiKhoan(txtSTK.Text));
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tinhTongTien();
                Xoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int select = timSoTaiKhoan(txtSTK.Text);
                if (select == -1)
                {
                    throw new Exception("Không tìm thấy số tài khoản cần xóa!");
                }
                else
                {
                    var selected = listViewDS.SelectedItems.Cast<Object>().ToArray();
                    if (selected.Length <= 0) return;

                    DialogResult dr = MessageBox.Show("Bạn có muốn xoá tài khoản này không?", "YES/NO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        foreach (ListViewItem item in selected)
                            listViewDS.Items.Remove(item);
                        stt--;
                        MessageBox.Show("Xoá tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tinhTongTien();
            Xoa();
        }

        //Hiện lại thông tin trong listview về textbox
        private void listViewDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDS.FocusedItem == null) return;
            int p = listViewDS.FocusedItem.Index;
            Binding(p);
        }

        protected void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ra không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listViewDS.Scrollable = true;
        }

        //Không cho nhập kí tự khác ngoài số
        private void txtTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
