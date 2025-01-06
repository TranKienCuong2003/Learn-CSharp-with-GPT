// Dog.cs
using System;

namespace OOP
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} barks.");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says Woof!");
        }
    }
}
