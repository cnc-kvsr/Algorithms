using System;
using System.Collections.Generic;
using System.Text;

namespace DNGS
{
    public static class DNGS3
    {
        public static void AnaKod()
        {
            int sayac = 0;

            for (int i = 1000; i >= 0; i -= 5)
            {
                Console.Write("{0,5}", i);
                sayac++;
            }

            Console.WriteLine("\n\nEleman Sayısı: {0}", sayac);

        }
    }
}
