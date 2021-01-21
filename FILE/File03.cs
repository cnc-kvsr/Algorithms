using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FILE
{
    public class File03
    {
        public static void AnaKod()
        {
            string ad = "";
            string dosyaYolu = Dosya.FizikselYol("Adlar.txt");
            try
            {
                FileStream fs = new FileStream(dosyaYolu,
                    FileMode.Append, //ekleme 
                    FileAccess.Write,  //eklediğimizi yazdırma
                    FileShare.None);  //herhangi bir paylaşım yok

                while (ad!="cikis") //dosyadan cıkmak için
                {
                    Console.WriteLine("Dosyaya kaydetmek üzere bir isim giriniz: ");
                    ad = Console.ReadLine();
                    if (ad != "cikis")  
                    {
                        if (fs.CanWrite) //yazma yetkisi var mı?
                        {
                            byte[] yaz = Encoding.UTF8.GetBytes(ad);  //string olarak girilmiş ifade bir byte dizisine çevrilmiş oldu
                            fs.Write(yaz, 0, yaz.Length);
                            fs.WriteByte(13);  //13 enter tuşuna karşılık geliyor
                        }
                        else
                        {
                            Console.WriteLine("Yazma yetkisi yok!");
                        }      
                    }
                }

                fs.Close(); //ilgili değişiklikleri kaydetmek için mutlaka fs.close eklenmeli
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
