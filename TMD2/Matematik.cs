using System;
using System.Collections.Generic;
using System.Text;

namespace TMD2
{
    public class Matematik
    {
        /// <summary>
        /// Parametre olarak aldığı taban ve kuvvet bilgisine bağlı olarak üst alma
        /// </summary>
        /// <param name="taban">taban bilgisi</param>
        /// <param name="kuvvet">kuvvet bilgisi</param>
        /// <returns>sonuç</returns>

        public static double UstAlma(double taban, double kuvvet)
        {
            double s = 1;
            for (int i = 1; i <= kuvvet; i++)
                s *= taban;
            return s;
        }

        /// <summary>
        /// Bir sayının asal çarpanlarını verir
        /// </summary>
        /// <param name="n">Sayıyı temsil eder</param>
        /// <returns>Asal çarpanlar dizisidir</returns>
        public static int[] AsalCarpanlar(int n)
        {
            string carpanListesi = "";
            int i = 2;

            //asal çarpanlarını bulalım
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    carpanListesi += i.ToString() + ",";
                }
                else
                    i++;
            }
            carpanListesi = carpanListesi.Substring(0, carpanListesi.Length - 1);
            string[] carpanlar = carpanListesi.Split(",");

            /*tekrar eden ifadelerden programı kurtarmak için önce geçici bir değişken tanımlanır ve carpanların ilk
             * değeri bu değişkene atanır.daha sonra tekrarsız ifadeleri tutan bir sonuç değişkeni tanımlanır(y).
             * y de varsayılan olarak çarpanlar[0] ilk elemanına atanır.*/

            string s = carpanlar[0];
            string y = s;

            for (i = 0; i < carpanlar.Length; i++)
            {
                if (!(s == carpanlar[i]))
                {
                    y = y + "," + carpanlar[i];
                    s = carpanlar[i];
                }
            }

            carpanlar = y.Split(',');
            int[] asalCarpanlar = new int[carpanlar.Length];
            for (i = 0; i < asalCarpanlar.Length; i++)
                asalCarpanlar[i] = Convert.ToInt32(carpanlar[i]);

            return asalCarpanlar;
        }

        /// <summary>
        /// Bir sayının asal çarpanlarının toplamını verir          
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>toplam</returns>
        public static int AsalCarpanlarınToplamı(int n)
        {
            int[] asalCarpanlar = AsalCarpanlar(60);
            int t = 0;
            for (int i = 0; i < asalCarpanlar.Length; i++)
                t += asalCarpanlar[i];
            return t;
        }


        /// <summary>
        /// Bir sayının asal çarpanlarının çarpımını hesaplar
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>Çarpım</returns>
        public static int AsalCarpanlarınCarpımı(int n)
        {
            int c = 1;
            int[] asalCarpanlar = AsalCarpanlar(n);
            for (int i = 0; i < asalCarpanlar.Length; i++)
                c *= asalCarpanlar[i];
            return c;
        }

        /// <summary>
        /// İki Sayının OKEK hesabı
        /// </summary>
        /// <param name="s1">sayı 1</param>
        /// <param name="s2">sayı 2</param>
        /// <returns>OKEK</returns>
        public static int OKEK(int s1, int s2)
        {
            int s = 1;
            while (s1 != 1 && s2 != 1)
            {
                int bol = 2;
                for (int i = 1; i <= (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bol == 0 || s2 % bol == 0)
                    {
                        s *= bol;
                        if (s1 % bol == 0)
                            s1 /= bol;

                        if (s2 % bol == 0)
                            s2 /= bol;
                    }
                    else
                        bol++;
                }
            }

            return s;
        }


        /// <summary>
        /// İki sayının OBEB hesabı
        /// </summary>
        /// <param name="s1">sayı1</param>
        /// <param name="s2">sayı2</param>
        /// <returns>iki sayının OBEBi</returns>
        public static int OBEB(int s1, int s2)
        {
            int s = 1;
            int bolen = 2;
            while (s1 != 1 && s2 != 1)
            {
                for (int i = 2; i < (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bolen == 0 || s2 % bolen == 0)
                    {
                        if (s1 % bolen == 0 && s2 % bolen == 0)
                            s *= bolen;
                        if (s1 % bolen == 0)
                            s1 /= bolen;
                        if (s2 % bolen == 0)
                            s2 /= bolen;
                    }
                    else
                        bolen++;
                }
            }
            return s;
        }

        /// <summary>
        /// Parametre olarak verilen sayının faktorıyel hesabı
        /// </summary>
        /// <param name="n">sayı</param>
        /// <returns>sayının faktoriyeli</returns>

        public static int Faktorıyel(int n)
        {
            if (n <= 1)
                return 1;
            int f = 1;
            for (int i = 1; i <= n; i++)
                f *= i;
            return f;
        }

        /// <summary>
        /// 2lik tabandan 10luk taban geçiş yapan bir program
        /// </summary>
        /// <param name="ikiliksayı">ikilik sayı</param>
        /// <returns>sayının 10 luk tabandaki karşılığı</returns>

        public static int İkilikTabandan10lukTabanaGeç (string ikiliksayı)
        {
            //uzunluğu belirle
            int n = ikiliksayı.Length;
            //her bir basamağın dizide tutulması
            int[] basamaklar = new int[n];
            //onluk karşılığı
            int sayı = 0;
            bool kontrol = true;
            for (int i = 0; i < n; i++)
            {
                if (!(ikiliksayı[i] == '0' || ikiliksayı[i] == '1'))
                {
                    Console.WriteLine("\aHatalı Giriş!");
                    kontrol = false;
                    break;
                }
                basamaklar[i] = (int)(ikiliksayı[i] - '0'); //char bir ifadenin int e dönüşümünü mümkün kılmak için böyle bir işleme gerek duyuldu
            }
            //2'lik sistemden 10'luk sisteme geçiş
            if (kontrol)
            {
                for (int i = 0; i < n; i++)
                    sayı += (int)Math.Pow(2, n - 1 - i) * basamaklar[i];
                Console.WriteLine("({0}) ikilik sayı = {1}",
                    ikiliksayı, sayı);
            }
            return sayı;
        }

    }
}
