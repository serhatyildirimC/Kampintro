using System;

namespace degervereferanstipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 12;
            int sayi2 = 23;
            sayi1 = sayi2;
            sayi2 = 34;
            Console.WriteLine(sayi1);

            int[] sayilar = new int[] { 1, 2, 3, 4, };
            int[] sayilar2 = new int[] { 5, 6, 7, 8 };  
            sayilar = sayilar2;
            sayilar2[0] = 16;
            Console.WriteLine(sayilar[0]);
            Console.WriteLine("ÖNEMLİİ!!!!");
        }
    }
}
