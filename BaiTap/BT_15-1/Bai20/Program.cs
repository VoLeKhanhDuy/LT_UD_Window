using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    class Program
    {
        static void Main(string[] args)
        {
            int so1, so2, ucln = 1;

            Console.WriteLine("Nhap vao so thu nhat: ");
            so1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao so thu nhat: ");
            so2 = int.Parse(Console.ReadLine());
            int j = (so1 < so2) ? so1 : so2;
            for (int i = 0; i <= j; i++)
            {
                if(so1 %i == 0 && so2 %i == 0)
                {
                    ucln = i;
                }
            }
            Console.WriteLine("Uoc chung lon nhat cua 2 so vua nhap la: " + ucln);
            Console.ReadLine();
        }
}
