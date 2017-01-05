using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStatic
{
    class Program
    {
        class MyCircle
        {
            public static double SqrCircle(double radius)
            {
                return Math.PI * radius * radius;
            }
            public static double LongCircle(double radius)
            {
                return 2 * Math.PI * radius;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");

            double r = Double.Parse(Console.ReadLine());

            Console.WriteLine("Площадь круга = {0}",MyCircle.SqrCircle(r));
            Console.WriteLine("Длинна окружности = {0}", MyCircle.LongCircle(r));
            Console.ReadLine();

        }
    }
}
