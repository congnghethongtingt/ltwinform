using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab01
{
    class Student
    {
        private string studentID;
        private string fullName;
        private float averageScore; //diemTB
        private string faculty; //khoa

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

        public Student()
        {

        }
        public Student(string id, string name, float score, string faculty)
        {
            StudentID = id;
            FullName = name;
            AverageScore = score;
            Faculty = faculty;
        }

        public void Input()
        {
            Console.Write(" Nhap MSSV: ");
            StudentID = Console.ReadLine();
            Console.Write(" Nhap Ten SV: ");
            FullName = Console.ReadLine();

            float kq;
            bool Ketqua;
            do
            {
                Console.Write(" Nhap Diem TB: ");
                string textInput = Console.ReadLine();
                Ketqua = float.TryParse(textInput, out kq);
            } while (!Ketqua);
            averageScore = kq;

            Console.Write(" Nhap Ten Khoa: ");
            Faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine(" MSSV:{0} \n Ho Ten:{1} \n Khoa:{2} \n DiemTB:{3} \n", this.StudentID, this.FullName, this.Faculty, this.AverageScore);
        }
    }
}
