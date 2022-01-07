using System;

namespace classIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.kursAdi = "c++";
            kurs1.degisken = 18;
            kurs1.egitmen = "serhat yıldırım";
            kurs kurs2 = new kurs();
            kurs2.kursAdi = "java";
            kurs2.degisken = 12;
            kurs2.egitmen = "serhat yıldırım";
            kurs kurs3 = new kurs();
            kurs3.kursAdi = "phyton";
            kurs3.degisken = 34;
            kurs3.egitmen = "serhat yıldırım";
            kurs kurs4 = new kurs();
            kurs4.kursAdi = "react";
            kurs4.degisken = 66;
            kurs4.egitmen = "serhat yıldırım";
            kurs kurs5 = new kurs();
            kurs5.kursAdi = "c#";
            kurs5.degisken = 92;
            kurs5.egitmen = "serhat yıldırım";

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3, kurs4, kurs5 };

            foreach (var kurs in kurslar)
                Console.WriteLine(kurs.kursAdi+" "+kurs.degisken +" Tl");

            Console.WriteLine("oldu ");
        }

    }
    class kurs 
    {
        public string kursAdi { get; set; }
        public int degisken { get; set; }
        public string  egitmen { get; set; }
    }
}
