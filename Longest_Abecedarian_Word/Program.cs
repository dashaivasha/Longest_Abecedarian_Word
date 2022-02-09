using Longest_Abecedarian_Word.ConsoleMenu;
using System;


namespace Longest_Abecedarian_Word
{
    class Program
    {
        static Menu menu = new Menu();
        static void Main(string[] args)
        {
            Menu.Actions[] ArrayActions = { Menu.Actions.FindLongestAbecedarianWord, Menu.Actions.SecondTask, Menu.Actions.CloseTask, Menu.Actions.Exit };
            Console.WriteLine("Please enter a number to choose your action");
            var IndexOfChoise = 1;

            for (int i = 0; i < ArrayActions.Length; i++)
            {
                Console.WriteLine("[{0}] = {1}", IndexOfChoise++, ArrayActions[i]);
            }

            var UserChoice = Convert.ToInt32(Console.ReadLine());
            Menu.Actions action = ArrayActions[--UserChoice];
            menu.Run(action);
        }
    }
}
