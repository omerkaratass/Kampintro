using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            //Arrays(Diziler)

            // kurslar değişkeni burada bir Dizidir yani Arraydir. Burada dizi tanımlama işlemi yaptık
            // kurslar array'imizde istediğimiz kadar string ifadeyi tek bir değişkende tutabilirim.
            // Bana 'kurslar adında bir yeni array döndür ki içine değişkenleri ben yazıbileyim.'
            // Aşağıda ki string ifadeleri tek tek tanımlamak yerine bir liste ifadesinde tuttum.
            // 
            string[] kurslar = new string[] 
            { 
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java",
                "Python",
                "C#"
            };

            // Burada for döngüsü ile i başlangıç değeri 0 olarak başlar ve 0,1,2 3 dahil değil içerisindeki
            // değerleri dönmeye başlar. biz ekrana yazdırmak için kurslar[i] ile kurslar array'ini
            // i elemanınca ekrana yazdır deriz böylelikle array'imizi for döngüsü içerisinde kullanarak
            // tek bir değişkende ekrana 3 tane string değer yazdırmış oluruz.
            // Burada kurslar arrayimizi dinamik hale getirmek kursların sayısı kadar anlamına gelen
            // i<kurslar.Length ile kurslar array'inin içerisinde ne kadar string değer varsa bize hepsini döndürür.

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti.");

            //Dizi Temelli Yapıları Tek Tek Dönmeye yarar.
            // Yapının tamamı kursları dolaş anlamına geliyor.
            // Burada kurslar array'i kurs değişkenine atanmış oluyor. ve kurslar tek tek değerleri dönüp ekrana yazdırıyor.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");
       
            // int i başlangıç değeri demektir yani i = 1 olduğu için 1'den başla demek istiyor.
            // i < 10 = Şartımız demektir Şart kısmı önemlidir burada i < 10 demek:
            // i yani 1 küçük olduğu sürece 10'dan 1'i 1 arttır 2 yap 2 yi 1 arttır 3 yap
            // i++ 1 arttır demektir.
            // Döngüleri elimizdeki verileri dönmek için kullanıyoruz.

            //for (int i = 1; i <= 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}



        }
    }
}
