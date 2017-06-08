using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiko skaiciaus eiles is intervalo isvedimas");
            Console.WriteLine();

            Console.WriteLine("Iveskite sveika skaiciu is intervalo -999 iki 999 imtinai");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            // tiesiog patikrinti zenkla ar minus su if ir skaiciaus eile Abs
            if (skaicius < 0)
            {
                Console.WriteLine("Zenklas: minus");
            }
            else if (skaicius > 0)
            {
                Console.WriteLine("Zenklas: plius");
            }

            Console.WriteLine("Skaiciaus eile: " + Math.Abs(skaicius));
            Console.ReadKey();
        }
    }
}
