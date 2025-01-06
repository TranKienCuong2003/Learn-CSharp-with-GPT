using System;

namespace NumberHandling
{
    public class SumOfTwoNumbers
    {
        public static void Run()
        {
            Console.WriteLine("Nhap so thu nhat:");
            int num1 = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Nhap so thu hai:");
            int num2 = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Tong hai so: {num1 + num2}");
        }
    }
}
