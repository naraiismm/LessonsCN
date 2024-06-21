using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyGenerics<T>
    {
        T[] array;
        T[] array2;

        public MyGenerics()
        {
            array = new T[0];
        }

        public void Add(T item)
            
        {
            array2 = array;
            array = new T [array.Length+1];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array[i];
            }

            array[array.Length-1]=item;
        }

       
        public int Count
        {
            get { return array.Length; }
            
        }

    }
}
