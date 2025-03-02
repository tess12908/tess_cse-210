using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _introPhrase; 
    private string _endPhrase; 
    private int _duration; 
    private string _discription; 
    

    public Activity(string introPhrase, string endPhrase, int duration, string discription)
    { 
        introPhrase = _introPhrase; 
        endPhrase = _endPhrase; 
        duration = _duration; 
        discription = _discription; 

    }

    public void Spinner(int time) // shows the spinner for x amount of time 
    {
        int i = 0; 
        while ( i < time)
        {
            Console.Write("/");  
            Thread.Sleep(250);
            Console.Write("\b"); 

            Console.Write("-");  
            Thread.Sleep(250);
            Console.Write("\b"); 
            
            Console.Write("\\");  
            Thread.Sleep(250);
            Console.Write("\b");

            Console.Write("|");  
            Thread.Sleep(250);
            Console.Write("\b");
            i += 1; 
        } 
    }

    public string getIntro() // getter for the intro 
    { 
        _introPhrase = "Welcome to the mindfulness function. We hope that we can help calm you and help you have a positive experience being mindful"; 
       return _introPhrase; 
    }

    public string getEnd()
    { 
        _endPhrase = "We hope this activity helped cultivate mindfulness and helped create a calming effect"; 
        return _endPhrase; 
    }

    public int setDuration(int userDuration)
    {
        Console.Write("What would you like the duration to be?"); 
        userDuration = int.Parse(Console.ReadLine());
        return userDuration; 
    }

    public string SetDiscription(string userChoice) 
    { 
         if (userChoice.ToLower() == "breath")
        {
            _discription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."; 
            return _discription; 
        }
        else if (userChoice.ToLower() == "reflection")
        {
            _discription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            return _discription; 
        }
        else if (userChoice.ToLower() == "listing")
        {
            _discription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."; 
            return _discription;
        }

        return "Unknown activity";
    }


}