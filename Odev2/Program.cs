using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programlama Geliştirici Kampı");
            Console.WriteLine("Hepsiburada");

            Urun urun1 = new Urun();
            urun1.UrunListesi = "Laptop";
            urun1.UrunFiyati = 200;
            urun1.Satici = "Mücahit ";

            Urun urun2 = new Urun();
            urun2.UrunListesi = "Kulaklık";
            urun2.UrunFiyati = 20;
            urun2.Satici = "Enes ";

            Urun urun3 = new Urun();
            urun3.UrunListesi = "Masa";
            urun3.UrunFiyati = 200;
            urun3.Satici = "Rahman ";


            Urun urun4 = new Urun();
            urun4.UrunListesi = "Telefon";
            urun4.UrunFiyati = 2000 ;
            urun4.Satici = "Eren ";
            



         Urun[] urunler = new Urun[] {urun1,urun2,urun3,urun4 };

            Console.WriteLine("FOR DÖNGÜSÜ");
            for (int i = 0; i <urunler.Length; i++)
            {
                Console.WriteLine("Ürünler= "+urunler[i].UrunListesi+ " : " + urunler[i].UrunFiyati+" tl "+" Satici: " + urunler[i].Satici);
            }

            Console.WriteLine("------------------------------------");

            Console.WriteLine("WHİLE DÖNGÜSÜ");

            int a = 0;
            while (a < urunler.Length) 
            {
                Console.WriteLine("Ürünler= " + urunler[a].UrunListesi + " : " + urunler[a].UrunFiyati + " tl " + " Satici: " + urunler[a].Satici);
                a++;
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("FOREACH DÖNGÜSÜ");
            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürünler ="+urun.UrunListesi + " : " + urun.UrunFiyati+ " tl "+" Satıcı: "+urun.Satici);
            }


        }
        class Urun
        {
            public string UrunListesi { get; set; }
            public int UrunFiyati { get; set; }

            public string Satici { get; set; }

        }
    }
}
