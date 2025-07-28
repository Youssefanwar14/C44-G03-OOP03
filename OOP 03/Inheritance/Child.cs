using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Inheritance
{
    public class Child : Parent
    {
       
        public int Z { get; set; }

        public Child(int x, int y ,int z) : base(x , y) // Call the base class constructor with default values for X and Y
        {
            Z = z;
        }
        public int product()
        {
            return X * Y * Z;
        }
    }
}
