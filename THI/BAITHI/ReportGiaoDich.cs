using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITHI
{
    public partial class ReportGiaoDich : Form
    {
        Model1 dbgiaoDich = new Model1();
        public ReportGiaoDich()
        {
            InitializeComponent();
        }

        private void ReportGiaoDich_Load(object sender, EventArgs e)
        {
            cbSTK.Enabled = true;
            reportViewer1.Visible = false;
            this.reportViewer1.RefreshReport();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            TaiKhoan listTaiKhoan = dbgiaoDich.TaiKhoans.FirstOrDefault(p => p.STK == cbSTK.Text);
            List<GiaoDich> listGiaoDich = dbgiaoDich.GiaoDiches.Where(p => p.STK == cbSTK.Text).ToList();
            if (listTaiKhoan == null || listGiaoDich.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy STK!");
                return;
            }
            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("sotaikhoan", listTaiKhoan.STK);

            this.reportViewer1.LocalReport.ReportPath = "./Report/ReportGiaoDich.rdlc";
            reportViewer1.LocalReport.SetParameters(param);
            ReportDataSource reportDataSource = new ReportDataSource("DataSetGiaoDich", listGiaoDich);
            
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.DisplayName = "Chi tiết các giao dịch";
            
            this.reportViewer1.RefreshReport();
        }

        private void cbSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSTK.Enabled = true;
            ComboBox cb = (ComboBox)sender;
            List<TaiKhoan> listSTK = dbgiaoDich.TaiKhoans.OrderBy(p => p.STK).ToList();
            cbSTK.DataSource = listSTK;
            cbSTK.DisplayMember = "STK";
            cbSTK.ValueMember = "STK";
        }
    }
}
