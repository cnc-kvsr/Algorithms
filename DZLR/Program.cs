using System;

namespace DZLR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n değerini giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] X = new Dizi().Olustur(n);

            Dizi dizi = new Dizi(); // class lar static olmadığı için nesne oluşturduk

            int[] tekSayılarDizisi = dizi.TekDiziOlustur(X);
            Dizi.Yazdır(tekSayılarDizisi);
            Console.WriteLine("Tek sayıların sayısı: {0,5}", dizi.TekSayılarınSayısı(X));

            int[] ciftSayılarDizisi = dizi.CiftDiziOluştur(X);
            Dizi.Yazdır(ciftSayılarDizisi);
            Console.WriteLine("Çift sayıların sayısı: {0,5}", dizi.CiftSayılarınSayısı(X));
        }
    }
}
