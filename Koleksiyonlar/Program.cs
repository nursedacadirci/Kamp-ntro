using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            //isimler = new string[5]; //!! dikkat //isimlerin adresi yeni bir adres
            //isimler[4] = "ilker"; //{ , , , , ,ilker}
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]); //boş bi değer veriri çünkü sen yeni bir new tanımladın


            //ya da //isimler2.Add("Engin");
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]); // engin yazar Not: 



        }
    }
}
