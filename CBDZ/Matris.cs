using System;
using System.Collections.Generic;
using System.Text;

namespace CBDZ
{
    public class Matris
    {
        /// <summary>
        /// Matris oluşturur
        /// </summary>
        /// <param name="satır">satır sayısı</param>
        /// <param name="sütun">sütun sayısı</param>
        /// <param name="min">min değer</param>
        /// <param name="mak">maks değer</param>
        /// <returns>X matrisi</returns>
        public static int[,] Olustur(int satır = 3,
            int sütun = 3, int min = 1, int mak = 9)
        {
            //iki boyutlu bir dizi oluşturma
            int[,] X = new int[satır, sütun];
            for (int i = 0; i < satır; i++)
                for (int j = 0; j < sütun; j++)
                    X[i, j] = new Random().Next(min, mak);
            return X;
        }

        /// <summary>
        /// parametre olarak aldığı matrisi ekrana yazar
        /// </summary>
        /// <param name="X"></param>
        public static void Yazdır(int[,] X)
        {
            Console.WriteLine();
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                    Console.Write("{0,5}", X[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Yazdır(int[] X)
        {
            Console.WriteLine();
            for (int i = 0; i < X.Length; i++)
                Console.Write("{0,5}", X[i]);
            Console.WriteLine();
        }

        public static void YazdırHata(string mesaj)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\a\n{0}\a\n", mesaj);
            Console.ResetColor();
        }

        /// <summary>
        /// sıfır matrisi oluşturur
        /// </summary>
        /// <param name="satir">satır sayısı</param>
        /// <param name="sutun">sutun sayısı</param>
        /// <returns>sıfır matrisi</returns>
        public static int[,] SifirMatrisiOlustur(int satir, int sutun)
        {
            return Olustur(satir, sutun, 0, 0);
        }

        /// <summary>
        /// birler matrisi oluşturur
        /// </summary>
        /// <param name="satir">satır sayısı</param>
        /// <param name="sutun">sütun sayısı</param>
        /// <returns>birler matrisi</returns>
        public static int[,] BirlerMatrisiOlustur(int satir, int sutun)
        {
            return Olustur(satir, sutun, 1, 1);
        }

        /// <summary>
        /// köşegen matris oluşturur
        /// </summary>
        /// <param name="boyut">satır ve sütun sayısı</param>
        /// <param name="min">min</param>
        /// <param name="maks">maks</param>
        /// <returns>köşegen matris</returns>
        public static int[,] KosegenMatrisOlustur(int boyut = 3,
            int min = 1, int maks = 9)
        {
            //önce sıfır matris oluşturulur sonra köşegen elemanlar üzerine işlem yapılır
            int[,] X = SifirMatrisiOlustur(boyut, boyut);
            for (int i = 0; i < boyut; i++)
                X[i, i] = new Random().Next(min, maks);
            return X;
        }
        /// <summary>
        /// Skaler matris oluşturur
        /// </summary>
        /// <param name="boyut">satır ve sütun</param>
        /// <param name="skaler">Köşegenler üstündeki değer</param>
        /// <returns>skaler matris</returns>
        public static int[,] SkalerMatrisOlustur(int boyut = 3, int skaler = 3)
        {
            return KosegenMatrisOlustur(boyut, skaler, skaler);
        }

        /// <summary>
        /// Kare matris kontrolü yapar
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>Sonuc</returns>
        public static bool KareMatrisMi(int[,] X)
        {
            return X.GetLength(0) == X.GetLength(1) ?
            true : false;
        }

        public static int[,] BirimMatrisOlustur(int boyut = 3)
        {
            return SkalerMatrisOlustur(boyut, 1);
        }

        public static bool BirimMatrisMi(int[,] X)
        {
            bool s = true;
            for (int i = 0; (i < X.GetLength(0) && s == true); i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    //Diyagonal elemanlar dışındaki 0 mı?
                    if (X[i, j] != 0 && i != j)
                    {
                        s = false;
                        break;
                    }
                    //diyagonal elemanlar 1 mi?
                    else
                    {
                        if (X[i, i] != 1 && i == j)
                        {
                            s = false;
                            break;
                        }
                    }
                }
            }
            return s;
        }

        /// <summary>
        /// Diyagonal elemanların listesini bir dizi olarak döner
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>Diyagonal elemanların listesi</returns>
        public static int[] DiyagonalElemanlarınListesi(int[,] X)
        {
            if (KareMatrisMi(X))
            {
                int[] D = new int[X.GetLength(0)];
                for (int i = 0; i < X.GetLength(0); i++)
                    D[i] = X[i, i];
                return D;
            }
            else
            {
                Console.WriteLine("Lütfen Kare Matris Giriniz!");
                return new int[1];
            }
        }
        /// <summary>
        /// Bir matrisin izini hesaplar
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>izi</returns>
        public static int Izi(int[,] X)
        {
            int t = 0;
            if (KareMatrisMi(X))
            {
                int[] D = DiyagonalElemanlarınListesi(X);
                for (int i = 0; i < X.GetLength(0); i++)
                    t += X[i, i];
                return t;
            }
            else
                return t;
        }
        /// <summary>
        /// bir matrisin transpozunu alır
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>transpoz</returns>
        public static int[,] Transpoz(int[,] X)
        {
            int[,] T = new int[X.GetLength(1), X.GetLength(0)];
            for (int i = 0; i < T.GetLength(0); i++)
                for (int j = 0; j < T.GetLength(1); j++)
                    T[i, j] = X[j, i];

            return T;
        }


        /// <summary>
        /// Parametre olarak verilen matrisi yeniden şekillendirir
        /// </summary>
        /// <param name="X"></param>
        /// <param name="yeniSatır"></param>
        /// <param name="yeniSutun"></param>
        /// <returns>yeni matris</returns>
        public static int[,] YenidenSekillendir(int[,] X,
            int yeniSatır, int yeniSutun)
        {
            if (X.Length == yeniSatır * yeniSutun)
            {

                int[] D = new int[X.Length];
                int sayac = 0;

                int[,] Y = new int[yeniSatır, yeniSutun];

                for (int i = 0; i < X.GetLength(0); i++)
                    for (int j = 0; j < X.GetLength(1); j++)
                    {
                        D[sayac] = X[i, j];
                        sayac++;
                    }
                Yazdır(D);

                sayac = 0;
                for (int i = 0; i < Y.GetLength(0); i++)
                    for (int j = 0; j < yeniSutun; j++)
                    {
                        Y[i, j] = D[sayac];
                        sayac++;
                    }
                return Y;
            }
            else
            {
                YazdırHata("Boyut Uyuşmazlığı Hatası!");
                return new int[1, 1];
            }
        }


        public static bool EsitlikMi(int[,] X, int[,] Y)
        {
            bool s = true;

            //boyut kontrolü
            if (X.GetLength(0) == Y.GetLength(0) &&
                X.GetLength(1) == Y.GetLength(1))
            {
                //eleman kotrolü
                for (int i = 0; i < X.GetLength(0); i++)
                    for (int j = 0; j < X.GetLength(1); j++)
                        if (X[i, j] != Y[i, j]) //koşul
                        {
                            s = false;
                            break;
                        }
            }
            else
            {
                s = false;
            }
            return s;
        }

        /// <summary>
        /// determinant hesabı yapar
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>determinant</returns>
        public static int Determinant(int[,] X)
        {
            int d = -1;
            if (KareMatrisMi(X))
            {
                if (X.Length == 4)
                    d = X[0, 0] * X[1, 1] - X[0, 1] * X[1, 0];
                else if (X.Length == 9)
                    d = X[0, 0] * (X[1, 1] * X[2, 2] - X[1, 2] * X[2, 1]) -
                        X[0, 1] * (X[1, 0] * X[2, 2] - X[1, 2] * X[2, 0]) +
                        X[0, 2] * (X[1, 0] * X[2, 1] - X[1, 1] * X[2, 0]);
                else
                    YazdırHata("Tanımlı bir boyut değil!");
                return d;
            }
            else
            {
                YazdırHata("Parametre kare matris olmalı!");
                return d;
            }

        }

        /// <summary>
        /// Skaler bir değer ile matrisi çarpar
        /// </summary>
        /// <param name="c">Skaler değer</param>
        /// <param name="X">matris</param>
        /// <returns>Çarpım sonucu</returns>
        public static int[,] SkalerCarpım(int c, int[,] X)
        {
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j < X.GetLength(1); j++)
                    X[i, j] = c * X[i, j];
            return X;
        }

