using System;
using System.Collections.Generic;
using System.Text;

namespace TekrarOOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }




        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}                                     //İKİSİDE TOPLAMA AMA İKİNCİ İŞLEM SONUCUNU FARKLI BİR İŞLEM İÇİN KULLANAMYIZ. "VOİD" OLDUĞU İÇİN SADECE YAZDIRDI.
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}


    }
}
