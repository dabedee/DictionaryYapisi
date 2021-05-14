using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryYapisi
{
    class MyDictionary<T1, T2>
    {

        T1[] keys;
        T2[] values;
        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];

        }
        public void Add(T1 key, T2 value)
        {
            T1[] tempArray1 = keys;
            T2[] tempArray2 = values;
            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                keys[i] = tempArray1[i];

            }
            for (int i = 0; i < tempArray2.Length; i++)
            {

                values[i] = tempArray2[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " " +values[i]);
            }
           

        }
        
        

    }                 
           
}
