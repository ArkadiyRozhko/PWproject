using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            Console.WriteLine("Введите строку:");
            str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            str2 = Console.ReadLine();

            if (String.Compare(str1,str2)>0)
            {
                Console.WriteLine("Строка\n{0}\nбольше строки\n{1}");
            }
            else if(String.Compare(str1, str2) < 0)
            {
                Console.WriteLine("Строка\n{0}\nменьше строки\n{1}");
            }
            else
            {
                Console.WriteLine("Строка равны");
            }




        }
    }
}
