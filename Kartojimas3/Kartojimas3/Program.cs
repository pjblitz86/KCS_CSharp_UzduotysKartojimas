using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paprastu palukanu apskaiciavimas");
            Console.WriteLine();

            Console.Write("Iveskite kokia suma norite padeti i banka: ");
            double pradinisIndelis = Convert.ToDouble(Console.ReadLine());
            double metinesPalukanos = 0.04;
            Console.WriteLine();

            for (int metai = 1; metai < 3; metai++)
            {
                double uzdirbta = pradinisIndelis * metai * metinesPalukanos;
                double turimasIndelis = pradinisIndelis + uzdirbta;

                Console.WriteLine("{0} metai: {1} palukanos, turimas indelis: {2}", 
                                    metai, metinesPalukanos, turimasIndelis);
            }
            Console.ReadKey();
        }
    }
}
