using System;

namespace AnagramSearcher
{
    public static class Converter
    {

        public static string GetAnagram(string word)
        {
            char[] anagram = word.ToCharArray();
            Array.Sort(anagram);
            return string.Concat(anagram);
        }

    }
}
