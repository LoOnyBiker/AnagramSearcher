using System;

namespace AnagramSearcher
{
    class Program
    {
        internal static string Load = "\\Sources";
        internal static string Result = "\\Result";

        static void Main(string[] args)
        {
            Console.WriteLine("Past path to input file: ");
            string path = Console.ReadLine();

            Searcher s = new Searcher(path);
            s.Search();

        }
    }
}
