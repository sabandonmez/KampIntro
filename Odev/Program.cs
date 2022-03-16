using System;
namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.CategoryId = 13;
            product1.ProductName = "Bisiklet";
            product1.ProductPrice = 4000;
            product1.UnitStock = 200;

            Product product2 = new Product();

            product2.Id = 2;
            product2.CategoryId = 15;
            product2.ProductName = "Masa";
            product2.ProductPrice = 900;
            product2.UnitStock = 400;

            //1 - Foreach

            //Product[] products = new Product[] { product1, product2 };

            //foreach (Product item in products)
            //{
            //    Console.WriteLine(item.Id + " " + item.ProductName + " " + item.ProductPrice + " " + item.UnitStock);
            //}

            //2 - For

            //Product[] products = new Product[] { product1, product2 };

            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine(products[i].Id + " " + products[i].ProductName + " " + products[i].ProductPrice + " " + products[i].UnitStock);
            //}

            //3 - While

            //Product[] products = new Product[] { product1, product2 };
            //int sayac = 0;
            //while (sayac<products.Length)
            //{
            //    Console.WriteLine(products[sayac].Id + " " + products[sayac].ProductName + " " + products[sayac].ProductPrice + " " + products[sayac].UnitStock);
            //    sayac++;
            //}


        }
    }
}