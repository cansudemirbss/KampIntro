using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // do not repeat yourself - kendini tekrar etme
            string kategoriEtiketi = "Kategori :";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45; // ondalıklı sayılar
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi.");
            }
            
                   




            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi); // değer tutucu

            

        }
    }
}
