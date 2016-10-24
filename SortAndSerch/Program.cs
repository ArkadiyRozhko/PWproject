using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSerch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------------------------");
            Array.Sort(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
