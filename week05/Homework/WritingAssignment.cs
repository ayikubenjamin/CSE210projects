public class WritingAssingment : Assignment
{
    private string _title;

    public WritingAssingment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    

    public string GetWritingInfo()
    {
        return $"{_title} by {GetStudentName()}";
    }

}