using System;
using System.Text;
using InternshipProject.Tasks;
using static InternshipProject.ConsoleMenu.Enums.MenuActionsEnum;

namespace InternshipProject.ConsoleMenu
{
    public class Menu
    {
        public static int UserChoice = 0;

        public static void OutputCasesandReadingUserChoise()
        {
            try
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Please enter a number to choose your action");
                var indexOfChoise = 1;

                StringBuilder stringBuilder = new StringBuilder();

                foreach (MenuActions action in MenuActions.GetValues(typeof(MenuActions)))
                {
                    stringBuilder.Append(indexOfChoise++ + " - " + action.GetDescription() + "\n");
                    
                }
                Console.WriteLine(stringBuilder.ToString());
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                UserChoice = Convert.ToInt32(Console.ReadLine());
                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"IndexOutOfRangeException: Wrong case number, select from 1 to {Enum.GetValues(typeof(MenuActions)).Length}");
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
                Run(UserChoice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OutputCasesandReadingUserChoise();
            }
        }

        private static void Run (int actions)
        {
            switch(actions)
            {
                case (int)MenuActions.FindLongestAbecedarianWord:
                    Console.WriteLine("Choose how you want to enter the words");
                    Console.ReadLine();

                    Console.WriteLine($"Your choice {MenuActions.FindLongestAbecedarianWord}");
                    Console.WriteLine($"Enter words separated by a space character ");
                    var userWords = Console.ReadLine();
                    Console.WriteLine(FindLongestAbecedarian(userWords));
                    break;
                case (int)MenuActions.ReverseAndNot:
                    Console.WriteLine($"Your choice {MenuActions.ReverseAndNot}");
                    Console.WriteLine($"Enter numbers");
                    var usernumber = Console.ReadLine();
                    Console.WriteLine(ReverseAndNot.Reverse(Convert.ToInt32(usernumber)));                  
                    break;
                case (int)MenuActions.CloseTask:
                    break;
                case (int)MenuActions.Exit:
                    Environment.Exit(0);
                    break;
            }

            OutputCasesandReadingUserChoise();
        }

        private static bool FindLongestAbecedarian(string userWords)
        {
            throw new NotImplementedException();
        }
    }
}
