public abstract class Goals

{ 
    protected string _name; 
    protected string _description; 
    protected bool _isComplete; 
    protected int _points; 

    public Goals(string points, string name, string description)
    {
        this._name = name; 
        this._description = description; 
        this._points = int.Parse(points); 
        //_isComplete = isComplete;  
    }

    public Goals ()
    {

    }

    public string GetName()
    {
        Console.WriteLine("What is the name of your goal"); 
        string _name = Console.ReadLine();
        return _name;
    }

    public string GetDescription()
    {
        Console.WriteLine("What is a short description of your goal"); 
        string _description = Console.ReadLine(); 
        return _description;
    }
    public int GetThePoints()
    { 
        return _points; 
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public bool MarkComplete()
    { 
        return true; 
    }

    public abstract string SaveAnswersTXT(); 
    public abstract int RecordEvent();
    public abstract void Display();  

   




    

}