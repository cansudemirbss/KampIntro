using System;

namespace MyOwnWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            ders ders1 = new ders();
            ders1.dersAdi = "Matematik";
            ders1.dersKodu = 100;
            ders1.egitmen = "Ender Yakup Polat";

            ders ders2 = new ders();
            ders2.dersAdi = "Edebiyat";
            ders2.dersKodu = 101;
            ders2.egitmen = "Ümitcan Koça";

            ders ders3 = new ders();
            ders3.dersAdi = "Geometri";
            ders3.dersKodu = 102;
            ders3.egitmen = "Cansu Demirbaş";

            ders[] dersler = new ders[] { ders1, ders2, ders3 };
            int j = 0;
            for (int i = 0; i < dersler.Length; i++)
            {
                Console.WriteLine(dersler[i].dersAdi +" "+ dersler[i].dersKodu +" "+ dersler[i].egitmen);
            }
            foreach (var ders in dersler)
            {
                Console.WriteLine(ders.dersAdi +" " + ders.dersKodu +" "+ ders.egitmen);
            }
            while (j<dersler.Length)
            {
                Console.WriteLine(dersler[j].dersAdi + " " + dersler[j].dersKodu + " " + dersler[j].egitmen);
                    j++;
            }
           
            


        }
    }


    class ders
    {
        public string dersAdi { get; set; }
        public int dersKodu { get; set; }
        public string egitmen { get; set; }


    }
}
