using System;

namespace ArrayAndListHandling
{
    public class FindElementIndex
    {
        public static void Run()
        {
            Console.WriteLine("Nhap so luong phan tu trong mang:");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int[] arr = new int[n];

            Console.WriteLine("Nhap cac phan tu trong mang:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine() ?? "0");
            }

            Console.WriteLine("Nhap gia tri can tim:");
            int searchValue = int.Parse(Console.ReadLine() ?? "0");

            int index = Array.IndexOf(arr, searchValue);
            if (index >= 0)
            {
                Console.WriteLine($"Phan tu {searchValue} tai chi so {index}");
            }
            else
            {
                Console.WriteLine("Phan tu khong ton tai trong mang.");
            }
        }
    }
}
