using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder hello = new StringBuilder("Это был я а может и нет",120);
            
            Console.WriteLine(hello);

            Console.WriteLine("Зашифруем строку");          
           

            for (int i = 'я'; i  >='а'; i--)
            {
                hello.Replace((char)i, (char)(i + 1));
            }
            Console.WriteLine(hello);

            Console.WriteLine("Расшифруем строку");

            for (int  i = 'а'; i <='я'; i++)
            {
                char ch = (char)(i+1);
                char ch1 = (char)i;
                hello.Replace(ch,ch1);
            }
            Console.WriteLine(hello);
            Console.ReadKey();
        }
    }
}
