using System;

namespace ifelseornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            kozmetik esya = new kozmetik();
            esya.makyaj = "Göz Makyajı , Ten Makyajı , Dudak Makyajı , Fondöten , Oje&Aseton , Makyaj Seti " + " dir." ;
            esya.parfum = " Deodorant , Roll-on , Vücut Spreyi , Parfüm Setleri" + " dir.";
            esya.ciltBakim = " Nemlendirme , Maske&Peeling , Göz Bakımı , Güneş Serumu , Yaşlanma Karşıtı " + " dir." ;
            esya.sacBakim = "Saç Şekillendirici , Şampuan , Saç Serumu&Maskesi , Saç Boyası, Saç Spreyi ";
            

            kozmetik[] esyalar = new kozmetik[] { esya };
            //esyalar belirlediğimiz dizi değişkeni adıdır.
            foreach (var kozmetik in esyalar)
            {
                Console.WriteLine("Değerli Müşterimiz " 
                    + "\nMakyaj Kategorisinde ki ürünlerimiz : " + kozmetik.makyaj
                    
                    + "\nParfüm kategorisinde ki ürünlerimiz :" + kozmetik.parfum 
                    + "\nCilt Bakımı Kategorisinde ki ürünlerimiz :" + kozmetik.ciltBakim 
                    + "\nSaç Bakımı Kategorisinde ki ürünlerimiz : " + kozmetik.sacBakim + " dir." + "\nKeyifli Alışveriler Dileriz.");
            }
            Console.WriteLine("BİTTİ");

            for (int i = 0; i < esyalar.Length; i++)
            {
                Console.WriteLine("Değerli Müşterimiz "
                    + "\nMakyaj Kategorisinde ki ürünlerimiz : " + esyalar[i].makyaj

                    + "\nParfüm kategorisinde ki ürünlerimiz :" + esyalar[i].parfum
                    + "\nCilt Bakımı Kategorisinde ki ürünlerimiz :" + esyalar[i].ciltBakim
                    + "\nSaç Bakımı Kategorisinde ki ürünlerimiz : " + esyalar[i].sacBakim);
            }
            Console.WriteLine("BİTTİİ.."); 

            int j = 0;
            while (j<esyalar.Length)
            {
                Console.WriteLine("Değerli Müşterimiz "
                    + "\nMakyaj Kategorisinde ki ürünlerimiz : " + esyalar[j].makyaj

                    + "\nParfüm kategorisinde ki ürünlerimiz :" + esyalar[j].parfum
                    + "\nCilt Bakımı Kategorisinde ki ürünlerimiz :" + esyalar[j].ciltBakim
                    + "\nSaç Bakımı Kategorisinde ki ürünlerimiz : " + esyalar[j].sacBakim);
                j++;
            }
        }

    }
    class kozmetik
    {
        public string makyaj { get; set; }
        public string parfum { get; set; }
        public string ciltBakim { get; set; }
        public string sacBakim { get; set; }

    }
}
