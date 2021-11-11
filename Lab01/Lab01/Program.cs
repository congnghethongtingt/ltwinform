using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab01
{
    class Program
    {
        private static List<Student> NhapDSSinhVien()
        {
            List<Student> listStudents = new List<Student>();
            Console.Write("Nhập tong so sinh vien N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n===Nhap Danh Sach Sinh Vien===");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n - Nhap sinh vien thu {0}", i + 1);
                Student temp = new Student();
                temp.Input();
                listStudents.Add(temp);

            }
            return listStudents;
        }

        private static void XuatDSSinhVien(List<Student> listStudent)
        {
            Console.WriteLine("\n ====Xuat Danh Sach Sinh Vien====");
            foreach (Student sv in listStudent)
            {
                sv.Show();
            }
        }

        private static void XuatDSSinhVienCNTT(List<Student> listStudent)
        {
            Console.WriteLine("1.1 Danh Sach Sinh Vien Khoa CNTT");
            List<Student> listStudentCNTT = listStudent.Where(p => p.Faculty == "CNTT").ToList();
            if (listStudentCNTT.Count() == 0)
                Console.WriteLine("Khong co sinh vien thuoc khoa CNTT");
            else
            {
                XuatDSSinhVien(listStudentCNTT);
                Console.ReadLine();
            }
        }

        private static void XuatDSSinhVienDTBLonHonBang5(List<Student> listStudent)
        {
            Console.WriteLine("1.2 Thong tin Sinh Vien co diem TB lon hon hoac bang 5");
            List<Student> listStudentReSult = listStudent.Where(p => p.AverageScore >= 5).ToList();
            if (listStudentReSult.Count == 0)
                Console.WriteLine("Khong co sinh vien co diem tb >=5");
            else
                XuatDSSinhVien(listStudentReSult);
            Console.ReadLine();
        }

        private static void XuatDSSinhVienDiemTangDan(List<Student> listStudent)
        {
            Console.WriteLine("1.3 Sap xep sinh vien co diem tang dan");
            List<Student> listStudentSort = listStudent.OrderBy(p => p.AverageScore).ToList();
            XuatDSSinhVien(listStudentSort);
            Console.ReadLine();
        }

        private static void XuatDSSinhVienCNTTDTBLonHonBang5(List<Student> listStudent)
        {
            Console.WriteLine("1.4 Sinh vien co diem TB >=5 va thuoc khoa CNTT");
            List<Student> listStudentCNTTReSult = listStudent.Where(p => p.AverageScore >=5 && p.Faculty == "CNTT").ToList();
            if (listStudentCNTTReSult.Count == 0)
                Console.WriteLine("Khong co sinh vien khoa CNTT co diem TB >=5");
            else
                XuatDSSinhVien(listStudentCNTTReSult);
                Console.ReadLine();
        }

        private static void XuatDSSinhVienCNTTDTBCaoNhat(List<Student> listStudent)
        {
            List<Student> listStudentCNTTMax = listStudent.Where(p => p.AverageScore >= 5 && p.Faculty == "CNTT").ToList();
            var result = listStudentCNTTMax.OrderByDescending(x => x.AverageScore).First();
            Console.WriteLine("\n ====Sinh vien co diem TB cao nhat va thuoc khoa CNTT==== ");
            if (listStudentCNTTMax.Count == 0)
                Console.WriteLine("Khong co sinh vien co diem TB cao nhat thuoc khoa CNTT");
            else
                XuatDSSinhVien(listStudentCNTTMax);
                Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            List<Student> listStudent = NhapDSSinhVien();
            XuatDSSinhVien(listStudent);
            Console.ReadKey();

            XuatDSSinhVien(listStudent);
            XuatDSSinhVienCNTT(listStudent);
            XuatDSSinhVienDTBLonHonBang5(listStudent);
            XuatDSSinhVienDiemTangDan(listStudent);
            XuatDSSinhVienCNTTDTBLonHonBang5(listStudent);
            XuatDSSinhVienCNTTDTBCaoNhat(listStudent);


        }


    }

}