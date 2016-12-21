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

            Console.WriteLine();

            if (str1==str4)
            {
                Console.WriteLine(str1 + "=" + str4);
            }
            if (str1!=str3)
            {
                Console.WriteLine(str1 + "!=" + str3);
            }
            if (str1!=str2)
            {
                Console.WriteLine(str1 + "!=" + str2);
            }

            if (String.Equals(str1,str2,StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Сравнение строк методом Equals() с параметром CurrentCultureIgnoreCase \n" + str1 +" равно " +str2 );
                Console.WriteLine();
            }

            if ((String.Compare(str2,0,str5,0,3))>0)
            {
                Console.WriteLine("Первые 3 символа строки " + str2 + " больше первых 3-х символов строки" + str5);
            }
        }
    }
}
