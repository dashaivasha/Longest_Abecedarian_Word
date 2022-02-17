namespace InternshipProject.Tasks
{
    public interface IStudent
    {
        string[] TestsTaken { get; }
        void TakeTest(ITestpaper paper, string[] answers);
    }
}
