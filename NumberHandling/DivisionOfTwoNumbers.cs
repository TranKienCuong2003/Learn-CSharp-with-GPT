using System;

namespace NumberHandling
{
    public class DivisionOfTwoNumbers
    {
        public static void Run()
        {
            Console.WriteLine("Nhap so thu nhat:");
            double num1 = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Nhap so thu hai:");
            double num2 = double.Parse(Console.ReadLine() ?? "0");

            if (num2 != 0)
            {
                Console.WriteLine($"Thuong hai so: {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Khong the chia cho 0!");
            }
        }
    }
}
