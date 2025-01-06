using System;

namespace StringAdvanced
{
    public class CheckPalindrome
    {
        public static void Run()
        {
            Console.WriteLine("Vui long nhap chuoi de kiem tra xem no co phai la Palindrome hay khong:");

            string input = Console.ReadLine()?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ban phai nhap mot chuoi khong rong.");
                return;
            }

            string reversed = new string(input.ToCharArray().Reverse().ToArray());

            if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Day la mot chuoi Palindrome.");
            }
            else
            {
                Console.WriteLine("Day khong phai la chuoi Palindrome.");
            }
        }
    }
}
