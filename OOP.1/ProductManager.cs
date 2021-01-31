using System;
using System.Collections.Generic;
using System.Text;

namespace OOP._1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.productName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.productName + " güncellendi.");

        }
    }
}
