using System;
using System.Collections.Generic;
using System.Text;

namespace VARS1
{
    public static class IfElse02
    {
        /// <summary>
        /// IF ELSE bloklarının && ve || yapısıyla kullanımı.
        /// </summary>
        public static void AnaKod()
        {
            int m = 9;
            int n = 7;
            int p = 5;

            if (m >= n && m >= p)
            {
                Console.WriteLine("En buyuk m");
            }

            if (m > n && !(p > m))
            {
                Console.WriteLine("En buyuk m");
            }

            if (m > n || m > p)
            {
                Console.WriteLine("m en kucuk değil");
            }

            m = 4;
            if (!(m >= n || m >= p))
            {
                Console.WriteLine("m artık en küçük!");
            }
        }

    }
}
