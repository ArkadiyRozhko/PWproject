using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarType
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Vasya";
            var age = 20;
            var IsProgramer = true;


            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type IsProgramerType = IsProgramer.GetType();


            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Тип name {0}",nameType);
            Console.WriteLine("Тип age {0}", ageType);
            Console.WriteLine("Тип IsProgramer {0}", IsProgramerType);

            Console.ReadLine();

        }
    }
}
