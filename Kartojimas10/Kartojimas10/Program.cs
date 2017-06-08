using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ar pralys katinas pro duru skyle?");
            Console.WriteLine();

            Console.Write("Iveskite skyles krastines ilgi cm: ");
            double skylesKrastine = Convert.ToDouble(Console.ReadLine());

            Console.Write("Iveskite katino galvos spinduli cm: ");
            double katinoGalvosSpindulys = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double skylesPlotas = skylesKrastine * skylesKrastine;
            double katinoGalvosPlotas = Math.PI * katinoGalvosSpindulys * katinoGalvosSpindulys; 

            if (katinoGalvosPlotas < skylesPlotas)
            {
                Console.WriteLine("Katinas pralys pro skyle, nes jo galvos plotas {0:0.00} yra mazesnis uz skyles {1:0.00} plota."
                                    , katinoGalvosPlotas, skylesPlotas);
            }
            else
            {
                Console.WriteLine("Katinas NEpralys pro skyle, nes jo galvos plotas {0:0.00}  nera mazesnis uz skyles {1:0.00} plota."
                                    , katinoGalvosPlotas, skylesPlotas);
            }
            Console.ReadKey();
        }
    }
}
