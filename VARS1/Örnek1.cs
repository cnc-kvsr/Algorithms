using System;
using System.Collections.Generic;
using System.Text;

namespace VARS1
{
    public enum Meyveler { Portakal, Elma, Çilek, Nar, Armut, Mandalina }

    public static class Örnek1
    {
        public static void AnaKod()
        {
            Meyveler m = (Meyveler)(new Random()).Next(0, 10);
            switch (m)
            {
                case Meyveler.Portakal:
                    Console.WriteLine("Portakal");
                    break;
                case Meyveler.Elma:
                    Console.WriteLine("Elma");
                    break;
                case Meyveler.Çilek:
                    Console.WriteLine("Çilek");
                    break;
                case Meyveler.Nar:
                    Console.WriteLine("Nar");
                    break;
                case Meyveler.Armut:
                    Console.WriteLine("Armut");
                    break;
                case Meyveler.Mandalina:
                    Console.WriteLine("Mandalina");
                    break;
                default:
                    Console.WriteLine("Meyve değil :) ");
                    break;
            }
        }
        
     }
 }
