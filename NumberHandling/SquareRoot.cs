using System;

namespace NumberHandling
{
    public class SquareRoot
    {
        public static void Run()
        {
            Console.WriteLine("Nhap so:");
            double num = double.Parse(Console.ReadLine() ?? "0");

            if (num >= 0)
            {
                Console.WriteLine($"Can bac hai cua {num} la: {Math.Sqrt(num)}");
            }
            else
            {
                Console.WriteLine("Khong the tinh can bac hai cua so am!");
            }
        }
    }
}
