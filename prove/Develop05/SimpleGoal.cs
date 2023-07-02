class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _iscomplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _iscomplete = isComplete;
    }

    
    public override double RecordEvent()
    {
        _iscomplete = true;
        Console.WriteLine($"Congratulations, you completed your task! You have earned {_points} points!");
        return _points;
    }


}
