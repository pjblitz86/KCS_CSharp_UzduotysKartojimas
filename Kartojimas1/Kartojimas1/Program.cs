using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek reikes lapu jei ivedame kiek mokiniu ir konspekto lapu skaiciu");
            Console.WriteLine();
            Console.Write("Iveskite kiek klaseje mokiniu: ");
            int kiekMokiniu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite kiek konspekte lapu: ");
            int kiekKonspekteLapu = Convert.ToInt32(Console.ReadLine());
            int visoLapu = kiekMokiniu * kiekKonspekteLapu;

            Console.WriteLine();
            Console.WriteLine("Viso jums reikes {0} lapu", visoLapu);
            Console.ReadKey();
        }
    }
}
