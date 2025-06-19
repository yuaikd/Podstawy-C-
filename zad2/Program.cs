using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static int max(int a,int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            //Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb
            //zadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max.

            Console.WriteLine("Maskimum z 2 i 5 to: {0}", max(2, 5));

        }
    }
}
