using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть розмірність таблиці");

            int num = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <=num; i++)
            {
                for (int j = 1; j <=num; j++)
                {
                    Console.Write("{0}\t",i*j);

                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }
}
