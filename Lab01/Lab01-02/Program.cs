using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Program
    {
        static Person person;
        static List<Person> listPerson = new List<Person>();
        public static void XuatDS(List<Person> people)
        {
            foreach (Person ps in people)
            {
                ps.Xuat();
            }
        }
        private static void XuatDSSinhVienCNTT()
        {
            var listStus = listPerson.OfType<Student>().ToList();
            Console.WriteLine("\n ==== Xuat Danh Sach Sinh Vien CNTT ====");
            List<Person> listStudentCNTT = (from s in listStus where s.Faculty == "CNTT" select s).Cast<Person>().ToList();
                XuatDS(listStudentCNTT);

        }
        private static void XuatDSSinhVienCNTTDTBBeHon5()
        {            
            Console.WriteLine("\n ==== Xuat Danh Sach Sinh Vien CNTT DTB <5 ====");
            var listStus = listPerson.OfType<Student>();
            List<Person> listStudentCNTTDTBBeHon5 = (from s in listStus where s.AverageScore < 5 && s.Faculty == "CNTT" select s).Cast<Person>().ToList();
                XuatDS(listStudentCNTTDTBBeHon5);
        }

        private static void XuatDSGVDiaChiQuan9()
        {   
            Console.WriteLine("==== Xuat Danh Sach Giao Vien Quan 9 ====");
            var listTech = listPerson.OfType<Teacher>();
            List<Person> listGVQuan9 = (from s in listTech where s.DiaChi == "Quan 9" select s).Cast<Person>().ToList();
                XuatDS(listGVQuan9);

        }
        private static void XuatDSGVTheoMa()
        {           
            Console.WriteLine("==== Xuat Danh Sach Giao Vien Theo ma CHN060286 ====");
            var listTech = listPerson.OfType<Teacher>();
            List<Person> listGVTheoMa = (from s in listTech where s.PersonID == "CHN060286" select s).Cast<Person>().ToList();
                XuatDS(listGVTheoMa);
        }

        private static void XuatDSSinhVienCNTTDTBCaoNhat()
        {
            Console.WriteLine("==== Xuat Danh Sach sinh vien CNTT DTB Cao Nhat ==== ");
            var listStus = listPerson.OfType<Student>();
            List<Student> listStudentCNTTDTBLonHon5 = (from s in listStus where s.AverageScore >= 5 && s.Faculty == "CNTT" select s).ToList();
            var result = listStudentCNTTDTBLonHon5.OrderByDescending(x => x.AverageScore).FirstOrDefault();      
            result.Xuat();
        }

            static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhap tong so N Person =");
            int N = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            Console.WriteLine("\n==== Nhap Danh Sach Person ====");
            do
            {
                temp = listPerson.Count();
                Console.WriteLine("===========Moi chon cong viec muon thuc hien==========");
                Console.WriteLine("\t1. Nhap Thong Tin SV");
                Console.WriteLine("\t2. Nhap Thong Tin GV");
                Console.WriteLine("\t3. Xuat Danh Sach");
                Console.WriteLine("\t4. Xuat DS SV thuoc khoa CNTT");
                Console.WriteLine("\t5. Xuat DS SV thuoc khoa CNTT co diem <5");
                Console.WriteLine("\t6. Xuat DS GV co chua thong tin 'Quan 9' ");
                Console.WriteLine("\t7. Xuat DS GV co ma la 'CHN060286'");
                Console.WriteLine("\t8. Xuat DS SV thuoc khoa CNTT co diem TB cao nhat");
                Console.WriteLine("\t0. END.");
                Console.WriteLine("=======================================================");
                int luaChon = int.Parse(Console.ReadLine());
                if (temp == N) Console.WriteLine("Khong the them thong tin SV hay GV duoc nua!!!");
                switch (luaChon)
                {
                    case 1:
                        person = new Student();
                        person.Nhap();
                        break;
                    case 2:
                        person = new Teacher();
                        person.Nhap();
                        break;
                    case 3:
                        XuatDS(listPerson);
                        break;
                    case 4:
                        XuatDSSinhVienCNTT();
                        break;
                    case 5:
                        XuatDSSinhVienCNTTDTBBeHon5();
                        break;
                    case 6:
                        XuatDSGVDiaChiQuan9();
                        break;
                    case 7:
                        XuatDSGVTheoMa();
                        break;
                    case 8:
                        XuatDSSinhVienCNTTDTBCaoNhat();
                        break;
                    default:
                        return;

                }
                if (!(temp == N)) listPerson.Add(person);
            } while (!(temp > N));

        }


    }
}
