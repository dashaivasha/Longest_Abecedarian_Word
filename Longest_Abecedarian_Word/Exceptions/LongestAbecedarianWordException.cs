using System;

namespace InternshipProject.Exceptions
{
    public class LongestAbecedarianWordException : Exception
    {
        public LongestAbecedarianWordException(string message) : base(message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
    }
}
