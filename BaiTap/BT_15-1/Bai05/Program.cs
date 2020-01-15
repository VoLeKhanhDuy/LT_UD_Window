using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            Console.WriteLine("Nhap vao canh a: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao canh b: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao canh c: ");
            c = float.Parse(Console.ReadLine());

            if((a + b > c || b + c > a || a + c > b) && ((a == b) || (a == c) || (b == c)))
            {
                Console.WriteLine("3 CANH VUA NHAP TAO THANH 1 TAM GIAC CAN");
            }



            Console.ReadLine();
        }
    }
}
