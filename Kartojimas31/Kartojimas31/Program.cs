using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koki dvizenkli skaiciu sugalvojo Virginijus?");
            Console.WriteLine();

            for (int skaicius = 10; skaicius <= 99; skaicius++)
            {
                int Skaitmuo1 = skaicius / 10;
                int Skaitmuo2 = skaicius % 10;

                string atvirkstinisSkaiciusString = Convert.ToString(Skaitmuo2 + Skaitmuo1);
                int atvirkstinisSkaiciusInt = Convert.ToInt32(atvirkstinisSkaiciusString); 
                if (Skaitmuo1 !=0) //&& Skaitmuo2 !=0)
                {
                    if ((Skaitmuo2 / Skaitmuo1 == 2) && (Skaitmuo2 % Skaitmuo1 == 0) && (skaicius == atvirkstinisSkaiciusInt + 36))
                    Console.WriteLine("Sugalvotas skaicius yra {0}", skaicius);
                }
                else
                {
                    Console.WriteLine("Dalyba is nulio negalima");
                }

            }

            Console.ReadKey();

        }
    }
}
