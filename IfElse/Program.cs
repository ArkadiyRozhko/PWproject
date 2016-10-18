using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");

            string str = Console.ReadLine();

            if (str.Length<5)
            {
                Console.WriteLine("В строке меньше 5 символов!");
            }
            else if ((str.Length>=5)&&(str.Length<=12))
            {
                Console.WriteLine("В даной строке {0} символов",str.Length);
            }
            else
            {
                Console.WriteLine("В строке больше 12 символов");
            }

            Console.ReadKey();
        }
    }
}
