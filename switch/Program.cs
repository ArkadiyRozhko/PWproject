using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введіть мову програмування (C#, VB або C++)");

            string str = Console.ReadLine();
            sw(str);
            Console.ReadKey();

            
        }
        static void sw(string st)
        {
            switch (st)
            {
                case "C#":
                    Console.WriteLine("Мова С#");
                    break;
                case "VB":
                    Console.WriteLine("Мова VB");
                    break;
                case "C++":
                    Console.WriteLine("Мова С++");
                    break;
                
                default:
                    Console.WriteLine("не правильне введення!");
                    break;
            }
        }
    }
}
