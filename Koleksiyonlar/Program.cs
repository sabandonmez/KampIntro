using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Ahmet","Mehmet","Ayşe","Taylan" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            //Console.WriteLine(isimler[4]); yazarsak program patlar.
            //arrayler genelde belirlediğimiz sınırların dışına çıkmaz.

            isimler = new string[5]; //new demek yeni bir adres demek.
            isimler[4] = "Halil";
            Console.WriteLine(isimler[4]); // Çıktı: Halil
            Console.WriteLine(isimler[2]); // Çıktı : (Boşluk)

            //Genellikle gerçek hayatta array kullanılmaz (java da öyle) onun yerine 
            //koleksiyonları kullanıyoruz.

            
            List<string> isimler2 = new List<string>() { "AhmetList", "MehmetList", "AyşeList", "TaylanList" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
        
            //Kısacası koleksiyonlarda arrayler gibi değerleri kaybetmemizi engelleyecek bir altyapı var.
            

                 

        }
    }
}