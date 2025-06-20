using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na
            //ekranie objętość i pole całkowite tego stożka.
            double r, h, l, v, Pc;
            Console.Write("Podaj długość r=");
            r=Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj długość h=");
            h = Convert.ToDouble(Console.ReadLine());
            l= Math.Sqrt(r*r+h*h);
            v = 1.0 / 3 * Math.PI * r * r * h;
            Pc = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("Objętość={0}", v);
            Console.WriteLine("Pole całkowite={0}", Math.PI * r*(r + l)); 
            Console.ReadKey(true);
        }
    }
}
