abstract class Activity
{
    protected string _date;
    protected int _duration; 
    //private double _speed; 

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
        //_speed = speed; 
    }

     public int GetDuration()
    {
        return _duration;
    }

    public string GetDate()
    {
        return _date;
    }
    
    public virtual double GetDistance() 
    {
        return 0; 
    }
    public virtual double GetSpeed() 
    { 
        return 0; 
    }
    public virtual double GetPace() 
    { 
        return 0; 
    }

    public virtual string GetSummary()
    {
        return $"{_date}\n{GetType().Name} ({_duration} min)\nDistance: {GetDistance():F2} miles\nSpeed: {GetSpeed():F2} MPH\nPace: {GetPace():F2} min per mile";
    }
}
