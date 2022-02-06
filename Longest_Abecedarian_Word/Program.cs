using System;

namespace Longest_Abecedarian_Word
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(LongestAbecedarian(new string[] { "one", "two", "three" }));
            Console.WriteLine(LongestAbecedarian(new string[] { "one", "aces", "hearts", "clubs" }));
        }

        public static string LongestAbecedarian(string[] array)
        {
            var Alphabet = "abcdefghijklmnopqrstuvwxyz";
            var result = String.Empty;
            var maxIndexOfAbecedarianWord = -1;
            var maxLenghthOfAbecedarianWord = -1;

            for (int j = 0; j < array.Length; j++)
            {
                var word = array[j];
                var i = 0;
                var lastIndexInAlphabet = -1;

                for (; i < word.Length; i++)
                {
                    var currentIndexInAlphabet = Alphabet.IndexOf(word[i]);

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

            result = maxIndexOfAbecedarianWord == -1 ? "" : array[maxIndexOfAbecedarianWord];

            return result;

        }
    }
}
