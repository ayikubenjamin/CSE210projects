public class SimpleGoal : Goal
{
    private bool _isComplete;


    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public void SetCompletionStatus(bool status)
    {
        _isComplete = status;
    }


    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points.");
    }


    public override bool IsCompleted()
    {
       return _isComplete;
    }


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }


}