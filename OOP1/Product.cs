using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product //Ürün
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public double UnitPrice { get; set; } // Fiyatı
        public int UnitInStock { get; set; } //adet


        //CRUD 
    }
}
