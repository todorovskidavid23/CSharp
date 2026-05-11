using Polymorphism.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Xml.Serialization;

//metoda isto ime isto vrakja razlicen broj na PARAMETRI
namespace Polymorphism.Services
{
    public class PetService
    {
        public void PrintPetInfo()
        {
            Console.WriteLine("Some pet info");
        }

        public void PrintPetInfo(Cat cat)
        {
            Console.WriteLine($"This cat is {(cat.IsLazy ? "lazy" : "not lazy")}");
        }

        //public void PrintPetInfo(Cat kitty,Dog doggy)//NE MOZE SAMO Cat kitty ako dodademe parametar togas kje moze
        //{
        //    Console.WriteLine($"This cat is {(kitty.IsLazy ? "lazy" : "not lazy")}");

        //}

        public void PrintPetInfo(Dog dog)
        {
            Console.WriteLine($"This dog is {(dog.IsFriendly ? "friendly" : "not Friendly")}");
        }

        public void PrintPetInfo(string owner,Dog dog)
        {
            Console.WriteLine($"The owner {owner} has dog named {dog.Name}");

        }

        public void PrintPetInfo(Dog dog, string owner)
        {
            Console.WriteLine($"The owner {owner} has dog named {dog.Name}");

        }



    }
}