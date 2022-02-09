using Longest_Abecedarian_Word.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Longest_Abecedarian_Word.ConsoleMenu
{


  
    public  class Menu
    {
        public enum Actions
        {
            FindLongestAbecedarianWord,
            SecondTask,
            CloseTask,
            Exit
        }
        public void Run (Actions actions)
        {
            switch(actions)
            {
                case Actions.FindLongestAbecedarianWord:
                    Console.WriteLine($"Your choice {Actions.FindLongestAbecedarianWord}");
                    Console.WriteLine($"Enter words separated by a space character ");
                    var UserWords = Console.ReadLine();
                    Console.WriteLine(LongestAbecedarianWord.FindLongestAbecedarian(UserWords));    
                    break;

                case Actions.SecondTask:
                    Console.WriteLine("you select 2 case");
                    break;

                case Actions.CloseTask:
                    Console.WriteLine("you select 2 case");
                    break;

                case Actions.Exit:
                    break;
            }

        }
       


    }
}
