using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            arr[0] = 123;
            arr[1] = 54;
            arr[2] = 52;
            arr[3] = 325;
            arr[4] = 1;

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            var arr1 = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Тип данных масива - {0}",arr1.GetType());

            var arr2 = new[] { "one", "two", "three", "four" };
            Console.WriteLine("Тип данных масива - {0}", arr2.GetType());

            Console.ReadKey();




        }
    }
}
