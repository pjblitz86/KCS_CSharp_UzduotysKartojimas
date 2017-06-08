using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Besmegenio skrituliai");
            Console.WriteLine();

            Console.Write("Iveskite maziausio is 3 skritulio spinduli: ");
            int r1 = Convert.ToInt32(Console.ReadLine());
            int r2 = r1 * 2;
            int r3 = r2 * 2;

            double plotas1 = /*Math.PI*/3.14 * r1 * r1;
            double plotas2 = 3.14 * r2 * r2;
            double plotas3 = 3.14 * r3 * r3;

            Console.WriteLine("Pirmo skritulio plotas: {0}", plotas1);
            Console.WriteLine("Antro skritulio plotas: {0}", plotas2);
            Console.WriteLine("Trecio skritulio plotas: {0}", plotas3);

            Console.ReadKey();

        }
    }
}
