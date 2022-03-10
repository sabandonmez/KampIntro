using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? = 30

            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] {100,200,300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar[0] = ? 999 


            //Peki neden böyle oldu halbuki pek bir fark yok gibi ??

            //Sayısal veri tipleri : int , decimal , float ,double ,bool (Değer tipleri)
            //Referans veri tipleri: array , class, interface 

            //Ramde             1)Stack                 2)Heap
            //                 Değer Tipler          Referans Tipler          
        }
    }
}