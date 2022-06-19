using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediBaseManager krediManager,ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediBaseManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
