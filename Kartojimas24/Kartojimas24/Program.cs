using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reiksminiai ir nereiksminiai skaitmenys");
            Console.WriteLine();
            Console.Write("Iveskite keturzenkli skaiciu: ");
            int ketuzenklisSkaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int kiekReiksminiu = 0;
            int kiekNereiksminiu = 0;

            int Skaitmuo1 = ketuzenklisSkaicius / 1000;
            int Skaitmuo2 = (ketuzenklisSkaicius % 1000) / 100;
            int Skaitmuo3 = (ketuzenklisSkaicius % 100) / 10;
            int Skaitmuo4 = ketuzenklisSkaicius % 10;

            if (Skaitmuo1 != 0)
            {
                kiekReiksminiu++;
            }
            else
            {
                kiekNereiksminiu++;
            }

            if (Skaitmuo2 != 0)
            {
                kiekReiksminiu++;
            }
            else
            {
                kiekNereiksminiu++;
            }
            if (Skaitmuo3 != 0)
            {
                kiekReiksminiu++;
            }
            else
            {
                kiekNereiksminiu++;
            }
            if (Skaitmuo4 != 0)
            {
                kiekReiksminiu++;
            }
            else
            {
                kiekNereiksminiu++;
            }

            Console.WriteLine("Reiksminiai skaitmenys viso: {0}", kiekReiksminiu);
            Console.WriteLine("Nereiksminiai skaitmenys viso: {0}", kiekNereiksminiu);
            Console.ReadKey();
        }
    }
}
