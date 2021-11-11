using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class ChungCu : KhuDat
    {
        private int tang;
        public int Tang { get => tang; set => tang = value; }
        public ChungCu() : base() { }

        public ChungCu(string diaChi, float giaBan, float dienTich, int tang) : base(diaChi, dienTich, giaBan)
        {

            this.tang = Tang;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine();
            Console.Write("\n Nhap tang chung cu : ");
            Tang = int.Parse(Console.ReadLine());

        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write(" Tang : {0} \n", this.Tang);
        }

    }
}
