using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass=new int[5];
            mass[0] = 125;
            mass[1] = 3;
            mass[2] = 456;
            mass[3] = 32;
            mass[4] = 21;

            foreach (var item  in mass)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
