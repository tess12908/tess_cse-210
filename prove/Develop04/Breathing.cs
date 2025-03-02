using System;
using System.Threading;

public class Breathing : Activity
{
    public Breathing() : base("","",  0,  "breath")
    { }

    public void StartBreathingActivity()
    {
        Console.WriteLine(getIntro()); // general welcome line 
        Console.WriteLine(""); 
        Console.WriteLine(SetDiscription("breath"));  // explains the breath program 
        Console.WriteLine("");
        int duration = setDuration(0); // find out what the user wants the duration to be 
        Console.Clear();
        Console.WriteLine("Get ready to start...");
        Spinner(5); 
        
        int timeElapsed = 0;
        DateTime startTime = DateTime.Now;

        while (timeElapsed <= duration)
        {
            Console.Clear();
            Console.WriteLine("Breathe in...");
            Countdown(3); 
            Console.Clear();
            Console.WriteLine("Breathe out...");
            Countdown(3); 
            Console.Clear();
            timeElapsed = (int)(DateTime.Now - startTime).TotalSeconds;
        }

        Console.WriteLine(getEnd()); // general end phrase 
        Spinner(5); 
        Console.Clear();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds...");
            Thread.Sleep(1000); 
        }
    }
}
