using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part2
{
    public class Cat : IAnimal
    {
        // public properties
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }

        // constructor
        public Cat(string name, string colour = "", int age = 0, double height = 0)
        {
            this.Name = name;
            this.Colour = colour;
            this.Age = age;
            this.Height = height;
        }

        // public methods
        public string Cry()
        {
            return $"Meow!";
        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice"); ;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Colour: {Colour}\n" +
                   $"Age: {Age}\n" +
                   $"Height: {Height}\"";
        }
    } // class
}// namespace
