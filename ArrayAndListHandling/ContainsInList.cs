using System;
using System.Collections.Generic;

namespace ArrayAndListHandling
{
    public class ContainsInList
    {
        public static void Run()
        {
            List<int> list = new List<int>();

            Console.WriteLine("Nhap so luong phan tu trong danh sach:");
            int n = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Nhap cac phan tu trong danh sach:");
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine() ?? "0"));
            }

            Console.WriteLine("Nhap gia tri can kiem tra:");
            int searchValue = int.Parse(Console.ReadLine() ?? "0");

            if (list.Contains(searchValue))
            {
                Console.WriteLine($"Danh sach chua gia tri {searchValue}");
            }
            else
            {
                Console.WriteLine($"Danh sach khong chua gia tri {searchValue}");
            }
        }
    }
}
