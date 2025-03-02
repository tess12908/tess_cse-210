using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("A - Breathing Activity");
        Console.WriteLine("B - Reflection Activity");
        Console.WriteLine("C - Listing Activity");

        
        string userInput = Console.ReadLine().ToUpper();  // Get user input

        if (userInput == "A")
        {
            Console.Clear();
            Breathing breathingActivity = new Breathing();
            breathingActivity.StartBreathingActivity();
        }
        else if (userInput == "B")
        {
            Console.Clear();
            Reflection reflectionActivity = new Reflection();
            reflectionActivity.StartReflectionActivity();
        }
        else if (userInput == "C")
        {
            Console.Clear();
            Listing listingActivity = new Listing();
            listingActivity.StartListingActivity();
        }
        else
        {
            Console.WriteLine("Invalid option. Please choose A, B, or C.");
        }
    }
}
