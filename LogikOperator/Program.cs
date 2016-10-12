using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            short d = 10, f = 12;
            bool var1 = true, var2 = false;

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            if (d<f)
            {
                Console.WriteLine("d < f");
            }

            if (d<=f)
            {
                Console.WriteLine("d <= f");
            }

            if (d!=f)
            {
                Console.WriteLine("d != f");
            }

            if (d>f)
            {
                Console.WriteLine("d > f");
            }

            if (var1&var2)
            {
                Console.WriteLine("var1 & var2");
            }

            if (!(var1 & var2))
            {
                Console.WriteLine("! (var1 & var2) = true");
            }

            if (var1 | var2)
            {
                Console.WriteLine("var1 | var2 = true");
            }

            if (var1 ^ var2)
            {
                Console.WriteLine("var1 ^ var2 = true");
            }

            Console.ReadLine();


        }
    }
}
