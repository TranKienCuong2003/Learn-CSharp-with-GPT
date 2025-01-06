// Counter.cs
using System;

namespace OOP
{
    public class Counter
    {
        public static int Count { get; private set; }

        public Counter()
        {
            Count++;
        }

        public static void ResetCount()
        {
            Count = 0;
        }
    }
}
