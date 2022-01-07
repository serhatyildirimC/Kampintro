using System;


 namespace ClassMetodDemo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 111;
            musteri1.Name = "Busra";
            musteri1.SurName = "Dinc";
            musteri1.Bakiye = 1950;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 112;
            musteri2.Name = "Serhat";
            musteri2.SurName = "Yildirim";
            musteri2.Bakiye = 500;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 113;
            musteri3.Name = "Ebru";
            musteri3.SurName = "Fındık";
            musteri3.Bakiye = 2000;

            Musteri[] Musteriler = new Musteri[] { musteri1 , musteri2, musteri3};

            foreach (var msteri in Musteriler)
            {
                Console.WriteLine(msteri.Name + " " + msteri.SurName);
                Console.WriteLine("Bakiye  : "+msteri.Bakiye);
                Console.WriteLine("-----------------");

            }
        }
    }

     class Musteri
     {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }

        public int Bakiye { get; set; }

     }
}
