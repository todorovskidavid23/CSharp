using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public virtual void Eat()
        {
            Console.WriteLine("Nom nom nom");
        }
    }
}
