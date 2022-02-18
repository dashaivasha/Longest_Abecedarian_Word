namespace InternshipProject.Tasks
{
    public interface ITestpaper
    {
        string Subject { get; }
        string[] MarkScheme { get; }
        string PassMark { get; }
    }
}
