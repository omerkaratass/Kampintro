using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Gerçek Müşteri - Tüzel Müşteri.
            //Engin Demiroğ Gerçek Müşteri.
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            //Kodlama.io Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "52232";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567892";
            //SOLID

            //Musteri Class'ı hem GercekMusteri'nin referansını tutabiliyor hemde Tuzel Musterinin referansını tutabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            

            

        }
    }
}
