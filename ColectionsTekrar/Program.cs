using System;
using System.Collections.Generic;

namespace ColectionsTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Kageyama", "Hinata", "İwa", "Kenma" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]); 

            //isimler = new string[5]; //yeni olduğu için önceki bilgileri adres değiştiinden kayboldu
            //isimler[4] = "Bokuto";
            //Console.WriteLine(isimler[4]);     //yani 4. ismi yazar 0. yı yazmaz
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Kageyama", "Hinata", "İwa", "Kenma" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);         //koleksiyonları kullanmamızın sebebi yeni eleman eklediğimizde kaybolma olmuyor
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Nishinoya");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }

    }
}
