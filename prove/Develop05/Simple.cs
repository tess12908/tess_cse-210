// this class needs to 
public class Simple : Goals
{ 
    
    public Simple (string _points, string _name, string _description) : base(_points, _name,_description) 
    { 
       
    }

    public Simple()
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
     public override string SaveAnswersTXT()
    { 
        return $" {_isComplete} | {_name} | {_description} | {_points} " ; 
        
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            //score += _points;
            Console.WriteLine($"Goal '{_name}' completed! You earned {_points} points.");
            return _points; 
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' is already completed.");
            return 0; 
        }
    }

    public override void Display()
    {
        string status = "[]";
        

        if (_isComplete == true)
        { 
            status = "[x]";
            Console.WriteLine($"{status} {_name} - {_description}");
        } 
        else if (_isComplete == false)
        { 
            status = "[]";
            Console.WriteLine($"{status} {_name} - {_description}");

        }

    }


}