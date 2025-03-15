public class Check : Goals
{ 
    private int _timeCompleted = 0; 
    private int _targetCount; 
    private int _bonus; 
    

    public Check(int targetCount, int bonus, string _points, string _name, string _description) : base(_points,_name,_description)
    { 
        //this._timeCompleted = timeCompleted; 
        this._targetCount = targetCount; 
        this._bonus = bonus; 

    }

    public Check() 
    { 
        
    }

    public string GetTitle()
    { 
        return _name; 
    }
    public string GetTheDescription()
    { 
        return _description; 
    }
    

    public int GetTimesCompleted()
    {
        return _timeCompleted;
    }

    public int GetTargetCount()
    {
        return _targetCount;
    }

    public int GetBonus()
    {
        return _bonus; 
    }

    public int GetPoints()
    { 
        return _points; 
    }
        
   
    public override int RecordEvent()
    {
        _timeCompleted++;

        if (_timeCompleted >= _targetCount)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{_name}' completed! You earned a bonus of {_bonus} points.");
            return _points +_bonus;

        }
        return _points; 
    }

     public override string SaveAnswersTXT()
    { 
        return $" {_isComplete} | {_name} | {_description} | {_timeCompleted} | {_targetCount} | {_bonus} " ; 
        
    }


    public override void Display()
    {
        string status = $"Completed {_timeCompleted}/{_targetCount}";
        Console.WriteLine($"{status} {_name} - {_description}");
        
    }
}