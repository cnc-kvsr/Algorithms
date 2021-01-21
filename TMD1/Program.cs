using System;

namespace TMD1
{
    class Program
    {
        static void Main(string[] args)
        {
           // int n = Convert.ToInt32(Console.ReadLine());

            //if (Sayi.ÇiftMi(n))
            //    Console.WriteLine("Girilen sayı = {0} çift bir sayıdır!", n);
            //else if (Sayi.TekMi(n))
            //    Console.WriteLine("Girilen sayı = {0} tek bir sayıdır!", n);


            //Console.WriteLine("|{0}| = {1}", n, Sayi.MutlakDeğer(n));


            //Console.WriteLine("{0}", Sayi.AsalMi(n) ? "Asal Sayı!" : "Asal sayı değil!");


            //Console.WriteLine("{0} Sayısının rakamları toplamı = {1}", n, Sayi.RakamlariToplami(n));


            //Console.WriteLine("Birden {0}'e kadar olan sayıların toplamı = {1,5}",
            //    n, Sayi.NeKadarOlanSayılarınToplamı(n));


            //Console.WriteLine("Birden {0}'e kadar olan sayıların toplamı = {1}",
            //   n, Sayi.NeKadarOlanSayılarınFormülleToplamı(n));


            //Console.WriteLine("Birden {0}'e kadar olan tek sayıların toplamı = {1}",
            //    n, Sayi.NeKadarOlanTekSayılarınFormülleToplamı(n));


            //Console.WriteLine("{0}", Sayi.NeKadarOlanÇiftSayılarınToplamı(n));
            //Console.WriteLine("{0}", Sayi.NeKadarOlanÇiftSayılarınToplamıAlternatifÇözüm(n));
            //Console.WriteLine("{0}", Sayi.NeKadarOlanÇiftSayılarınFormülleToplamı(n));

             
            int t1 = Sayi.NeKadarOlanÇiftSayılarınFormülleToplamı(80);
            int t2 = Sayi.NeKadarOlanÇiftSayılarınFormülleToplamı(48);
            Console.WriteLine("{0,5} - {1,5} = {2,5}",
                t1, t2, t1 - t2);
        }

    }
}
