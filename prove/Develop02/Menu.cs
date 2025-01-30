using System.Security.Cryptography.X509Certificates;
using System.IO;

public  class Menu
{  
    public void MenuLoop()
    { 
        Journal journalOne = new Journal(); 

        int MenuChoice = 0; 
        while (MenuChoice != 5 )

        {

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1.Write \n2.Display \n3.Load \n4.Save \n5.Quit"); 
            Console.Write("What would you like to do?");   
            MenuChoice = Convert.ToInt32(Console.ReadLine());

             
            if (MenuChoice == 1)
            {
                journalOne.WriteNewEntry(); 
            }
            else if (MenuChoice == 2)
            {
                journalOne.Display(); 
            }
            else if (MenuChoice == 3)
            {
                Console.WriteLine("What file do you want to find?"); 
                string FindFileName = Console.ReadLine(); 

                string[] lines = System.IO.File.ReadAllLines(FindFileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("~");
                    string  _entryDate= parts[0];
                    string _entryTitle = parts[1]; 
                    string _entryPrompt = parts[2];
                    string _entryResponce = parts[3];
                    journalOne.AddFromFile(_entryDate, _entryTitle, _entryPrompt, _entryResponce); 
                }
            } 
            else if (MenuChoice == 4)
            {
                Console.WriteLine("What do you want the filename to be? "); 
                string fileName = Console.ReadLine(); 
                
                using (StreamWriter outputFile = new StreamWriter(fileName))
                    { 
                        outputFile.WriteLine($" {journalOne.ReturnListOfEntry()}");
                    }
            }
        }
    } 

} 