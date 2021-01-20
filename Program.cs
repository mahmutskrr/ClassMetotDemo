using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri musteri1 = new musteri();
            musteri1.ad = "Ahmet Baki";
            musteri1.soyad = "taşkıran";
            musteri1.Id = 8546953;
            musteri1.yas = 42;

            musteri musteri2 = new musteri();
            musteri2.ad = "mahmut";
            musteri2.soyad;= "şeker";
            musteri2.Id = 1534856;
            musteri2.yas = 21;

            musteri musteri3 = new musteri();
            musteri3.ad = "Ali";
            musteri3.soyad = "Akarsu";
            musteri3.Id = 4659953;
            musteri3.yas = 18;

            Console.WriteLine("Müşteri adı:" + musteri1.ad);
            Console.WriteLine("Müşteri soyad: " + musteri1.soyad);
            Console.WriteLine("Müşteri ID: " + musteri1.Id);
            Console.WriteLine("Müşteri yaş: " + musteri1.yas);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Müşteri adı: " + musteri2.ad);
            Console.WriteLine("Müşteri soyad: " + musteri2.soyad);
            Console.WriteLine("Müşteri ID: " + musteri2.Id);
            Console.WriteLine("Müşteri yaş: " + musteri2.yas);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Müşteri adı: " + musteri3.ad);
            Console.WriteLine("Müşteri soyad: " + musteri3.soyad);
            Console.WriteLine("Müşteri ID: " + musteri3.Id);
            Console.WriteLine("Müşteri yaş: " + musteri3.yas);
            Console.WriteLine("-------------------------------------------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);
        }
    }
}
