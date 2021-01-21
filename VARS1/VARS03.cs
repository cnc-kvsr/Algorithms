using System;
using System.Collections.Generic;
using System.Text;

namespace VARS1
{
    public static class VARS03
    {
        public static void AnaKod()
        {
            // kutulama - boxing
            int i = 23;
            object o = i;

            // kutudan çıkarma - unboxing
            i *= 2; // i = i*2;
            i = (int)o; // cast

            Console.WriteLine("Deger turu: {0}", i);
            Console.WriteLine("Referans turu: {0}", o);
        }

    }
}
