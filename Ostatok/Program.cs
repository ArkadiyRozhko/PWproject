using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostatok
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            float f1, f2;

            num1 = 13 / 3;
            num2 = 13 % 3;

            f1 = 13.0f / 3.0f;
            f2 = 13.0f % 3.0f;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Результат і залишок від ділення 13 на 3 = {0} - {1}",num1,num2);
            Console.WriteLine("Результат ділення 13,0 на 3,0 = {0:#.###} - {1}",f1,f2);

            Console.ReadLine();
        }
    }
}
