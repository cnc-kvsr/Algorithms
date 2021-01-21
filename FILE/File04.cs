using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FILE
{
    public static class File04
    {
        public static void AnaKod()
        {
            //FileInfo'yU kullanarak bir dosyayla alakalı detaylı bilgilere ulaşabiliyoruz
            string dosyaYolu = Dosya.FizikselYol("Adlar.txt");
            var fi = new FileInfo(dosyaYolu);

            Console.WriteLine(fi.FullName);  //dosyanın tam adı
            Console.WriteLine(fi.Length);   //dosyanın uzunluğu
            Console.WriteLine(fi.Extension);  //dosyanın uzantı bilgisi
            Console.WriteLine(fi.CreationTime);  //oluşturulma zamanı
            Console.WriteLine(fi.LastAccessTime);  //son erişim zamanı
            Console.WriteLine(fi.Name);  // adı

        }

        
    }
}
