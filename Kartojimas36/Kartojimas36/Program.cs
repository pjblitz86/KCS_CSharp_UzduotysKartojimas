using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KARALIAUS IZDAS. FIBONACI SKAICIAI\n");
            Console.WriteLine("*******************");
            Console.Write("Iveskite kiek naktu norite saugoti karaliaus izda: ");
            int naktuSkaicius = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite karaliaus izdo dydi auksinais: ");
            int izdoDydis = Convert.ToInt32(Console.ReadLine());

            int sargybosSuma = 2;
            int pirmaNaktis = 1;
            int antraNaktis = 1;
            int treciaNaktis = pirmaNaktis + antraNaktis;
            Console.WriteLine("1 naktis. Sargybos suma: 1");
            Console.WriteLine("2 naktis. Sargybos suma: 2");

            for (int i = 3; i <= naktuSkaicius; i++)
            {
                treciaNaktis = pirmaNaktis + antraNaktis;
                sargybosSuma += treciaNaktis;
                Console.WriteLine("{0} naktis. Sargybos suma: {0}", i, sargybosSuma);
                pirmaNaktis = antraNaktis;
                antraNaktis = treciaNaktis;
                
                if (izdoDydis < sargybosSuma)
                {
                    Console.WriteLine("Izdas pasibaige");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
