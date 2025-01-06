using System;

namespace StringAdvanced
{
    public class ReverseString
    {
        public static void Run()
        {
            Console.WriteLine("Vui long nhap chuoi de dao nguoc:");
            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ban phai nhap chuoi khong rong.");
                return;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine($"Chuoi sau khi dao nguoc la: {new string(arr)}");
        }
    }
}
