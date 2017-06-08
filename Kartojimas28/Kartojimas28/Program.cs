using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ar gaunasi artimetine progresija is 4 ivestu skaiciu?");
            Console.WriteLine();
            Console.WriteLine("Iveskite 4 sveikuosius skaicius:");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            int skaicius3 = Convert.ToInt32(Console.ReadLine());
            int skaicius4 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 == skaicius2 && skaicius2 == skaicius3 && skaicius3 == skaicius4)
            {
                Console.WriteLine("Skaiciai {0}, {1}, {2}, {3} yra VIENAREIKSME aritmetine progresija",
                                    skaicius1, skaicius2, skaicius3, skaicius4);
            }
            else if (((skaicius2 - skaicius1 < 0) && (skaicius1 - skaicius2) == (skaicius2 - skaicius3)) &&
                ((skaicius2 - skaicius3) == (skaicius3 - skaicius4)))
            {
                Console.WriteLine("Skaiciai {0}, {1}, {2}, {3} yra MAZEJANTI aritmetine progresija",
                                    skaicius1, skaicius2, skaicius3, skaicius4);
            }
            else if (((skaicius4 - skaicius3 > 0) && (skaicius4 - skaicius3) == (skaicius3 - skaicius2)) &&
                ((skaicius3 - skaicius2) == (skaicius2 - skaicius1)))
            {
                Console.WriteLine("Skaiciai {0}, {1}, {2}, {3} yra DIDEJANTI aritmetine progresija",
                                    skaicius1, skaicius2, skaicius3, skaicius4);
            }
            else
            {
                Console.WriteLine("Skaiciai {0}, {1}, {2}, {3} NERA aritmetine progresija",
                                    skaicius1, skaicius2, skaicius3, skaicius4);
            }
            Console.ReadKey();
        }
    }
}
