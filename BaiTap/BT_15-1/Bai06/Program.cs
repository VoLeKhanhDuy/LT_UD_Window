using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Nhap vao a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao c: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao d: ");
            d = int.Parse(Console.ReadLine());

            if (a > b && a > c && a > d)
                Console.WriteLine("So lon nhat la: " + a);
            else if (b > a && b > c && b > d)
                Console.WriteLine("So lon nhat la: " + b);
            else if (c > a && c > b && c > d)
                Console.WriteLine("So lon nhat la: " + c);
            else Console.WriteLine("So lon nhat la: " + d);

            Console.ReadLine(); 
        }
    }
}
