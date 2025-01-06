using System;

namespace NumberHandling
{
    public class SumFrom1ToN
    {
        public static void Run()
        {
            Console.WriteLine("Nhap so N:");
            int n = int.Parse(Console.ReadLine() ?? "0");

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Tong cac so tu 1 den {n} la: {sum}");
        }
    }
}
