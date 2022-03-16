using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager // Manager de : Ürünle ilgili opersayonları içerir.
    {
        //Ürünle iligili operasyonlar: CRUD

        //Encaptulation
        public void Add(Product product)
        {
            Console.WriteLine(product.PruductName + " eklendi. " );
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.PruductName + " güncellendi. ");
        }

    }
}
