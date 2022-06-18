// System içerisinde ki int,string,array, gibi değerleri kullanmak istiyorum.
using System;
// Collections.Generic içerisinde ki Koleksiyonları kullanmamk istiyorum.
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"};
            //isimler arrayinin 0'ıncı elemanını yazdır.
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            // Bu kısımda elbette İlker değerini konsola yazdırır fakat yine new string dediğimiz için
            // sadece 4.elemana(aslında beş 0'dan başladığı için) ilker değerini atar diğer 0,1,2
            // Gibi Değerler boş gelir sebebi ise new string' heap'de tutulduğu için adres değişikliği
            //Yapmış oldu bu yüzden sadece ilker değerini görüyor Arrayimiz.
            // Koleksiyonlar array'in yerini mi aldı ?. Gerçek hayatta pek array kullanılmıyor.
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);

            //Standart bir yeni string veri tipinde isimler2 oluştur kalıbı yazdım.

            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            
        }
    }
}
