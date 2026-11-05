using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba_13
{
    internal class CollectionHelper
    {
public static void PrintReverse<T>(IEnumerable<T> collection)
        {
            List<T> list = new List<T>(collection);

            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }

        
        public static T GetFirstElement<T>(IList<T> collection)
        {
            return collection[0];
        }

        
        public static T GetLastElement<T>(IList<T> collection)
        {
            return collection[collection.Count - 1];
        }

       
        public static bool ContainsElement<T>(IEnumerable<T> collection, T value)
        {
            return collection.Contains(value);
        }

       
        public static int CountElements<T>(IEnumerable<T> collection)
        {
            int count = 0;

            foreach (T item in collection)
            {
                count++;
            }

            return count;
        }

       
        public static int FindIndex<T>(IList<T> collection, T value)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(collection[i], value))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

