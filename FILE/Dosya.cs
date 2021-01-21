using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FILE
{
    public class Dosya
    {
        public static string FizikselYol(string dosyaAdı)
        {
            string[] yol = Directory.GetCurrentDirectory().Split('\\');
            string dosyaYol = "";
            for (int i = 0; i < yol.Length - 3; i++) 
                dosyaYol += yol[i] + '\\';
            dosyaYol += dosyaAdı;
            return dosyaYol;
        }

        /// <summary>
        /// Dosya kopyalama metodu
        /// </summary>
        /// <param name="kaynak">kaynak dosya yolu</param>
        /// <param name="hedef">hedef dosya yolu</param>
        public static void Kopyalama(string kaynak, string hedef)
        {
            try
            {
                FileInfo fi = new FileInfo(kaynak);
                fi.CopyTo(hedef);
                Console.WriteLine("{0} kaynaklı dosya {1} e kopyalandı", kaynak, hedef);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Verilen parametre bilgisine bağlı olarak ilgili dosyayı 
        /// kalıcı olarak siler
        /// </summary>
        /// <param name="kaynak">Kaynak dosya yolu</param>
        public static void Silme(string kaynak)
        {
            try
            {
                FileInfo fi = new FileInfo(kaynak);
                fi.Delete();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");  // $ ifadesini kull. zaman değişkenlari dinamik olarak süslü parantez içerisinde görebiliyoruz 
            }
        }

    }
}
