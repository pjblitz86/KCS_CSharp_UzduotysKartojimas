using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("31 Diena. Turtuolis vs Matematikas");
            Console.WriteLine();

            double turtuolioPinigai = 1000000;
            double matematikoPinigai = 0.02;

            Console.WriteLine("{0} diena. Turtuolio pinigai = {1:000,000.00} dol, matematiko = {2:000,000.00} dol"
                , 1, turtuolioPinigai, matematikoPinigai);

            for (int diena = 2; diena <= 31; diena++)
            {
                turtuolioPinigai += 1000000;
                matematikoPinigai *= 2;
                Console.WriteLine("{0} diena. Turtuolio pinigai = {1:000,000.00} dol, matematiko = {2:000,000.00} dol"
                , diena, turtuolioPinigai, matematikoPinigai);
            }
            Console.ReadKey();
        }
    }
}
