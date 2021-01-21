using System;
using System.IO;

namespace FILE
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kaynak = Dosya.FizikselYol("Adlar.txt");
            //string hedef = Dosya.FizikselYol("İsimler.txt");

            //Dosya.Kopyalama(kaynak, hedef);

            
            string kaynak = Dosya.FizikselYol("İsimler.txt");

            Dosya.Silme(kaynak);


        }
    }
}
   