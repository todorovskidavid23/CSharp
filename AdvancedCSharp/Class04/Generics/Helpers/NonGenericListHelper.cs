using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Helpers
{
    public class NonGenericListHelper
    {
        public void PrintStrings(List<string> strings)
        {
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintInfoForStrings(List<string> strings)
        {
            string first = strings[0];
            string elementType = first.GetType().Name;

            Console.WriteLine($"This list has {strings.Count} elements and is of type {elementType}");
        }

        public void PrintInts(List<int> integers)
        {
            foreach(var item in integers)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintInfoForInts(List<int> integers)
        {
            int first = integers[0];
            string elementType = first.GetType().Name;

            Console.WriteLine($"This list has {integers.Count} elements and is of type {elementType}");
        }

        public void PrintBooleans(List<bool> booleans)
        {
            foreach(var item in booleans)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintInfoForBooleans(List<bool> booleans)
        {
            bool first = booleans[0];
            string elementType = first.GetType().Name;

            Console.WriteLine($"This list has {booleans.Count} elements and is of type {elementType}");
        }

    }
}
