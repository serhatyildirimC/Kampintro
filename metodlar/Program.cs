using System;

namespace metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product urun1 = new product();
            urun1.Aciklamasi = "amasya elması";
            urun1.Id = 12;
            urun1.Fiyati = 50;
            urun1.Adi = "elma";
            urun1.StokAdedi = 56;

            product urun2 = new product();
            urun2.Id = 13;
            urun2.Fiyati = 100;
            urun2.Adi = "karpuz";
            urun2.Aciklamasi = "diyarbakır karpuzu";
            urun2.StokAdedi = 25;

                product[] products = new product[] {urun1, urun2};

            foreach (product x in products)
            {
                Console.WriteLine(x.Id);
                Console.WriteLine(x.Fiyati); 
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Aciklamasi);
                Console.WriteLine(x.StokAdedi);
                Console.WriteLine("---------------");
            }
            sepetManeger sepetManeger = new sepetManeger();
            sepetManeger.Ekle(urun2);
            sepetManeger.Ekle(urun1);

            sepetManeger.Ekle2("elma", "yeşil elma" , 12 , 25);
            sepetManeger.Ekle2("armut" , "ballı armut", 15,65);
            sepetManeger.Ekle2("mahmut" , "kel mahmut", 34,12);

            Console.WriteLine("bitti!");
        }
    }
}
