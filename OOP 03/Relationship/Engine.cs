using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Relationship
{
    internal class Engine
    {
    }
    public class Car // Has-A relationship
    {
        private Engine engine { get; set; } // Composition relationship, Car has an Engine

        public Car()
        {
            engine = new Engine(); // Initialize the Engine when a Car is created
        }
    }
}
