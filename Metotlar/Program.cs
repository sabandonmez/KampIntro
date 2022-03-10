using System;
namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            // Dont repeat yourself - DRY - Clean Code - Best Pratice
            // C# ve Java da her şey classlardan oluşur (istisnalar olabilir)

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elmasi";

            string[] meyveler = new string[] {"Elma"};


            //Tıpkı yukardaki örneği classa uygulayacağız.
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
           
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 };

            foreach (Urun urunDiziEleman in urunler)
            {
                Console.WriteLine(urunDiziEleman.Adi);
                Console.WriteLine(urunDiziEleman.Fiyati);
                Console.WriteLine(urunDiziEleman.Aciklama);
                Console.WriteLine("*************************");
            }

            Console.WriteLine("*********Metotlar**********");

            //Bu işlemin adı : instance - Örnek
            #region Encapsulation
            //Encapsulation: ayrı ayrı yazacağımız ve düzensiz olacak bir yapıyı düzene sokuyoruz kapsüle alıyoruz.
            SepetManager sepetManagerOperation = new SepetManager();

            sepetManagerOperation.Ekle(urun1);
            sepetManagerOperation.Ekle(urun2);
            #endregion

            //Artık bu operasyonu istediğim yerde tekrar tekra yazabilirim.Bu demek oluyor ki hammallık yapmadan sadece tek bir
            //yerden kodları istediğim yere yapıştırabiliyorum.Metotları bir dişlinin parçaları gibi düşünüyoruz.
            //Yarın bir değişiklik yapmam gerekirse kodlarda sadece tek bir yerde (Metotta) değişiklik yaparak hepsini değiştirmiş oluyorum.



            sepetManagerOperation.Ekle2("Armut","Deveci armut",12);
            sepetManagerOperation.Ekle2("Elma", "Yeşil Elma", 12);
            sepetManagerOperation.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);

            //Biz class oluşturmak yerine bu şekilde de metoda ürünleri yollayabilirdik.Neden YAPMAMALIYIZ:

            //Firma geldi bize ben stok adedini de görmek istiyorum dedi tamam dedik gittik SepetManager.cs clasına orada Ekle2 metoduna
            //stokAdedi adında parametre ekler eklemez ne oldu ?
            //Yukarıda ki 3 tane örnek hepsi kızdı.Bunları gidip şimdi tek tek değiştirmek lazım PATLADIIK.

            //Fakat biz classda ürünün propertylerini tutsaydık tıpku Urun.cs de yaptığımız gibi oraya giderdik 
            // public int stokAdedi { get; set; } derdik tüm herşey bir kerede hallolurdu:)




    }

    }
}