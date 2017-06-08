using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olimpiniai metai kas 4 FOR");
            Console.WriteLine();

            Console.Write("Iveskite metus: ");
            int metai = Convert.ToInt32(Console.ReadLine());
            int zaidyniuNumeris = 0;

            for (int i = 1896; i <= metai ; i+=4)
            {
                if (i % 4 == 0)
                {
                    zaidyniuNumeris++;
                }
                else
                {
                    Console.WriteLine("Metai neolimpiniai");
                } 
            }
            Console.WriteLine("Zaidyniu numeris yra: {0}", zaidyniuNumeris);
            Console.ReadKey();
        }
    }
}
