using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muvelet
{
    class Program
    {
        static void Main(string[] args)
        {
            double szam1 = 0, szam2 = 0;
            Console.Write("Add meg az első számot:");
            szam1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg az második számot:");
            szam2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A két szám összege: {0:0.000}", szam1 * szam2);
            Console.ReadLine();
        }
    }
}
