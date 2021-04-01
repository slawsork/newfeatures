using System;

namespace newfeatures1
{
    public record Animal(string Type);

    public record Pet(string Type, string Name) : Animal(Type)
    {
        public void SomeAction() => Console.WriteLine($"{Name} is doing something.");

        public string SomeProperty { get; set; }
    }
}