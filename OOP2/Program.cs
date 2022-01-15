using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1  = new GercekMusteri();
            musteri1.Adi = "serhat";
            musteri1.Soyadi = "yıldırım";
            musteri1.TcNo = "1234567890";
            musteri1.MusteriNo = "123456";
            musteri1.Id = 111;

            TuzelMusteri musteri2   =   new TuzelMusteri();
            musteri2.Id = 311;
            musteri2.MusteriNo = "123457";
            musteri2.SirketAdi = "king inwest";
            musteri2.VergiNo = "0987654321";

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(musteri2);
            costumerManager.Add(musteri1);


        }
    }
}
