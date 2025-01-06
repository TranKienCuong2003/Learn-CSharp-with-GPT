namespace OOP
{
    public class Dog
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} đang kêu...");
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} đang sủa!");
        }
    }
}
