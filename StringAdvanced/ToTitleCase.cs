using System;

namespace StringAdvanced
{
    public class ToTitleCase
    {
        public static void Run()
        {
            Console.WriteLine("Vui long nhap chuoi de chuyen thanh Title Case:");
            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ban phai nhap chuoi khong rong.");
                return;
            }

            var titleCase = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
            Console.WriteLine($"Chuoi sau khi chuyen thanh Title Case: {titleCase}");
        }
    }
}
