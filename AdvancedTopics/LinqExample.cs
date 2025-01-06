using System;
using System.Linq;

namespace AdvancedTopics
{
    public class LinqExample
    {
        public static void Run()
        {
            int[] so = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var soChan = from num in so
                         where num % 2 == 0
                         select num;

            Console.WriteLine("So chan:");
            foreach (var soItem in soChan)
            {
                Console.WriteLine(soItem);
            }
        }
    }
}
