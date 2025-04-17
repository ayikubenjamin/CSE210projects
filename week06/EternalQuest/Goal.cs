public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public virtual int GetEarnedPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    

    public abstract bool IsCompleted();
   

    public virtual string GetDetailsString()
    {
        string checkBox = IsCompleted() ? "[X]" : "[]"; 
        return $"{checkBox} {_shortName} - {_description}";
    }

    public abstract string GetStringRepresentation();

    public string GetShortName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public static Goal CreateFromString(string line)
    {
        
        string[] parts = line.Split(':');
        string goalType = parts[0];
        string[] parameters = parts[1].Split(',');

        switch (goalType)
        {
            case "SimpleGoal":
                var simple = new SimpleGoal(parameters[0], parameters[1], int.Parse(parameters[2]));
                if (parameters.Length > 3 && bool.TryParse(parameters[3], out bool isComplete))
                {
                    simple.SetCompletionStatus(isComplete);
                }
                return simple;

            case "EternalGoal":
                return new EternalGoal(parameters[0], parameters[1], int.Parse(parameters[2]));

            case "CheckListGoal":
                var checklist = new CheckListGoal(
                    parameters[0],
                    parameters[1],
                    int.Parse(parameters[2]),
                    int.Parse(parameters[3]),
                    int.Parse(parameters[4])
                );
                if (parameters.Length > 5)
                {
                    checklist.SetAmountCompleted(int.Parse(parameters[5]));
                }
                return checklist;

            default:
                throw new Exception("Unknown goal type");
        }
    }
    
}

