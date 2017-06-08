using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Keturzenklio skaiciaus uzkodavimas");
            Console.WriteLine();

            Console.Write("Iveskite 4zenkli skaiciu: ");
            int ivestas4zenklis = Convert.ToInt32(Console.ReadLine());

            int Skaitmuo1 = ivestas4zenklis / 1000;
            int Skaitmuo2 = ivestas4zenklis % 1000 / 100;
            int Skaitmuo3 = ivestas4zenklis % 100 / 10;
            int Skaitmuo4 = ivestas4zenklis % 10;
            
            // sukeiciam 1 ir 4 bei 2 ir 3 vietomis 
            int Skaitmuo1Pakeistas1 = Skaitmuo4;
            int Skaitmuo2Pakeistas1 = Skaitmuo3;
            int Skaitmuo3Pakeistas1 = Skaitmuo2;
            int SKaitmuo4Pakeistas1 = Skaitmuo1;

            // is gauto skaiciaus dar sukeiciame 2 ir 4 vietomis
            int Skaitmuo1Pakeistas2 = Skaitmuo4;
            int Skaitmuo2Pakeistas2 = Skaitmuo1;
            int Skaitmuo3Pakeistas2 = Skaitmuo2;
            int SKaitmuo4Pakeistas2 = Skaitmuo3;

            Console.WriteLine("Ivestas keturzenklis {0}. Po uzkodavimo jis yra {1}{2}{3}{4}",
             ivestas4zenklis, Skaitmuo1Pakeistas2, Skaitmuo2Pakeistas2, Skaitmuo3Pakeistas2, SKaitmuo4Pakeistas2);
            Console.ReadKey();

        }
    }
}
