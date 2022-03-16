using System;
namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Yol
            Product product1 = new Product();    
            
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.PruductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //2.Yol

            Product product2 = new Product {Id=2 , CategoryId=5 , UnitsInStock=5 , 
                                   PruductName="Kalem" , UnitPrice=35};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);






        }
    }
}