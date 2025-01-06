using System;

namespace NumberHandling
{
    public class CelsiusToFahrenheit
    {
        public static void Run()
        {
            Console.WriteLine("Nhap nhiet do (C):");
            double celsius = double.Parse(Console.ReadLine() ?? "0");
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Nhiet do {celsius} C = {fahrenheit} F");
        }
    }
}
