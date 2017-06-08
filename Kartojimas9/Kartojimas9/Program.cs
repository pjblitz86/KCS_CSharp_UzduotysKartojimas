using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laiko nustatymas po sekundės");
            Console.WriteLine();

            Console.Write("Iveskite valandas nuo 0 iki 23: ");
            int valanda = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite minutes nuo 0 iki 59: ");
            int minute = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite sekundes nuo 0 iki 59: ");
            int sekunde = Convert.ToInt32(Console.ReadLine());

            if ((valanda >= 0 && valanda <= 23) && 
                (minute >= 0 && minute <= 59) && 
                (sekunde >= 0 && sekunde <= 59))
            {
                Console.WriteLine("Dabar yra {0:00}h:{1:00}m:{2:00}s", valanda, minute, sekunde);
            }
            else
            {
                Console.WriteLine("Blogai ivestas dabartinis laikas");
            }

            int valandapoSek = 0;
            int minutepoSek = 0;
            int sekundepoSek = 0;

            // tikrinam jei tuoj vidurnaktis
            if ((valanda == 23) && (minute == 59) && (sekunde == 59))
            {
                valandapoSek = 0;
                minutepoSek = 0;
                sekundepoSek = 0;

            }
            // tikrinam kai keiciasi valandos
            else if ((sekunde == 59) && (minute == 59))
            {
                sekundepoSek = 0;
                minutepoSek = 0;
                valandapoSek = valanda + 1;
            }
            // kai keiciasi minutes
            else if (sekunde == 59)
            {
                sekundepoSek = 0;
                minutepoSek = minute + 1;
                valandapoSek = valanda;
            }
            else
            {
                valandapoSek = valanda;
                minutepoSek = minute;
                sekundepoSek = sekunde + 1;
            }
           
            Console.WriteLine("Po 1 sekundes laikas bus: {0:00}h:{1:00}m:{2:00}s", valandapoSek, minutepoSek, sekundepoSek);

            Console.ReadKey();
        }
    }
}
