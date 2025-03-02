public class Listing : Activity
{

    List<string> ponderQuestions = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    public Listing() : base("","",  0,  "Listing")
    { }

    public void StartListingActivity()
    {
        Console.WriteLine(getIntro()); // general welcome line
        Console.WriteLine(""); 
        Console.WriteLine(SetDiscription("listing")); // show Listing intro 
        Console.WriteLine(""); 

        int duration = setDuration(0); // find out what the user wants the duration to be 
        Console.Write("Ok getting it ready now"); 
        Spinner(5);
        Console.Clear();

        Random rnd = new Random();
        int randomReflectionIndex = rnd.Next(ponderQuestions.Count);

        Console.Write("List as many things as you can for the following prompt::"); 
        Console.WriteLine($"---{ponderQuestions[randomReflectionIndex]}---"); // Print actual reflection prompt
        Countdown(3); 
        Console.Clear();

        Console.Clear();
        Console.WriteLine($"Start listing your thoughts for the prompt: {ponderQuestions[randomReflectionIndex]}");
        Console.WriteLine("Press 'Enter' after each item. Type 'done' when you are finished.");

        List<string> userEntries = new List<string>(); // List to hold user's responses
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine().Trim();

            if (input.ToLower() == "done")
            {
                break;
            } 
            else if (!string.IsNullOrEmpty(input))
            {
                userEntries.Add(input);
            }
            //timeElapsed = (int)(DateTime.Now - startTime).TotalSeconds;
        }

        Console.WriteLine($"\nYou listed {userEntries.Count} item(s). Great job!"); // Display how many items were entered
        Console.WriteLine(getEnd()); // general end phrase 
        Spinner(5); 
        Console.Clear();
    } 

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Begin in: {i} seconds...");
            Thread.Sleep(1000); 
        }
    }



} 