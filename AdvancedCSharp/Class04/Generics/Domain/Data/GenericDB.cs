using Generics.Domain.Interfaces;
using Generics.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Domain.Data
{
    public class GenericDB<T> : IGenericDB<T> where T : BaseEntity//plaseholder T    //da imame kontrola vrz ova T //mora da ima Id i getInfo
    {
        //znaemse sto da upotrebime od BaseEntity za da T ne bide bilo sto da mu tekne da bide
        private List<T> Db;//ova se odnesuva na 7ma linija
        public GenericDB()
        {
            Db = new List<T>();
        }
        public void PrintAll()
        {
            Console.WriteLine($"\nPrinting items for {typeof(T).Name}");
            foreach (T item in Db)
            {
                Console.WriteLine(item.GetInfo());//deka doagja od BaseEntity;
                //Ctrl + KD ni e format 
            }
        }

        public T GetById(int id)
        {
            //T item = Db.FirstOrDefault(x => x.Id);
            //return Db.First();
            T item = Db.FirstOrDefault(x => x.Id == id);
            ArgumentNullException.ThrowIfNull(item, $"No item with id {id} found");
            return item;
        }
        public T GetByIndex(int index)
        {
            return Db[index];
        }

        public void Insert(T entity)
        {
            Db.Add(entity);
            Console.WriteLine($"Item was added in the {typeof(T).Name} Db.");
        }


        public void RemoveById(int id)
        {
            T item = GetById(id);
            Db.Remove(item);
        }
    }
}
