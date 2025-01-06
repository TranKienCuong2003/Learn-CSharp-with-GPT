using System;
using System.IO;

namespace AdvancedTopics
{
    public class FileOperations
    {
        public static void Run()
        {
            string duongDanFile = "example.txt";

            File.WriteAllText(duongDanFile, "Day la vi du ve file I/O trong C#.");

            string noiDung = File.ReadAllText(duongDanFile);
            Console.WriteLine("Noi dung cua file:");
            Console.WriteLine(noiDung);
        }
    }
}
