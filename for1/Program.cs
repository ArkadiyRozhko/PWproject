using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0 , j=100; i <= j; i+=2,j-=2)
            {
                Console.WriteLine("i ={0} --- j ={1} ",i,j);
            }
            Console.ReadKey();




        }
    }
}
