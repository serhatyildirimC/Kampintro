using System;

namespace Kampintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategorietiketi = "Kategori";
            int x = 32000;
            double y = 1.54;
            bool giris = false;
            double dd = 7.35;
            double db = 7.54;
            if (dd < db) 
            {
                Console.WriteLine("ok yukarı");     
            }
            else if (dd > db) 
            {
                Console.WriteLine("ok aşşağı");
            }
            else
            {
                Console.WriteLine("çizik");

            }
            if (giris==true)
            {
                Console.WriteLine("ayarlar butonu");

            }
            else if (giris == false)
            {
                Console.WriteLine("giriş yap butonu");

            }


            Console.WriteLine(kategorietiketi);
        }
    }
}
