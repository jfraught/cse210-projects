using System;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private readonly string file = "journal.txt";
    // Exceed expectations. I added a readonly property because I didn't like the user inputing the file. 

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }

    // Exceed expectations. I like JSON so I used that instead of the CSV stuff. 
    public void SaveToFile()
    {
        string jsonString = JsonSerializer.Serialize(_entries);
        File.WriteAllText(file, jsonString);
    }

    public void LoadFromFile()
    {
        if (File.Exists(file))
        {
            string jsonString = File.ReadAllText(file);
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
        }
    }
}
