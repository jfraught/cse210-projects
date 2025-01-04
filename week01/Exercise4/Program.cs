using System;
using System.Collections.Generic;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        int currentNumber = -1;
        List<int> numbers = []; // used the suggestion to simplify from VS Code 

        do 
        {
            Console.Write("Enter number: ");

            string userNumberInput = Console.ReadLine();
            currentNumber = int.Parse(userNumberInput);

            if (currentNumber != 0) 
            {
                numbers.Add(currentNumber);
            }
        } while (currentNumber != 0);

        // Found the higher-order functions for some of these
        int sum = numbers.Sum();
        double average = Queryable.Average(numbers.AsQueryable());
        int largest = numbers.Max();
        int smallestPositive = largest;
        foreach (int number in numbers)
        {
            if (number > 0 && number < largest)
            {
                smallestPositive = number;
            }
        }
        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine($"The list in sorted order is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}