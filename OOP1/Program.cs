using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();//101
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = " MASA";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, UnitPrice = 35 };


            //PascalCase  //camelCase
            //case sensitive- Küçük büyük harf duyarlılığı
            //string türünde isim /class değişken ismi
            ProductManager productManager = new ProductManager(); 
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);//masa

            //productManager.Topla2(3, 6);

            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);


            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi);// cevap 100


            //int,double,bool... değer tip
            //diziler,class,abstrat class,inferface... referans tip
            //ref out

        }
    }
}
