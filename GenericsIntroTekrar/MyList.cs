using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntroTekrar
{
    class MyList<T>
    {
        T[] items;
        // bir class ı newlemek için kullanılan ctor -constructor
    
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;          //önceki bilgileri korumak için
            items = new T[items.Length + 1]; // eleman sayısını 1 artırdık
            for (int i = 0; i < tempArray.Length ; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
        
        public int Lenght
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
