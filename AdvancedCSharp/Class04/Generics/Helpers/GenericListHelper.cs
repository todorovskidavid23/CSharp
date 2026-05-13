using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Helpers
{
    public class GenericListHelper
    {
        public void PrintItems<T>(List<T> items)//<T> odma posle ova stanuva genericka
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintItemsInfo<T>(List<T> items)
        {
            //T first = items[0];
            var elementType = typeof(T).Name;
            //var elementType2 = nameof(T);

            Console.WriteLine($"This list has {items.Count} elements and is of type {elementType}");

        }

    }
}
