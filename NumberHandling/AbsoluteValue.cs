using System;

namespace NumberHandling
{
    public class AbsoluteValue
    {
        public static void Run()
        {
            Console.WriteLine("Nhap so:");
            double num = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Gia tri tuyet doi cua {num} la: {Math.Abs(num)}");
        }
    }
}
