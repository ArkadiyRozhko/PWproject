using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Array arr = Array.CreateInstance(typeof(string), 5);

            arr.SetValue("masha", 0);
            arr.SetValue("Petya", 1);

            string s1 = (string)arr.GetValue(0);
            string s2 = (string)arr.GetValue(1);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.ReadKey();
        }
    }
}
