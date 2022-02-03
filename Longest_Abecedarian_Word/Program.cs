using System;

namespace Longest_Abecedarian_Word
{
    class Program
    {

        public static string LongestAbecedarian(string[] array)
        {
            string Alphabet = "abcdefghijklmnopqrstuvwxyz";
            string result = "";
            int maxIndexOfAbecedarianWord = -1;
            int maxLenghthOfAbecedarianWord = -1;
            for (int j = 0; j < array.Length; j++)
            {
                string word = array[j];
                int i;
                int lastIndexInAlphabet = -1;
                for (i = 0; i < word.Length; i++)
                {
                    int currentIndexInAlphabet = Alphabet.IndexOf(word[i]);
                    if (currentIndexInAlphabet < lastIndexInAlphabet)
                    {
                        break;

                    }
                    lastIndexInAlphabet = currentIndexInAlphabet;

                }
                int currentLenghthOfAbecedarianWord = i;
                if (currentLenghthOfAbecedarianWord == word.Length)
                {
                    if (currentLenghthOfAbecedarianWord > maxLenghthOfAbecedarianWord)
                    {
                        maxLenghthOfAbecedarianWord = currentLenghthOfAbecedarianWord;
                        maxIndexOfAbecedarianWord = j;
                    }

                }



            }

            return maxIndexOfAbecedarianWord == -1 ? "" : array[maxIndexOfAbecedarianWord];


        }


        static void Main(string[] args)
        {
            Console.WriteLine(LongestAbecedarian(new string[] { "one", "two", "three" }));
            Console.WriteLine(LongestAbecedarian(new string[] { "one", "aces", "hearts", "clubs" }));
        }
    }
}
