using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001207332_HoMyNhu_LTHDT_Buoi3
{
    class Thisinh
    {
        string HoTen;
        int sbd, namsinh;
        float diemlythuyet, diemthuchanh;
    
        public void Nhap()
        {
            Console.Write("Nhap ho ten thi sinh: ");
            HoTen =Console.ReadLine();
            Console.Write("Nhap so bao danh: ");
            sbd = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam sinh: ");
            namsinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly thuyet: ");
            diemlythuyet = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem thuc hanh: ");
            diemthuchanh = float.Parse(Console.ReadLine());
        }

        public void Ketqua()
        {
            float tongdiem = diemthuchanh+diemlythuyet;
            if(tongdiem >10 || diemlythuyet >2 || diemthuchanh >2)
            {
                Console.Write("Dau");
                
            }
            else
                Console.Write("Khong dau");
        }

        public void Xuat()
        {
            Console.Write("Ho ten thi sinh: ", HoTen);
            Console.Write("So bao danh: ", sbd);
            Console.Write("Nam sinh: ", namsinh);
            Console.Write("Diem ly thuyet: ", diemlythuyet);
            Console.Write("Diem thuc hanh: ", diemthuchanh);
        }

                 static void Main(string[] args)
        {
                     Thisinh ts = new Thisinh();
                     ts.Nhap();
                     ts.Xuat();
                     Console.WriteLine("Ket qua cua thi sinh la: ", ts.Ketqua());
                     Console.ReadLine();


        }
    }
}
