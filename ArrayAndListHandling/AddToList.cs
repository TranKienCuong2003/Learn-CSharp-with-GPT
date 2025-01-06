using System;
using System.Collections.Generic;

namespace ArrayAndListHandling
{
    public class AddToList
    {
        public static void Run()
        {
            List<int> list = new List<int>();

            Console.WriteLine("Nhap so luong phan tu can them vao danh sach:");
            int n = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Nhap cac phan tu:");
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine() ?? "0"));
            }

            Console.WriteLine("Danh sach sau khi them:");
            foreach (var num in list)
            {
                Console.Write(num + " ");
            }
        }
    }
}
