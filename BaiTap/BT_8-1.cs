using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, Delta;

            Console.WriteLine("Nhap vao he so a: ");
            a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao he so b: ");
            b = Double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao he so c: ");
            c = Double.Parse(Console.ReadLine());


            Delta = (b * b) - 4 * a * c;

            if(a == 0)
            {
                if(b == 0 && c == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem!!");
                }
                else if(b == 0 && c != 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem!!");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem: " + (-c) / b);
                }
            }
            else
            {
                 if(Delta < 0)
                 {
                       Console.WriteLine("Phuong trinh vo nghiem!!");
                 }
                 else if(Delta == 0)
                 {
                       Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = " + ((-b)/(2*a)));
                 }
                 else
                 {
                       Console.WriteLine("Phuong trinh co 2 nghiem phan biet: x1 = " + (((-b) + Math.Sqrt(Delta)) / 2) + "\nx2 =" + (((-b) - Math.Sqrt(Delta)) / 2));
                 }

            }
           
            Console.ReadLine();
        }
    }
}
