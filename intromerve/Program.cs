using System;

namespace intromerve
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";
            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (var x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
            }

           
        }
    }
}
//clean code- best practice
