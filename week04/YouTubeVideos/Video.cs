
public class Video
{
    public string _title;
    public string _author;
    public int _videoLength;
    
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int videoLength)
{
    _title = title;
    _author = author;
    _videoLength = videoLength;
}

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayComment()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplayText());
        }
    }
    
}