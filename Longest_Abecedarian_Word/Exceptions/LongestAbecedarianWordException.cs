using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
