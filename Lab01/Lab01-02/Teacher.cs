using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Teacher : Person
    {
        private string diaChi;


        public string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }

        public Teacher() 
        { 
        
        }

        public Teacher(string id, string name, string diaChi) : base(id, name)
        {
            DiaChi = diaChi;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Dia chi:");
            DiaChi = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("\tDia chi:{0}\n1", this.DiaChi);
        }
    }

}
