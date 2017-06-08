using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Staciakampio perimetras ir plotas pagal duotus taskus");
            Console.WriteLine();

            Console.WriteLine("Iveskite staciakampio virsutinio kairio tasko koordinates x ir y: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite staciakampio apatinio desinio tasko koordinates x ir y: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            int ilgis = Math.Abs(x2 - x1);
            int plotis = Math.Abs(y2 - y1);

            int plotas = ilgis * plotis;
            int perimetras = 2 * (ilgis + plotis);

            Console.WriteLine("Pagal gautus taskus A({0},{1}) ir B({2},{3})\n", x1, y1, x2, y2);
            Console.WriteLine("Plotas: {0}, perimetras: {1}", plotas, perimetras);

            Console.ReadKey();
        }
    }
}
