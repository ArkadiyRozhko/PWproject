using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySegmentProj
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 5, 9, 6, 4, 5, 6, 5, 6 };
            int[] arr2 = { 7, 8, 5, 6, 3, 2, 1 };

            var arrsegment = new ArraySegment<int>[3]
            {
                new ArraySegment<int>(arr1,1,2),
                new ArraySegment<int>(arr2,2,1),
                new ArraySegment<int>(arr1,0,3)
            };

            Console.WriteLine("Сумма выбранных значений равна:\n"+SumSegment(arrsegment));
            Console.ReadKey();
                
        }
        static int SumSegment(ArraySegment<int>[] val)
        {
            int sum = 0;
            foreach (var item in val)
            {
                for (int i = item.Offset; i < item.Offset+item.Count; i++)
                {
                    sum += item.Array[i];
                }
            }
            return sum;

        }
    }
}
