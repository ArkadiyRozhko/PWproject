using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Array myArr = Array.CreateInstance(typeof(string), 5);

            myArr.SetValue("Vasya", 0);
            myArr.SetValue("Pupkin", 1);

            Console.WriteLine(myArr.GetValue(1));
            Console.ReadKey();
        }
    }
}
