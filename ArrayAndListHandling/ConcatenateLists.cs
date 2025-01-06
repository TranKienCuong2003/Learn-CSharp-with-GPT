using System;
using System.Collections.Generic;

namespace ArrayAndListHandling
{
    public class ConcatenateLists
    {
        public static void Run()
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            Console.WriteLine("Nhap so luong phan tu trong danh sach 1:");
            int n1 = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Nhap cac phan tu cho danh sach 1:");
            for (int i = 0; i < n1; i++)
            {
                list1.Add(int.Parse(Console.ReadLine() ?? "0"));
            }

            Console.WriteLine("Nhap so luong phan tu trong danh sach 2:");
            int n2 = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Nhap cac phan tu cho danh sach 2:");
            for (int i = 0; i < n2; i++)
            {
                list2.Add(int.Parse(Console.ReadLine() ?? "0"));
            }

            list1.AddRange(list2);
            Console.WriteLine("Danh sach sau khi ket hop:");
            foreach (var num in list1)
            {
                Console.Write(num + " ");
            }
        }
    }
}
