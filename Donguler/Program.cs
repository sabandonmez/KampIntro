
using System;
namespace Donguler
{
    class Hello
    {
        static void Main(string[] args)
        {
            #region Döngüler

            //Döngüler: Döngüleri Birbirine benzeyen işleri tekrar etmek için kullanırız.

            for (int i = 1; i < 10; i++) //i+=2 olarak ta yazılabiliyor.
{
    Console.WriteLine(i);

}
#endregion

            #region Array-Dizler
string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya Başlamak İçin Temel Kurs";
string kurs3 = "Java";

//İşte Biz bunun gibi değişkenleri arraylerde listeliyoruz.Eğer listelemessek nasıl gezeceğiz?
//Peki bir dizi nazıl tanımlanıyor?

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlamak İçin Temel Kurs", "Java" };

/* Şimdi geldik işin en güzel kısmına eğer biz bu verileri bir dizide tanımlamamış olsaydık tek tek ekrana yazdırmak için 
 * şunu yapacaktık:
 *          Console.WriteLine(kurs1);
 *          Console.WriteLine(kurs2);
 *          Console.WriteLine(kurs3);
 *          
 * Ama biz Bunu dizide listelediğimiz için aşağıdaki gibi yapacağız:
*/

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("For Bitti");

//Artık Bu döngüde arraye ne kadar eleman eklemek istersek ekleyelim döngümüz kusursuz çalışacak
//Ben bu işlemi dizilerle yapmasaydım sürekli yeni eleman/veri eklemek istediğimde tek tek Console.WriteLine ile 
//bu yeni veriyi ekrana yazdıracak kodu yazmam gerekecekti.

//Bir başka döngü yapımızda foreach döngüsüdür
//Foreach Döngüsü: Dizi temelli yapıları tek tek dönmeye yarıyor.


foreach (string kurs in kurslar) //kurslar'ı dolaş demek.
{
    Console.WriteLine(kurs);
}
Console.WriteLine("Foreach Bitti.");

            //For döngüsü biraz daha genel amaçlar için kullanılır.

            #endregion
        }
    }
}





















