using System;
using System.Reflection;

namespace AdvancedTopics
{
    public class ReflectionExample
    {
        public static void Run()
        {
            Type type = typeof(Person);
            Console.WriteLine($"Loai: {type.Name}");

            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine($"Phuong thuc: {method.Name}");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public void Greet() => Console.WriteLine("Xin chao!");
    }
}
