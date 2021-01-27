using System;

namespace GenericsIntroTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>() ;
            isimler.Add("Sara");
            Console.WriteLine(isimler.Lenght);
            isimler.Add("Mei");
            Console.WriteLine(isimler.Lenght);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
