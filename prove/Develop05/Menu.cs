public class Menu
{
    private static List<Goals> _goals = new List<Goals>();
    private int score = 0;


    public List<String> BasicQuestions() 
    {

        List<String> Questions = new List<String>();

        Console.WriteLine("What is the name of your goal"); 
        string _name = Console.ReadLine(); 
        Questions.Add(_name); 

        Console.WriteLine("What is a short description of your goal"); 
        string _description = Console.ReadLine(); 
        Questions.Add(_description); 

        Console.WriteLine("How many points will it be worth"); 
        string _points = Console.ReadLine();
        Questions.Add(_points); 

        return Questions;  

    }

    public List<int> AddOnQuestions()
    { 
        List<int> Questions = new List<int>();
        Console.WriteLine("How many times does this goal need to be completed for a bonus?"); 
        int _targetCount = int.Parse(Console.ReadLine()); 
        Questions.Add(_targetCount); 
        Console.WriteLine($"What is the bonus for completing it {_targetCount} times?"); 
        int _bonus = int.Parse(Console.ReadLine()); 
        Questions.Add(_bonus); 

        return Questions; 
    }
    public string MenuDisplay()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create a new Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("What would you like to do? ");
        return Console.ReadLine();
    }

    public int ShowScore()
    {
        return score;
    }

    public void CreateGoal(string choiceOfGoal)
    {
        //Goals newGoal = new Goals(); 

        if (choiceOfGoal == "1") 
        {
            List<String> BasicQ = new List<String>();
            BasicQ = BasicQuestions(); 
            //List<string> Menu.BasicQuestions()
            Simple newGoal = new Simple(BasicQ[2], BasicQ[0], BasicQ[1]);
            //newGoal.Simple();
            _goals.Add(newGoal); 

        }
        else if (choiceOfGoal == "2") 
        {
            List<String> BasicQ = new List<String>();
            BasicQ = BasicQuestions(); 
            Eternal newGoal = new Eternal(BasicQ[2], BasicQ[0], BasicQ[1]);
            //newGoal.Simple();
            _goals.Add(newGoal); 
        }
        else if (choiceOfGoal == "3") 
        {
            List<String> BasicQ = new List<String>();
            BasicQ = BasicQuestions(); 
            List <int> NewQ= AddOnQuestions(); 
            Check newGoal = new Check(NewQ[0], NewQ[1], BasicQ[2], BasicQ[0], BasicQ[1]);
            //newGoal.Simple();
            _goals.Add(newGoal); 
        }
        else
        {
            Console.WriteLine("Wrong answer");
            return;
        }

    }


    public void DisplayGoals()
    {
      //int index = 1;
        foreach (var goal in _goals)
        {
            goal.Display();
        }
    }

    //public void RecordEvent()
    //{
        //DisplayGoals();
        //Console.Write("Enter goal number: ");
        //int choice = int.Parse(Console.ReadLine());
        //_goals[choice - 1].RecordEvent();
    //}

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        DisplayGoals();

        Console.Write("Enter goal number to record an event: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            Goals selectedGoal = _goals[choice - 1];
            selectedGoal.RecordEvent();

            // Update the score
            score += selectedGoal.GetThePoints();
            Console.WriteLine($"Event recorded! Your new score is: {score}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }
    }

    public void SaveGoals(string filename) 
    {
        Console.WriteLine("Saving Goals...");

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename, false, System.Text.Encoding.UTF8))
            {
                // Save the total score at the top of the file
                outputFile.WriteLine(score);

                // Loop through each goal and save its details
                foreach (Goals goal in _goals)
                {
                    if (goal is Simple simpleGoal)
                    {
                        outputFile.WriteLine($"Simple,{simpleGoal.GetTitle()},{simpleGoal.GetTheDescription()},{simpleGoal.GetPoints()},{simpleGoal.GetIsComplete()}");
                    }
                    else if (goal is Eternal eternalGoal)
                    {
                        outputFile.WriteLine($"Eternal,{eternalGoal.GetTitle()},{eternalGoal.GetDescription()},{eternalGoal.GetPoints()}");
                    }
                    else if (goal is Check checklistGoal)
                    {
                        outputFile.WriteLine($"Checklist,{checklistGoal.GetTitle()},{checklistGoal.GetDescription()},{checklistGoal.GetPoints()},{checklistGoal.GetTimesCompleted()},{checklistGoal.GetTargetCount()},{checklistGoal.GetIsComplete()},{checklistGoal.GetBonus()}");
                    }
                }
            }
            Console.WriteLine($"Goals saved successfully! Check '{filename}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved goals found!");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(filename);
            
            if (lines.Length > 0)
            {
                // Load the score from the first line
                score = int.Parse(lines[0]);
                Console.WriteLine($"Total Points: {score}");

                _goals.Clear(); // Clear existing goals before loading new ones

                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] parts = line.Split('|');

                    if (parts.Length > 0)
                    {
                        string goalType = parts[0].Trim();
                        Goals goal = null;

                        if (goalType == "Simple" && parts.Length == 4)
                        {
                            string title = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);
                            bool completed = bool.Parse(parts[4]);

                            goal = new Simple(points.ToString(), title, description);
                            if (completed) goal.MarkComplete();
                        }
                        else if (goalType == "Eternal" && parts.Length == 3)
                        {
                            string title = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);

                            goal = new Eternal(points.ToString(), title, description);
                        }
                        else if (goalType == "Checklist" && parts.Length == 7)
                        {
                            string title = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);
                            int currentCount = int.Parse(parts[4]);
                            int targetCount = int.Parse(parts[5]);
                            bool completed = bool.Parse(parts[6]);
                            int bonus = int.Parse(parts[7]);

                            goal = new Check(targetCount, bonus, points.ToString(), title, description);
                            for (int j = 0; j < currentCount; j++) 
                            {
                                goal.RecordEvent();
                            }
                            if (completed) goal.MarkComplete();
                        }
                        else
                        {
                            Console.WriteLine($"Skipping invalid line: {line}");
                        }

                        if (goal != null)
                        {
                            _goals.Add(goal);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Skipping malformed line: {line}");
                    }
                }
            }
            else
            {
                Console.WriteLine("File is empty!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

}