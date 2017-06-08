using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ar is lazdeliu sudesime keturkampi?");
            Console.WriteLine();

            Console.WriteLine("Iveskite lazdeliu a ir b ilgus:");
            int lazdeleA = Convert.ToInt32(Console.ReadLine());
            int lazdeleB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite lazdeliu c ir d ilgus:");
            int lazdeleC = Convert.ToInt32(Console.ReadLine());
            int lazdeleD = Convert.ToInt32(Console.ReadLine());

           if ((lazdeleA + lazdeleB) == (lazdeleC + lazdeleD))
            {
                if ((lazdeleA == lazdeleB) && (lazdeleA == lazdeleC) && (lazdeleA == lazdeleD) &&
                    (lazdeleB == lazdeleC) && (lazdeleB == lazdeleD) && (lazdeleC == lazdeleD))
                {
                    Console.WriteLine("Keturkampis yra kvadratas");
                }
                else if (((lazdeleA == lazdeleC) && (lazdeleB == lazdeleD)) || 
                          ((lazdeleA == lazdeleD) && (lazdeleB == lazdeleC)))
                {
                    Console.WriteLine("Keturkampis yra staciakampis");
                }
            }
           else
            {
                Console.WriteLine("Is siu lazdeliu neimanoma sudeti keturkampio");
            }
            Console.ReadKey();

        }
    }
}
