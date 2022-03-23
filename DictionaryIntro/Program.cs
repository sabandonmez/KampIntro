using System;
using System.Collections.Generic;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary bizim belirlediğimiz bir key'e göre value saklamamızı sağlayan yapıdır.

            Dictionary<int, string> adYasDictionary = new Dictionary<int, string>();
            //Ekleme
            adYasDictionary.Add(132030018, "Şaban");
            adYasDictionary.Add(132030010, "Mehmet");
            adYasDictionary.Add(132030017, "Ayşe");
            adYasDictionary.Add(132030019, "Hüseyin");
            adYasDictionary.Add(102030076, "Halime");

            foreach (var item in adYasDictionary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            //Silme
            adYasDictionary.Remove(132030018);

            foreach (var item in adYasDictionary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            //Sayma
            Console.WriteLine(adYasDictionary.Count);

            Console.WriteLine("\n\n");

            //Kendi Dictionary mizi yapalım.


            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(18, "Emirhan");
            myDictionary.Add(21, "Oğuzhan");
            myDictionary.Add(24, "Ulaş");
            myDictionary.Add(16, "Ebrar");

           






        }


        }
}