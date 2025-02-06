using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Part2
{
    public interface IAnimal
    {
        // getters and setters
        string Name { get; set; }
        string Colour { get; set; }
        int Age { get; set; }
        double Height { get; set; }

        // methods
        void Eat();
        string Cry();
    } // interface
} // namespace
