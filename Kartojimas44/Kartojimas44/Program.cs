using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pazymiu vidurkio skaiciavimas");
            Console.WriteLine();
            bool arIvesti = true;
            int pazymiuSkaicius = 0;
            int pazymiuSuma = 0;

            

            Console.WriteLine("Iveskite visus pazymius viena po kito. Po paskutinio spauskite 0.");

            while(arIvesti)
            {
                int pazymiai = Convert.ToInt32(Console.ReadLine());

                if (pazymiai == 0)
                {
                    arIvesti = false;
                    break;
                }
                pazymiuSuma += pazymiai;
                pazymiuSkaicius++;
            }

            if (pazymiuSuma !=0)
            {
                Console.WriteLine("Mokinio trimestro pazymiu vidurkis yra {0:0.00}"
                    , (double)pazymiuSuma/pazymiuSkaicius);
            }
            Console.ReadKey();
        }
    }
}
