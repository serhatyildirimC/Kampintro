using System;
using System.Collections.Generic;
using System.Text;

namespace metodlar
{
    internal class sepetManeger
    {
        public void Ekle(product product)
        {
            Console.WriteLine("sepete eklendi : "+ product.Aciklamasi );


        }
        public void Ekle2(string Adi, string acıklama, int fiyat , int StokAdedi)
        {
            Console.WriteLine("sepete eklendi : " + Adi +"  "+ acıklama );

        }
    }
}
