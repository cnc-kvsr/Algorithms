using System;
using System.Collections.Generic;
using System.Text;

namespace DZLR
{
    public class Dizi
    {
        /// <summary>
        /// tek boyutlu dizi oluşturmak için kullanılan fonksiyon
        /// </summary>
        /// <param name="limit">dizinin uzunluğununu belirtir</param>
        /// <returns>Belirtilen uzunlukta rastgele sayılardan oluşmuş diziyi döner</returns>
        /// 
        public int[] Olustur(int limit)
        {
            int[] sayılar = new int[limit];
            Console.WriteLine(" ");
            for (int i = 0; i < limit; i++)
            {
                sayılar[i] = new Random().Next(1, 100);
                Console.Write("{0,3}", sayılar[i]);
            }
            Console.WriteLine(" ");

            return sayılar;
        }

        /// <summary>
        /// Parametre olarak aldığı dizideki en büyük elemanı döner
        /// </summary>
        /// <param name="dizi">dizi</param>
        /// <returns>en büyük eleman</returns>
        /// 
        public static int EnBuyuk(int[] dizi)
        {
            int eb = dizi[0];   //En büyük eleman dizinin sıfırıncı elemanıdır.
            for (int i = 1; i < dizi.Length; i++) //dizinin uzunluğu kadar dön.
            {
                if (dizi[i] > eb)
                    eb = dizi[i];
            }
            return eb;
        }

        /// <summary>
        /// parametre olarak aldığı dizideki en küçük elemanı döner
        /// </summary>
        /// <param name="dizi">dizi</param>
        /// <returns>en küçük eleman</returns>
        /// 
        public static int EnKucuk(int[] dizi)
        {
            int ek = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (ek > dizi[i])
                    ek = dizi[i];
            }
            return ek;
        }

        /// <summary>
        /// Parametre olarak aldığı dizinin aritmetik ortalamasını hesaplar ve döner.
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>Aritmetik ortalama</returns>
        /// 
        public static double AritmetikOrtalama(int[] X)
        {
            double toplam = 0;
            for (int i = 0; i < X.Length; i++)
                toplam += X[i];

            return toplam/X.Length;  
        }

        /// <summary>
        /// parametre olarak aldığı dizinin standart sapmasını hesaplar
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>Standart sapma</returns>
        /// 
        public static double StandartSapma(int[] X)
        {
            double aritmetikOrtalama = AritmetikOrtalama(X);
            double t = 0, f = 0;
            for (int i = 0; i < X.Length; i++)
            {
                f = X[i] - aritmetikOrtalama;
                t += Math.Pow(f, 2); //Math matematik fonksiyonu, Pow üs alma fonksiyonu
            }
            return Math.Sqrt(t / (X.Length - 1));
        }


        /// <summary>
        /// Bu dizideki tek sayıların sayısını döner
        /// </summary>
        /// <param name="X">X</param>
        /// <returns>Sonuç:tek sayıların sayısı</returns>
        public int TekSayılarınSayısı(int[] X)
        {
            int tekSayılarınSayısı = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 1)
                    tekSayılarınSayısı++;
            }
            return tekSayılarınSayısı;
        }

        /// <summary>
        /// Bu dizideki çift sayıların sayısını döner
        /// </summary>
        /// <param name="X">X</param>
        /// <returns>Sonuç:çift sayıların sayısı</returns>
        public int CiftSayılarınSayısı(int[] X)
        {
            int ciftSayılarınSayısı = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                    ciftSayılarınSayısı++;
            }
            return ciftSayılarınSayısı;
        }


        /// <summary>
        /// Bir dizideki tek sayılardan yeni bir dizi olusturur
        /// </summary>
        /// <param name="X">Dizi</param>
        /// <returns>tek sayılardan oluşan diziyi temsil eder</returns>
        public int[] TekDiziOlustur(int[] X)
        {
            int[] tekDizi = new int[TekSayılarınSayısı(X)];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 1)
                {
                    tekDizi[y] =X[i];
                    y++;
                }
            }
            return tekDizi;
        }


        /// <summary>
        /// Bir dizideki çift sayılardan oluşan yeni bir dizi oluşturur
        /// </summary>
        /// <param name="X">dizi</param>
        /// <returns>çift sayılardan oluşan diziyi temsil eder</returns>
        public int[] CiftDiziOluştur(int[] X)
        {
            int[] ciftDizi = new int[CiftSayılarınSayısı(X)];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    ciftDizi[y] = X[i];
                    y++;
                }
            }
            return ciftDizi;
        }

        /// <summary>
        /// parametre olarak aldığı diziyi ekrana yazdırır.
        /// </summary>
        /// <param name="X"></param>
        public static void Yazdır(int[] X)
        {
            Console.WriteLine(" ");
            for (int i = 0; i < X.Length; i++)
                Console.Write("{0,3}", X[i]);
            Console.WriteLine(" ");


        }
    }
}
