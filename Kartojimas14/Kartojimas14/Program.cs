using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 skysciu buseliu ir galonu sudejimas ir pavertimas litrais");
            Console.WriteLine("1 buselis = 8 galonai. 1 galonas = 4.54069 litro.");
            Console.WriteLine();

            Console.WriteLine("Iveskite pirmo skyscio buselius ir galonus:");
            int buseliai1 = Convert.ToInt32(Console.ReadLine());
            int galonai1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Iveskite antro skyscio buselius ir galonus:");
            int buseliai2 = Convert.ToInt32(Console.ReadLine());
            int galonai2 = Convert.ToInt32(Console.ReadLine());


            int tikGalonais1 = buseliai1 * 8 + galonai1;
            int tikGalonais2 = buseliai2 * 8 + galonai2;

            int visaSumaTikGalonais = tikGalonais1 + tikGalonais2;
            int sumaBuseliais = 0;
            int sumaGalonais = 0;

            double galonuSumaLitrais = visaSumaTikGalonais * 4.54069;

            if (visaSumaTikGalonais >= 8)
            {
                sumaBuseliais = visaSumaTikGalonais / 8;
                sumaGalonais = visaSumaTikGalonais % 8;
                Console.WriteLine("2 skysciu suma: {0} buseliai, {1} galonai", sumaBuseliais, sumaGalonais);
            }
            else
            {
                sumaBuseliais = 0;
                sumaGalonais = visaSumaTikGalonais;
                Console.WriteLine("2 skysciu suma: {0} buseliai, {1} galonai", sumaBuseliais, sumaGalonais);
            }

            Console.WriteLine("1 ir 2 skyscio suma yra {0} galonai. Tai sudaro {1} litru"
                                , visaSumaTikGalonais, galonuSumaLitrais);

            Console.ReadKey();
        }
    }
}
