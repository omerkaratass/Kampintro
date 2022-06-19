using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // İnterface'lerde referans numarası tutabilir. interface onu implemente eden class'ın referansını tutabilir.
            IKrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediBaseManager tasitKrediManager = new TasitKrediManager();
            IKrediBaseManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService filerLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ihtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
