using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i%5!=0)
                {
                    continue;
                }
                Console.WriteLine("i={0} \t",i);
            }
            Console.ReadKey();
        }
    }
}
