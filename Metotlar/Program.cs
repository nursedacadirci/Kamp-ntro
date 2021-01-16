using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

           

            string[] meyveler = new string[] { };

            Urun Urun1 = new Urun();
            Urun1.Adi = "Elma";
            Urun1.Fiyati = 15;
            Urun1.Aciklama = "Amasya Elması";

            Urun Urun2 = new Urun();
            Urun2.Adi = "Karpuz";
            Urun2.Fiyati = 80;
            Urun2.Aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[] {Urun1,Urun2 };


            //type safe-- tip güvenli
            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");

            }

            Console.WriteLine("----------Metotlar-----------------");

            //instance - örnek
            //encapsulation - Kansülleme/ayrı ayrı yazmak yerine, kısa yöntemden yazmak.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Urun1);
            sepetManager.Ekle(Urun2);


            Console.WriteLine("--------------------------");


            sepetManager.Ekle2("Armut","Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma","Yeşil elma", 12,9);
            sepetManager.Ekle2("Karpuz","Diyarbakır karpuzu", 12,8);



        }
    }

}

///Do not repeat yourself- DRY (Kendini Tekrar Etme
///Clean Code (Temiz Kod)
///Best Practice (Doğru Uygulama Teknikleri)
