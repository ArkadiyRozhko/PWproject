using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regexpApp
{
    class Program
    {
        public static object Regexp { get; private set; }

        static void Main(string[] args)
        {
            string[] strs = new string[] { "Wuck World", "Hello world", "My wonderful world" };

            Regex regexp = new Regex("World");

            Console.WriteLine("Регистрозависимый поиск:");

            foreach (var item in strs)
            {
                if (regexp.IsMatch(item))
                {
                    Console.WriteLine("Есть такое слово в строке {0}",item);
                }
            }

            Console.WriteLine();

            regexp = new Regex("World", RegexOptions.IgnoreCase);

            Console.WriteLine("Регистронезависимый поиск:");

            foreach (var item in strs)
            {
                if (regexp.IsMatch(item))
                {
                    Console.WriteLine("Есть такое слово в строке {0}",item);
                }
            }

            Console.ReadKey();


        }
    }
}
