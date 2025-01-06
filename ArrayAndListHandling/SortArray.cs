using System;

namespace ArrayAndListHandling
{
    public class SortArray
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

            Array.Sort(arr);
            Console.WriteLine("Mang sau khi sap xep:");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
