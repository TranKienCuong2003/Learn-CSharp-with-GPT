using System;

namespace NumberHandling
{
    public class FahrenheitToCelsius
    {
        public static void Run()
        {
            Console.WriteLine("Nhap nhiet do (F):");
            double fahrenheit = double.Parse(Console.ReadLine() ?? "0");
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"Nhiet do {fahrenheit} F = {celsius} C");
        }
    }
}
