using System;

class Program
{
    /*Random randomGenerator = new Random();
        int Magic_num = randomGenerator.Next(1, 11);
        int Guess = -3; 
        
        while (Guess != Magic_num)
        {
            Console.WriteLine(" Guess a number");
            Guess = int.Parse(Console.ReadLine());

            if (Guess!> Magic_num)
            {
                Console.WriteLine(" To large");
            } 

            if (Guess!< Magic_num)
            {
                Console.WriteLine(" To small");
            }  
        */ 
        static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}