using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, luachon, kq ;

            Console.WriteLine("Nhap vao a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("1.Cong");
            Console.WriteLine("2.Tru");
            Console.WriteLine("3.Nhan");
            Console.WriteLine("4.Chia");
            Console.WriteLine("Lua chon: ");
            luachon = int.Parse(Console.ReadLine());
            switch (luachon) {
                case 1:
                    kq = a + b;
                    Console.WriteLine("{0} + {1} = {2}", a, b, kq);
                    break;
                case 2:
                    kq = a - b;
                    Console.WriteLine("{0} - {1} = {2}", a, b, kq);
                    break;
                case 3:
                    kq = a * b;
                    Console.WriteLine("{0} * {1} = {2}", a, b, kq);
                    break;
                case 4:
                    kq = a / b;
                    Console.WriteLine("{0} / {1} = {2}", a, b, kq);
                    break;
                default:
                    Console.WriteLine("Phep toan khong hop le!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
