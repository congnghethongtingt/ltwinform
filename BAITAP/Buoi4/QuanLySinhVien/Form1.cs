using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class form : Form
    {
        public form ()
        {
            InitializeComponent();
        }


        public void setNull()
        {
            txtMSSV.Text = "";
            txtHoTen.Text = "";
            txtDiemTB.Text = "";
            rdoNam.Checked = true;
            txtMSSV.Focus();
        }


        private int GetSelectedRow(String maSV)
        {
            for (int i = 0; i < dgvDSSV.Rows.Count; i++)
            {
                if (dgvDSSV.Rows[i].Cells[0].Value.ToString() == maSV)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvDSSV.Rows[selectedRow].Cells[0].Value = txtMSSV.Text;
            dgvDSSV.Rows[selectedRow].Cells[1].Value = txtHoTen.Text;
            dgvDSSV.Rows[selectedRow].Cells[2].Value = rdoNu.Checked ? "Nữ" : "Nam";
            dgvDSSV.Rows[selectedRow].Cells[3].Value = float.Parse(txtDiemTB.Text).ToString();
            dgvDSSV.Rows[selectedRow].Cells[4].Value = cbbChuyenNganh.Text;
        }
       
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSSV.Text == "" || txtHoTen.Text == "" || txtDiemTB.Text == "")
                    throw new Exception("Bạn chưa nhập đủ thông tin!");
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvDSSV.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Them sinh vien moi thanh cong");
                    //Sua();
                }
                else
                {

                }
            }
            catch
            {
               
            }
        }


        private bool ktTrung(string mssv)
        {
            for(int i = 0; i< dgvDSSV.Rows.Count; i++)
            {
                if(dgvDSSV.SelectedRows[i].Cells[0].Value.ToString()==mssv)
                {
                    return true;
                }
            }
            return false;
        }

        private int vitriTrung(string mssv)
        {
            for (int i = 0; i < dgvDSSV.Rows.Count; i++)
            {
                if (dgvDSSV.SelectedRows[i].Cells[0].Value.ToString() == mssv)
                {
                    return i;
                }
            }
            return -1;
        }

        private bool ktNhap(string MSSV, string hoTen, string gioiTinh, string ngaySinh, string diemTB,string chuyenNganh )
        {
            if (MSSV == "" || hoTen == "" || gioiTinh == "" || ngaySinh == "" || diemTB == "" || chuyenNganh == "")
                
                return true;
                
            return false;
        }

        //private int demSoLuongNam()
        //{
        //    int n = dgvDSSV.SelectedRows.Count;
        //    int dem = 0;
        //    for(int i = 0; i < n; i++)
        //    {
        //        if (dgvDSSV.SelectedRows[i].Cells[2].Value == "Nam")
        //            dem++;
        //    }
        //    return dem;
        //}




        private void formSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if(selectedRow == -1)
                {
                    throw new Exception("Khong tim thay sinh vien can xoa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Ban co muon xoa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        dgvDSSV.Rows.RemoveAt(selectedRow);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void form_Load(object sender, EventArgs e)
        {
            rdoNu.Checked = true;
            cbbChuyenNganh.SelectedIndex = 0;
        }
    }
}
