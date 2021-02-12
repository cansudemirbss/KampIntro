using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";
            
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------");
            }
            //encapsulation

            Console.WriteLine("----------METHOTLAT----------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12);
            sepetManager.Ekle2("elma", "yeşil elma", 10);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 56);
        }
    }
}
// tekrar tekrar kullanılabilirliği sağlar.
//e-ticaret sisteminde sepete ekle butonu gibi. Her yerde karşımıza çıkar.