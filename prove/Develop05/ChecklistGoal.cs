class ChecklistGoal : Goal
{
    private int _bonuspoints;
    private int _target;
    private int _quantity;
    
    public ChecklistGoal(string name, string description, int points, int bonuspoints, int target) : base(name, description, points)
    {
        _bonuspoints = bonuspoints;
        _target = target; 
    }

    public override double RecordEvent()
    {
        _quantity++;
        if(_quantity == _target)
        {
            _iscomplete = true;
            Console.WriteLine($"Congratulations, you reached your goal! You have earned {_points} points! In addition, you have earned {_bonuspoints} Bonus Points!");
            // return the points + bonus
            return _points + _bonuspoints;
        }
        Console.WriteLine($"Congratulations, you completed your task! You have earned {_points} points!");
        return _points;
    }
}
