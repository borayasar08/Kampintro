using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();

            urun1.Adi = "Elma";
            urun1.Fiyati = 14.99;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product urun3 = new Product();

            urun3.Adi = "Çilek";
            urun3.Fiyati = 10;
            urun3.Aciklama = "Çilek gibi çilek";

            Product[] urunler = new Product[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı : " + urun.Adi);
                Console.WriteLine("Ürün Fiyatı : " + urun.Fiyati);
                Console.WriteLine("Ürün Açıklaması : " + urun.Aciklama);
                  
            }


            Console.WriteLine("------------------Metodlar----------------");

            //intance - örnek

            SepetManager sepetManager = new SepetManager();


            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //bunu yapma!
            sepetManager.Ekle2("Armut" , "Yeşil Armut" , 12 , 9);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 9);






        }
    }
}
