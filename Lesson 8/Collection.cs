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
        T[] collections = new T[1];
       
        
        public void Add(T value, int i)
        {
            collections[i] = value;
          
        }

        public T [] Remove(int remove)
        {
            
            T [] removedCollection = new T [collections.Length -1 ];
            for (int i = 0; i < remove; i++)
            {
                removedCollection[i] = collections[i];
            }
            for (int i = remove +1 ; i < collections.Length; i++)
            {
                removedCollection[i-1] = collections[i];
            }
            collections = removedCollection;
            return collections;
        }

        public void ShowRemovedArray()
        {
            for (int i = 0; i < collections.Length; i++)
            {
                Console.Write(collections[i] + " ");
            }
            Console.WriteLine();
        }

        public T [] ShowAllArray()
        {
            for (int i = 0; i < collections.Length; i++)
            {
                Console.Write(collections[i] + " ");
                
            }
            Console.WriteLine();
            return collections;
        }

        public T GetItem(int i)
        {
            return collections[i];    
            
        }
        public int Count()
        {

            return collections.Length;
        }

        public void IncreaseArray<T> (ref T[] collections, int newSize)
        {
            T[] newCollections = new T[newSize];
            for (int i = 0; i < newCollections.Length && i <collections.Length; i++)
            {
                newCollections[i] = collections[i];

            }
            collections = newCollections;
        }

        public void Increase()
        {
            IncreaseArray(ref collections, collections.Length+1);
        }

    }
}