        /// <summary>
        /// Bir matrisdeki elemanların toplamını bulur      
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>Toplam Sonucu</returns>
        public static int ElemanlarınToplamı(int[,] X)
        {
            int t = 0;
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j < X.GetLength(1); j++)
                    t += X[i, j];
            return t;
        }

        /// <summary>
        /// Simetrik matris oluşturur
        /// </summary>
        /// <param name="boyut">satır ve sütun sayısı</param>
        /// <param name="min">min</param>
        /// <param name="maks">maks</param>
        /// <returns>simetrik matris</returns>
        public static int[,] SimetrikMatrisOlustur(int boyut = 3,
           int min = 1, int maks = 9)
        {
            int[,] X = KosegenMatrisOlustur(boyut, min, maks);
            for (int i = 1; i < X.GetLength(0); i++)
                for (int j = 0; j <= i - 1; j++)
                {
                    X[i, j] = new Random().Next(min, maks);
                    X[j, i] = X[i, j];
                }
            return X;
        }
        /// <summary>
        /// matrisin simetrik olup olmadığını kontrol eder
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>eşitlik mi</returns>
        public static bool SimetrikMi(int[,] X)
        {
            int[,] Y = Matris.Transpoz(X);
            return EsitlikMi(X, Y);
        }


        /// <summary>
        /// parametre olarak aldıgı matrisin köşegen olup olmadığını söyler
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>köşegen mi</returns>
        public static bool KösegenMatrisMi(int[,] X)
        {
            bool s = true;
            if (Matris.KareMatrisMi(X))
            {
                for (int i = 0; i < X.GetLength(0); i++)
                    for (int j = 0; j < X.GetLength(1); j++)
                        if (!(X[i, j] == 0))
                            if (i != j)
                            {
                                s = false;
                                break;
                            }
            }
            else
            {
                YazdırHata("Kare matris değil!");
                s = false;
            }
            return s;
        }

