using System;

namespace StringAdvanced
{
    public class LongestWord
    {
        public static void Run()
        {
            Console.WriteLine("Vui long nhap chuoi de tim tu dai nhat:");
            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ban phai nhap chuoi khong rong.");
                return;
            }

            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string longestWord = "";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }

            if (string.IsNullOrEmpty(longestWord))
            {
                Console.WriteLine("Khong tim thay tu nao.");
            }
            else
            {
                Console.WriteLine($"Tu dai nhat trong chuoi la: '{longestWord}'");
            }
        }
    }
}
