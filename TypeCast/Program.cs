using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCast
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 410, i2 = 85420;
            decimal dec = 12.123654m;

            Console.WriteLine((short)i1);
            Console.WriteLine((short)i2);

            Console.WriteLine((int)dec);

            Console.ReadLine();
        }
    }
}
