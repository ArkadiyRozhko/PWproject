using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectUniversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyOs = Environment.OSVersion;

            object[] arr = { "Строка", 120, 0.35m, 0.58f, MyOs, 'A' };

            foreach (var item in arr)
            {
                Console.WriteLine(" {0}---- Тип = {1}",item,item.GetType());
            }

            Console.ReadKey();
        }
    }
}
