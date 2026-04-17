using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglatest
{
    class Program
    {
        static void Main(string[] args)
        {
            int valasz = 0;
            Console.Write("Mit számoljunk téglatestet(1) vagy gömböt(2), vagy egy szám négyzetgyökét(3)? ");
            valasz = Convert.ToInt32(Console.ReadLine());

            if (valasz == 1)
            {
                double a = 0, b = 0, c = 0, V = 0, A = 0;
                Console.Write("Add meg az a oldalt: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Add meg a b oldalt: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Add meg a c oldalt: ");
                c = Convert.ToDouble(Console.ReadLine());
                V = a * b * c;
                A = 2 * (a * b + a * c + b * c);
                Console.Write("A téglatest térfogata: {0:0.000}, a felszíne: {1:0.000}", V, A);
                Console.ReadLine();
            }
            else if (valasz == 2)
            {
                double r = 0, V = 0, A = 0;
                Console.Write("Add meg a sugarat: ");
                r = Convert.ToDouble(Console.ReadLine());
                V = (4 * Math.Pow(r, 3) * Math.PI)/3;
                A = 4 * Math.Pow(r, 2) * Math.PI;
                Console.Write("A gömb térfogata: {0:0.000}, a felszíne: {1:0.000}", V, A);
                Console.ReadLine();
            }
            else if (valasz == 3)
            {
                double a = 0;
                Console.Write("Add meg az a számot: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("A szám négyzetcsöke: {0} & -{0}", Math.Sqrt(a));
                Console.ReadLine();
            }
        }
    }
}
