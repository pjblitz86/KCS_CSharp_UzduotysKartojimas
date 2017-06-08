using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ar penkiazenklis yra polindromas?");
            Console.WriteLine();

            Console.WriteLine("Iveskite naturalu 5zenkli skaiciu");
            int penkiazenklis = Convert.ToInt32(Console.ReadLine());

            int Skaitmuo1 = penkiazenklis / 10000;
            int Skaitmuo2 = penkiazenklis % 10000 / 1000;
            int Skaitmuo3 = penkiazenklis % 1000 / 100;
            int Skaitmuo4 = penkiazenklis % 100 / 10;
            int Skaitmuo5 = penkiazenklis % 10;

            if (penkiazenklis >= 10000 && penkiazenklis <= 99999)
            {
                if (Skaitmuo1 == Skaitmuo5 && Skaitmuo2 == Skaitmuo4)
                {
                    Console.WriteLine("Skaicius {0} yra polindromas nes skaitomas is abieju galu vienodai",
                                        penkiazenklis);
                }
                else
                {
                    Console.WriteLine("Skaicius {0} nera polindromas", penkiazenklis);
                } 
            }
            else
            {
                Console.WriteLine("Ivedete ne penkiazenkli skaiciu arba blogas ivedimas");
            }

            Console.ReadKey();
        }
    }
}
