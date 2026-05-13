using Generics.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Domain.Interfaces
{
    //Genericki interface
    public interface IGenericDB<T>
    {
        void PrintAll();
        T GetById(int id);
        T GetByIndex(int index);
        void Insert(T entity);
        void RemoveById(int id);

    }
}
