using System;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("serhat");
            isimler.Add("ahmet");
            isimler.Add("seko");
            isimler.Add("umut");
            isimler.Add("büş");

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
            


        }
    }
}
