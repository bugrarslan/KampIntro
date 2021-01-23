using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, new DatabaseLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { };

            krediler.Add(konutKrediManager);
            krediler.Add(tasitKrediManager);
            krediler.Add(ihtiyacKrediManager);
            krediler.Add(esnafKrediManager);

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
