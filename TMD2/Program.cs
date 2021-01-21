using DZLR;
using System;

namespace TMD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Katarlar.Desen1();
            Katarlar.Desen1('!');
            Katarlar.Desen1('?', 10);

            Katarlar.Desen2();
            Katarlar.Desen2('!');
            Katarlar.Desen2('?', 10);

            //Katarlar.KarakterSeti();
            //Katarlar.KarakterSeti(128,255);
            //Katarlar.KarakterSeti(128,255,10);

            //string ifade = " Afacan ";
            //Console.WriteLine(ifade);
            //Console.WriteLine(ifade.Length);
            //Console.WriteLine(ifade.Trim());
            //Console.WriteLine(ifade.Trim().Length);
            //Console.WriteLine(ifade.TrimStart());
            //Console.WriteLine(ifade.TrimEnd());
            //Console.WriteLine(ifade.ToLower());
            //Console.WriteLine(ifade.ToUpper());
            //Console.WriteLine(ifade.Replace('a', 'e'));

            ////Üst Alma
            //double s1 = Convert.ToDouble(Console.ReadLine());
            //double s2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("{0}^{1} = {2}",
            //    s1, s2, Matematik.UstAlma(s1, s2));

            //asal çarpanlar
            //int[] asalCarpanlar = Matematik.AsalCarpanlar(60);
            //for (int i = 0; i < asalCarpanlar.Length; i++)
            //{
            //    Console.WriteLine(asalCarpanlar[i]);
            //}

            //Console.WriteLine("{0} sayısının asal çarpanlarının toplamı = {1}",60,Matematik.AsalCarpanlarınToplamı(60));

            //Console.WriteLine("{0} sayısının asal çarpanlarının çarpımı = {1}", 180, Matematik.AsalCarpanlarınCarpımı(180));

            ////OKEK
            //double s1 = Convert.ToDouble(Console.ReadLine());
            //double s2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("OKEK({0},{1}) = {2}",
            //    s1, s2, Matematik.OKEK((int)s1, (int)s2));

            ////OBEB
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //int s2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("OBEB({0},{1}) = {2}",
            //    s1, s2, Matematik.OBEB(s1, s2));

            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0}!= {1}", n, Matematik.Faktorıyel(n));

            //int t = 0;
            //for (int i = 2; i < 9; i++)
            //{
            //    t += Matematik.Faktorıyel(i);
            //    Console.WriteLine("{0}! = {1}", i, Matematik.Faktorıyel(i));
            //}

            //Console.WriteLine("Ortalama = {0:F2}", (double)t / 7);


            //Dizi d = new Dizi(); //metot statik olmadığı için nesne oluşturduk

            //int[] dizi = d.IfadeyiDiziyeÇevir("2,3,4,5,6");

            //int[] dizi = new Dizi().IfadeyiDiziyeÇevir("1,23"); 

            //int a = Matematik.İkilikTabandan10lukTabanaGeç("101");
            //Console.WriteLine(a);


            //int a = new Katarlar().SesliHarfSayısı("Köpek");
            //Console.WriteLine(a);

        }


    }
}
