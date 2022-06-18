using System;
using System.Collections.Generic;
using System.Text;

namespace GenereicsIntro
{
    // Bu kısımda List gibi kendi class'ımızı oluşturuyoruz.
    // Eğer MyList bir yerde new'lersem otomatik olarak public Mylist(){} çalışır ve
    // içerisinde ki değerleri çalıştırır.
    class MyList<T>
    {
        T[] items;

        // Bir Class newlendiğinde çalışan kod bloğuna Constructor denir.
        public MyList()
        {
            items = new T[0];
        }
        // Bana T türünde bir item(eleman) ver integer string bool array değer tiplerinden birisi.
        public void Add(T item)
        {
            // T türündeli Array'imi newlediğim zaman eski değerlerim uçmasın diye
            // Geçici bir değişkeni items'a tutturuyorum.
            T[] tempArray = items;
            // Dizinin elaman sayısını 1 arttır.
            items = new T[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
