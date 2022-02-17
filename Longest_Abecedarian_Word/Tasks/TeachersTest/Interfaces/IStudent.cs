using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipProject.Tasks
{
    public interface IStudent
    {
        string[] TestsTaken { get; }
        void TakeTest(ITestpaper paper, string[] answers);
    }
}
