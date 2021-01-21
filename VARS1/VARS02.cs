using System;
using System.Collections.Generic;
using System.Text;

namespace VARS1
{
    public static class VARS02
    {
        public static void AnaKod()
        {
            int maks, mins;
            maks = System.Int16.MaxValue;
            mins = System.Int16.MinValue;


            int maks32 = System.Int32.MaxValue;
            int mins32 = System.Int32.MinValue;

            byte minByte = System.Byte.MinValue;
            byte maxByte = System.Byte.MaxValue;

            int sayı = 23;
            sayı = sayı * 2;
            // Console.WriteLine(sayı);

            Console.WriteLine("byte -> Min : {0} \t\t Mak : {1}",
                minByte, maxByte);

            Console.WriteLine("Int16 -> Min : {0} \t\t Mak : {1}",
                mins, maks);
            Console.WriteLine("Int32 -> Min : {0} \t Mak : {1}",
                mins32, maks32);
        }
    }
}
