using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, tong = 0;

            Console.WriteLine("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                tong += i;
            }
            Console.WriteLine("Tong cac so tu 1 den {0} la: {1} " + n, tong);

            Console.ReadLine();
        }
    }
}
