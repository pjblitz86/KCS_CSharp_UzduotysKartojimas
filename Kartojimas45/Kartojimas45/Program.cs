using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kada turesiu miliona?");
            Console.WriteLine();

            Console.WriteLine("Iveskite pradine suma padeta i banka");
            double pradinisIndelis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite metine palukanu norma procentais");
            double metinePalukanuNormaProc = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i < 100; i++)
            {
                double sumaBanke = pradinisIndelis * i * ((metinePalukanuNormaProc / 100)+1);
                Console.WriteLine("{0} metai, {1:0.00} Eur banke", i, sumaBanke);
                if (sumaBanke >= 1000000)
                {
                    Console.WriteLine();
                    Console.WriteLine("Jus turesite milijona kai jums bus {0}", i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
