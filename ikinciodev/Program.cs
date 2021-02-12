using System;

namespace ikinciodev
{
    class Program
    {
        static void Main(string[] args)
        {
            urun urun1 = new urun();
            urun1.urunAdi = "bilgisayar";
            urun1.markasi = "casper";
            urun1.renk = "siyah";

            urun urun2 = new urun();
            urun2.urunAdi = "tablet";
            urun2.markasi = "lenova";
            urun2.renk = "gri";

            urun urun3 = new urun();
            urun3.urunAdi = "telefon";
            urun3.markasi = "apple";
            urun3.renk = "beyaz";

            urun[] urunler = new urun[] {urun1,urun2,urun3};

            int j = 0;
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürünün Adı : "+ urunler[i].urunAdi + " Markası :" + urunler[i].markasi + " Rengi : "+ urunler[i].renk);

            }
            Console.WriteLine("FOR BİTTİ.");

            foreach (var urun in urunler) 
            {
                Console.WriteLine("Ürünün Adı : "+ urun.urunAdi + " Markası: " + urun.markasi + " Rengi: "+ urun.renk);
            }
            Console.WriteLine("FOREACH BİTTİ.");
            
            while (j<urunler.Length) 
            {
                Console.WriteLine("Ürünün Adı: "+ urunler[j].urunAdi + " Markası: " + urunler[j].markasi + " Rengi: "+ urunler[j].renk);
                j++;
            }
            Console.WriteLine("WHİLE BİTTİ.");
        }
    }

    class urun
    {

        public string urunAdi { get; set; }
        public string markasi { get; set; }
        public string renk { get; set; }
    }
  
}
