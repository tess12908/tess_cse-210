using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First name?"); 
        string first_name = Console.ReadLine(); 

        Console.Write("What is your Last name?"); 
        string last_name = Console.ReadLine(); 

        Console.WriteLine($"{last_name}, {first_name} {last_name}");
    }
}