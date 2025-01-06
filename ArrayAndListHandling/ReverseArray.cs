using System;

namespace ArrayAndListHandling
{
    public class ReverseArray
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

            Array.Reverse(arr);
            Console.WriteLine("Mang sau khi dao nguoc:");
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
