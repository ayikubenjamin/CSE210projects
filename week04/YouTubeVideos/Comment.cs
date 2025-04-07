public class Comment
{
    private string _person;
    private string _commentText;

    public Comment(string person, string commentText)
    {
        _person = person;
        _commentText = commentText;
    }

    public string GetDisplayText()
    {
        return $"{_person} : {_commentText}";
    }
}