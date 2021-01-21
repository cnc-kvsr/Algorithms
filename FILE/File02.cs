using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FILE
{
    public static class File02
    {
        public static void AnaKod()
        {
            try
            {
                //dinamik yol tanımı
                string[] yol = Directory.GetCurrentDirectory().Split('\\');
                string dosyaYol = "";
                for (int i = 0; i < yol.Length - 3; i++)
                    dosyaYol += yol[i] + "\\";
                dosyaYol += "Adlar.txt";

                string[] adlar = new string[] { "Zara", "Ayca", "Burak", "Mehmet" };
                using (StreamWriter sw = new StreamWriter(dosyaYol))
                {
                    foreach (string s in adlar)
                        sw.WriteLine(s);
                    Console.WriteLine("\n Adlar.txt dosyası başarılı bir şekilde oluşturuldu.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
