using System;

namespace Metodlar_d3
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 50;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("................"); ;
            }

            Console.WriteLine("--------Metotlar-----------");

            SepetManager sm = new SepetManager();
            sm.Ekle(urun1);
            sm.Ekle(urun2);
            //instance - örnek
            //encapsulation
            sm.Ekle2("armut", "yeşil armut", 12, 4994);
            sm.Ekle2("elma", "yeşil elma", 16, 4321);
            sm.Ekle2("karpuz", "Diyarbakır karpuzu", 53, 6543);
        }
    }
}





//Do not repeat yourself - Clean Code - Best Practice
