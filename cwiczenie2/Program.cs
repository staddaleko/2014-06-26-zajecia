using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, v;
            Console.Write("Podaj wartosc zmiennej x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wartosc zmiennej y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wartosc zmiennej z: ");
            z = Convert.ToDouble(Console.ReadLine());
            v = (4 * x - y) / (3 * (z * z + 1));
            Console.WriteLine("wartosc wyrazenia wynosi {0}", v);
        }
    }
}
