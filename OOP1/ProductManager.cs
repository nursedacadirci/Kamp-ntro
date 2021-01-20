using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //(Product türünde ürün ver)
        public void Add(Product product) 
        {
            //product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName +" Eklendi. ");                
        }

        // void: git yap (metodları git ekle, git sil, git güncelle...)
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " Güncellendi");       
    
        }

        // int: 
        public int Topla(int sayi1, int sayi2) 
        {
            return sayi1 + sayi2; 
        
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+ sayi2); //sayi1 ile sayi2 yi topla ekrana yaz
        }

        //public void BiseyYap(int sayi) 
        //{
        //    sayi = 99;             

        //}

    }
}
