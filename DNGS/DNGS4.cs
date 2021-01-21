using System;
using System.Collections.Generic;
using System.Text;

namespace DNGS
{
    public static class DNGS4
    {
        public static void AnaKod()
        {
            //Çarpım tablosu
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0,5} \tx {1,5} = {2,5}",
                        i, j, i * j);
                }

                Console.WriteLine("\n\n----------------------------\n\n");
            }
        }
    }
}
