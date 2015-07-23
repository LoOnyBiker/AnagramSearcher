namespace AnagramSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            Searcher s = new Searcher(path);
            s.Search();

        }
    }
}
