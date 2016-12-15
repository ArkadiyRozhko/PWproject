using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupenchatuyMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] stupArr = new int[4][];

            stupArr[0] = new int[1];
            stupArr[1] = new int[4];
            stupArr[2] = new int[2];
            stupArr[3] = new int[3];


            for (int i = 0; i < stupArr[0].Length; i++)
            {
                stupArr[0][i] = i;
                Console.Write(stupArr[0][i]);
            }

            Console.WriteLine();

            for (int i = 0; i < stupArr[1].Length; i++)
            {
                stupArr[1][i] = i;
                Console.Write(stupArr[1][i]);
            }

            Console.WriteLine();

            for (int i = 0; i < stupArr[2].Length; i++)
            {
                stupArr[2][i] = i;
                Console.Write(stupArr[2][i]);
            }

            Console.WriteLine();

            for (int i = 0; i < stupArr[3].Length; i++)
            {
                stupArr[3][i] = i;
                Console.Write(stupArr[3][i]);
            }
            Console.WriteLine();
        }
    }
}
