using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek laiko studentas sprende kontrolini?");
            Console.WriteLine();

            Console.WriteLine("Iveskite valandas, minutes ir sekundes kada mokinys pradejo spresti kontrolini:");
            int valandosPradejo = Convert.ToInt32(Console.ReadLine());
            int minutesPradejo = Convert.ToInt32(Console.ReadLine());
            int sekundesPradejo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Iveskite valandas, minutes ir sekundes kada mokinys baige spresti kontrolini:");
            int valandosBaige = Convert.ToInt32(Console.ReadLine());
            int minutesBaige = Convert.ToInt32(Console.ReadLine());
            int sekundesBaige = Convert.ToInt32(Console.ReadLine());

            int kiekValSprende = 0;
            int kiekMinSprende = 0;
            int kiekSekSprende = 0;

            if ((valandosPradejo >= 0) && (valandosPradejo <= 23) &&
                (valandosBaige >= 0) && (valandosBaige <= 23) &&
                (minutesPradejo >= 0) && (minutesPradejo <= 59) &&
                (minutesBaige >= 0) && (minutesBaige <= 59) &&
                (sekundesPradejo >= 0) && (sekundesPradejo <= 59) &&
                (sekundesBaige >= 0) && (sekundesBaige <= 59))
            {
                if ((valandosBaige - valandosPradejo < 0) &&
                    (minutesBaige - minutesPradejo < 0) &&
                    (sekundesBaige - sekundesPradejo < 0))
                {
                    kiekValSprende = valandosBaige + 24 - valandosPradejo;
                    kiekMinSprende = minutesBaige + 60 - minutesPradejo;
                    kiekSekSprende = sekundesBaige + 60 - sekundesPradejo;
                    Console.WriteLine("Sprendimo laikas: {0:00}h{1:00}min{2:00}s",
                        kiekValSprende, kiekMinSprende, kiekSekSprende);
                }
                // ar nereikia +-1
                else if ((valandosBaige - valandosPradejo < 0) && (minutesBaige - minutesPradejo < 0))
                {
                    kiekValSprende = valandosBaige + 24 - valandosPradejo;
                    kiekMinSprende = minutesBaige + 60 - minutesPradejo;
                    kiekSekSprende = sekundesBaige - sekundesPradejo - 1;
                    Console.WriteLine("Sprendimo laikas: {0:00}h{1:00}min{2:00}s",
                        kiekValSprende, kiekMinSprende, kiekSekSprende);
                }
                // ar nereikia +-1
                else if ((valandosBaige - valandosPradejo < 0) && (sekundesBaige - sekundesPradejo < 0))
                {
                    kiekValSprende = valandosBaige + 24 - valandosPradejo;
                    kiekMinSprende = minutesBaige - minutesPradejo - 1;
                    kiekSekSprende = sekundesBaige + 60 - sekundesPradejo;
                    Console.WriteLine("Sprendimo laikas: {0:00}h{1:00}min{2:00}s",
                        kiekValSprende, kiekMinSprende, kiekSekSprende);
                }
                else if ((minutesBaige - minutesPradejo < 0) && (sekundesBaige - sekundesPradejo < 0))
                {
                    kiekValSprende = valandosBaige - valandosPradejo - 1;
                    kiekMinSprende = minutesBaige + 60 - minutesPradejo;
                    kiekSekSprende = sekundesBaige + 60 - sekundesPradejo;
                    Console.WriteLine("Sprendimo laikas: {0:00}h{1:00}min{2:00}s",
                        kiekValSprende, kiekMinSprende, kiekSekSprende);
                }
                else if ((valandosBaige - valandosPradejo >= 0) || 
                        (minutesBaige - minutesPradejo >= 0) || 
                        (valandosBaige - valandosPradejo >= 0))
                {
                    kiekValSprende = valandosBaige - valandosPradejo;
                    kiekMinSprende = minutesBaige - minutesPradejo;
                    kiekSekSprende = sekundesBaige - sekundesPradejo;
                    Console.WriteLine("Sprendimo laikas: {0:00}h{1:00}min{2:00}s",
                        kiekValSprende, kiekMinSprende, kiekSekSprende);
                }
            }
            else
            {
                Console.WriteLine("Blogai ivesti laikai");
            }
            Console.ReadKey();
        }
    }
}
