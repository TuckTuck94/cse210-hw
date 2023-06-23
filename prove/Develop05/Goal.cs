abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _iscomplete;
    public Goal(string name, string description, int points)
    {
        _name = name; 
        _description = description;
        _points = points;
        _iscomplete = false;
    }

    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name; 
        _description = description;
        _points = points;
        _iscomplete = isComplete;
    }

    public bool GetIsComplete()
    {
        return _iscomplete;
    }
    
    public virtual void  DisplayGoal()
    {
        Console.Write($"{_name}, {_description}");
    }

    public abstract double RecordEvent();
}