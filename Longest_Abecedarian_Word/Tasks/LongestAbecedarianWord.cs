using InternshipProject.Exceptions;

namespace InternshipProject.Tasks
{
    public static class LongestAbecedarianWord
    {
        public static string FindLongestAbecedarian(string words)
        {
            string[] array = words.ToLower().Split(' ');
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var result = string.Empty;
            var maxIndexOfAbecedarianWord = -1;
            var maxLenghthOfAbecedarianWord = -1;

            for (int j = 0; j < array.Length; j++)
            {
                var word = array[j];
                var i = 0;
                var lastIndexInAlphabet = -1;

                for (; i < word.Length; i++)
                {
                    var currentIndexInAlphabet = alphabet.IndexOf(word[i]);

                    if (currentIndexInAlphabet == -1)
                    {
                        throw new LongestAbecedarianWordException(message: "Unsupported symbol");
                    }

                    if (currentIndexInAlphabet < lastIndexInAlphabet)
                    {
                        break;
                    }

                    lastIndexInAlphabet = currentIndexInAlphabet;
                }

                var currentLenghthOfAbecedarianWord = i;

                if (currentLenghthOfAbecedarianWord == word.Length)
                {
                    if (currentLenghthOfAbecedarianWord > maxLenghthOfAbecedarianWord)
                    {
                        maxLenghthOfAbecedarianWord = currentLenghthOfAbecedarianWord;
                        maxIndexOfAbecedarianWord = j;
                    }
                }
            }

            if (maxIndexOfAbecedarianWord == -1)
            {
               throw new LongestAbecedarianWordException(message: "Abecedarian word not found");
            }
            
               return result =  $"Longest abecedarian word:  {array[maxIndexOfAbecedarianWord]}";
        }
    }
}
