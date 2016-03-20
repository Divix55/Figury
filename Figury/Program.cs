using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Program
    {
        static void Main(string[] args)
        {
            Wlasciwosci obiekt = new Wlasciwosci();
            Console.WriteLine("Witaj!");
            Console.WriteLine("");
            Console.WriteLine("Jestem programem liczącym właściwości figury prawidłowej, której parametry zaraz podasz!");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Jaka jest długość krawędzi?");
            obiekt.krawedz = double.Parse(Console.ReadLine());
            Console.WriteLine("Ile ma kątów?");
            obiekt.katy = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Pole=" + obiekt.pole(obiekt.krawedz, obiekt.katy));
            Console.WriteLine("Obwód=" + obiekt.obwod(obiekt.krawedz, obiekt.katy));
            Console.ReadKey();
        }
    }
}
