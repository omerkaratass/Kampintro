using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2};

            // type-safe -- tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("-----------Metotlar----------");
            
            // instance - class örneği oluşturmak.
            //encapsulation
            //
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            // Aşağıdaki kod satırı hatalı kullanım bir parametetre daha 
            //sepetmanager değişkenine eklediği anda aşağıdaki kod bloğu bütün ekranlarında patlar
            // O yüzden methoda parametre olarak class tipi göndermek daha kullanışlı olur.
            sepetManager.Ekle2("Armut","Yeşil armut",12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12 ,9);
            sepetManager.Ekle2("Armut", "Diyarbakır karpuzu", 12 ,9);

        }
    }
}
