using System;

namespace StringAdvanced
{
    public class ConcatenateStrings
    {
        public static void Run()
        {
            Console.WriteLine("Vui long nhap chuoi thu nhat:");
            string input1 = Console.ReadLine() ?? "";

            Console.WriteLine("Vui long nhap chuoi thu hai:");
            string input2 = Console.ReadLine() ?? "";

            string result = string.Concat(input1, input2);

            Console.WriteLine("Ket qua sau khi noi hai chuoi: " + result);
        }
    }
}
