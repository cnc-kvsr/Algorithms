using System;
using System.Collections.Generic;
using System.Text;

namespace VARS1
{
    public static class IfElse01
    {
        public static void AnaKod()
        {
            Console.WriteLine("Bir Karakter Giriniz:");
            char ch = (char)Console.Read();

            if (char.IsUpper(ch))
            {
                Console.WriteLine("Girilen İfade Büyük Bir Karakterdir.");
            }

            else if (char.IsLower(ch))
            {
                Console.WriteLine("Girilen Karakter Küçük Bir Karakterdir.");
            }

            else if (char.IsDigit(ch))
            {
                Console.WriteLine("Girilen Karakter Bir Rakamdır.");
            }

            else
            {
                Console.WriteLine("Girilen Karakter Alfanumerik Bir İfade Değildir. ");
            }

        }
    }
}
