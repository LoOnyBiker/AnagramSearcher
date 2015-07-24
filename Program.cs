namespace AnagramSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            //AnagramKeeper ak;
            //ak.unloadFilePath = path + "\\input.txt";
            //for (int i = 5; i < 15; i++)
            //{
            //    for (int j = 0; j < 1000000; j++)
            //    {
            //        ak.saveAnagram(new DictionaryCreator().GenerateEng(i));
            //    }
            //}

            Searcher s = new Searcher(path);
            s.Search();
        }
    }
}
