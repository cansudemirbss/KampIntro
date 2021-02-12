using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya Başlangıç için temel kurs";
            string kurs3 = "Java";

            // yukarıda ki gibi olsaydı tek tek yazmak zorunda kalırdık.
            //console.writeline(kurs1) vs gibi bu uğraşılmaz o yüzden array dizi şeklinde yapılır
            
            // array - dizi
            // çoklu olanları diziler şeklinde tutarız.
           
            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı",
                "Programlamaya Başlangıç için temel kurs"
            ,"Java","Python","c++","c#"};

            //  i =0; i<3 şeklinde yazmak dinamik olmaaz. Dizinin kaç karakter olacağını tek tek sayamayız.
            // o yüzden kuslar.lenght şeklinde dinamik hale getiririz.
           
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti"); 


            //dizileri tek tek dolaşmaya yarar.Daha kolay dolaşır. Foreach dizilere uygulanır.
            
            foreach (string kurs in kurslar)  //burada olan kurs ALİAS'TIR. istersen abc yaz. takma isimdir.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
