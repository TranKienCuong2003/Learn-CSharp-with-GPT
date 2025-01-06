using System;
using System.Collections;
using System.Collections.Generic;

namespace AdvancedTopics
{
    public class CustomCollectionExample
    {
        public static void Run()
        {
            var customCollection = new CustomCollection<int>();
            customCollection.Add(1);
            customCollection.Add(2);
            customCollection.Add(3);

            foreach (var item in customCollection)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class CustomCollection<T> : IEnumerable<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
