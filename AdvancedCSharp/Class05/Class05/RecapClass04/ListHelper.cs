using System;
using System.Collections.Generic;
using System.Text;

namespace RecapClass04
{
    public static class ListHelper
    {
        public static void PrintListInfo<T>(this List<T> items)
        {
            string listType = typeof(T).Name;
            Console.WriteLine($"This list has {items.Count} element and is oof type {listType}");
        }
    }
}
