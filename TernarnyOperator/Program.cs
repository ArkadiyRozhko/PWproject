using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernarnyOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            // Реализуем функцию модуля числа
            for (int i = 5; i >= -5; i--)
            {
                result = i >= 0 ? i : -i;
                Console.Write("{0}\t", result);
            }

            Console.WriteLine("\n\n");

            // Выбор четных чисел
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0 ? true : false)
                    Console.Write("{0}\t", i);
            }

            Console.ReadLine();
        }
    }
}
