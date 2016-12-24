using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Первая строка";

            Console.WriteLine("Длинна строки ={0}\n 6-ой елемент - {1}", str.Length,str[5]);
            Console.ReadLine();
        }
    }
}
