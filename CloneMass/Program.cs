using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneMass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];

            Array arr1 = Array.CreateInstance(typeof(string), 5);
            arr1.SetValue("masha", 0);
            arr1.SetValue("vasya", 1);
            arr1.SetValue("petya", 2);
            arr1.SetValue("misha", 3);
            arr1.SetValue("mitya", 4);

            string[] arr2 = (string[])arr1.Clone();

            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("------------------------------------------------");

            Array.Copy(arr1, arr, 5);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
