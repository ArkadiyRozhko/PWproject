using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korteg
{
    class Program
    {
        static Tuple<int,float,string,char>Corteg(int a,string name)
        {
            int srt = a * a;
            float sqrt = (float)Math.Sqrt(a);
            string s = "Привет, " + name;
            char ch = name[0];

            return Tuple.Create<int, float, string, char>(srt, sqrt, s, ch);
        }
        static void Main(string[] args)
        {
            var MyTuple = Corteg(25, "Vasya");
            Console.WriteLine("{0}\n Kvadrat - {1}\n Kvadratnuy korin - {2}\n Pervaya bukva - {3}",MyTuple.Item3,MyTuple.Item1,MyTuple.Item2,MyTuple.Item4);
            Console.ReadKey();
        }
       
    }
}
