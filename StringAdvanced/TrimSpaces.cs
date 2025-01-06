using System;

namespace StringAdvanced
{
    public class TrimSpaces
    {
        public static void Run()
        {
            Console.WriteLine("Vui long nhap chuoi can cat bo khoang trang:");
            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Chuoi khong duoc de trong.");
                return;
            }

            string trimmedInput = input.Trim();
            Console.WriteLine($"Chuoi sau khi cat khoang trang: '{trimmedInput}'");
        }
    }
}
