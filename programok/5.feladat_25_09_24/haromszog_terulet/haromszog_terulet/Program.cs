using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haromszog_terulet
{
    class Program
    {
        static void Main(string[] args)
        {
            int valasz = 0;
            Console.Write("Hogyan számoljunk területet? Magassággal(1) vagy oldalakkal(2)? ");
            valasz = Convert.ToInt32(Console.ReadLine());

            if (valasz == 1)
            {
                double m = 0, a = 0;
                Console.Write("Add meg az alapot: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Add meg a magasságot: ");
                m = Convert.ToDouble(Console.ReadLine());
                Console.Write("A háromszög területe: {0:0.00}", a * m / 2);
                Console.ReadLine();
            }
            else if (valasz == 2)
            {
                double a = 0, b = 0, c = 0, s = 0, T = 0;
                Console.Write("Add meg az a oldalt: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Add meg a b oldalt: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Add meg a c oldalt: ");
                c = Convert.ToDouble(Console.ReadLine());
                s = (a + b + c) / 2;
                T = Math.Sqrt(s*(s - a) * (s - b) * (s - c));
                Console.Write("A háromszög területe: {0:0.00}", T);
                Console.ReadLine();
            }
            
        }
    }
}
