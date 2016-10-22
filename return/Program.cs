using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @return
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = Int32.Parse(Console.ReadLine());
            int sum = Sum(num);
            Console.WriteLine("Сумма всех парных чисел до {0} = {1}",num,sum);
            Console.ReadKey();
        }

        static int Sum(int s)
        {
            int sum=0;
            for (int i = 0; i < s; i++)
            {
                if (i%2==0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
