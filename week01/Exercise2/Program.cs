using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        int lastDigit = percentage % 10;

        string letter;
        string symbol = "";

        if (percentage >= 90) 
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        if (lastDigit >= 7 && letter != "F" && letter != "A")
        {
            symbol = "+";
        }
        else if (lastDigit < 3 && letter != "F") 
        {
            symbol = "-";
        }

        Console.WriteLine($"You have a {letter}{symbol}");
        if (percentage >= 70)
        {
            Console.WriteLine("Congrats. You passed.");
        }
        else
        {
            Console.WriteLine("Womp womp. You failed.");
        }
    }
}