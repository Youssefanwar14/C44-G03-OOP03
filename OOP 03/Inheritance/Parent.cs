using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Inheritance
{
    public class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int product() 
        {
            return X * Y;
        }
    }
}
