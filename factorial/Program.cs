using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static int factoriall(int i)
        {
            int result;
            if (i==1)
            {
                return 1;
            }
            result = factoriall(i - 1) * i;
            return result;
        }
        static void Main(string[] args)
        {
            label1:
            Console.WriteLine("Введите число");
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} factorial = {1}", num, factoriall(num));
            }
            catch (FormatException)
            {
                Console.WriteLine("неверное число");
                goto label1;
            }
            
            Console.ReadKey();
        }
    }
}
