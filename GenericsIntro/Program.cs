using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        //Burada da List ' i kendimiz oluşturmak isteseydik nasıl yapardık onu inceleyeceğiz.
        static void Main(string[] args)
        { 
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

        }

    }
}