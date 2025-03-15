using System;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {
        bool running = true; 
        while(running == true)
        {
            Menu Menu = new Menu();
            int Score = Menu.ShowScore(); 
            Console.WriteLine($"Points:{Score}"); 
            Console.WriteLine(""); 
            string userChoice = Menu.MenuDisplay();

            if (userChoice == "1") // create new goal 
            {
                Console.WriteLine("The type of Goals are:"); 
                Console.WriteLine("1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal"); 
                string choiceOfGoal = Console.ReadLine(); 
                Menu.CreateGoal(choiceOfGoal);
                running = true; 
            }
            else if(userChoice == "2") // List Goals 
            {
                Menu.DisplayGoals();
                running = true;    
            }
            else if(userChoice == "3") // Save Goals 
            {
                Console.WriteLine("What do you want to name the txt file? Format as 'name.txt' "); 
                string fileName = Console.ReadLine(); 
                Menu.SaveGoals(fileName); 
                running = true;
            }
            else if(userChoice == "4") //Load Goals 
            {
                Console.WriteLine("What is the name of the TXT file you want to access? Format as 'name.txt'"); 
                string fileName = Console.ReadLine();
                Menu.LoadGoals( fileName);
                running = true; 
            }
            else if(userChoice == "5") // Record Event 
            {
                Menu.DisplayGoals(); 
                Menu.RecordEvent();
                running = true; 
            }
            else if(userChoice == "6") // quit 
            {
                running=false; 
            }

        }
    }
}

// why is it not showing the points as the program goes on 
// my goals are not being listed... is it pulling from the list? 
// why is it not loading goals... lots of error messages 
// save is broken 