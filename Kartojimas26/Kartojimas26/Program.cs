using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ar paveluos Petras i pamoka?");
            Console.WriteLine();

            Console.WriteLine("Iveskite kiek valandu ir minuciu rode laikrodis Petrui isejus is namu");
            int valandosIsejus = Convert.ToInt32(Console.ReadLine());
            int minutesIsejus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite valandas ir minutes, kada prasideda pamoka");
            int valandosPamoka = Convert.ToInt32(Console.ReadLine());
            int minutesPamoka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite kiek minuciu trunka Petro kelione i gimnazija");
            int kelioneMin = Convert.ToInt32(Console.ReadLine());
            
            int isejimasMinutemis = valandosIsejus * 60 + minutesIsejus;
            int pamokaPrasidedaMinutemis = valandosPamoka * 60 + minutesPamoka;

            if (pamokaPrasidedaMinutemis - isejimasMinutemis >= kelioneMin)
            {
                Console.WriteLine("Petras ateis i pamoka laiku");
            }
            else
            {
                Console.WriteLine("Petras paveluos i pamoka");
            }
            Console.ReadKey();
        }
    }
}
