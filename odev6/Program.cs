using System;

namespace odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun Urun1 = new Urun();
            Urun1.UrunAdi = "6344 Beyaz 4 Programlı Bulaşık Makinesi";
            Urun1.UrunFiyati = 2692;
            Urun1.UrunOzelİndirim = 42;
            Urun1.UrunSonFiyatı = 2650;


            Urun Urun2 = new Urun();
            Urun2.UrunAdi = "6133 Beyaz 3 Programlı Bulaşık Makinesi";
            Urun2.UrunFiyati = 2565;
            Urun2.UrunOzelİndirim = 140;
            Urun2.UrunSonFiyatı = 2425;

            Urun Urun3 = new Urun();
            Urun3.UrunAdi = "6133 S Gümüş 3 Programlı Bulaşık Makinesi";
            Urun3.UrunFiyati = 2584;
            Urun3.UrunOzelİndirim = 84;
            Urun3.UrunSonFiyatı = 2500;

            Urun Urun4 = new Urun();
            Urun4.UrunAdi = "6344 I Inoks 4 Programlı Bulaşık Makinesi";
            Urun4.UrunFiyati = 3157;
            Urun4.UrunOzelİndirim = 57;
            Urun4.UrunSonFiyatı = 3100;


            Urun[] Urunler = new Urun[] { Urun1, Urun2, Urun3, Urun4 };

            foreach (var Urun in Urunler)
            {
                Console.WriteLine (Urun.UrunAdi + " " + Urun.UrunFiyati + " TL Yerine " + Urun.UrunOzelİndirim + " TL İndirimle!!! " + Urun.UrunSonFiyatı+ " TL ");

            }
        }

            class Urun
        {
            public string UrunAdi { get; set; }
            public int UrunFiyati { get; set; }
            public int UrunOzelİndirim { get; set; }
            public int UrunSonFiyatı { get; set; }

        }

    }

}