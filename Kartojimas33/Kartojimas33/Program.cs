using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek dvejetu dvizenkliuose skaiciuose?");
            Console.WriteLine();

            int kiekDvejetu = 0;

            for (int dvizenklis = 10; dvizenklis <= 99; dvizenklis++)
            {
                int Skaitmuo1 = dvizenklis / 10;
                int Skaitmuo2 = dvizenklis % 10;
                
                if (Skaitmuo1 ==2)
                {
                    if (Skaitmuo2 == 2)
                    {
                        kiekDvejetu++;
                    }
                    kiekDvejetu++;
                }
            }
            Console.WriteLine("Dvizenkliu skaiciu dvejetu skaitmenu suma {0}", kiekDvejetu);
            Console.ReadKey();
        }
    }
}
