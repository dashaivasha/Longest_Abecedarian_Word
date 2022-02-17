using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipProject.Tasks.TeachersTest
{
    public class Student : IStudent
    {
        private Dictionary<ITestpaper, string[]> _papers = new Dictionary<ITestpaper, string[]>();
        public string[] TestsTaken
        {
            get
            {
                List<string> results = new List<string>();

                if (_papers.Count == 0)
                {
                    results.Add("No tests taken");
                    return results.ToArray();
                }

                foreach (var paper in _papers.OrderBy(p => p.Key.Subject))
                {
                    var score = 0;

                    for (int i = 0; i < paper.Key.MarkScheme.Length; i++)
                    {
                        if (paper.Key.MarkScheme == paper.Value[i])
                        {
                            score++;
                        }
                    }

                    var result = Math.Ceiling(decimal.Divide(100, paper.Key.MarkScheme.Length) * score);
                    var passed = int.Parse(paper.Key.PassMark.TrimEnd('%'));
                    results.Add(string.Format("{0} : {1}! ({2}%)", paper.Key.Subject, result >= passed ? "Passed" : "Failed", result));
                }

                return results.ToArray();
            }
        }

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            this._papers.Add(paper, answers);
        }

    }
}
