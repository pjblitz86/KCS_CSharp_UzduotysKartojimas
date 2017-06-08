using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek keleiviu vaziuoja i Vilniu");
            Console.WriteLine();

            Console.Write("Iveskite traukinio keleiviu skaiciu: ");
            int traukinioKeleiviai = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite traukinio keleiviu vykstanciu ne i Vilniu skaiciu: ");
            int neIVilniuKeleiviai = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite traukinio vagonu skaiciu: ");
            int vagonuSkaicius = Convert.ToInt32(Console.ReadLine());

            int kiekKeleiviuVagoneIVilniu = ((traukinioKeleiviai - neIVilniuKeleiviai) / vagonuSkaicius);
            Console.WriteLine("Vidutiniskai keleiviu 1 vagone: {0}", kiekKeleiviuVagoneIVilniu);

            Console.ReadKey();
        }
    }
}
