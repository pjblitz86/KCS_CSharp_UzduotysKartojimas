using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek pinigu prarukys");
            Console.WriteLine();

            Console.WriteLine("Kiek metu rukys");
            int metai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek cigareciu surukoma per diena?");
            int cigareciuPerDiena = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek cigareciu surukytu per diena padideja per metus?");
            int cigareciuPerDienaPadidejimas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kokia vienos cigaretes kaina?");
            double cigaretesKaina = Convert.ToDouble(Console.ReadLine());

            double kiekPinigu1 = (double) (cigaretesKaina * cigareciuPerDiena * 365);
            Console.WriteLine("1 metai - {0:0.00} Eur dumais", kiekPinigu1);

            for (int i = 2; i <= metai; i++)
            {
                double kiekPinigu2 = (double) (cigaretesKaina * (cigareciuPerDiena + cigareciuPerDienaPadidejimas) * 365);
                cigareciuPerDienaPadidejimas += cigareciuPerDienaPadidejimas;
                Console.WriteLine("{0} metai - {1:0.00} Eur dumais", i, kiekPinigu2);
            }
            Console.ReadKey();
        }
    }
}
