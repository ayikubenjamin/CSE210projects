public class MathAssigment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssigment(string studentName, string topic, string textbooksection, string problems) :base(studentName, topic)
    {
        _textbookSection = textbooksection;
        _problems = problems;
    }

    public string HomeWorkList()
    {
        return $"{_textbookSection} {_problems}";
    }
}