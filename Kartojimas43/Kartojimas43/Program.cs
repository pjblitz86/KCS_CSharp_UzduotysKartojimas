using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Naturalaus skaiciaus maziausio skaitmens radimas numeruojant is desines i kaire");
            Console.WriteLine();
            Program radimas = new Program();
            radimas.paklausimas();
            int naturalusSk = Convert.ToInt32(Console.ReadLine());
            int Skaitmuo1 = naturalusSk % 10;
            int Skaitmuo2 = naturalusSk / 10;
            int Skaitmuo3 = naturalusSk / 100;
            int Skaitmuo4 = naturalusSk / 1000;
            int Skaitmuo5 = naturalusSk / 10000;
            int Skaitmuo6 = naturalusSk / 100000;
            int Skaitmuo7 = naturalusSk / 1000000;
            int Skaitmuo8 = naturalusSk / 10000000;
            int Skaitmuo9 = naturalusSk / 100000000;
            int Skaitmuo10 = naturalusSk / 1000000000;


        }

        private void paklausimas()
        {
            Console.WriteLine("Iveskite naturalu skaiciu iki 2000.000.000: ");
        }
    }
}
