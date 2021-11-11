using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Student
    {
        //1. Tao thuoc tinh 
        private string studentID; //mã số sinh viên
        private string fullName; // họ tên sinh viên
        private float averageScore; //điểm trung bình
        private string faculty; //khoa 
        //2. Tao các Property (tip: chọn Quick Actions And Refactorings từ thuộc tính)
        public string StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
        public float AverageScore
        {
            get
            {
                return averageScore;
            }
            set
            {
                averageScore = value;
            }
        }
        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
            }
        }
        // 3. Tạo constructor m nh không tham s
        public Student()
        {
        }
        // 4. Tạo constuctor có tham số
        public Student(string id, string name, float score, string faculty)
        {
            StudentID = id;
            FullName = name;
            AverageScore = score;
            Faculty = faculty;
        }
        // 5. Viết các phương trình nhập, xuất sinh viên
        public void Input()
        {
            Console.Write("Nhập MSSV:");
            StudentID = Console.ReadLine();
            Console.Write("Nhập Họ tên Sinh viên:");
            FullName = Console.ReadLine();

            float kq;
            bool Ketqua;
            do
            {
                Console.Write("Nhập Điểm TB:");
                string textInput = Console.ReadLine();
                Ketqua = float.TryParse(textInput, out kq); //ép sang kiểu float 
            } while (!Ketqua);
            averageScore = kq;



            Console.Write("Nhập Khoa:");
            Faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine(" MSSV:{0} \n Họ Tên:{1} \n Khoa:{2} \n ĐiểmTB:{3}", this.StudentID, this.fullName, this.Faculty, this.AverageScore);
        }
    }
}
