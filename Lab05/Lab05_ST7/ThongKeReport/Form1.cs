using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThongKeReport.Model;
using Microsoft.Reporting.WinForms;

namespace ThongKeReport
{
    public partial class Form1 : Form
    {
        DBThongKe dbthongKe = new DBThongKe();
        //private List<ThongKeModel> listThongKe;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDateFormat();
            dtTuNgay.Enabled = false;
            dtDenNgay.Enabled = false;
            dtNgay.Enabled = false;
            dtThang.Enabled = false;
            reportViewer1.Visible = false;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void SetDateFormat()
        {
            dtNgay.Value = new DateTime(2019, 10, 02);
            dtThang.Value = new DateTime(2019, 10, 02);
            dtTuNgay.Value = new DateTime(2019, 10, 02);
            dtDenNgay.Value = new DateTime(2019, 10, 02);
            dtNgay.Format = DateTimePickerFormat.Custom;
            dtThang.CustomFormat = "dd/MM/yyyy";
            dtThang.Format = DateTimePickerFormat.Custom;
            dtThang.CustomFormat = "MM/yyyy";
            dtTuNgay.Format = DateTimePickerFormat.Custom;
            dtTuNgay.CustomFormat = "dd/MM/yyyy";
            dtDenNgay.Format = DateTimePickerFormat.Custom;
            dtDenNgay.CustomFormat = "dd/MM/yyyy";
        }

        private void rdoNgay_Click(object sender, EventArgs e)
        {
        }

        private void rdoNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtNgay.Enabled = true;
            dtThang.Enabled = false;

            dtTuNgay.Enabled = false;
            dtDenNgay.Enabled = false;
        }


        private void rdoThang_CheckedChanged(object sender, EventArgs e)
        {
            dtThang.Enabled = true;
            dtNgay.Enabled = false;

            dtTuNgay.Enabled = false;
            dtDenNgay.Enabled = false;
        }

        private void rdoTuNgayDenNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtTuNgay.Enabled = true;
            dtDenNgay.Enabled = true;
            dtThang.Enabled = false;
            dtNgay.Enabled = false;
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            if (rdoNgay.Checked == true)
            {
                List<Order> listOrders = dbthongKe.Orders.Where(p => p.Invoice.DeliveryDate == dtNgay.Value).ToList();
                List<ThongKeModel> listTKs = new List<ThongKeModel>();

                var List2 = from q in listOrders
                            group q by new { q.InvoiceNo, q.Invoice.OrderDate, q.Invoice.DeliveryDate } into p
                            select new { InvoiceNo = p.Key.InvoiceNo, OrderDate = p.Key.OrderDate, p.Key.DeliveryDate, Price = p.Sum(o => o.Price * o.Quantity) };

                if (List2.Count() == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng!");
                    return;
                }
                foreach (var item in List2)
                {
                    ThongKeModel thongkeReport = new ThongKeModel();
                    thongkeReport.SoHD = item.InvoiceNo;
                    thongkeReport.GiaoHang = item.DeliveryDate;
                    thongkeReport.tongTien = Convert.ToDouble(item.Price);
                    listTKs.Add(thongkeReport);
                    //this.reportViewer1.LocalReport.ReportPath = "./Reports/ThongKeReport.rdlc";
                    //ReportParameter[] param = new ReportParameter[1];
                    //param[0] = new ReportParameter("Ngay1Parameter", string.Format(item.DeliveryDate.ToString("dd/MM/yyyy")));
                    //reportViewer1.LocalReport.SetParameters(param);
                }
                this.reportViewer1.LocalReport.ReportPath = "./Reports/ReportThongKeTheoThoiGian.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource("DataSetThongKeThoiGian", listTKs);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            if (rdoThang.Checked == true)
            {
                List<Order> listOrders = dbthongKe.Orders.Where(p => p.Invoice.DeliveryDate == dtThang.Value).ToList();
                List<ThongKeModel> listTKReports = new List<ThongKeModel>();
                var list2 = from q in listOrders
                            group q by new { q.InvoiceNo, q.Invoice.DeliveryDate } into p
                            select new { InvoiceNO = p.Key.InvoiceNo, DeliveryDate = p.Key.DeliveryDate, Price = p.Sum(o => o.Price * o.Quantity) };
                if (list2.Count() == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng!");
                    return;
                }
                foreach (var item in list2)
                {
                    ThongKeModel thongkeReport = new ThongKeModel();
                    thongkeReport.SoHD = item.InvoiceNO;
                    thongkeReport.GiaoHang = item.DeliveryDate;
                    thongkeReport.tongTien = Convert.ToDouble(item.Price);
                    listTKReports.Add(thongkeReport);
                }
                this.reportViewer1.LocalReport.ReportPath = "./Reports/ReportThongKeTheoThoiGian.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource("DataSetThongKeThoiGian", listTKReports);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            if (rdoNgay.Checked == true)
            {
                List<Order> listOrders = dbthongKe.Orders.Where(p => p.Invoice.DeliveryDate >= dtNgay.Value && p.Invoice.DeliveryDate <= dtDenNgay.Value).ToList();
                List<ThongKeModel> listTKReports = new List<ThongKeModel>();
                var list2 = from q in listOrders
                            group q by new { q.InvoiceNo, q.Invoice.OrderDate, q.Invoice.DeliveryDate } into p
                            select new { InvoiceNo = p.Key.InvoiceNo, OrderDate = p.Key.OrderDate, p.Key.DeliveryDate, Price = p.Sum(o => o.Price * o.Quantity) };
                if (list2.Count() == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng!");
                    return;
                }
                foreach (var item in list2)
                {
                    ThongKeModel thongkeReport = new ThongKeModel();
                    thongkeReport.SoHD = item.InvoiceNo;
                    thongkeReport.GiaoHang = item.DeliveryDate;
                    thongkeReport.tongTien = Convert.ToDouble(item.Price);
                    listTKReports.Add(thongkeReport);
                }
                this.reportViewer1.LocalReport.ReportPath = "./Reports/ReportThongKeTheoThoiGian.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource("DataSetThongKeThoiGian", listTKReports);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }

}
