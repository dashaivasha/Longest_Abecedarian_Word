using System;
using System.IO;
using System.Reflection;
using System.Text;
using InternshipProject.Tasks;
using static InternshipProject.ConsoleMenu.Enums.MenuActionsEnum;

namespace InternshipProject.ConsoleMenu
{
    public class Menu
    {
        public static int UserChoice;

        public static void OutputCasesandReadingUserChoice()
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
                OutputCasesandReadingUserChoice();
            }
            catch (InvalidCastException)
            {
                OutputCasesandReadingUserChoice();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OutputCasesandReadingUserChoice();
            }
            try
            {
                Run(UserChoice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OutputCasesandReadingUserChoice();
            }
        }

        private static void Run (int actions)
        {
            switch(actions)
            {
                case (int)MenuActions.FindLongestAbecedarianWord:
                    Console.WriteLine($"Your choice {MenuActions.FindLongestAbecedarianWord}");
                    var userWords = string.Empty;
                    Console.WriteLine("Choose how you want to enter the words \n 1 - Json" +
                    "\n 2 - Enter it yourself ");
                    var userChoise = Convert.ToInt32(Console.ReadLine());

                    if (userChoise == 1)
                    {
                        TaskParams task = new TaskParams();
                        string workingDirectory = Environment.CurrentDirectory;
                        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                        var path = $"{projectDirectory}\\Data\\data.json";
                        task = DataSerializer.JsonDeserialize(typeof(TaskParams), path) as TaskParams;
                        StringBuilder stringBuilder = new StringBuilder();

                        foreach(string value in task.Str )
                        {
                            stringBuilder.Append(value);
                            stringBuilder.Append(' ');
                        }

                        userWords = stringBuilder.ToString();
                        Console.WriteLine(userWords);
                    }

                    if (userChoise == 2)
                    {
                        Console.WriteLine($"Enter words separated by a space character ");
                        userWords = Console.ReadLine();
                    }

                    Console.WriteLine(LongestAbecedarianWord.FindLongestAbecedarian(userWords));
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

            OutputCasesandReadingUserChoice();
        }
    }
}
