using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktorialas");
            Console.WriteLine();
            Console.WriteLine("Iveskite naturalu skaiciu:");
            int sk = Convert.ToInt32(Console.ReadLine());

            int sandauga = 1;

            
            int faktor = 1;
            bool arDaugiau = true;
            while (arDaugiau)
            {
                for (int i = sk; i > 0; i--)
                {
                    sandauga *= i;



                    if (sandauga > sk)
                    {
                        Console.WriteLine("Skaicius {0} neturi faktorialo", sk);
                        arDaugiau = false;
                    }
                    else if (sandauga == sk)
                    {
                        Console.WriteLine("Skaiciaus {0} turi faktoriala {1}", );
                    }
                    else
                    {

                    }
                }
            }
            
            



        }
    }
}
