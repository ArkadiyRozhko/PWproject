using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            byte k = 2, i = 0;
            int result = 1;

            while (i<30)
            {
                result *= k;
                i++;
                Console.WriteLine("{0} В степені {1}={2}",i,k,result);
            }

            Console.ReadKey();
        }
    }
}
