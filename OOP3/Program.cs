using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService datebaseLoggerService = new DetabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), fileLogerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };// Hangi krediye ihtiyac duyuluyorsa o kredilere göre basvuru yapılabilir.
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
