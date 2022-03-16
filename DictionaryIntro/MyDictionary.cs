using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryIntro
{
    class MyDictionary<T,U>
    {
        T[] keys;
        U[] values;
       

        public MyDictionary()
        {
            keys = new T[0];
            values = new U[0];
        }

        public void Add(T key,U value)
        {
            T[] tempKeys=keys;
            U[] tempValues=values;
            keys=new T[keys.Length+1];
            values=new U[keys.Length+1];
            

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i]=tempKeys[i];
            }
            keys[keys.Length - 1] = key;
            for (int i = 0; i < tempValues.Length ; i++)
            {
                values[i] = tempValues[i];
            }
             values[values.Length - 1] = value;

             Console.WriteLine("[" + key + "," + value + "]");
            
            
        }
        

    }
}
