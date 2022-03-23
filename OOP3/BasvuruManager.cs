using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager     //Buşvuranın bilgilerinin değerlendirildiği yer.
    {
        // Methot İnjection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Eğer aşağıdaki gibi yapsaydım her kredi türü için farklı BasvuruYap classı
            //tanımlamam gerekecekti.
            //IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            //ıhtiyacKrediManager.Hesapla()


            //Bu şekilde dinamik hale getirdik.

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
