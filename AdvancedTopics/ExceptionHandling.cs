using System;

namespace AdvancedTopics
{
    public class ExceptionHandling
    {
        public static void Run()
        {
            try
            {
                int[] so = { 1, 2, 3 };
                Console.WriteLine(so[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Bat duoc ngoai le: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Khoi lenh nay luon duoc thuc thi.");
            }
        }
    }
}
