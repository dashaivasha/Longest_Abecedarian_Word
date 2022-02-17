using InternshipProject.Tasks;
using InternshipProject.Tasks.TeachersTest;
using System;
using System.IO;
using System.Text;
using static InternshipProject.ConsoleMenu.Enums.MenuActionsEnum;

namespace InternshipProject.ConsoleMenu
{
    public class Menu
    {
        private static int _userChoice;

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
                _userChoice = Convert.ToInt32(Console.ReadLine());
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
                Run(_userChoice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OutputCasesandReadingUserChoice();
            }
        }

        private static void Run(int actions)
        {
            switch (actions)
            {
                case (int)MenuActions.FindLongestAbecedarianWord:
                    Console.WriteLine($"Your choice {MenuActions.FindLongestAbecedarianWord}");
                    var userWords = string.Empty;
                    Console.WriteLine("Choose how you want to enter the words \n 1 - Json" +
                    "\n 2 - Enter it yourself ");
                    _userChoice = Convert.ToInt32(Console.ReadLine());

                    if (_userChoice == 1)
                    {
                        TaskParams task = new TaskParams();
                        string workingDirectory = Environment.CurrentDirectory;
                        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                        var path = $"{projectDirectory}\\Data\\data.json";
                        task = DataSerializer.JsonDeserialize(typeof(TaskParams), path) as TaskParams;
                        StringBuilder stringBuilder = new StringBuilder();

                        foreach (string value in task.Str)
                        {
                            stringBuilder.Append(value);
                            stringBuilder.Append(' ');
                        }

                        userWords = stringBuilder.ToString();
                    }

                    if (_userChoice == 2)
                    {
                        Console.WriteLine($"Enter words separated by a space character ");
                        userWords = Console.ReadLine();
                    }

                    Console.WriteLine(LongestAbecedarianWord.FindLongestAbecedarian(userWords));
                    break;
                case (int)MenuActions.ReverseAndNot:
                    Console.WriteLine($"Your choice {MenuActions.ReverseAndNot}");
                    Console.WriteLine("Choose how you want to enter the words \n 1 - Json" +
                    "\n 2 - Enter it yourself ");
                    _userChoice = Convert.ToInt32(Console.ReadLine());
                    string userNumber = string.Empty;

                    if (_userChoice == 1)
                    {
                        TaskParams task = new TaskParams();
                        string workingDirectory = Environment.CurrentDirectory;
                        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                        var path = $"{projectDirectory}\\Data\\dataReverseAndNot.json";
                        task = DataSerializer.JsonDeserialize(typeof(TaskParams), path) as TaskParams;
                        StringBuilder stringBuilder = new StringBuilder();

                        foreach (string value in task.Str)
                        {
                            stringBuilder.Append(value);
                        }

                        userNumber = stringBuilder.ToString();
                    }

                    if (_userChoice == 2)
                    {
                        Console.WriteLine($"Enter numbers");
                        userNumber = Console.ReadLine();
                    }

                    Console.WriteLine(ReverseAndNot.Reverse(Convert.ToInt32(userNumber)));
                    break;
                case (int)MenuActions.Circle:
                    Console.WriteLine($"Your choice {MenuActions.Circle}");
                    Console.WriteLine("Choose how you want to enter the words \n 1 - Json" +
                    "\n 2 - Enter it yourself ");
                    _userChoice = Convert.ToInt32(Console.ReadLine());
                    var dataForCircle = string.Empty;

                    if (_userChoice == 1)
                    {
                        TaskParams task = new TaskParams();
                        string workingDirectory = Environment.CurrentDirectory;
                        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                        var path = $"{projectDirectory}\\Data\\dataCircle.json";
                        task = DataSerializer.JsonDeserialize(typeof(TaskParams), path) as TaskParams;
                        StringBuilder stringBuilder = new StringBuilder();

                        foreach (string value in task.Str)
                        {
                            stringBuilder.Append(value);
                        }

                        dataForCircle = stringBuilder.ToString();
                    }

                    if (_userChoice == 2)
                    {
                        Console.WriteLine($"Enter numbers");
                        dataForCircle = Console.ReadLine();
                    }

                    Circle circle = new Circle(Convert.ToDouble(dataForCircle));
                    Console.WriteLine(circle.GetP() + "\n" + circle.GetS());
                    break;
                case (int)MenuActions.Tests:
                    var result = string.Empty;
                    Console.WriteLine($"Your choice {MenuActions.Tests}");
                    Console.WriteLine("Choose how you want to enter the words \n 1 - Get Test paper from Json" +
                    "\n 2 - Enter it yourself ");
                    _userChoice = Convert.ToInt32(Console.ReadLine());
                    if (_userChoice == 1)
                    {
                        Student student = new Student();
                        string workingDirectory = Environment.CurrentDirectory;
                        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                        var path = $"{projectDirectory}\\Data\\dataTests.json";
                        Testpaper testpaper = new Testpaper("Mathematics", new string[] { "1c", "2b", "3f" }, "60");
                        testpaper = DataSerializer.JsonDeserialize(typeof(Testpaper), path) as Testpaper;
                        StringBuilder stringBuilder = new StringBuilder();
                        Console.WriteLine("Enter answers");
                        var studentAnswers = Console.ReadLine();
                        string[] ArrayAnsw = studentAnswers.Split(' ');
                        student.TakeTest(testpaper, ArrayAnsw);

                        foreach (string value in student.TestsTaken)
                        {
                            stringBuilder.Append(value);
                        }

                        result = stringBuilder.ToString();
                        Console.WriteLine(result);
                    }

                    if (_userChoice == 2)
                    {
                        Console.WriteLine("How many tests to create?");
                        var count = Convert.ToInt32(Console.ReadLine());
                        string[] Arraysubjects = new string[count];
                        string[] ArraypassMark = new string[count];
                        Testpaper[] testpaper = new Testpaper[count];
                        var student = new Student();
                        StringBuilder stringBuilder = new StringBuilder();

                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Enter a subject name");
                            var subject = Console.ReadLine();
                            Arraysubjects[i] = subject;
                            Console.WriteLine("Enter a Mark Scheme (separated by a space character)");
                            var markScheme = Console.ReadLine();
                            string[] ArrayMarkScheme = markScheme.Split(' ');
                            Console.WriteLine("Enter a Pass Mark");
                            var passMark = Console.ReadLine();
                            ArraypassMark[i] = passMark;
                            testpaper[i] = new Testpaper(Arraysubjects[i], ArrayMarkScheme, ArraypassMark[i]);
                            Console.WriteLine("Enter answers");
                            var studentAnswers = Console.ReadLine();
                            string[] ArrayAnsw = studentAnswers.Split(' ');
                            student.TakeTest(testpaper[i], ArrayAnsw);

                            foreach (string value in student.TestsTaken)
                            {
                                stringBuilder.Append(value);
                            }

                            result = stringBuilder.ToString();
                            Console.WriteLine(result);
                        }
                    }
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