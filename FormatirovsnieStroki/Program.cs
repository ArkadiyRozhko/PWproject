using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatirovsnieStroki
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;

            Console.WriteLine("Дата в формате d {0:d}\nДата в формате D {0:D}",myDate);
            Console.WriteLine("Дата в формате f {0:f}\nДата в формате F {0:F}",myDate);
            Console.WriteLine("Дата в формате g {0:g}\nДата в формате G {0:G}",myDate);
            Console.WriteLine("Дата в формате m {0:m}\nДата в формате M {0:M}",myDate);
            Console.WriteLine("Дата в формате o {0:o}\nДата в формате O {0:O}",myDate);
            Console.WriteLine("Дата в формате r {0:r}\nДата в формате R {0:R}",myDate);
            Console.WriteLine("Дата в формате s {0:s}", myDate);                      
            Console.WriteLine("Дата в формате t {0:t}\nДата в формате T {0:T}",myDate);
            Console.WriteLine("Дата в формате u {0:u}\nДата в формате U {0:U}",myDate);
            Console.WriteLine("Дата в формате y {0:y}\nДата в формате Y {0:Y}",myDate);
            Console.ReadKey();
        }
    }
}
