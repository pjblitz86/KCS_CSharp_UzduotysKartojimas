using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valandos ir minutes paverstos minutem ir sekundem");
            Console.WriteLine();

            Console.Write("Iveskite kiek valadu: ");
            int valandos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite kiek valadu: ");
            int minutes = Convert.ToInt32(Console.ReadLine());


            int valandosIMinutes = valandos * 60;
            int pilnasLaikasMinutemis = valandosIMinutes + minutes;
            int pilnasLaikasSekundemis = pilnasLaikasMinutemis * 60;

            Console.WriteLine("Ivedete {0} valandas ir {1} minutes", valandos, minutes);
            Console.WriteLine("Tai yra {0} minuciu ir {1} sekundziu", pilnasLaikasMinutemis, pilnasLaikasSekundemis);

            Console.ReadKey();
        }
    }
}
