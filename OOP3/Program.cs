using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            

            ICrediManager konutKrediManager = new KonutKrediManager();

            ICrediManager esnafKrediManager = new EsnafKrediManager();
           

            ICrediManager tasıtKrediManager = new TasıtKrediManager();
            ILoggerServis dataBaseLoggerServis = new DataBaseLoggerServis();
            ILoggerServis fileLoggerServis = new FileLoggerServis();
            ILoggerServis smsLoggerServis =  new SmsLoggerServis();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,smsLoggerServis);

            List<ICrediManager> krediler = new List<ICrediManager>() {ihtiyacKrediManager,};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
           

        }
    }
}
