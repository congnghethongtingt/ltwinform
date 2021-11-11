using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ProductOrderRP.Model;

namespace ProductOrderRP
{
    public partial class Lab052 : Form
    {

        DBHoaDon dbHoaDon = new DBHoaDon(); 
        public Lab052()
        {
            InitializeComponent();
        }

        private void Lab052_Load(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            rdoBaoGia.Checked = true;
            rdoPhieuGiaoHang.Checked = false;
            cbMaGH.Enabled = false;
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void rdoPhieuGiaoHang_CheckedChanged(object sender, EventArgs e)
        {
            cbMaGH.Enabled = true;
            List<Invoice> listInvoice = dbHoaDon.Invoices.OrderBy(p => p.OrderDate).ToList();
            cbMaGH.DataSource = listInvoice;
            cbMaGH.DisplayMember = "InvoiceNo";
            cbMaGH.ValueMember = "InvoiceNo";
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            if(rdoBaoGia.Checked==true)
            {
                List<Product> listProduct = dbHoaDon.Products.ToList();
                this.reportViewer1.LocalReport.ReportPath = "./Report/ReportBaoGia.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource("DataSetBaoGia",listProduct);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            }
            else
            {
                Invoice invoiceIDHoaDon = dbHoaDon.Invoices.FirstOrDefault(p => p.InvoiceNo == cbMaGH.Text);
                List<Order> listOrder = dbHoaDon.Orders.Where(p => p.InvoiceNo == cbMaGH.Text).ToList();
                if(invoiceIDHoaDon==null || listOrder.Count()==0)
                {
                    MessageBox.Show("Khong tim thay don hang!");
                    return;
                }
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("ngaygiaohang", string.Format("Ngày " + invoiceIDHoaDon.DeliveryDate.ToString("dd/MM/yyyy")));
                param[1] = new ReportParameter("sohoadon", invoiceIDHoaDon.InvoiceNo);

                this.reportViewer1.LocalReport.ReportPath = "./Report/ReportDonHang.rdlc";
                reportViewer1.LocalReport.SetParameters(param);
                ReportDataSource reportDataSource = new ReportDataSource("DataSetDonHang", listOrder);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.DisplayName = "Phiếu giao hàng:";
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
