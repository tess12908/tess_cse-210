using System;

class Program
{
    static void Main(string[] args)
    {
        //call the scripture class in a while loop and clear the console here  
        bool keepRunning = true; 


        Console.WriteLine("What scripture do you want to work on memorizing?"); 
        Console.Write("A for 1st Nephi 3:7 - B for Moroni 10:3-5 - C for D&C 6:36-37"); 
        string userChoice = Console.ReadLine(); 
         

        Scripture scripture = new Scripture(userChoice.ToLower()); 

        Console.Clear(); 
        while (keepRunning == true) 
        { 
            scripture.DisplayScripture(); 
            Console.Write("\nPress enter to hide a word // quit to exit// u to undhide a word "); 
            string running = Console.ReadLine(); 
            Console.Clear(); 

            if(scripture.IsAllHiden() || running.ToLower() == "quit")
            {
                Environment.Exit(0); 
            }
            else if (running.ToLower()  == "u" )
            { 
                scripture.UnhideWord(); 
            }
            else
            {
                scripture.HideWords(); 
            }
        }
    }
}