using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(ICrediManager crediManager,ILoggerServis loggerServis)
        {
            crediManager.Hesapla();
            loggerServis.Log();

        }
        public void KrediOnBilgilendirmesiYap (List<ICrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
