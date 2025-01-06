using System;

namespace StringAdvanced
{
    public class ConvertToLower
    {
        public static void Run()
        {
            Console.WriteLine("Vui long nhap chuoi can chuyen thanh chu thuong:");

            string input = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ban phai nhap mot chuoi khong rong.");
                return;
            }

            string result = input.ToLower();
            Console.WriteLine("Chuoi sau khi chuyen thanh chu thuong: " + result);
        }
    }
}
