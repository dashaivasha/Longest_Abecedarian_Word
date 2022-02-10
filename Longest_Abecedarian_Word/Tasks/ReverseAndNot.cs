using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
