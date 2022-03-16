using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;

        //constructor: aslında bir metottur classın ismi ile aynıdır.void vs yoktur (direkt çalışacak)  
        //biz bu classı bir yerde new lersek otomatik constructer çalışır.

        public MyList() // ctor + Tab*2
        {
            items = new T[0];
        }

        //Artık benim elimde 0 elemanlı bir dizim var.

        public void Add(T item)
        {
            T[] tempArray = items;
            // Fakat hatırlarsan referans türlüleri new leyince değerler uçuyordu.(Aslında referans numarası düşüyordu.)
            //bizde bu yüzden burada (T[] tempArray = items;) referans numarasını geçici bir arraye emanet ettik.
            items = new T[items.Length + 1]; // artık dinamik bir hale dönüştü.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //items.Lenght-1 = sen eleman

            items[items.Length-1] = item; //Yukardan gelen elemanı işte şimdi ekleyebiliyorum.



        }
        


    }
}
