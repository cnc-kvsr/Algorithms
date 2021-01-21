using System;

namespace TMD2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //kolsoldan ifadenin okunması
            string ifade = Console.ReadLine();

            string[] bolunmusIfade = ifade.Split(',');

            int n = bolunmusIfade.Length;

            //sayısal dizi
            int[] sayısalDizi = new int[n];

            //ayrıştırma
            for (int i = 0; i < n; i++)
            {
                sayısalDizi[i] = Convert.ToInt32(bolunmusIfade[i]);
                Console.WriteLine("dizi[{0}] = {1}", i + 1, sayısalDizi[i]);
            }
        }
    }
}
