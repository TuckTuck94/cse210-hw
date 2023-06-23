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
    public ChecklistGoal(string name, string description, int points, bool isComplete, int bonuspoints, int target) : base(name, description, points, isComplete)
    {
        _bonuspoints = bonuspoints;
        _target = target; 
    }

    public override double RecordEvent()
    {
        // increment our quantity
        // check if they have reached thier target
        // award bonus points if they hit the target and set goal to completed
        // otherwise just awrd normal points
        return 0.0;
    }
}
