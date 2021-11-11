using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    public class KhuDat
    {
        private string diaChi;
        private float giaBan;
        private float dienTich;

        public string DiaChi { get => diaChi; set => diaChi = value; }
        public float GiaBan { get => giaBan; set => giaBan = value; }
        public float DienTich { get => dienTich; set => dienTich = value; }


        public KhuDat()
        {

        }
        public KhuDat(string diaChi, float giaBan, float dienTich)
        {
            this.diaChi = diaChi;
            this.dienTich = dienTich;
            this.giaBan = giaBan;
        }
        public virtual int getNamXayDung()
        {
            KhuDat kd = new NhaPho();
            return kd.getNamXayDung();
        }

        public virtual void Nhap()
        {
            Console.WriteLine();
            Console.Write(" Nhap Dia Chi : ");
            diaChi = Console.ReadLine();
            Console.Write(" Nhap Gia Ban : ");
            giaBan = float.Parse(Console.ReadLine());
            Console.Write(" Nhap Dien Tich : ");
            dienTich = float.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("\n Dia Chi : {0} \t\t Dien Tich : {1} \t Gia Ban : {2}", diaChi, dienTich, giaBan);
        }

    }
}
