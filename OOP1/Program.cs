using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Product product1 = new Product();
            product1.Id = 111;
            product1.CategoryId = 11;
            product1.ProductName = "masa";
            product1.UnitPrice = 999;
            product1.UnitsInStock = 16;
           Product product2 = new Product() { UnitsInStock =11,Id =112,CategoryId = 12 ,    ProductName="kalem",UnitPrice=25};

           ProductManeger productManeger = new ProductManeger();
            productManeger.Add(product1);
            productManeger.Update(product2);

        }
    }
}
