using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = Environment.Version;

            Console.WriteLine("Тип - {0}", m.GetType());

            string s = m.ToString();
            Console.WriteLine("Моя версия .Net Framework - {0}",s);

            Version v = (Version)m.Clone();
            Console.WriteLine("Значение переменной v - {0}",v);

            Console.ReadKey();
        }
    }
}
