using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.TC = 11111111111 ;
            m1.İsim = "Seda";
            m1.Soyisim = "ÇADIRCI";
            
            Musteri m2 = new Musteri();
            m2.TC = 22222222222 ;
            m2.İsim = "NUR";
            m2.Soyisim = "TEPE";

            Musteri m3 = new Musteri();
            m3.TC = 33333333333;
            m3.İsim = "Bahar";
            m3.Soyisim = "YILMAZ";
            
            Musteri m4 = new Musteri();
            m4.TC = 44444444444;
            m4.İsim = "Esma";
            m4.Soyisim = "AKTAŞ";
            
            Musteri m5 = new Musteri();
            m5.TC = 55555555555;
            m5.İsim = "RANA";
            m5.Soyisim = "GÜZEL";
            
            Console.WriteLine("\n---------------------------------LİSTELENENLER---------------------------------");
            Musteri[] musteriler = new Musteri[] { m1, m2, m3, m4, m5 };

            foreach (var Musteri in musteriler)
            {
                Console.WriteLine(Musteri.TC + " " + Musteri.İsim + " " + Musteri.Soyisim);
            }


            Console.WriteLine("\n\n---------------------------------EKLENENLER---------------------------------");
            MusteriManager musteri = new MusteriManager();
            musteri.Ekle(m1);
            musteri.Ekle(m2);
            musteri.Ekle(m3);
            musteri.Ekle(m4);
            musteri.Ekle(m5);


            Console.WriteLine("\n\n---------------------------------SİLİNENLER---------------------------------");
            musteri.Sil(m5);



        }
    }
}
