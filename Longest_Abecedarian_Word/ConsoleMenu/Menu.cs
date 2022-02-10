using InternshipProject.Exceptions;
using InternshipProject.Tasks;
using Longest_Abecedarian_Word.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InternshipProject.ConsoleMenu.Enums.MenuActionsEnum;

namespace Longest_Abecedarian_Word.ConsoleMenu
{
    public class Menu
    {
        public static MenuActions[] ArrayActions = { MenuActions.FindLongestAbecedarianWord, MenuActions.ReverseAndNot, MenuActions.CloseTask, MenuActions.Exit };
        public static MenuActions action = MenuActions.CloseTask;
        public static void OutputCasesandReadingUserChoise()
        {
            try
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Please enter a number to choose your action");
                var IndexOfChoise = 1;

                for (int i = 0; i < ArrayActions.Length; i++)
                {
                    Console.WriteLine("[{0}] = {1}", IndexOfChoise++, ArrayActions[i]);
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                 var UserChoice = Convert.ToInt32(Console.ReadLine());
                action = ArrayActions[--UserChoice];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"IndexOutOfRangeException: Wrong case number, select from 1 to {ArrayActions.Length}");
                OutputCasesandReadingUserChoise();
            }
            catch (InvalidCastException)
            {
                OutputCasesandReadingUserChoise();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OutputCasesandReadingUserChoise();
            }
            try
            {
                Run(action);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OutputCasesandReadingUserChoise();
            }
        }

        public static void Run (MenuActions actions)
        {
            switch(actions)
            {
                case MenuActions.FindLongestAbecedarianWord:
                    Console.WriteLine($"Your choice {MenuActions.FindLongestAbecedarianWord}");
                    Console.WriteLine($"Enter words separated by a space character ");
                    var UserWords = Console.ReadLine();
                    Console.WriteLine(LongestAbecedarianWord.FindLongestAbecedarian(UserWords));
                    break;

                case MenuActions.ReverseAndNot:
                    Console.WriteLine($"Your choice {MenuActions.ReverseAndNot}");
                    Console.WriteLine($"Enter numbers");
                    var Usernumber = Console.ReadLine();
                    Console.WriteLine(ReverseAndNot.Reverse(Convert.ToInt32(Usernumber)));                  
                    break;

                case MenuActions.CloseTask:
                    break;

                case MenuActions.Exit:
                    Environment.Exit(0);
                    break;
            }
            OutputCasesandReadingUserChoise();
        }
    }
}
