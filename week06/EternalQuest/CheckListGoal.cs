public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public CheckListGoal(string name, string description, int points,  int target, int bonus ) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public void SetAmountCompleted(int count)
    {
        _amountCompleted = count;
    }


    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted ++;
            Console.WriteLine($"Congrats, you have gained {_points} points");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congrats, You've earned a {_bonus} bonus points");
            }
        }
        else 
        {
            Console.WriteLine("Goal completed already");
        }
    }

    public override bool IsCompleted()
    {
        if(_amountCompleted >= _target)
        {
            return true;
        }
        else 
            return false;
    }

    public override string GetDetailsString()
    {
        string checkBox = IsCompleted() ? "[X]" : "[ ]"; 
        return $"{checkBox} {_shortName} - {_description}, currently completed {_amountCompleted}/{_target}";

    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";

    }

    public override int GetEarnedPoints()
    {
        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        return _points;
    }

}