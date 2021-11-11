using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Student : Person
    {

        private float averageScore; //diemTB
        private string faculty; //khoa

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
        public Student(string id, string name, float averageScore, string faculty) : base(id, name)
        {
            AverageScore = averageScore;
            Faculty = faculty;
        }

        public override void Nhap()
        {
            base.Nhap();
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
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\n Khoa:{0} \n DiemTB:{1} \n", this.Faculty, this.AverageScore);
        }
    }
}