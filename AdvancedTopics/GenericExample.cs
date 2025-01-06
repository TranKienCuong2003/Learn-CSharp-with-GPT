using System;

namespace AdvancedTopics
{
    public class GenericExample
    {
        public static void Run()
        {
            Box<int> intBox = new Box<int>(5);
            Box<string> stringBox = new Box<string>("Hello, World!");

            Console.WriteLine($"Gia tri integer: {intBox.GetValue()}");
            Console.WriteLine($"Gia tri string: {stringBox.GetValue()}");
        }
    }

    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public T GetValue() => value;
    }
}
