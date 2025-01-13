using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int choice = -1;
        Journal journal = new Journal();

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out choice))
            {
                switch (choice)
                {
                    case 1:
                        string promptText = PromptGenerator.GetRandomPrompt();
                        Console.WriteLine(promptText);
                        string entryText = Console.ReadLine();
                        DateTime currentDate = DateTime.Now;
                        string date = currentDate.ToShortDateString();
                        Entry newEntry = new Entry(date, promptText, entryText);
                        journal.AddEntry(newEntry);
                        break;
                    case 2:
                        journal.DisplayAll();
                        break;
                    case 3:
                        journal.LoadFromFile();
                        break;
                    case 4:
                        journal.SaveToFile();
                        break;
                    case 5:
                        Console.WriteLine("Quitting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}