using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COLINE MATAVIMO SISTEMA.\n1 colis = 25.4 mm\n12 coliu = 1 peda\n3 pedos = 1 jardas");
            Console.WriteLine();

            Console.WriteLine("Iveskite kiek jardu, pedu ir coliu sudaro 1 lazdele:");

            int jardai1 = Convert.ToInt32(Console.ReadLine());
            int pedos1 = Convert.ToInt32(Console.ReadLine());
            int coliai1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite kiek jardu, pedu ir coliu sudaro 2 lazdele:");
            int jardai2 = Convert.ToInt32(Console.ReadLine());
            int pedos2 = Convert.ToInt32(Console.ReadLine());
            int coliai2 = Convert.ToInt32(Console.ReadLine());

            // isreiskiame suma
            int jardaiSuma = jardai1 + jardai2;
            int pedosSuma = pedos1 + pedos2;
            int coliaiSuma = coliai1 + coliai2;

            // isivedame galutines sukonvertuotos sumos kintamuosius
            int jardaiGalutiniai = 0;
            int pedosGalutines = 0;
            int coliaiGalutiniai = 0;

            // tikriname ar sudejus lazdeles vienetai bus uz ribu (daugiau) gausis 6 var
            // tikriname kaip ivede atitinkamai konvertuojame i jardus, pedas ir colius
            if (coliaiSuma >= 12)
            {
                coliaiGalutiniai = coliaiSuma % 12;
                pedosGalutines = coliaiSuma / 12;
                jardaiGalutiniai = jardaiSuma + (coliaiSuma / 36);
                Console.WriteLine("Lazdeliu ilgiu suma: {0} jardai, {1} pedos, {2} coliai",
                    jardaiGalutiniai, pedosGalutines, coliaiGalutiniai);
            }
            // tikrinam pedas ar uz ribu
            else if (pedosSuma >= 3)
            {
                coliaiGalutiniai = coliai1 + coliai2;
                pedosGalutines = pedosSuma % 3;
                jardaiGalutiniai = jardaiSuma + pedosSuma / 3;
                Console.WriteLine("Lazdeliu ilgiu suma: {0} jardai, {1} pedos, {2} coliai",
                    jardaiGalutiniai, pedosGalutines, coliaiGalutiniai);
            }
            // jei ir coliai ir pedos uz ribu
            else if ((coliaiSuma >= 12) && (pedosSuma >= 3))
            {
                coliaiGalutiniai = coliaiSuma % 12;
                pedosGalutines = (coliaiSuma / 12) + (pedosSuma % 3);
                jardaiGalutiniai = jardaiSuma + coliaiSuma / 36 + (pedosSuma / 3);
                Console.WriteLine("Lazdeliu ilgiu suma: {0} jardai, {1} pedos, {2} coliai",
                    jardaiGalutiniai, pedosGalutines, coliaiGalutiniai);
            }
            // ir t.t.
            else if ((jardaiSuma >= 1) && (coliaiSuma >= 12) && (pedosSuma >= 3))
            {
                coliaiGalutiniai = coliaiSuma % 12;
                pedosGalutines = pedosSuma + coliaiSuma / 12 + (pedosSuma % 3);
                jardaiGalutiniai = jardaiSuma + (coliaiSuma / 36) + ((pedosSuma) / 3);
                Console.WriteLine("Lazdeliu ilgiu suma: {0} jardai, {1} pedos, {2} coliai",
                    jardaiGalutiniai, pedosGalutines, coliaiGalutiniai);
            }
            else if ((jardaiSuma >= 1) && (coliaiSuma >= 12))
            {
                coliaiGalutiniai = coliaiSuma % 12;
                pedosGalutines = (coliaiSuma) / 12;
                jardaiGalutiniai = jardaiSuma + (coliaiSuma / 36);
                Console.WriteLine("Lazdeliu ilgiu suma: {0} jardai, {1} pedos, {2} coliai",
                    jardaiGalutiniai, pedosGalutines, coliaiGalutiniai);
            }
            else if ((jardaiSuma >= 1) && (pedosSuma >= 3))
            {
                coliaiGalutiniai = coliai1 + coliai2;
                pedosGalutines = pedosSuma % 3;
                jardaiGalutiniai = jardaiSuma + (pedosSuma / 3);
                Console.WriteLine("Lazdeliu ilgiu suma: {0} jardai, {1} pedos, {2} coliai",
                    jardaiGalutiniai, pedosGalutines, coliaiGalutiniai);
            }
            else
            {
                Console.WriteLine("Lazdeliu ilgiu suma: {0} jardai, {1} pedos, {2} coliai",
                    jardaiSuma, pedosSuma, coliaiSuma);
            }
            Console.ReadKey();
        }
    }
}
