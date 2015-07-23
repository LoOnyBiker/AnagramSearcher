using System.IO;

namespace AnagramSearcher
{
    public sealed class Searcher
    {

        private AnagramKeeper ak;

        private string loadFilePath;

        public Searcher(string path)
        {
            loadFilePath = path + "\\input.txt";
            ak.unloadFilePath = path + "\\output.txt";
        }

        public void Search()
        {
            BeforeSearching();
            SearchAlgorithm();
            AfterSearching();
        }

        private void BeforeSearching()
        {

        }

        private void SearchAlgorithm()
        {
            using (FileStream stream = File.Open(loadFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string anagram = Converter.GetAnagram(line.ToLower());
                            if (!ak.ContainsAnagram(anagram))
                            {
                                ak.saveAnagram(anagram);
                            }
                        }
                    }
                }
            }
        }

        private void AfterSearching()
        {

        }
    } 
}
