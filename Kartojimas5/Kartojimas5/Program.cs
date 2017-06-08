using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek vidutiniskai perskaite knygu");
            Console.WriteLine();

            Console.Write("Iveskite kiek vidutiniskai perskaityta knygu per menesi: ");
            int knyguPerMenesi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite kiek skaitytoju buvo per metus: ");
            int skaitytojuPerMetus = Convert.ToInt32(Console.ReadLine());

            int knyguPerMetus = knyguPerMenesi * 12;
            int kiek1SkaitytojasPerskaitoPerMetus = knyguPerMetus / skaitytojuPerMetus;

            Console.WriteLine("Per metus vienas skaitytojas vidutiniskai perskaito {0} knygu",
                                kiek1SkaitytojasPerskaitoPerMetus);

            Console.ReadKey();

        }
    }
}
