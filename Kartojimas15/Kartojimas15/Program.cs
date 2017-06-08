using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Svarai, silingai ir pencai");
            Console.WriteLine("1 svaras = 20 silingu, 1 silingas = 12 pencu");
            Console.WriteLine();

            Console.WriteLine("Iveskite svarus, silingus ir pencus");
            int svarai = Convert.ToInt32(Console.ReadLine());
            int silingai = Convert.ToInt32(Console.ReadLine());
            int pencai = Convert.ToInt32(Console.ReadLine());

            // pridejus 1 penca
            int svarai1 = 0;
            int silingai1 = 0;
            int pencai1 = 0;




            if (silingai < 20 && pencai < 11)
            {
                svarai1 = svarai;
                silingai1 = silingai;
                pencai1 = pencai++;
                Console.WriteLine("Idejus 1 penca turesime: {0} svaru, {1} silingu, {2} pencu"
                                    , svarai1, silingai1, pencai1); 


            }
            else if (silingai < 19 && pencai == 11)
            {
                svarai1 = svarai;
                silingai1 = silingai++;
                pencai1 = 0;

                Console.WriteLine("Idejus 1 penca turesime: {0} svaru, {1} silingu, {2} pencu"
                                  , svarai1, silingai1, pencai1);

            }
            else if (silingai == 19 && pencai == 11)
            {
                svarai1 = svarai++;
                silingai1 = 0;
                pencai1 = 0;

                Console.WriteLine("Idejus 1 penca turesime: {0} svaru, {1} silingu, {2} pencu"
                                  , svarai1, silingai1, pencai1);

            }
            else
            {
                Console.WriteLine("Kazka blogai ivedete");
            }
        
        if (pencai >=12 && silingai >= 20)
            {

                svarai1 = silingai / 20;
                silingai1 = pencai / 20 + pencai % 20;
                pencai1 =  ///???;

                Console.WriteLine("Idejus 1 penca turesime: {0} svaru, {1} silingu, {2} pencu"
                                  , svarai1, silingai1, pencai1);



        }
}
}
