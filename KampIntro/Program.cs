
using System;
namespace KampIntro
{
    class Hello
    {
        static void Main(string[] args)
        {
            #region Değişkenler

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;

            #endregion


            #region İf Else-İf
            bool sistemeGirisYapmisMi = false; //Gerçek Hayatta burası bir veri kaynağından gelir.

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }



            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            #endregion

        }
    }
}