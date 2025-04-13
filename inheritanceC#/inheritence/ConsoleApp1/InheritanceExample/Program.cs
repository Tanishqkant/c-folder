// See https://aka.ms/new-console-template for more information
using System;

namespace InheritanceExample
{
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

    class Program
    {
        static void Main()
        {
            Dog myDog = new Dog();
            myDog.Name = "Buddy";
            myDog.Eat();  // Inherited from Animal
            myDog.Bark(); // Defined in Dog

            Console.ReadLine();
        }
    }
}


