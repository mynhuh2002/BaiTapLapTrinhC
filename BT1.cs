using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001207332_HoMyNhu_LTHDT_Buoi3
{
    class TinhKhoangCach
    {
        double xa, xb, ya, yb, khoangcach;
        public void Nhap()
        {
            Console.Write("Nhap diem X cua a: ");
            xa = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem Y cua a: ");
            ya = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem X cua b: ");
            xb = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem Y cua b: ");
            xa = double.Parse(Console.ReadLine());
        }

        public void Tinhkhoangcach()
        {
            khoangcach = Math.Sqrt((xb - xa) + (yb - ya) * (yb - ya));

        }
         static void Main(string[] args)
        {
            TinhKhoangCach tkc = new TinhKhoangCach();
            tkc.Nhap();
            Console.Write("Khoang cach = ", tkc.Tinhkhoangcach());
            Console.ReadLine();
        }

    }

}
