/*
 * CPRG-211-C Lab Interfaces and Abstract Classes
 * Author: Jirch Tumbokon
 * When: Winter 2025
 */

/*
 * This program inherits from the IAnimal Interface
 * then displays the animal's details
 * what it eats and the sound it makes
 * then creates a list of animals and prints their names.
 */

using Lab3Part2;

class Program
{
    public static void Main()
    {
        Dog dog = new Dog("Rover", "Brown", 5, 22);
        Console.WriteLine(dog.ToString());
        dog.Eat();
        Console.WriteLine(dog.Cry() + "\n");

        Cat cat = new Cat("Whiskers", "White", 3, 11);
        Console.WriteLine(cat.ToString());
        cat.Eat();
        Console.WriteLine(cat.Cry() + "\n");

        List<IAnimal> animals = new List<IAnimal> // creates animals list
        {
            { new Dog("Rover") },
            { new Cat("Whiskers") },
            { new Dog("Fido") },
            { new Cat("Fluffy") },
            { new Dog("Rolly") },
            { new Dog("Rocky") },
            { new Cat("Mittens") },
            { new Cat("Socks") }
        };

        foreach (IAnimal animal in animals) // iterates through the animals list and prints their name
        {
            Console.WriteLine(animal.Name);
        };
    }
}

