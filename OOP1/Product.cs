using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //prop gibi yazdıktan sonra 2 kere tab yaptığımız syntaxlere snippet (parça-kesit) denir.

    class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        //Kodun okunurluluğu için bu sırayla yazarız.
        public string PruductName { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

       //CRUD - Creat / Read / Update / Delete

    }
}
