using System;

namespace StringAdvanced
{
    public class ConvertToUpper
    {
        public static void Run()
        {
            Console.WriteLine("Vui long nhap chuoi can chuyen thanh chu hoa:");

            string input = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ban phai nhap mot chuoi khong rong.");
                return;
            }

            string result = input.ToUpper();
            Console.WriteLine("Chuoi sau khi chuyen thanh chu hoa: " + result);
        }
    }
}
