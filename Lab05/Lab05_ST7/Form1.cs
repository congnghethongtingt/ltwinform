using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05_ST7.Model;
using Microsoft.Reporting.WinForms;

namespace Lab05_ST7
{
    public partial class ReportSV : Form
    {

        DBContentSV dbSinhVien = new DBContentSV(); //Khởi tạo
        public ReportSV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> listStudent = dbSinhVien.Students.ToList();
            List<SinhVienReport> listSVReport = new List<SinhVienReport>();
            
            foreach(var student in listStudent)
            {
                SinhVienReport sinhVienReport = new SinhVienReport();
                sinhVienReport.StudentID = student.StudentID;
                sinhVienReport.StudentName = student.FullName;
                sinhVienReport.DiemTB = student.AvarageScroce;
                sinhVienReport.FacultyName = student.Faculty.FacultyName;

                listSVReport.Add(sinhVienReport);
            }

            this.reportViewer1.LocalReport.ReportPath = "./Report/ReportSV.rdlc"; //Gan duong dan
            var reportDataSource = new ReportDataSource("DataSetSV",listSVReport);
            this.reportViewer1.LocalReport.DataSources.Clear();//xoa du lieu cu
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
