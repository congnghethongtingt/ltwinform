using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class Program
    {
        static KhuDat khuDat;
        static List<KhuDat> listKhuDat = new List<KhuDat>();
        public static void XuatDS()
        {
            foreach (KhuDat kd in listKhuDat)
            {
                kd.Xuat();
            }
        }
        public static void tong3Loai()
        {
            float SumGia = 0;

            foreach (KhuDat khuDat in listKhuDat)
            {
                SumGia += khuDat.GiaBan;
            }
            Console.WriteLine(" Gia tien tong danh sach 3 loai la: {0}", SumGia);
        }
        public static void XuatDSTheoDk()
        {
            foreach (KhuDat kd in listKhuDat)
            {
                if (kd.GetType().ToString() == "Lab01_04.KhuDat" && kd.DienTich > 100) kd.Xuat();
                if (kd.GetType().ToString() == "Lab01_04.NhaPho" && kd.DienTich > 60 && kd.getNamXayDung() >= 2020) kd.Xuat();
            }
            Console.WriteLine("\n Danh sach cac khu dat co dien tich > 100m2 hoac nha pho co dien tich >60m2 va nam xay dung >= 2020");
        }

        private static bool KiemTra(KhuDat kd, string diaChiCanTiem, float giaBanCanTiem, float dienTichCanTiem)
        {
            if (kd.DiaChi.Contains(diaChiCanTiem) && kd.GiaBan <= giaBanCanTiem && kd.DienTich >= dienTichCanTiem)
                return true;
            return false;
        }
        private static void TimKiem()
        {
            string diaChi;
            float giaBan, dienTich;
            Console.Write(" Nhap dia chi can tim: ");
            diaChi = Console.ReadLine();
            Console.Write(" Nhap gia can tim : ");
            giaBan = float.Parse(Console.ReadLine());
            Console.Write(" Nhap dien tich can tim: ");
            dienTich = float.Parse(Console.ReadLine());

            foreach (KhuDat kd in listKhuDat)
            {
                if (KiemTra(kd, diaChi, giaBan, dienTich)) kd.Xuat();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            do
            {
                Console.WriteLine("================MENU================");
                Console.WriteLine("\t1. Nhap thong tin Khu dat");
                Console.WriteLine("\t2. Nhap thong tin Nha pho");
                Console.WriteLine("\t3. Nhap thong tin Chung cu");
                Console.WriteLine("\t4. Xuat Danh Sach Thong Tin");
                Console.WriteLine("\t5. Tong gia 3 loai");
                Console.WriteLine("\t6. Danh sach cac khu dat co dien tich > 100m2 hoac la nha pho co dien tich >60m2 va nam xay dung >= 2020");
                Console.WriteLine("\t7. Xuat thong tin danh sach tat ca cac nha pho hoac chung cu phu hop yeu cau.(");
                Console.WriteLine("\t0. END");
                Console.WriteLine("=====================================");
                int luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        khuDat = new KhuDat();
                        Console.WriteLine("Thong tin Khu Dat: ");
                        khuDat.Nhap();
                        listKhuDat.Add(khuDat);
                        break;
                    case 2:
                        Console.WriteLine("Thong tin Nha Pho: ");
                        khuDat = new NhaPho();
                        khuDat.Nhap();
                        listKhuDat.Add(khuDat);
                        break;
                    case 3:
                        Console.WriteLine("Thong tin Chung Cu: ");
                        khuDat = new ChungCu();
                        khuDat.Nhap();
                        listKhuDat.Add(khuDat);
                        break;
                    case 4:
                        Console.WriteLine("Danh Sach Thong Tin ");
                        XuatDS();
                        break;
                    case 5:
                        Console.WriteLine("Tong gia cua 3 loai: ");
                        tong3Loai();
                        break;
                    case 6:
                        XuatDSTheoDk();
                        break;
                    case 7:
                        Console.WriteLine("Thong tin tim kiem phu hop yeu cau: ");
                        TimKiem();
                        break;

                    default:
                        return;

                }

            } while (true);
        }
    }
}
