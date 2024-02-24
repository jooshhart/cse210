public class Writing : Base
{
    private string _title;
    public Writing(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWriting()
    {
        string studentName = GetStudent();
        return $"{_title} by {studentName}";
    }
}