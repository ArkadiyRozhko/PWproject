using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "alpha";
            string str2 = "Alpha";
            string str3 = "Beta";
            string str4 = "alpha";
            string str5 = "alpha, beta";
            int result;

            result = String.Compare(str1, str2, StringComparison.CurrentCulture);
            Console.WriteLine("Сравнение строк с учетом культурной среды:");

            if (result<0)
            {
                Console.WriteLine("{0} меньше {1}", str1,str2);
            }
            else if (result>0)
            {
                Console.WriteLine("{0} больше {1}", str1,str2);
            }
            else
            {
                Console.WriteLine("Строки равны");
            }


            result = String.Compare(str1, str2, StringComparison.Ordinal);
            Console.WriteLine("Порядковое сравнение строк");

            if (result<0)
            {
                Console.WriteLine("{0} меньше {1}", str1, str2);
            }
            else if (result > 0)
            {
                Console.WriteLine("{0} больше {1}", str1, str2);
            }
            else
            {
                Console.WriteLine("Строки равны");
            }

            result = String.CompareOrdinal(str1, str2);
            Console.WriteLine("Сравнение строк методом CompareOrdinal()");

            if (result<0)
            {
                Console.WriteLine("{0} меньше {1}", str1, str2);
            }
            else if (result > 0)
            {
                Console.WriteLine("{0} больше {1}", str1, str2);
            }
            else
            {
                Console.WriteLine("Строки равны");
            }

        }
    }
}
