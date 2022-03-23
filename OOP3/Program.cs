using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfacelerde o classı implement eden claslların ref num. tutabiliyor.

            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
                        //IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
                        //KonutKrediManager konutKrediManager = new KonutKrediManager()
            IKrediManager tasitKrediManager = new TasitKrediManager();
                        //TasitKrediManager tasitKrediManager = new TasitKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtiyacKrediManager,new List<ILoggerService> { new DatabaseLoggerService(),new FileLoggerService()}); // List olarak çoklu log yolladığımızda
            //basvuruManager.BasvuruYap(tasitKrediManager,new FileLoggerService());  Sadece 1 tane log servisi parametre olarak yolladığımızda
            //basvuruManager.BasvuruYap(konutKrediManager); Log servisi olmadan 

            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager , tasitKrediManager }; 

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}