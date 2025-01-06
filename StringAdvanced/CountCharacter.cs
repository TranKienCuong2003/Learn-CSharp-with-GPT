using System;

namespace StringAdvanced
{
    public class CountCharacter
    {
        public static void Run()
        {
            Console.WriteLine("Vui long nhap chuoi can dem ky tu:");
            string input = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Vui long nhap ky tu can dem:");
            string characterInput = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(characterInput))
            {
                Console.WriteLine("Ban phai nhap ca chuoi va ky tu de dem.");
                return;
            }

            if (characterInput.Length > 0)
            {
                char character = characterInput[0];
                int count = input.Count(c => c == character);
                Console.WriteLine($"Ky tu '{character}' xuat hien {count} lan trong chuoi.");
            }
            else
            {
                Console.WriteLine("Khong co ky tu nao duoc nhap!");
            }
        }
    }
}
