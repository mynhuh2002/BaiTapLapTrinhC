using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001207332_HoMyNhu_LTHDT_Buoi3
{
    class PhanSo
    {
        int tu, mau;

        public void NhapPhanso()
        {
            Console.Write("Nhap tu so: ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            do
                this.mau = int.Parse(Console.ReadLine());
            while (this.mau == 0);
        }

        public void XuatPhanso()
        {
            Console.Write("Phan so la" +tu+ "/"+mau);
        }

        public void Rutgon()
        {

        }

             static void Main(string[] args)
        {
                 PhanSo ps= new PhanSo();
                 ps.NhapPhanso();
                 Console.ReadLine();
        }
    }
}
