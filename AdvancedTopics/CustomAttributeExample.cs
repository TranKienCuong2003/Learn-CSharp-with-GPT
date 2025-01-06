using System;

namespace AdvancedTopics
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DeveloperAttribute : Attribute
    {
        public string DeveloperName { get; }
        public DeveloperAttribute(string developerName)
        {
            DeveloperName = developerName;
        }
    }

    [Developer("John Doe")]
    public class CustomAttributeExample
    {
        public static void Run()
        {
            Type type = typeof(CustomAttributeExample);
            object[] attributes = type.GetCustomAttributes(typeof(DeveloperAttribute), false);

            if (attributes.Length > 0)
            {
                DeveloperAttribute attribute = (DeveloperAttribute)attributes[0];
                Console.WriteLine($"Nha phat trien: {attribute.DeveloperName}");
            }
        }
    }
}
