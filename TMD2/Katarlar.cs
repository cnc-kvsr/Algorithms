using System;
using System.Collections.Generic;
using System.Text;

namespace TMD2
{
    public class Katarlar
    {
        /// <summary>
        /// Desen Oluşturucu
        /// </summary>
        /// <param name="c">Karakter Katarı</param>
        /// <param name="n">Tekrar sayısı</param>
        public static void Desen1(char c = '*', int n = 5)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0,10}", new string(c, i));
            }
        }

        /// <summary>
        /// Desen Oluşturucu    
        /// </summary>
        /// <param name="c">Karakter</param>
        /// <param name="n">Döngü Sayısı</param>
        public static void Desen2(char c = '-', int n = 4)
        {
            for (int i = n; i >= 0; i--)
            {
                Console.WriteLine("{0}", new string(c, i));
            }
        }

        /// <summary>
        /// Karakter seti
        /// </summary>
        /// <param name="baslangıcİndisi"></param>
        /// <param name="bitisİndisi"></param>
        /// <param name="satırKarakterSayısı"></param>
        public static void KarakterSeti(int baslangıcİndisi=65, int bitisİndisi=90, 
            int satırKarakterSayısı=5)
        {
            for (int i = baslangıcİndisi; i <= bitisİndisi; i++)
            {
                Console.Write("{0,5}", (char)i);
                if (i % satırKarakterSayısı == 0)
                    Console.WriteLine();
            }
        }

        /// <summary>
        /// Girilen ifadedeki sesli harf sayısını döner
        /// </summary>
        /// <param name="ifade">string ifadesi</param>
        /// <returns>sesli harf sayısı</returns>
        public int SesliHarfSayısı(string ifade)
        {
            //sesli harf
            int sesliHarf = 0;

            for (int i = 0; i < ifade.Length; i++)  //bir döngü yardımıyla girilen ifade tek tek dolaşılır.
            {
                //sesli harf kontrolü
                if (ifade[i] == 'a' || ifade[i] == 'A' ||
                    ifade[i] == 'e' || ifade[i] == 'E' ||
                    ifade[i] == 'ı' || ifade[i] == 'I' ||
                    ifade[i] == 'i' || ifade[i] == 'İ' ||
                    ifade[i] == 'o' || ifade[i] == 'O' ||
                    ifade[i] == 'ö' || ifade[i] == 'Ö' ||
                    ifade[i] == 'u' || ifade[i] == 'U' ||
                    ifade[i] == 'ü' || ifade[i] == 'Ü')
                    sesliHarf++;

            }
            Console.WriteLine("{0} ifedesinde {1} sesli harf var", ifade, sesliHarf);
            return sesliHarf;
        }
    }
}
