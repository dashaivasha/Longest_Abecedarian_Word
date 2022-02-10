using InternshipProject.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Abecedarian_Word.Tasks
{
    
    public static class LongestAbecedarianWord
    {
        public static string FindLongestAbecedarian(string words)
        {
            string[] array = words.Split(' ');
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

            if (maxIndexOfAbecedarianWord == -1)
            {
               throw new LongestAbecedarianWordException(message: "Abecedarian word not found");
            }
            else
            {
               return result =  $"Longest abecedarian word:  {array[maxIndexOfAbecedarianWord]}";
            }
        }
    }
}
