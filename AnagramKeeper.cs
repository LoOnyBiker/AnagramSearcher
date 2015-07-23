using System.IO;
using System.Text;

namespace AnagramSearcher
{
    struct AnagramKeeper
    {
        public string unloadFilePath
        {
            get;
            set;
        }

        public void saveAnagram(string anagram)
        {
            File.AppendAllText(unloadFilePath, anagram);
        }

        public bool ContainsAnagram(string searchingAnagram)
        {
            foreach (string line in File.ReadLines(unloadFilePath, Encoding.UTF8))
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    if (Converter.GetAnagram(line) == searchingAnagram)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
