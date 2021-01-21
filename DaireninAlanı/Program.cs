using System;

namespace DaireninAlanı
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Alan = {0:F2}", Daire.AlanıHesapla(r));

            Console.WriteLine("Alan = {0:F2}",
                Daire.AlanıHesapla(r, 60));
        }
    }
}
