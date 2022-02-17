using System;
using System.Collections.Generic;
using System.Linq;

namespace InternshipProject.Tasks
{ 
    public class Testpaper : ITestpaper
    {
        public Testpaper(string subject, string markScheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark;
        }

        public string Subject { get; private set; }
        public string MarkScheme { get; private set; }
        public string PassMark { get; private set; }
    }
}
