using System;

namespace AlgoritmaTasarımı.Temeller
{
    public class Kisi
    {
        public Kisi()
        {

        }
        public Kisi(string adi)
        {
            Adi = adi;
        }
        public Kisi(string adi,int yas)
        {
            Adi = adi;
            Yas = yas;
        }

        public string Adi { get; set; }
        public int Yas { get; set; }
    }
    /*Kişi class olduğıu zaman soyut bir kavram ve bu classdan herhangi 
     * bir nesne üretilecekse yapılacak iş bu sınıfı somutlaştırmak */

    class Program
    {
        static void Main(string[] args)
        {
            Kisi k = new Kisi("Ahmet", 18);
            Console.WriteLine(k.Adi + ":" + k.Yas);

            Kisi k1 = new Kisi("Mehmet");
            Console.WriteLine(k1.Adi + ":" + k1.Yas);

            Kisi k2 = new Kisi();
            Console.WriteLine(k2.Adi + ":" + k2.Yas);
        }
    }
}
