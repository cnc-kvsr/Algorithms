using System;
using System.Collections.Generic;
using System.Text;

namespace VARS1
{
    public static class SWTC03
    {
        public static void AnaKod()
        {

            Random rnd = new Random();

            int caseSwitch = rnd.Next(1, 10);
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Durum 1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine($"Case {caseSwitch}");
                    break;
                default:
                    Console.WriteLine($"Beklenmeyen durum {caseSwitch}");
                    break;
            }
        }
    }
}
