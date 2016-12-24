using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in GetArray())
            {
                Console.WriteLine(item);
            }

            int[] arr = { 21, 56, -2, 78, 22 };

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = MySortArray(arr, i);
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static Array GetArray()
        {
            string[] arr = { "vasya", "petya", "masha" };
            return arr;
        }

        static int MySortArray(Array arr,int i)
        {
            Array.Sort(arr);
            return (int)arr.GetValue(i);
        }
    }
}
