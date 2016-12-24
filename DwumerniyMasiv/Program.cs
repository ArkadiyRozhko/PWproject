using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwumerniyMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10, 20];

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    arr[i, j] = rnd.Next(1, 100);
                    Console.Write("{0}\t",arr[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }
    }
}
