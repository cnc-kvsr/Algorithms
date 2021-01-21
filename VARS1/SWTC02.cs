using System;
using System.Collections.Generic;
using System.Text;

namespace VARS1
{
    public static class SWTC02
    {
        public enum Renkler { Kirmizi, Yeşil, Mavi }

        public static void AnaKod()
        {
            Renkler r = (Renkler)(new Random()).Next(0, 10);

            /* Rastgele bir renk seçimi yapacağımız için new Random() ile random klasından bir nesne
             * üretiriz ve next komutuyla yeni bir rastgele sayının üretilmesini sağlarız.*/

            /* switch (r) yazıp iki defa tab tuşuna bastığımızda otomatik olarak switch durumu oluşur*/

            switch (r)
            {
                case Renkler.Kirmizi:
                    Console.WriteLine("Renk kirmizidir. ");
                    break;
                case Renkler.Yeşil:
                    Console.WriteLine("Renk yeşildir. ");
                    break;
                case Renkler.Mavi:
                    Console.WriteLine("Renk mavidir. ");
                    break;
                default:
                    Console.WriteLine("Renk bilinmiyor. ");
                    break;
            }

        }
    }
}
