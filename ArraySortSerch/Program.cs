using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySortSerch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArr = new[] { 10, 12, 22, -12, 6, 45, 89, 54, 56, 5 };


            foreach (var item in myArr)
            {
                Console.Write("{0}\t",item);
                //Console.Write(" - ");
            }

            Console.WriteLine();
          

            Array.Sort(myArr);

            foreach (var item in myArr)
            {
                Console.Write("{0}\t",item);
                //Console.Write(" - ");
            }

            Console.WriteLine();

            int position = Array.BinarySearch(myArr, 12);

            Console.WriteLine("position 12 is - {0}", position + 1);

        }
    }
}
