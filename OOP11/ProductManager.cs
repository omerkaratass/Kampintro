using System;
using System.Collections.Generic;
using System.Text;

namespace OOP11
{
    //ProductManager - ProductService
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

   
    }
}
