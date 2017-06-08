using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek laiko mokinys sprende uzdavinius?");
            Console.WriteLine();

            Console.WriteLine("Iveskite valandas ir minutes nuo kada mokinys pradejo spresti uzdavinius:");
            int valandosPradejo = Convert.ToInt32(Console.ReadLine());
            int minutesPradejo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Iveskite valandas ir minutes kada mokinys baige spresti uzdavinius:");
            int valandosBaige = Convert.ToInt32(Console.ReadLine());
            int minutesBaige = Convert.ToInt32(Console.ReadLine());

            int kiekValSprende = 0;
            int kiekMinSprende = 0;

            if ((valandosPradejo >=0) && (valandosPradejo <= 23) &&
                (valandosBaige >= 0) && (valandosBaige <= 23) &&
                (minutesPradejo >= 0) && (minutesPradejo <= 59) &&
                (minutesBaige >= 0) && (minutesBaige <= 59))
            {
                if ((valandosBaige - valandosPradejo < 0) && (minutesBaige - minutesPradejo < 0))
                {
                    kiekValSprende = valandosBaige + 24 - valandosPradejo;
                    kiekMinSprende = minutesBaige + 60 - minutesPradejo;
                    Console.WriteLine("Sprendimo laikas: {0:00}h{1:00}min", kiekValSprende, kiekMinSprende);
                }
                else if (valandosBaige - valandosPradejo < 0)
                {
                    kiekValSprende = valandosBaige + 24 - valandosPradejo;
                    kiekMinSprende = minutesBaige - minutesPradejo;
                    Console.WriteLine("Sprendimo laikas: {0:00}h{1:00}min", kiekValSprende, kiekMinSprende);
                }
                else if ((valandosBaige - valandosPradejo >= 0) || (minutesBaige - minutesPradejo >=0))
                {
                    kiekValSprende = valandosBaige - valandosPradejo;
                    kiekMinSprende = minutesBaige - minutesPradejo;
                    Console.WriteLine("Sprendimo laikas: {0:00}h{1:00}min", kiekValSprende, kiekMinSprende);
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
