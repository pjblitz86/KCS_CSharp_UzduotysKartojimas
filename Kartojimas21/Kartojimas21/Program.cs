using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laiko nustatymas pries 1 sekunde");
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

            int valandapriesSek = 0;
            int minutepriesSek = 0;
            int sekundepriesSek = 0;

            // tikrinam jei ka tik vidurnaktis
            if ((valanda == 0) && (minute == 0) && (sekunde == 0))
            {
                valandapriesSek = 23;
                minutepriesSek = 59;
                sekundepriesSek = 59;

            }
            // tikrinam kai keiciasi valandos
            else if ((sekunde == 0) && (minute == 0))
            {
                sekundepriesSek = 59;
                minutepriesSek = 59;
                valandapriesSek = valanda - 1;
            }
            // kai keiciasi minutes
            else if (sekunde == 0)
            {
                sekundepriesSek = 59;
                minutepriesSek = minute - 1;
                valandapriesSek = valanda;
            }
            else
            {
                valandapriesSek = valanda;
                minutepriesSek = minute;
                sekundepriesSek = sekunde - 1;
            }

            Console.WriteLine("Pries 1 sekunde laikas buvo: {0:00}h:{1:00}m:{2:00}s", valandapriesSek, minutepriesSek, sekundepriesSek);

            Console.ReadKey();
        }
    }
}
