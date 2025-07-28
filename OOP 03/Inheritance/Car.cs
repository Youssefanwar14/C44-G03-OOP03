using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    // If I defne a constructor, the default constructor is not created automatically
    // but struct still has it.

    internal class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Speed{ get; set; }

        
        public Car (int id, string model, int speed) : this (id,model)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }


        public Car(int id, string model) : this(id)
        {
            //Id = id;
            Model = model;
            
        }

        public Car(int id)
        {
            Id = id;
        }
            




    }
}
