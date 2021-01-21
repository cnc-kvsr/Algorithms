using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace VARS1
{
    public static class VARS05
    {
        public static void AnaKod()
        {
            string[] meyveler = { "elma", "armut", "muz", "üzüm", "şeftali" };
            var meyve = from m in meyveler
                        where m[0] == 'a'
                        select m;

            // Direk Console.WriteLine(meyve) diyerek çıktı alındığında istenilen sonuç çıktıya yansımıyor!!!
            // Console.WriteLine(meyve);
            // WriteLine deyince alt alta yazar. Write dersek yan yana yazar!
            // {} kümeli parantez içine tek satırlık bir komut yazacaksak paranteze gerek yok.

            foreach (string m in meyve)
                Console.Write(m);

        }

    }
}
