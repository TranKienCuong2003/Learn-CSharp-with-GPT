using System;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    public class AsyncProgramming
    {
        public static async Task Run()
        {
            Console.WriteLine("Bat dau");
            await Task.Delay(2000);
            Console.WriteLine("Ket thuc sau 2 giay");
        }
    }
}
