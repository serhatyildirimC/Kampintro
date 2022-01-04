using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // string kurs1 = "porg";
            //string kurs2 = "temel";
            //string kurs3 = "jaza";
            string [] kurslar = { "prog", "temel", "jaza", "kava", "jaba", "kaba" };

            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine   (kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine (kurs);
            }
            Console.WriteLine ("sayfa sonu");
        }
    }
}
