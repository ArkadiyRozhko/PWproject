using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Факторіал числа!!!");
                int i, num = 1, result = 1;

                Console.WriteLine("Введіть число");
                i = Int32.Parse(Console.ReadLine());

                do
                {
                    result *= num;
                    num++;
                    Console.WriteLine(result);
                } while (num <= i);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ви ввели не число {0}", ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
            


        }
    }
}
