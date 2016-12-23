using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regexMatch1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1 кг яблок стоит 20 грн" + "1 кг мандарин стоит 40 грн" + "1 кг апельсин стоит 45 грн" + "1 кг мяса стоит 80 грн";

            string patern = @"\b(\d+\W?грн)";

            Regex regex = new Regex(patern);

            foreach (var item in regex.Matches(input))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();


        }
    }
}
