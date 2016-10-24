using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            arr[0] = 45;
            arr[1] = 32;
            arr[2] = 12;
            arr[3] = 98;
            arr[4] = 123;

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
