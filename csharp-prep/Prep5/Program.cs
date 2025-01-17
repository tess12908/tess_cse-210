using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage(); 
        string name = UserInputName(); 
        int number = UserInputNumber(); 
        int squared = Squared(number); 
        DisplayResult(name, squared); 

    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Hello and welcome to the program!");
    }

    static string UserInputName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name; 
    }

    static int UserInputNumber()
    {
        Console.WriteLine("Please enter your fav. number: ");
        int number = int.Parse(Console.ReadLine());
        return number; 
    }

    static int Squared(int Number)
    {
        int Squared = Number * Number; 
        return Squared; 
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

}