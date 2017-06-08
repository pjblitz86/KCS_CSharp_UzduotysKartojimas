using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dvieju skaiciu sandaugos be sandaugos zenklo radimas");
            Console.WriteLine();

            Console.WriteLine("Iveskite 2 sveikus skaicius");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());



            int sandauga = (int)(decimal.Multiply(skaicius1, skaicius2));
            Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, sandauga);
            Console.ReadKey();
        }
    }
}
