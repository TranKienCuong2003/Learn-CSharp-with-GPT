using System;
using System.Collections.Generic;

namespace ArrayAndListHandling
{
    public class RemoveFromList
    {
        public static void Run()
        {
            List<int> list = new List<int>();

            Console.WriteLine("Nhap so luong phan tu ban dau trong danh sach:");
            int n = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Nhap cac phan tu vao danh sach:");
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine() ?? "0"));
            }

            Console.WriteLine("Nhap gia tri can xoa:");
            int removeValue = int.Parse(Console.ReadLine() ?? "0");

            bool removed = list.Remove(removeValue);
            if (removed)
            {
                Console.WriteLine("Da xoa phan tu.");
            }
            else
            {
                Console.WriteLine("Phan tu khong ton tai trong danh sach.");
            }

            Console.WriteLine("Danh sach sau khi xoa:");
            foreach (var num in list)
            {
                Console.Write(num + " ");
            }
        }
    }
}
