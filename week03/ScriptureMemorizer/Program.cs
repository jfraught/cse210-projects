using System;
using System.Text.RegularExpressions;


class Program
{
    static void Main(string[] args)
    {
        string command = "";
        string text = "";
        string book = "";
        int chapter = -1;
        int verse = -1;
        int endVerse = -1;

        //Exceeds expectations: Added a file to load a random scripture from.
        string filename = "scriptures.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        Random random = new Random();
        int randomIndex = random.Next(lines.Length);
        string line = lines[randomIndex];
        string[] parts = Regex.Split(line, @",(?=\S)");

        text = parts[0];
        book = parts[1];
        chapter = int.Parse(parts[2]);
        verse = int.Parse(parts[3]);
        if (parts.Length > 4)
        {
            endVerse = int.Parse(parts[4]);
        }

        Reference reference = new Reference(book: book, chapter: chapter, startVerse: verse, endVerse: endVerse);
        Scripture scripture = new Scripture(reference: reference, text: text);
        bool isHidden = false;

        while (command.ToLower() != "quit" && !isHidden)
        {
            isHidden = scripture.IsCompletelyHidden();
            Console.WriteLine(scripture.GetDisplayString());
            command = Console.ReadLine();
            scripture.HideRandomWords();
            Console.Clear();
        }

    }
}