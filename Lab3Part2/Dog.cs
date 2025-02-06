using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part2
{
    public class Dog : IAnimal
    {
        // public properties
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }

        // constructor
        public Dog(string name, string colour = "", int age = 0, double height = 0)
        {
            this.Name = name;
            this.Colour = colour;
            this.Age = age;
            this.Height = height;
        }

        // public methods
        public string Cry()
        {
            return $"Woof!";
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat"); ;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Colour: {Colour}\n" +
                   $"Age: {Age}\n" +
                   $"Height: {Height}\"";
        }
    }// class
}// namespace
