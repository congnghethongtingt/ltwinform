using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class NhaPho : KhuDat
    {
        private int namXayDung;
        private int soTang;

        public int NamXayDung { get => namXayDung; set => namXayDung = value; }
        public int SoTang { get => soTang; set => soTang = value; }
        public override int getNamXayDung()
        {
            return this.NamXayDung;
        }

        public NhaPho() : base()
        {

        }

        public NhaPho(string diaChi, float giaBan, float dienTich, int namXayDung, int soTang) : base(diaChi, dienTich, giaBan)
        {
            this.namXayDung = NamXayDung;
            this.soTang = SoTang;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine();
            Console.Write("\n Nhap nam xay dung : ");
            NamXayDung = int.Parse(Console.ReadLine());
            Console.Write("\n Nhap so tang nha pho : ");
            SoTang = int.Parse(Console.ReadLine());

        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write(" Nam xay dung:{0} \t So tang:{1} \n", this.NamXayDung, this.SoTang);
        }
    }
}
