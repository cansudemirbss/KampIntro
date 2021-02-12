using System;

namespace ornekCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
           // TERNANY OPERATÖRÜ KULLANIMI
           //IF ELSE YERİNE GEÇER..
            int a = 25, b = 35;
            var sonuc = a < b ? "A B'den büyüktür." : "A B'den küçüktür.";
            Console.WriteLine(sonuc);
        }
    }
}
