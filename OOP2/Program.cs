using System;
namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gercek Müşteri
            GercekMusteri musteri1 =new GercekMusteri();
            musteri1.Id = 12;
            musteri1.Adi = "Şaban";
            musteri1.Soyadi = "Dönmez";
            musteri1.MusteriNo = "1213";
            musteri1.TcNo = "2131241431234";

            //Tüzel Müşteri 
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 13;
            musteri2.MusteriNo = "13123";
            musteri2.VergiNo = "314124";
            musteri2.SirketAdi = "ABCD";

            //Musteri classı hem GercekMusteri hem TuzelMusteri nin ref no sunu tutabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


        }
    }
}