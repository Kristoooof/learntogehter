using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mat
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            Console.Write("Adj meg egy számot: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A szám köbgyöke: +-{0:0.00}", Math.Pow(a,1/3.00));
            Console.ReadLine();
        }
    }
}
