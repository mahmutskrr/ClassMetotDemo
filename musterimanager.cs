using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class musterimanager
    {
        public void ekle(musteri musteri)
        {
            Console.WriteLine(musteri.ad + "isimli müşteri sisteme eklendi.");
        }
        public void listele(musteri musteri)
        {
            Console.WriteLine("Müşterilerin bilgileri listelendi." + "isim:" + musteri.ad + "soyad:" + musteri.soyad + "ID No:" + musteri.Id + "yaş:" + musteri.yas);
        }
        public void silme(musteri musteri)
        {
            Console.WriteLine(musteri.ad + " İsimli müşteri sistemden silindi. ");
        }
    }
}
