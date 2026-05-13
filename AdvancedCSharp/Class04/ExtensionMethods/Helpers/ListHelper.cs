using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Helpers
{
    public static class ListHelper
    {
        //static metoda se se printa items
        //extensiot metodot e ust this
        //ovaa metoda kje se dodade na ovoj tip
        public static void PrintItems<T>(this List<T> items)//<T> odma posle ova stanuva genericka
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
