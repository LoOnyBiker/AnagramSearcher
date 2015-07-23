using System.IO;
using System.Text;

namespace AnagramSearcher
{
    public sealed class Searcher
    {

        private AnagramKeeper ak;

        private string loadFilePath;

        public Searcher(string path)
        {
            loadFilePath = path;
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
            foreach (string line in File.ReadLines(loadFilePath, Encoding.UTF8))
            {
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

        private void AfterSearching()
        {

        }
    } 
}
