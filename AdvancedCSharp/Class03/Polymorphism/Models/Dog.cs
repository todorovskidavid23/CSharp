using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Models
{
    public class Dog : Pet
    {
        public bool IsFriendly { get; set; }

        public override void Eat()
        {
            //base.Eat();
            Console.WriteLine($"The {(IsFriendly ? "lazy" : "")} cat {Name} is eating...");
        }
    }
}
