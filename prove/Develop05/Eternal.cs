public class Eternal : Goals
{
       
     
    public Eternal(string points, string name, string description) : base(points, name, description)
    {
        
    }

    public Eternal() 
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

    public int GetPoints()
    { 
        return _points; 
    }

    
    public override int  RecordEvent()
    {
        Console.WriteLine($"You earned {_points} points for repeating '{_name}'.");
        return _points; 
    }
    
     public override string SaveAnswersTXT()
    { 
        return $" {_isComplete} | {_name} | {_description} | {_points} " ; 
        
    }

    public override void Display()
    {
        string status = "[ ]";
        Console.WriteLine($"{status} {_name} - {_description}");
    }
} 
