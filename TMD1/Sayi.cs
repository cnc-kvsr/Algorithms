using System;
using System.Collections.Generic;
using System.Text;

namespace TMD1
{
    public class Sayi
    {
        /// <summary>
        /// Parametre olarak aldığı sayının tek mi çift mi olduğunu kontrol eder. 
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Tek ise true çift ise false dönüş yapar.</returns>

        public static bool TekMi(int n)
        {
            if (n % 2 == 1)
                return true;
            return false;
        }

        /// <summary>
        /// Parametre olarak aldığı sayının çift olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="n">Sayi</param>
        /// <returns>Çift ise true aksi durumda false dönüş yapar.</returns>

        public static bool ÇiftMi(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }

        /// <summary>
        /// Parametre olarak alınan sayının mutlak değerini döner.
        /// </summary>
        /// <param name="n">Girilen sayıyı temsil eder.</param>
        /// <returns>Girilen sayının mutlak değeri dönüş ifadesi olacak.</returns>

        public static int MutlakDeğer(int n)
        {
            if (n > 0)
                return n;
            else if (n < 0)
                return -1 * n;
            else
                return 0;
        }

        /// <summary>
        /// Parametre olarak aldığı sayının asal sayı olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="n">Girilen sayı</param>
        /// <returns>Girilen sayının asal sayı olup olmadığını söyler.</returns>

        public static bool AsalMi(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("En küçük asal sayı 2'dir!");
                return false;
            }

            bool kontrol = true;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                {
                    kontrol = false;
                    break;
                }
            return kontrol;
        }

        /// <summary>
        /// Parametre olarak alınan sayının rakamlarının toplamını verir.
        /// </summary>
        /// <param name="n">Girilen sayı</param>
        /// <returns>Sayının rakamları toplamını dönüş yapar.</returns>

        public static int RakamlariToplami(int n)
        {
            int toplam = 0, rakam = 0;
            while (n > 0)
            {
                rakam = n % 10;
                toplam += rakam;
                n = n / 10;
            }
            return toplam;
        }

        /// <summary>
        /// Birden 10a kadar olan sayıların toplamı
        /// </summary>
        /// <param name="n">Girilen sayı</param>
        /// <returns>Toplam değer</returns>
        public static int NeKadarOlanSayılarınToplamı(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
                t += i;
            return t;
        }
        /// <summary>
        /// Birden 10a kadar olan sayıların formülle toplamı
        /// </summary>
        /// <param name="n">Girilen sayı</param>
        /// <returns>toplam değer</returns>
        public static int NeKadarOlanSayılarınFormülleToplamı(int n)
        {
            return n * (n + 1) / 2;
        }

        /// <summary>
        /// Birden n'e kadar olan tek sayıların toplamı
        /// </summary>
        /// <param name="n">Girilen sayı</param>
        /// <returns>Tek sayıların toplamını verir.</returns>
        public static int NeKadarOlanTekSayılarınToplamı(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                    t += i;
            }
            return t;
        }

        /// <summary>
        /// Birden n'e kadar olan tek sayıların toplamı alternatif çözüm
        /// </summary>
        /// <param name="n">girilen sayı</param>
        /// <returns>Tek sayıların toplamı</returns>
        public static int NeKadarOlanTekSayılarınToplamıAlternatifÇözüm(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i += 2)
                t += i;
            return t;
        }


        //public static int NeKadarOlanTekSayılarınFormülleToplamı(int n)
        //{
        //    int i;
        //    int t;
        //    i = (n + 1) / 2;
        //    return t = i * i;
        //}

        /// <summary>
        /// Birden n'e kadar olan tek sayıların formülle toplamı 
        /// </summary>
        /// <param name="n">girilen sayı</param>
        /// <returns>tek sayıları toplamı</returns>
        public static int NeKadarOlanTekSayılarınFormülleToplamı(int n)
        {
            n = n + 1;
            n = n / 2;
            return n * n;
        }

        /// <summary>
        /// n'e kadar olan çift sayıların toplamı
        /// </summary>
        /// <param name="n">Girilen sayı</param>
        /// <returns>Çift sayıların toplamını verir</returns>
        public static int NeKadarOlanÇiftSayılarınToplamı (int n)
        {
            int t = 0;
            for (int i = 2; i <=n; i++)
            {
                if (i % 2 == 0)
                    t += i;
            }
            return t;
        }

        /// <summary>
        /// n'e kadar olan çift sayıların toplamı alternatif çözümü
        /// </summary>
        /// <param name="n">Girilen sayı</param>
        /// <returns>Çift sayıların toplamını verir</returns>
        public static int NeKadarOlanÇiftSayılarınToplamıAlternatifÇözüm (int n)
        {
            int t = 0;
            for (int i = 2; i <= n; i += 2)
                t += i;
            return t;
           
        }

        /// <summary>
        /// n'e kadar olan çift sayıların formülle toplamı
        /// </summary>
        /// <param name="n">Girilen sayı</param>
        /// <returns>Çift sayıların toplamını verir</returns>
        public static int NeKadarOlanÇiftSayılarınFormülleToplamı (int n)
        {
            n = n / 2;
            return n * (n+1);
        }
    }
}
