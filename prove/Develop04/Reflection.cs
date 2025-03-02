using System;
using System.Collections.Generic;
using System.Threading;

public class Reflection : Activity
{
    List<string> reflections = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    List<string> reflectiveQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection() : base("", "", 0, "reflection")
    { }

    public void StartReflectionActivity()
    {
        Console.WriteLine(getIntro()); // general welcome line
        Console.WriteLine(""); 
        Console.WriteLine(SetDiscription("reflection")); // show reflection intro 
        Console.WriteLine(""); 

        int duration = setDuration(0); // find out what the user wants the duration to be 
        Console.Write("Ok getting it ready now"); 
        Spinner(5);
        Console.Clear();

        Random rnd = new Random();
        int randomReflectionIndex = rnd.Next(reflections.Count);

        Console.Write("Consider the following prompt:"); 
        Console.WriteLine($"---{reflections[randomReflectionIndex]}---"); // Print actual reflection prompt
        Console.WriteLine("When you are ready for the following questions, press enter"); 
        string userClickedEnter = Console.ReadLine(); 

        if (userClickedEnter == "")
        { 
            Console.Write($"Please take this time to answer these follow-up questions to help you reflect. Click enter for a new question. This will run for {duration} seconds."); 
            Countdown(3); 

            int timeElapsed = 0;
            DateTime startTime = DateTime.Now;
            while (timeElapsed <= duration)
            {
                Console.Clear();
                Console.WriteLine($"---{reflections[randomReflectionIndex]}---");
                int timeLeft = duration - timeElapsed; 
                Console.WriteLine($"Time left is: {timeLeft}"); 
                Console.WriteLine("");
                int randomQuestionIndex = rnd.Next(reflectiveQuestions.Count);
                Console.Write(reflectiveQuestions[randomQuestionIndex]); // Print random reflective question
                string userInput = Console.ReadLine();
            
                if (userInput == "")
                { 
                    Console.WriteLine(reflectiveQuestions[randomQuestionIndex]);// Print a new random reflective question
                }
                timeElapsed = (int)(DateTime.Now - startTime).TotalSeconds;
            } 
        }
        else 
        { 
            Console.WriteLine("That is not a valid entry"); 
        }

        Console.WriteLine(getEnd()); // general end phrase 
        Spinner(5); 
        Console.Clear();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Starting in: {i} seconds...");
            Thread.Sleep(1000); 
        }
    }
}