        /// <summary>
        /// üst üçgen matris oluşturur
        /// </summary>
        /// <param name="boyut">boyut</param>
        /// <param name="min">min</param>
        /// <param name="maks">maks</param>
        /// <returns>üst üçgen matris</returns>
        public static int[,] UstUcgenMatrisOlustur(int boyut = 3,
           int min = 1, int maks = 9)
        {
            int[,] X = KosegenMatrisOlustur(boyut, min, maks);

            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = i; j < X.GetLength(1); j++)
                    X[i, j] = new Random().Next(min, maks);
            return X;
        }
        /// <summary>
        /// alt üçgen matris oluşturur
        /// </summary>
        /// <param name="boyut">boyut</param>
        /// <param name="min">min</param>
        /// <param name="maks">maks</param>
        /// <returns>alt üçgen matris</returns>
        public static int[,] AltUcgenMatrisOlustur(int boyut = 3,
           int min = 1, int maks = 9)
        {
            int[,] X = KosegenMatrisOlustur(boyut, min, maks);

            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j <= i; j++)
                    X[i, j] = new Random().Next(min, maks);
            return X;
        }

        /// <summary>
        /// parametre olarak aldığı matrisin üst üçgen matris olup olmadığına bakar
        /// </summary>
        /// <param name="X">matris</param>
        /// <returns>sonuç</returns>
        public static bool UstUcgenMatrisMi(int[,] X)
        {
            bool s = true;

            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j <= i - 1; j++)
                    if (!(X[i, j] == 0))
                    {
                        s = false;
                        break;
                    }
            return s;
        }

        /// <summary>
        /// Alt üçgen matris kontrolü yapar
        /// </summary>
        /// <param name="X">Matris</param>
        /// <returns>sonuç</returns>
        public static bool AltUcgenMatrisMi (int[,] X)
        {
            bool s = true;

            for (int i = 0; i < X.GetLength(0)-1; i++)
                for (int j =i+1; j <X.GetLength(1); j++)
                    if (!(X[i,j] == 0))
                    {
                        s = false;
                        break;
                    }
            return s;
        }
    } 
}


