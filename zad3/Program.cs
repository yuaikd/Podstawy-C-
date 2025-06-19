using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace zad3
{
    internal class Program
    {
        static double pole_kola(int r)
        {
            return Math.PI * r*r;
        }
        static void Main(string[] args)
        {
            //3. Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i
            //obliczoną wartość pola koła. Napisz program wykorzystujący funkcję pole_kola.
            Console.Write("Koło o promieniu 3 ma pole: {0}",pole_kola(3));

        }
    }
}
