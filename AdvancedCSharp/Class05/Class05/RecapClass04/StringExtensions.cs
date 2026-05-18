using System;
using System.Collections.Generic;
using System.Text;

namespace RecapClass04
{
    public static class StringExtensions
    {
        //da ni skrati odreden broj na karaketri da za dade 3 tocki ...
        //this „Овој метод е extension за овој тип.“
        public static string Truncate(this string word, int length)
        {
            if (string.IsNullOrWhiteSpace(word) || word.Length <= length)
                return word;

            string result = word.Substring(0, length);

            return result + "...";
        }

        public static string Quote(this string word)
        {
            return $@"""{word}""";
        }
    }
}
