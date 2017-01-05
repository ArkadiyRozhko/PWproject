using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static class MyMath
        {
            public static int Round(double d)
            {
                return (int)d;
            }
            public static double Doub(double d)
            {
                return d - (int)d;
            }
            public static double Sqr(double d)
            {
                return d * d;
            }
            public static double Sqrt(double d)
            {
                return Math.Sqrt(d);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Исходное число = 12,5");
            Console.WriteLine("Целая часть = {0}",MyMath.Round(d:12.5));
            Console.WriteLine("Дробная часть = {0}",MyMath.Doub(d:12.5));
            Console.WriteLine("Квадрат числа = {0:##.###}",MyMath.Sqr(d:12.5));
            Console.WriteLine("Квадратный корень = {0:##.###}",MyMath.Sqrt(d:12.5));

            Console.ReadKey();
        }
    }
}
