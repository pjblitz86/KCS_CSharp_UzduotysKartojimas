using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Keturzenklio skaiciaus apsukimas");
            Console.WriteLine();

            Console.Write("Iveskite 4zenkli skaiciu: ");
            int keturzenklis = Convert.ToInt32(Console.ReadLine());

            int Skaitmuo1 = keturzenklis / 1000;
            int Skaitmuo2 = keturzenklis % 1000 / 100;
            int Skaitmuo3 = keturzenklis % 100 / 10;
            int Skaitmuo4 = keturzenklis % 10;

            Console.WriteLine("Apsuktas {0} yra {1}{2}{3}{4}", keturzenklis, Skaitmuo4, Skaitmuo3, Skaitmuo2, Skaitmuo1);
            Console.ReadKey();
        }
    }
}
