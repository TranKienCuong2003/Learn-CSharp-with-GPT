using System;

namespace NumberHandling
{
    public class PrimeNumberCheck
    {
        public static void Run()
        {
            Console.WriteLine("Nhap so de kiem tra:");
            int num = int.Parse(Console.ReadLine() ?? "0");

            bool isPrime = true;
            if (num < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isPrime ? "So nguyen to" : "Khong phai so nguyen to");
        }
    }
}
