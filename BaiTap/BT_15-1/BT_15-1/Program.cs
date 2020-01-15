using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            int so;
            do
            {
                Console.WriteLine("Nhap vao so nguyen duong: ");
                so = int.Parse(Console.ReadLine());
                if (so < 0) Console.WriteLine("So nhap vao phai lon hon 0");
            } while (so < 0);
           

            if (so % 2 == 0)
                Console.WriteLine("So chan!!");
            else Console.WriteLine("So le!!");

            Console.ReadLine();
        }
    }
}
