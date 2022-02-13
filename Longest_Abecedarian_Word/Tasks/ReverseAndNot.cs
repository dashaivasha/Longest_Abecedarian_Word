using System;
using System.Linq;

namespace InternshipProject.Tasks
{
    class ReverseAndNot
    {
        public static string Reverse(int number)
        {
            return $"Result: {String.Concat(number.ToString().Reverse())}{number}";
        }
    }
}
