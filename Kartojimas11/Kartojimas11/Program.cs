using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seimos biudzetas");
            Console.WriteLine();

            Console.Write("Iveskite kiek seima gauna Eur per men: ");
            double eurPerMen = Convert.ToDouble(Console.ReadLine());

            // 5 proc. mokesciams
            double mokesciai = eurPerMen * 0.05;
            double eurPerMenPoMokesciu = eurPerMen - mokesciai;

            // atskaiciavus mokescius nuo sios sumos skaiciuojame kitas biudzeto dalis
            double maistui = eurPerMenPoMokesciu * 0.5;
            double rubams = eurPerMenPoMokesciu * 0.3;
            double pramogoms = eurPerMen - mokesciai - maistui - rubams;

            Console.WriteLine("Seima per menesi gauna {0:0.00} Eur.", eurPerMen);
            Console.WriteLine("Mokesciams isleidziama {0:0.00} Eur.", mokesciai);
            Console.WriteLine("Maistui isleidziama {0:0.00} Eur.", maistui);
            Console.WriteLine("Rubams isleidziama {0:0.00} Eur.", rubams);
            Console.WriteLine("Pramogoms isleidziama {0:0.00} Eur.", pramogoms);

            Console.ReadKey();
        }
    }
}
