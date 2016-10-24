using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassivObjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = { true, "one", 12};

            foreach (var item in arr)
            {
                Console.WriteLine("{0} тип элемента - {1}",item,item.GetType());
            }
            Console.ReadKey();
        }
    }
}
