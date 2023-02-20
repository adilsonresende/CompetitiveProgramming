using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsBusiness._6kyu
{
    public class SpinningWordsBusiness
    {
        public string SpinWords(string sentence)
        {
            List<string> words = sentence.Split(" ").ToList();
            List<string> reversedWords = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];
                if (currentWord.Length >= 5)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    for(int j = currentWord.Length; j > 0; j--)
                    {
                        stringBuilder.Append(currentWord[j - 1]);
                    }

                    words[i] = stringBuilder.ToString();
                }

                reversedWords.Add(words[i]);
            }

            return string.Join(" ", reversedWords);
        }
    }
}
