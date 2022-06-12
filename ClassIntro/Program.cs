using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string adi = "Engin";
            //int yas = 36;

            // Kurs değişkenini tanımladığım yer. kurs1 adında bir değişken oluşturdum Tipi 'Kurs' yani Kurs class'ının
            //İçerisinde kaç tane property özellik veya değer varsa artık bu kurs1'e eşitlendi.

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java"; 
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            // İçerisinde Kurs nesnesini barındıran bir Array tanımladık.
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            };

             //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen); 
             
           
            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }





    /*
    Class Mantığı genel hatlarıyla.. Örneğin 1000 tane müşterimiz var gidip bunu tek tek string musteri = "omer";  string musteri1 = "murat"; şeklinde tutamam
    Class Mantığı ile sadece isim bilgisini tutmayı bırak bir müşterinin adı,soyadı,yaşı,doğum tarihi vb'i özelliklerini tutabilirim.
    Nasıl tutarım? Bir class oluştururum bu class'a tek tek property dediğimiz farklı veri tiplerinde değişkenler atayabilirim.
    Örneğin müsterininadi,müsterinin soyadi,yasi gibi.. Bu propertyleri tanımladıktan sonra yeni bir class oluşturmak için class tanımımı yaparım.
    
        Musteriler musteriler = new Musteriler(); --> Burada Musteriler class'ımız musteriler ise artık Musteriler class'ın daki veri tiplerine ulaşabilir.
    Aynı Zamanda musteriler'in tipi artık Musteriler class'ı oldu. Bu class mantığı ile neler yapabilirim?

    Öncelikle Class'ımızı oluşturalım.

        class Musteriler
    {
        public string MusteriAdi { get; set; }

        public string MusteriSoyadi { get; set; }

        public int Yasi { get; set; }

        public Date DogumYeri { get; set; }
    }

    --> musteriler adında bir değişken oluşturalım ki Musteriler class'ından özellikleri alıp yeni değerlerimizi yazdıralım.

    --> Musteriler musteriler = new  Musteriler(); --> Bu kısımdan sonra artık musteriler değişkenimiz ile istediğimiz kadar müşteri oluşturabiliriz.
    
    Örnek:

     Musteriler musteriler = new Musteriler();

    musteriler.MusteriAdi = "Omer";
    musteriler.MusteriSoyadi = "Karatas";
    musteriler.Yasi = 23;
    musteriler.DogumYeri = "Istanbul";

     Musteriler musteriler2 = new Musteriler();

    musteriler2.MusteriAdi = "Samet";
    musteriler2.MusteriSoyadi = "Karatas";
    musteriler2.Yasi = 28;
    musteriler2.DogumYeri = "Tosya";

    bu şekilde n tane müşteri tanımlayabilirim.

    */









}
