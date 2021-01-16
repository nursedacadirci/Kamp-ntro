using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not yourself - Kendini tekrarlama
            //değer tutucu, alias
            //List<product> products;
            //<button>Kullanıcı ayarları</button>

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            //if (sistemeGirisYapmisMi ==true)
            //{
                //Console.WriteLine("Kullanıcı ayarları butonu");       
            //}



            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butınu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        
        }
    }
}
