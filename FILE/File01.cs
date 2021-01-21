using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FILE
{
    public static class File01
    {
        public static void AnaKod()
        {

            try
            {
                //dinamik konum
                string[] yol = Directory.GetCurrentDirectory().Split('\\');
                string dosyaYol = ""; //başlangıcta boş
                for (int i = 0; i < yol.Length - 3; i++)  //dizi uzunluğundan sondan 3 tanesini atarak aktif yola (gerçek fiziksel yola)erişmiş olacaz
                    dosyaYol += yol[i] + '\\';
                dosyaYol += "Rakamlar.txt"; //dosya dinamik olarak oluşturulmuş oldu

                //dosya okuma ve yazma
                using (StreamReader sr = new StreamReader(dosyaYol))
                {
                    string line;  //boş(null) bir string oluşturuldu
                    while ((line = sr.ReadLine()) != null)  //boş ifade gelene kadar consol yazmaya devam edecek
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
