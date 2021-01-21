using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VARS1
{
    public static class VAR_deneme
    {
        public static void AnaKod()
        {
            string[] kimyasallar = { "arsenik", "klor", "seryum", "klorat", "etil alkol", "metil alkol", "hidroklorik asit" };
            var kimyasal = from h in kimyasallar
                           where h[0] == 'h'
                           select h;

            foreach (string h in kimyasal)
                Console.WriteLine(h);
        }
    }
}
