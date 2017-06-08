using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 DRAUGU UGIAI");
            Console.WriteLine();

            Console.Write("Iveskite Jono ugi cm: ");
            int UgisJono = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite Petro ugi cm: ");
            int UgisPetro = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite Broniaus ugi cm: ");
            int UgisBroniaus = Convert.ToInt32(Console.ReadLine());

            if ((UgisJono > UgisPetro) && (UgisJono > UgisBroniaus))
            {
                Console.WriteLine("Jono ugis didziausias");
            }
            else if ((UgisJono > UgisPetro) && (UgisJono < UgisBroniaus))
            {
                Console.WriteLine("Broniaus ugis didziausias");
            }
            else if ((UgisJono > UgisPetro) && (UgisJono == UgisBroniaus))
            {
                Console.WriteLine("Jono ir Broniaus ugiai lygus ir didziausi");
            }
            else if ((UgisJono < UgisPetro) && (UgisPetro < UgisBroniaus))
            {
                Console.WriteLine("Broniaus ugis didziausias");
            }
            else if ((UgisJono < UgisPetro) && (UgisPetro > UgisBroniaus))
            {
                Console.WriteLine("Petro ugis didziausias");
            }
            else if ((UgisJono < UgisPetro) && (UgisPetro == UgisBroniaus))
            {
                Console.WriteLine("Petro ir Broniaus ugiai lygus ir didziausi");
            }
            else if ((UgisJono == UgisPetro) && (UgisPetro < UgisBroniaus))
            {
                Console.WriteLine("Broniaus ugis didziausias");
            }
            else if ((UgisJono == UgisPetro) && (UgisPetro > UgisBroniaus))
            {
                Console.WriteLine("Jono ir Petro ugiai lygus ir didziausi");
            }
            else
            {
                Console.WriteLine("Blogai ivesti ugiai");
            }
            Console.ReadKey();
        }
    }
}
