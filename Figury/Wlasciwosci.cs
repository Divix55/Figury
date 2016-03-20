using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Wlasciwosci
    {
        private double _krawedz;
        private int _katy;

        public double krawedz
        {
            get
            {
                if (_krawedz > 0)
                    return _krawedz;
                else
                    return 0;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Dlugosc krawedzi musi byc wieksza od 0!");
                else
                    _krawedz = value;
            }
        }
        public int katy
        {
            get
            {
                if (_katy > 2)
                    return _katy;
                else
                    return 0;
            }
            set
            {
                if (value < 2)
                {
                    Console.WriteLine("Ilość kątów musi być większa lub równa 3!");
                }
                else
                    _katy = value;
            }
        }

        public double pole(double krawedz, int kat)
        {
            double r = (krawedz / 2) * (1 / Math.Tan(Math.PI / kat));
            return (krawedz * kat * r) / 2;
        }

        public double obwod(double krawedz, int kat)
        {
            return krawedz * kat;
        }
    }
}
