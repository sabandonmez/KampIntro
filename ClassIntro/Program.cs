
using System;
namespace ClassIntro
{
    class Hello
    {
        static void Main(string[] args)
        {
            //Peki bu Kurs classımızı veya başka bir değişle bu değişken tipimizi nasıl kullanacağız:
            string adi = "saban";
            int yas = 21;
            //gibi düşünelim Kurs u da :

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //Gerçek Hayatta da örn e ticaret sisteminde bootstraptaki ürün kartı olsun o da class :)


            //Önce ki yaptığımız diziler/arrayler örneğini hatırlayalım ne yapmıştık önce tek tek tanımlamıştık.
            //daha sonra bunun iyi bir fikir olmadığına karar vermiştik.Burada da o geçerli:

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + "(Olmaması gereken...)");

            //Yazmak yerine biz diyoruz ki dizi oluşturalım bu kurs1,kurs2,kurs3 ü arrayde listeleyelim.

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kursTakmaAd in kurslar)
            {
                Console.WriteLine(kursTakmaAd.KursAdi + ":" + kursTakmaAd.Egitmen + ":" + kursTakmaAd.IzlenmeOrani);

            }

        }
    }
    class Kurs
    {
        //Kurs cllassımızın 3 tane property si var :

        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
