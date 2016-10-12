using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inkrement_dekrement
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = 1;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+ n++ + "\t");
                
            }
            Console.WriteLine();

            n = 1;

            for (int i = 0; i <10;  i++)
            {
                Console.Write(i+ ++n + "\t");
               
            }
            Console.ReadLine();
        }
    }
}
