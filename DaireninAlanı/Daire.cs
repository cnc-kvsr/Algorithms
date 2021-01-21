using System;
using System.Collections.Generic;
using System.Text;

namespace DaireninAlanı
{
    public class Daire
    {
        public const double pi = 3.14;
        /// <summary>
        /// Dairenin alanını hesaplar.
        /// </summary>
        /// <param name="r">Yarıçap</param>
        /// <returns>Alan değeridir.</returns>
        /// 

        public static double AlanıHesapla(double r)
        {
            return pi * r * r;
        }

        /// <summary>
        /// Dairenin alanını hesaplar
        /// </summary>
        /// <param name="r">Yarıçap</param>
        /// <param name="aci">Gördüğü açı</param>
        /// <returns></returns>

        public static double AlanıHesapla(double r, double aci)
        {
            return pi * r * r * aci/360;
        }


    }
}
