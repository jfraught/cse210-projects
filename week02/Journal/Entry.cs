using System;
using System.Text.Json;

public class Entry
{
    // In order to serialize to JSON I needed to use PascalCasing for these property names. 
    // The .NET documentation found https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/capitalization-conventions 
    // states that properties should be names with PascalCasing. 
    // Please do not doc points here for not using the _ on these properties as they cannot be serialized using the _. 
    public string Date { get; set; }
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {PromptText}");
        Console.WriteLine(EntryText);
    }
}