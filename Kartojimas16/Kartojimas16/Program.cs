using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek paros turi h, m, s");
            Console.WriteLine();

            Console.Write("Iveskite paru skaiciu: ");
            int paros = Convert.ToInt32(Console.ReadLine());

            int paruValandos = paros * 24;
            int paruMinutes = paros * 24 * 60;
            int paruSekundes = paros * 24 * 60 * 60;

            Console.WriteLine("{0} paru galima paversti {1} valandomis arba\n{2} minutemis arba\n{3} sekundemis"
                                , paros, paruValandos, paruMinutes, paruSekundes);
            Console.ReadKey();

        }
    }
}
