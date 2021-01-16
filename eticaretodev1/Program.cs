using System;

namespace eticaretodev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();

            urun1.urunAdi = "Xiaomi Redmi Note 9";

            urun1.urunAdet = 4;

            urun1.urunFiyat = 2699.9;

            urun1.urunAciklama = "Xiaomi Redmi Note 9 128 gb 4gb Ram";


            Product urun2 = new Product();

            urun2.urunAdi = "Huawei Y9 Prime 2019";

            urun2.urunAdet = 3;

            urun2.urunFiyat = 3099.9;

            urun2.urunAciklama = "Huawei Y9 Prime 2019 Pop-up Kamera 128gb 4gb Ram";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (var urun in urunler)

                Console.WriteLine("Ürün Adı: " + urun.urunAdi + "/" + urun.urunFiyat + " TL " + urun.urunAdet + " Adet Ürün Açıklaması: " + urun.urunAciklama);

            {

            }



        }
    }
    
    class Product
    {
        public string urunAdi { get; set; }

        public int urunAdet { get; set; }

        public double urunFiyat { get; set; }

        public string urunAciklama { get; set; }
    }
       
}
