using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek kainos iskloti plota plytelemis");
            Console.WriteLine();

            Console.Write("Iveskite kambario ilgi: ");
            int ilgis = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite kambario ploti: ");
            int plotis = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite plyteliu kvadrato kaina: ");
            int kainaKvadrato = Convert.ToInt32(Console.ReadLine());

            int plotas = ilgis * plotis;
            double kainaVisa = (double) (plotas * kainaKvadrato * 1.05);

            Console.WriteLine();
            Console.WriteLine("Jums reikes iskloti {0} plota, kuriam trinkeliu visa kaina: {1}", plotas, kainaVisa);
            Console.ReadKey();
        }
    }
}
