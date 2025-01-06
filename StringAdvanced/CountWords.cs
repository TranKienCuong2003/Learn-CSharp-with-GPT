using System;

namespace StringAdvanced
{
    public class CountWords
    {
        public static void Run()
        {
            Console.WriteLine("Vui long nhap chuoi can dem tu:");
            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ban phai nhap chuoi khong rong.");
                return;
            }

            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Chuoi ban nhap chua {words.Length} tu.");
        }
    }
}
