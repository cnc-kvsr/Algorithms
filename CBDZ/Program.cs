using System;

namespace CBDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] X = Matris.Olustur();
            //int[,] X = Matris.SifirMatrisiOlustur(3, 3);
            //int[,] X = Matris.KosegenMatrisOlustur(4);
            //int[,] X = Matris.SkalerMatrisOlustur(4,3);
            //int[,] X = Matris.BirlerMatrisiOlustur(3, 3);
            //Matris.Yazdır(X);
            //Console.WriteLine("{0}",
            //    Matris.KareMatrisMi(X) ? "Kare matris!" : "Kare Matris Dağil!");

            //int[,] X = Matris.BirimMatrisOlustur(4);
            //Matris.Yazdır(X);
            //Console.WriteLine("{0}", Matris.BirimMatrisMi(X) ? "Birim matris!" : "Birim matris değil!");

            //int[,] X = Matris.KosegenMatrisOlustur(3);
            //Matris.Yazdır(X);

            //int[] D = Matris.DiyagonalElemanlarınListesi(X);
            //Matris.Yazdır(D);

            //Console.WriteLine("Matrisin İzi: {0}", Matris.Izi(X));

            //int[,] X = Matris.Olustur(3, 2);
            //Matris.Yazdır(X);
            //int[,] T = Matris.Transpoz(X);
            //Matris.Yazdır(T);

            //int[,] X = Matris.Olustur(4, 3);
            //Matris.Yazdır(X);

            //int[,] Y = Matris.YenidenSekillendir(X, 6, 2);
            //Matris.Yazdır(Y);


            //int[,] X = Matris.Olustur(3, 4);
            //int[,] Y = Matris.Olustur(4,3);

            //Matris.Yazdır(X);
            //Matris.Yazdır(Y);

            ////Console.WriteLine("{0}", Matris.EsitlikMi(X, Y) ? "Matrisler Eşit!" : "Matrisler Eşit Değil!");
            //if (Matris.EsitlikMi(X, Y))
            //    Console.WriteLine("Matrisler Eşit!");
            //else
            //    Matris.YazdırHata("Matrisler Eşit Değil!");


            //int[,] X = Matris.Olustur(2,2);
            //Matris.Yazdır(X);
            //Console.WriteLine("|X| = {0}",
            //   Matris.Determinant(X));

            //int[,] X = Matris.Olustur();
            //Matris.Yazdır(X);

            //X = Matris.SkalerCarpım(2, X);
            //Matris.Yazdır(X);

            //int[,] X = Matris.BirlerMatrisiOlustur(2,2);
            //Matris.Yazdır(X);
            //Console.WriteLine("Elemanların toplamı: {0}", Matris.ElemanlarınToplamı(X));

            //int[,] X = Matris.SimetrikMatrisOlustur(5);
            //Matris.Yazdır(X);

            //Console.Write("{0}",
            //   Matris.SimetrikMi(X) ?
            //   "Simetrik!" : "Simetrik değil!");

            //int[,] X = Matris.KosegenMatrisOlustur(5, 5);
            //Matris.Yazdır(X);

            //Console.WriteLine("{0}",
            //    Matris.KösegenMatrisMi(X) ?
            //    "Köşegen matrisdir" : "Köşegen matris değildir!");

            //int[,] X = Matris.UstUcgenMatrisOlustur(5, -2, 3);
            //Matris.Yazdır(X);

            int[,] X = Matris.AltUcgenMatrisOlustur(5, -2, 3);
            Matris.Yazdır(X);

            //Console.WriteLine("{0}",
            //    Matris.UstUcgenMatrisMi(X) ?
            //    "Ust üçgen matris." :
            //    "Ust üçgen matris değil.");


             Console.WriteLine("{0}",
                Matris.AltUcgenMatrisMi(X) ?
                "Alt üçgen matris." :
                "Alt üçgen matris değil.");

        }
    }
}
