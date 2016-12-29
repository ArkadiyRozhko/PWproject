using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameters
{
    class Program
    {
        class MyClass
        {
            public void methArr(double[]arr,int i)
            {
                arr[0] = 15.23;
                i = 0;
            }
        }
        static void Main(string[] args)
        {
            double[] array = { 12.5, 48.6, 56.2, 47.8 };
            int i = 10;

            Console.WriteLine("Исходный масив");
            foreach (var item in array)
            {
                Console.Write("{0}\t",item);
            }
            Console.WriteLine();
            Console.WriteLine("Исходное значение i = {0}",i);

            MyClass mc = new MyClass();
            mc.methArr(array, i);

            Console.WriteLine("Измененный масив");
            foreach (var item in array)
            {
                Console.Write("{0}\t",item);
            }
            Console.WriteLine();
            Console.WriteLine("Значение i = {0}",i);
            Console.ReadKey();
        }
    }
}
