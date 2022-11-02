using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    public class Collection<T>
    {
        T[] collections = new T[5];
       
        
        public void Add(T value, int i)
        {
                collections[i] = value;
             
        }

        public void Remove()
        {

        }

        public void ShowAllArray()
        {
            for (int i = 0; i < collections.Length; i++)
            {
                Console.Write(collections[i] + " ");
                
            }
            Console.WriteLine();

        }

        public void ShowValueOfArray(int i)
        {
            Console.WriteLine($"{i} element of the Array is {collections[i]}");

        }
        public int Count()
        {
            return collections.Length;
        }
    }
}






