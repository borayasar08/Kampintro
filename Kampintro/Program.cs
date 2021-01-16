using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string kategoriEditörü = "Kategori";
            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonunu göster");
            }

            else 
            {
                Console.WriteLine("Değişmedi butonunu göster");
            }
            
            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            

            Console.WriteLine(kategoriEditörü);


        }
    }
}
