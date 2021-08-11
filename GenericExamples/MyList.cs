using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExamples
{
    class MyList<T>
    {
        T[] temps;

        public MyList()
        {
            temps = new T[0];
        }
        public void Add(T temp)
        {
            T[] tempArray = temps;

            temps = new T[temps.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                temps[i] = tempArray[i];
            }
            temps[temps.Length - 1] = temp;
        }

         public void ShowMyList()
        {
            foreach (var item in temps)
            {
                Console.WriteLine(item);
            }
        }

    }
}
