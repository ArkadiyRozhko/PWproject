using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        class MyMathOperation
        {
            public double r;
            public string s;

            public double sqrCircle()
            {
                return Math.PI * r * r;
            }

            public double longCircle()
            {
                return 2 * Math.PI * r;
            }

            public void writeResult()
            {
                Console.WriteLine("Вывести площадь или длинну? s/l");
                s = Console.ReadLine();
                //s = s.ToLower();
                if (s == "s")
                {
                    Console.WriteLine("Площадь круга равна = {0:#.###}",sqrCircle());
                    return;

                }
                else if (s=="l")
                {
                    Console.WriteLine("Длинна окружности равна = {0:#.###}",longCircle());
                    return;
                }
                else
                {
                    Console.WriteLine("Вы ввели не правильный символ!!!!!");
                }
            }
        }
        static void Main(string[] args)
        {
            MyMathOperation math = new MyMathOperation();
            Console.WriteLine("Введите радиус окружности:");
            string radius = Console.ReadLine();
            math.r = double.Parse(radius);
            math.writeResult();
            Console.ReadKey();            
        }
    }
}
