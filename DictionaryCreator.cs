using System.Threading;

namespace AnagramSearcher
{
    public class DictionaryCreator
    {
        char[] engChars = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] rusChars = new char[29] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ш', 'щ', 'ъ', 'ь', 'э', 'ю', 'я' };

        private System.Random rGen;

        public string GenerateEng(int i)
        {
            rGen = new System.Random();

            int p = 0;
            string str = "";
            for (int x = 0; x <= i; x++)
            {
                p = rGen.Next(0, 25);
                str += engChars[p];
            }
            Thread.Sleep(12);
            return str;
        }

        public string GenerateRus(int i)
        {
            rGen = new System.Random();

            int p = 0;
            string str = "";
            for (int x = 0; x <= i; x++)
            {
                p = rGen.Next(0, 28);
                str += rusChars[p];
            }
            Thread.Sleep(12);
            return str;
        }

    }
}
