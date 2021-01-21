using System;
using System.Collections.Generic;
using System.Text;

namespace DNGS
{
    public static class DNGS2
    {
        public static void AnaKod()
        {
            int tekToplam = 0, ciftToplam = 0;

            Console.WriteLine("Limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tek Sayılar");
            for (int i = 1; i <= limit; i += 2)
            {
                Console.Write("{0,5}", i);
                tekToplam += i; // tekToplam = tekToplam + i;
            }


            Console.WriteLine("\n\nÇift Sayılar");
            for (int i = 2; i <= limit; i += 2)
            {
                Console.Write("{0,5}", i);
                ciftToplam += i; // ciftToplam = ciftToplam + i;
            }


            Console.WriteLine("\n\nTek toplam: {0,5} \nCift toplam: {1,5}",
                tekToplam, ciftToplam);

        }
    }
}
