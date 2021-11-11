using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; //Để sử dụng tiếng việt
            Console.InputEncoding = Encoding.Unicode;
            //Nhập tổng số sinh viên N, Convert kiểu dữ liệu sang biến N kiểu int 
            Console.Write("Nhập tổng số sinh viên N =");
            int N = Convert.ToInt32(Console.ReadLine());

            Student[] arrStudents = new Student[N];
            Console.WriteLine("\n ====Nhập Danh Sách sinh viên====");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n - Nhập sinh viên thứ {0}", i + 1);
                arrStudents[i] = new Student();
                arrStudents[i].Input();
            }
            Console.WriteLine("\n ====Xuất Danh Sách sinh viên====");
            foreach (Student sv in arrStudents)
            {
                sv.Show();
            }
            Console.ReadKey(); //Dừng màn hình kiểm tra kết quả
        }
    }
}
