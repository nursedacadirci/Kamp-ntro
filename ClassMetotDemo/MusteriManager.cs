using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.TC + " " + "TC KİMLİK NUMARALI" + " "+ musteri.İsim + " " + musteri.Soyisim + " " + "eklenmiştir.");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Listelendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.TC + " " + "TC KİMLİK NUMARALI" + " "+ musteri.İsim + " " + musteri.Soyisim + " " + "müşteri silinmiştir.");
        }
    }
}


   