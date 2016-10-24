using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foretch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr=new int[5];
            int[,]meTwoArr = new int[5,6];
            int sum = 0;

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                myarr[i] = rnd.Next(1, 50);
                for (int j = 0; j < 6; j++)
                {
                    meTwoArr[i, j] = rnd.Next(1, 30);
                }
            }

            foreach (var item in myarr)
            {
                Console.WriteLine("{0} в квадраті = {1}", item,item*item);
            }

            foreach (var item in meTwoArr)
            {
                sum += item;
            }
            Console.WriteLine("Сума елементів = {0}", sum);

            Console.ReadKey();

        }
    }
}
